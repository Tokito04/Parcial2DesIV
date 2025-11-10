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
    // Clase responsable de las operaciones de acceso a datos relacionadas con usuarios,
    // cuentas y transacciones. Encapsula la conexión a la base de datos y comandos.

    public class Database
    {
        private Npgsql.NpgsqlConnection _con;

        Npgsql.NpgsqlCommand _cmd;


        Npgsql.NpgsqlDataAdapter _adapter;

        DataSet _ds;

        public Database()
        {
            _con = new Npgsql.NpgsqlConnection();
            _con.ConnectionString = ConfigurationManager.ConnectionStrings["cad_con"].ConnectionString;
            _cmd = new Npgsql.NpgsqlCommand();
            _cmd.Connection = _con;
        }


        // Valida las credenciales de un usuario llamando a la función de BD
        // fn_validar_login con los parámetros de usuario y contraseña.
        // Si la función devuelve datos, mapea la primera fila a un objeto Usuarios.
        // En caso de error o si no se encuentra el usuario, devuelve null.

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



        // Obtiene la lista de cuentas asociadas a un usuario específico llamando a la
        // función de base de datos fn_obtener_cuentas_usuario.
        // Mapea cada fila resultante a un objeto Cuentas y devuelve
        // una lista con todas las cuentas encontradas.
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



        // Verifica si existe una cuenta destino por número de cuenta llamando a la función
        // de BD fn_verificar_destino. Si la función devuelve datos, mapea la primera fila
        // a un objeto Cuentas con la información mínima necesaria (id, número y saldo).
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


        // Obtiene el historial de transacciones de un usuario específico llamando a la función
        // de base de datos fn_obtener_transacciones_usuario. Mapea cada fila resultante a un objeto
        // HistorialTransaccion y devuelve una lista con todas las transacciones encontradas.
        public List<HistorialTransaccion> ObtenerTransaccionesUsuario(int id_usuario)
        {
            List<HistorialTransaccion> listaTransacciones = new List<HistorialTransaccion>();
            try
            {
                _cmd.Parameters.Clear();
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = "SELECT * FROM fn_obtener_transacciones_usuario(@p_id_usuario)";
                _cmd.Parameters.Add(new Npgsql.NpgsqlParameter("p_id_usuario", id_usuario));

                _cmd.Connection.Open();

                _ds = new DataSet();
                _adapter = new Npgsql.NpgsqlDataAdapter(_cmd);
                _adapter.Fill(_ds);
                foreach (DataRow row in _ds.Tables[0].Rows)
                {
                    listaTransacciones.Add(new HistorialTransaccion
                    {
                        fecha = Convert.ToDateTime(row["fecha"]),
                        tipo = row["tipo"].ToString(),
                        cuenta_origen = row["cuenta_origen"].ToString(),
                        cuenta_destino = row["cuenta_destino"].ToString(),
                        contraparte = row["contraparte"].ToString(),
                        monto = Convert.ToDecimal(row["monto"])
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener transacciones del usuario: " + ex.Message);
                return listaTransacciones;
            }
            finally
            {
                if (_cmd.Connection.State == ConnectionState.Open)
                {
                    _cmd.Connection.Close();
                }
            }
            return listaTransacciones;
        }

        public ResultadoTransaccion RegistrarTransaccion(int id_cuenta_origen,
            int id_cuenta_destino, decimal monto, DateTime fecha)
        {
            try
            {
                _cmd.Parameters.Clear();
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = "SELECT * FROM fn_registrar_transaccion(@p_id_cuenta_origen, @p_id_cuenta_destino, @p_monto, @fecha)";
                _cmd.Parameters.Add(new Npgsql.NpgsqlParameter("p_id_cuenta_origen", id_cuenta_origen));
                _cmd.Parameters.Add(new Npgsql.NpgsqlParameter("p_id_cuenta_destino", id_cuenta_destino));
                _cmd.Parameters.Add(new Npgsql.NpgsqlParameter("p_monto", monto));
                _cmd.Parameters.Add(new Npgsql.NpgsqlParameter("fecha", fecha));

                _cmd.Connection.Open();

                _ds = new DataSet();
                _adapter = new Npgsql.NpgsqlDataAdapter(_cmd);
                _adapter.Fill(_ds);
                
                var datos = _ds.Tables[0].Rows[0]["mensaje"].ToString();
                if (!string.IsNullOrEmpty(datos) && datos.ToLower().Contains("éxito"))
                {
                    var resultado = _ds.Tables[0].Rows[0];
                    return new ResultadoTransaccion
                    {
                        mensaje = resultado["mensaje"].ToString(),
                        cuenta_origen = resultado["cuenta_origen"].ToString(),
                        cuenta_destino = resultado["cuenta_destino"].ToString(),
                        destinatario = resultado["destinatario"].ToString(),
                        monto = Convert.ToDecimal(resultado["monto"]),
                        fecha = Convert.ToDateTime(resultado["fecha"])
                    };
                }
                return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar la transacción: " + ex.Message);
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

    }
}

