using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionesBD;
using System.Data;

namespace TransicionDatos
{
    public class Egresos
    {
        EgresosBD egresosBD = new EgresosBD();
        Tablas tablas = new Tablas();
        NuevoCodigo nuevoCodigo = new NuevoCodigo();
        DataTable tabla;
        public string IngresarEgresos(string Modo, string Codigo, string Fecha, string Talon, string Boleta, string Monto, string Descripcion, string Colegio)
        {
            string Mensaje = "Error";
            if (Modo == "Guardar")
            {
                if (egresosBD.InsertarEgresos(Convert.ToDateTime(Fecha), Convert.ToInt32(Talon), Convert.ToInt32(Boleta), Decimal.Parse(Monto), Descripcion, Colegio))
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
                if (egresosBD.ModificarEgresos(Convert.ToInt32(Codigo), Convert.ToDateTime(Fecha), Convert.ToInt32(Talon), Convert.ToInt32(Boleta), Decimal.Parse(Monto), Descripcion, Colegio))
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
        public string EliminarEgresos(string Codigo, string Fecha, string Talon, string Boleta, string Monto, string Descripcion, string Colegio)
        {
            string Mensaje = "Error";
            if (egresosBD.EliminarEgresos(Convert.ToInt32(Codigo), Convert.ToDateTime(Fecha), Convert.ToInt32(Talon), Convert.ToInt32(Boleta), Decimal.Parse(Monto), Descripcion, Colegio))

            {
                Mensaje = "Datos Eliminados Correctamente";
            }
            else
            {
                Mensaje = "No se han podido eliminar los datos";
            }
            return Mensaje;

        }
        public DataTable TablaEgresos(string condicion)
        {
            tabla = tablas.SelectDataTable("select Codigo as 'Código', Colegio as 'Nombre de Colegio', Fecha, Talon as 'Número de Talón', Boleta as 'Número de Boleta', Descripcion as 'Descripción', Monto from egresos where Estado <> 'Anulado' " + condicion);
            return tabla;
        }
        public string NuevoCodigo()
        {
            return nuevoCodigo.Codigo("Egresos");
        }
    }
}
