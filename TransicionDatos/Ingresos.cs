using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionesBD;
using System.Data;

namespace TransicionDatos
{
    public class Ingresos
    {
        IngresosBD ingresosBD = new IngresosBD();
        Tablas tablas = new Tablas();
        NuevoCodigo nuevoCodigo = new NuevoCodigo();
        DataTable tabla;
        public string IngresarIngresos(string Modo, string Codigo, string Fecha, string Talon, string Boleta, string Monto, string Descripcion, string Colegio)
        {
            string Mensaje = "Error";
            if (Modo == "Guardar")
            {
                if (ingresosBD.InsertarIngresos(Convert.ToDateTime(Fecha), Convert.ToInt32(Talon), Convert.ToInt32(Boleta), Decimal.Parse(Monto), Descripcion, Colegio))
                {
                    Mensaje = "Datos guardados Correctamente";
                }
                else
                {
                    Mensaje = "No se han podido guardar los datos";
                }
            }
            if (Modo == "Modificar")
            {
                if (ingresosBD.ModificarIngresos(Convert.ToInt32(Codigo), Convert.ToDateTime(Fecha), Convert.ToInt32(Talon), Convert.ToInt32(Boleta), Decimal.Parse(Monto), Descripcion, Colegio))
                {
                    Mensaje = "Datos modificados Correctamente";
                }
                else
                {
                    Mensaje = "No se han podido modificar los datos";
                }
            }
            return Mensaje;
        }
        public string EliminarIngresos(string Codigo, string Fecha, string Talon, string Boleta, string Monto, string Descripcion, string Colegio)
        {
            string Mensaje = "Error";
            if (ingresosBD.EliminarIngresos(Convert.ToInt32(Codigo), Convert.ToDateTime(Fecha), Convert.ToInt32(Talon), Convert.ToInt32(Boleta), Decimal.Parse(Monto), Descripcion, Colegio))

            {
                Mensaje = "Datos Eliminados Correctamente";
            }
            else
            {
                Mensaje = "No se han podido eliminar los datos";
            }
            return Mensaje;

        }
        public DataTable TablaIngresos(string condicion)
        {
            tabla = tablas.SelectDataTable("select Codigo, Colegio, Talon, Boleta, Monto, Descripcion, Fecha from ingresos where Estado <> 'Anulado' " + condicion);
            return tabla;
        }
        public string NuevoCodigo()
        {
            return nuevoCodigo.Codigo("Ingresos");
        }
    }
}