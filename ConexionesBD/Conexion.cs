using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConexionesBD
{
    public class Conexion
    {

        public SqlConnection conexion;
        String nombre_instancia = "YIWO\\SQLEXPRESS";
        String nombre_bd = "BalanceGeneral";
        String usuario = "Druisor";
        String clave = "kc34jopz";

        public Boolean AbirConexionBD()
        {
            Boolean valor;
            try
            {
                conexion = new SqlConnection("Data Source=" + nombre_instancia + ";Initial Catalog=" + nombre_bd + ";User ID=" + usuario + ";Password=" + clave);
                conexion.Open();
                valor = true;
            }
            catch
            {
                valor = false;
            }
            return valor;
        }
        public void CerrarConexionBD()
        {
            if (conexion.State != ConnectionState.Closed)
            {
                try
                {
                    conexion.Close();
                }
                catch
                {
                    conexion = null;
                }
            }
        }
    }
}
