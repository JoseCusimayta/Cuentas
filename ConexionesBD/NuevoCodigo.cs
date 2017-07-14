using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ConexionesBD
{
    public class NuevoCodigo
    {

        Conexion con = new Conexion();

        public SqlConnection connect;
        public SqlCommand command;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;

        public String Codigo(String Tabla)
        {
            Int32 Orden=0;
            object count;
            if (con.AbirConexionBD())
            {
                try
                {
                    command = new SqlCommand("select top (1) Codigo from " + Tabla + " order by Codigo desc", con.conexion);
                    count = command.ExecuteScalar();
                    if (count != null)
                        Orden = Convert.ToInt32(count.ToString()) + 1;
                    else
                        Orden = 1;
                }
                catch
                {
                    Orden = 1;
                }
            }
            return Orden.ToString();
        }
    }
}
