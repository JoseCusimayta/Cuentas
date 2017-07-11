using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ConexionesBD
{
    public class Login
    {
        Conexion con = new Conexion();
        
        public SqlConnection connect;
        public SqlCommand command;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;

        public String VerificarUsuario(String Usuario, String Clave)
        {            
            string cadena="0";
            try
            {
                if (con.AbirConexionBD())
                {
                    command = new SqlCommand("select count(*) from Usuarios WHERE Usuario = '" + Usuario + "' And Clave = '" + Clave + "' and estado= 1", con.conexion);
                    cadena = command.ExecuteScalar().ToString();
                    con.CerrarConexionBD();
                }
            }
            catch
            {
                cadena = string.Empty;
            }
            return cadena;
        }
    }
}