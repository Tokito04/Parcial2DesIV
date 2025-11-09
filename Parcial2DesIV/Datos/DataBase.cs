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
    public class DataBase
    {
        private Npgsql.NpgsqlConnection _con;
        Npgsql.NpgsqlCommand _cmd;
        Npgsql.NpgsqlDataAdapter _adapter;

        DataSet _ds;

        public DataBase()
        {
            _con = new Npgsql.NpgsqlConnection();
            _con.ConnectionString = ConfigurationManager.ConnectionStrings["cad_con"].ConnectionString;
            _cmd = new Npgsql.NpgsqlCommand();
            _cmd.Connection = _con;
        }

        public Usuarios validarLogin(string usuario, string contrasena)
        {
            try
            {
                _cmd.Parameters.Clear();
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.CommandText = "fn_validarlogin";
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
            catch (Exception)
            {
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
