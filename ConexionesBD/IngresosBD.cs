using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConexionesBD
{
    public class IngresosBD
    {
        Conexion con = new Conexion();

        public SqlConnection connect;
        public SqlCommand command;
        public SqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;
        
        public bool InsertarIngresos(DateTime Fecha, int Talon, int Boleta, decimal Monto, string Descripcion,string Colegio)
        {
            try
            {
                if (con.AbirConexionBD())
                {
                    command = new SqlCommand("InsertarIngresos", con.conexion);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Fecha", SqlDbType.Date).Value = Fecha;
                    command.Parameters.Add("@Talon", SqlDbType.Int).Value = Talon;
                    command.Parameters.Add("@Boleta", SqlDbType.Int).Value = Boleta;
                    command.Parameters.Add("@Monto", SqlDbType.Decimal).Value = Monto;
                    command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100).Value = Descripcion;
                    command.Parameters.Add("@Colegio", SqlDbType.VarChar, 50).Value = Colegio;
                    command.ExecuteNonQuery();
                    con.CerrarConexionBD();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool ModificarIngresos(int Codigo, DateTime Fecha, int Talon, int Boleta, decimal Monto, string Descripcion, string Colegio)
        {
            try
            {
                if (con.AbirConexionBD())
                {
                    command = new SqlCommand("ModificarIngresos", con.conexion);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo;
                    command.Parameters.Add("@Fecha", SqlDbType.Date).Value = Fecha;
                    command.Parameters.Add("@Talon", SqlDbType.Int).Value = Talon;
                    command.Parameters.Add("@Boleta", SqlDbType.Int).Value = Boleta;
                    command.Parameters.Add("@Monto", SqlDbType.Decimal).Value = Monto;
                    command.Parameters.Add("@Descripcion", SqlDbType.VarChar, 100).Value = Descripcion;
                    command.Parameters.Add("@Colegio", SqlDbType.VarChar, 50).Value = Colegio;
                    command.ExecuteNonQuery();
                    con.CerrarConexionBD();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool EliminarIngresos(int Codigo, DateTime Fecha, int Talon, int Boleta, decimal Monto, string Descripcion, string Colegio)
        {
            try
            {
                if (con.AbirConexionBD())
                {
                    command = new SqlCommand("EliminarIngresos", con.conexion);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo;
                    command.ExecuteNonQuery();
                    con.CerrarConexionBD();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
