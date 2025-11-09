using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
