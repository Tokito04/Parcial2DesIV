using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2DesIV.Modelos;

namespace Parcial2DesIV.Datos
{
    /// <summary>
    /// Clase responsable de las operaciones de acceso a datos relacionadas con usuarios,
    /// cuentas y transacciones. Encapsula la conexión a la base de datos y comandos.
    /// </summary>
    public class Database
    {
        // Conexión a la base de datos PostgreSQL. Se inicializa en el constructor
        // usando la cadena de conexión definida en el archivo de configuración.
        private Npgsql.NpgsqlConnection _con;

        // Objeto comando que se reutiliza para ejecutar consultas y funciones en la BD.
        Npgsql.NpgsqlCommand _cmd;

        // Adaptador usado para llenar conjuntos de datos (DataSet) a partir del comando.
        Npgsql.NpgsqlDataAdapter _adapter;

        // DataSet temporal donde se cargan los resultados de las consultas.
        DataSet _ds;

        /// <summary>
        /// Inicializa la conexión, comando y configura la cadena de conexión
        /// tomada de <c>ConfigurationManager.ConnectionStrings["cad_con"]</c>.
        /// </summary>
        public Database()
        {
            _con = new Npgsql.NpgsqlConnection();
            _con.ConnectionString = ConfigurationManager.ConnectionStrings["cad_con"].ConnectionString;
            _cmd = new Npgsql.NpgsqlCommand();
            _cmd.Connection = _con;
        }


        /// <summary>
        /// Valida las credenciales de un usuario llamando a la función de BD
        /// <c>fn_validar_login</c> con los parámetros de usuario y contraseña.
        /// Si la función devuelve datos, mapea la primera fila a un objeto <see cref="Usuarios"/>.
        /// En caso de error o si no se encuentra el usuario, devuelve <c>null</c>.
        /// </summary>
        /// <param name="usuario">Nombre de usuario a validar.</param>
        /// <param name="contrasena">Contraseña asociada al usuario.</param>
        /// <returns>Un objeto <see cref="Usuarios"/> con los datos del usuario o <c>null</c> si no existe/ocurre un error.</returns>
        public Usuarios ValidarLogin(string usuario, string contrasena)
        {
            try
            {
                _cmd.Parameters.Clear();
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = "SELECT * FROM fn_validar_login(@p_usuario, @p_contrasena)";
                _cmd.Parameters.Add(new Npgsql.NpgsqlParameter("p_usuario", usuario));
                _cmd.Parameters.Add(new Npgsql.NpgsqlParameter("p_contrasena", contrasena));

                _cmd.Connection.Open();

                _ds = new DataSet();
                _adapter = new Npgsql.NpgsqlDataAdapter(_cmd);
                _adapter.Fill(_ds);

                var datos = _ds.Tables[0].Rows[0]["nombre"].ToString();
                if (!string.IsNullOrEmpty(datos))
                {
                    return new Usuarios
                    {
                        id = Convert.ToInt32(_ds.Tables[0].Rows[0]["id"]),
                        nombre = _ds.Tables[0].Rows[0]["nombre"].ToString(),
                        correo = _ds.Tables[0].Rows[0]["correo"].ToString(),
                        usuario = _ds.Tables[0].Rows[0]["usuario"].ToString(),
                        contrasena = _ds.Tables[0].Rows[0]["contrasena"].ToString()
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                // Se registra el error en la consola. En una aplicación real se preferiría
                // un mecanismo de logging más robusto.
                Console.WriteLine("Error al validar login: " + ex.Message);
                return null;
            }
            finally
            {
                if (_cmd.Connection.State == ConnectionState.Open)
                {
                    _cmd.Connection.Close();
                }
            }
        }


        /// <summary>
        /// Obtiene la lista de cuentas asociadas a un usuario específico llamando a la
        /// función de base de datos <c>fn_obtener_cuentas_usuario</c>.
        /// Mapea cada fila resultante a un objeto <see cref="Cuentas"/> y devuelve
        /// una lista con todas las cuentas encontradas.
        /// </summary>
        /// <param name="id_usuario">Identificador del usuario cuyas cuentas se desean obtener.</param>
        /// <returns>Lista de objetos <see cref="Cuentas"/> (vacía si no hay cuentas o si ocurre un error).</returns>
        public List<Cuentas> ObtenerCuentasUsuario(int id_usuario)
        {
            List<Cuentas> listaCuentas = new List<Cuentas>();
            try
            {
                _cmd.Parameters.Clear();
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = "SELECT * FROM fn_obtener_cuentas_usuario(@p_id_usuario)";
                _cmd.Parameters.Add(new Npgsql.NpgsqlParameter("p_id_usuario", id_usuario));
                
                _cmd.Connection.Open();

                _ds = new DataSet();
                _adapter = new Npgsql.NpgsqlDataAdapter(_cmd);
                _adapter.Fill(_ds);
                foreach (DataRow row in _ds.Tables[0].Rows)
                {
                    listaCuentas.Add(new Cuentas
                    {
                        id = Convert.ToInt32(row["id"]),
                        nombre = row["nombre"].ToString(),
                        num_cuenta = row["numero_cuenta"].ToString(),
                        saldo = Convert.ToDecimal(row["saldo"])
                    });
                }
                

            }
            catch (Exception ex)
            {
                // Se devuelve la lista (posiblemente vacía) y se registra el error en consola.
                Console.WriteLine("Error al obtener cuentas del usuario: " + ex.Message);
                return listaCuentas;
            }
            finally
            {
                if (_cmd.Connection.State == ConnectionState.Open)
                {
                    _cmd.Connection.Close();
                }
            }
            return listaCuentas;
        }


        /// <summary>
        /// Verifica si existe una cuenta destino por número de cuenta llamando a la función
        /// de BD <c>fn_verificar_destino</c>. Si la función devuelve datos, mapea la primera fila
        /// a un objeto <see cref="Cuentas"/> con la información mínima necesaria (id, número y saldo).
        /// </summary>
        /// <param name="num_cuenta">Número de cuenta destino a verificar.</param>
        /// <returns>Objeto <see cref="Cuentas"/> con la información encontrada o <c>null</c> si no existe/ocurre un error.</returns>
        public Cuentas VerificarDestino(string num_cuenta)
        {
            try
            {
                _cmd.Parameters.Clear();
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = "SELECT * FROM fn_verificar_destino(@p_num_cuenta)";
                _cmd.Parameters.Add(new Npgsql.NpgsqlParameter("p_num_cuenta", num_cuenta));

                _cmd.Connection.Open();

                _ds = new DataSet();
                _adapter = new Npgsql.NpgsqlDataAdapter(_cmd);
                _adapter.Fill(_ds);

                var datos = _ds.Tables[0].Rows[0]["num_cuenta"].ToString();
                if (!string.IsNullOrEmpty(datos))
                {
                    return new Cuentas
                    {
                        id = Convert.ToInt32(_ds.Tables[0].Rows[0]["id"]),
                        num_cuenta = _ds.Tables[0].Rows[0]["num_cuenta"].ToString(),
                        saldo = Convert.ToDecimal(_ds.Tables[0].Rows[0]["saldo"]),
                        usuario_id = Convert.ToInt32(_ds.Tables[0].Rows[0]["usuario_id"]) 
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al comprobar la cuenta destino: " + ex.Message);
                return null;
            }
            finally
            {
                if (_cmd.Connection.State == ConnectionState.Open)
                {
                    _cmd.Connection.Close();
                }
            }
        }


        // Miembro pendiente de implementación para obtener transacciones de un usuario.
        // Actualmente es solo una referencia comentada en el código original.
        public Transacciones ObtenerTransaccionesUsuario; // Aún tengo que implementarlo

    }
}

