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
        public string Modificar(string numero)
        {
            DataRow filatabla = tabla.Rows[Convert.ToInt32(numero) - 1];
            return filatabla["Codigo"].ToString();
        }
        public DataTable TablaEgresos(string condicion)
        {
            tabla = tablas.SelectDataTable("select * from egresos where Estado <> 'Anulado' " + condicion);
            decimal suma = 0;
            DataTable dataTable = new DataTable();
            DataColumn column;
            ////Número
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Número";
            dataTable.Columns.Add(column);
            ////Fecha
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "Fecha";
            dataTable.Columns.Add(column);
            ////Colegio
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Colegio";
            dataTable.Columns.Add(column);
            ////Talon
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Número de Talón";
            dataTable.Columns.Add(column);
            ////Boleta
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Número de Boleta";
            dataTable.Columns.Add(column);
            ////Descripcion
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Descripción";
            dataTable.Columns.Add(column);
            ////Monto
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Decimal");
            column.ColumnName = "Monto";
            dataTable.Columns.Add(column);
            //////Hallar la suma
            for (int i = 0; i < tabla.Rows.Count; i++)
            {

                DataRow dataRow;
                DataRow filatabla = tabla.Rows[i];
                dataRow = dataTable.NewRow();

                dataRow["Número"] = (i + 1).ToString();
                dataRow["Fecha"] = filatabla[1].ToString();
                dataRow["Colegio"] = filatabla[6].ToString();
                dataRow["Número de Talón"] = filatabla[2].ToString();
                dataRow["Número de Boleta"] = filatabla[3].ToString();
                dataRow["Descripción"] = filatabla[5].ToString();
                dataRow["Monto"] = filatabla[4].ToString();


                dataTable.Rows.Add(dataRow);
                suma += Convert.ToDecimal(dataRow["Monto"]);
            }
            /////Fila vacia
            DataRow row = dataTable.NewRow();
            dataTable.Rows.Add(row);
            /////Fila Suma Total
            row = dataTable.NewRow();
            row["Descripción"] = "Suma Total";
            row["Monto"] = Convert.ToDecimal(suma);
            dataTable.Rows.Add(row);

            return dataTable;
        }
        public string NuevoCodigo()
        {
            return nuevoCodigo.Codigo("Egresos");
        }
    }
}
