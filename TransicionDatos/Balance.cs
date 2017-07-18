using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionesBD;
using System.Data;

namespace TransicionDatos
{
    public class Balance
    {
        BalanceBD balanceBD = new BalanceBD();
        Tablas tablas = new Tablas();
        NuevoCodigo nuevoCodigo = new NuevoCodigo();


        public DataTable TablaBalance(String Condicion, DateTime Fecha)
        {
            decimal suma_ingresos = 0;
            decimal suma_egresos = 0;
            DataTable tablaIngresos = tablas.SelectDataTable("select * from ingresos where Estado <> 'Anulado' "+Condicion+ " order by Fecha");
            DataTable tablaEgresos = tablas.SelectDataTable("select * from egresos where Estado <> 'Anulado' "+Condicion + " order by Fecha");
            Int32 numfilasIngreso = tablaIngresos.Rows.Count;
            Int32 numfilasEgreso = tablaEgresos.Rows.Count;
            DataTable tablaBalance = new DataTable();
            DataColumn column;
            DataRow row;
            //// Ingresos
            // Columna Fecha
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "Fecha de Ingreso";
            tablaBalance.Columns.Add(column);
            // Columna Tipo Ingreso
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Ingreso";
            tablaBalance.Columns.Add(column);
            // Columna Monto
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Decimal");
            column.ColumnName = "Monto de Ingreso";
            tablaBalance.Columns.Add(column);
            // Columna Descripcion
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Descripción de Ingreso";
            tablaBalance.Columns.Add(column);

            // Columna Separadora
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = " ";
            tablaBalance.Columns.Add(column);

            //// Egresos
            // Columna Fecha
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "Fecha de Egreso";
            tablaBalance.Columns.Add(column);
            // Columna Tipo Egreso
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Egreso";
            tablaBalance.Columns.Add(column);
            // Columna Monto
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Decimal");
            column.ColumnName = "Monto de Egreso";
            tablaBalance.Columns.Add(column);
            // Columna Descripcion
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Descripción de Egreso";
            tablaBalance.Columns.Add(column);

            // Create new DataRow objects and add to DataTable. 

            if (numfilasIngreso > numfilasEgreso)
            {
                for (int i = 0; i < numfilasIngreso; i++)
                {
                    DataRow filaIngresos = tablaIngresos.Rows[i];

                    row = tablaBalance.NewRow();
                    row["Fecha de Ingreso"] = filaIngresos[1].ToString();
                    row["Ingreso"] = "Ingreso";
                    row["Monto de Ingreso"] = filaIngresos[4].ToString();
                    row["Descripción de Ingreso"] = filaIngresos[5].ToString();
                    suma_ingresos += Convert.ToDecimal(filaIngresos[4].ToString());
                    if (numfilasEgreso > i)
                    {
                        row["Egreso"] = "Egreso";
                        DataRow filaEgresos = tablaEgresos.Rows[i];
                        row["Fecha de Egreso"] = filaEgresos[1].ToString();
                        row["Monto de Egreso"] = filaEgresos[4].ToString();
                        row["Descripción de Egreso"] = filaEgresos[5].ToString();
                        suma_egresos += Convert.ToDecimal(filaEgresos[4].ToString());
                    }
                    tablaBalance.Rows.Add(row);
                }
            }
            else
            {
                for (int i = 0; i < numfilasEgreso; i++)
                {
                    row = tablaBalance.NewRow();

                    DataRow filaEgresos = tablaEgresos.Rows[i];
                    row["Egreso"] = "Egreso";
                    row["Fecha de Egreso"] = filaEgresos[1].ToString();
                    row["Monto de Egreso"] = filaEgresos[4].ToString();
                    row["Descripción de Egreso"] = filaEgresos[5].ToString();
                    suma_egresos += Convert.ToDecimal(filaEgresos[4].ToString());
                    if (numfilasIngreso > i)
                    {
                        DataRow filaIngresos = tablaIngresos.Rows[i];
                        row["Ingreso"] = "Ingreso";
                        row["Fecha de Ingreso"] = filaIngresos[1].ToString();
                        row["Monto de Ingreso"] = filaIngresos[4].ToString();
                        row["Descripción de Ingreso"] = filaIngresos[5].ToString();
                        suma_ingresos += Convert.ToDecimal(filaIngresos[4].ToString());
                    }
                    tablaBalance.Rows.Add(row);
                }
            }

            

            row = tablaBalance.NewRow();
            tablaBalance.Rows.Add(row);

            row = tablaBalance.NewRow();
            row["Ingreso"] = "Suma Total de Ingresos";
            row["Monto de Ingreso"] = suma_ingresos;
            row["Egreso"] = "Suma Total de Egresos";
            row["Monto de Egreso"] = suma_egresos;
            tablaBalance.Rows.Add(row);

            row = tablaBalance.NewRow();
            tablaBalance.Rows.Add(row);

            row = tablaBalance.NewRow();
            row["Egreso"] = "Balance General";
            row["Monto de Egreso"] = suma_ingresos - suma_egresos;
            tablaBalance.Rows.Add(row);
            return tablaBalance;
        }
    }
}
