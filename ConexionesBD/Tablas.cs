using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConexionesBD
{
    public class Tablas
    {
        Conexion con = new Conexion();

        public SqlConnection connect;
        public SqlCommand command;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        public DataTable SelectDataTable(string query)
        {
            dt = new DataTable();
            try
            {
                if (con.AbirConexionBD())
                {
                    da = new SqlDataAdapter(query, con.conexion);
                    da.Fill(dt);
                    con.CerrarConexionBD();
                }
            }
            catch
            {
                dt = null;
            }
            return dt;
        }
    }
}
