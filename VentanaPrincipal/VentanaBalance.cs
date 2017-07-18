using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransicionDatos;

namespace VentanaPrincipal
{
    public partial class VentanaBalance : Form
    {
        VerificarCampos verificarCampos = new VerificarCampos();
        Balance balance = new Balance();
        Egresos egresos = new Egresos();
        Ingresos ingresos = new Ingresos();
        Imprimir imp = new Imprimir();
        LimpiarCampos limpiarCampos = new LimpiarCampos();
        String Colegio = "Balance de Cuentas";
        public VentanaBalance()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }

        private void VentanaBalance_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        #region Diseño de Tablas
        private void TablaBalance()
        {
            DateTime Fecha= DateTime.Now;
            string query="";
            if (rb_dia.Checked)
            {
                Fecha = picker_dia.Value;
                query = " and Fecha= '" + picker_dia.Value.ToString("yyyy/MM/dd") + "'";
            }
            if (rb_mes.Checked)
            {
                Fecha = picker_mes.Value;
                query = " and DATEPART(month,Fecha)="+ picker_mes.Value.Month+" and DATEPART(year,Fecha)="+ picker_mes.Value.Year;
            }
            if (rb_year.Checked)
            {
                Fecha = picker_year.Value;
                query = " and DATEPART(year,Fecha)=" + picker_year.Value.Year;
            }
            if (rb_intervalo.Checked)
            {
                query = "  and Fecha between '" + picker_inicio.Value.ToString("yyyy/MM/dd") + "' and '" + picker_final.Value.ToString("yyyy/MM/dd") + "' ";
            }
            DataTable dataTable = balance.TablaBalance(query,Fecha);
            if (dataTable.Rows.Count<5)
            {
                MessageBox.Show("No se encuentran registros de Ingresos y Egresos");
            }
            else
            {
                dataGridView1.DataSource = dataTable;
                DiseñoTablas();
            }
        }
        public void DiseñoTablas()
        {
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Ivory;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[2].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns[7].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[0].HeaderText = "Fecha";
            dataGridView1.Columns[2].HeaderText = "Monto";
            dataGridView1.Columns[3].HeaderText = "Descripción";
            dataGridView1.Columns[5].HeaderText = "Fecha";
            dataGridView1.Columns[7].HeaderText = "Monto";
            dataGridView1.Columns[8].HeaderText = "Descripción";
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion

        #region Formato Fechas
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            picker_mes.Format = DateTimePickerFormat.Custom;
            picker_mes.CustomFormat = "'Mes' MMMM 'de' yyyy";
            picker_year.Format = DateTimePickerFormat.Custom;
            picker_year.CustomFormat = "'Año' yyyy";
        }
        #endregion        

        #region Función de los botones
        private void b_nuevo_Click(object sender, EventArgs e)
        {
            TablaBalance();
        }


        private void b_modificar_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region Función de los Radio Button
        private void rb_dia_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_dia.Checked)
            {
                ActivarGroupBox(gb_dia);
            }
        }

        private void rb_mes_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_mes.Checked)
            {
                ActivarGroupBox(gb_mes);
            }
        }

        private void rb_year_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_year.Checked)
            {
                ActivarGroupBox(gb_year);
            }
        }

        private void rb_intervalo_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_intervalo.Checked)
            {
                ActivarGroupBox(gb_intervalo);
            }
        }

        void ActivarGroupBox(GroupBox groupBox)
        {
            gb_dia.Visible = false;
            gb_mes.Visible = false;
            gb_year.Visible = false;
            gb_intervalo.Visible = false;
            groupBox.Visible = true;
        }
        #endregion

        #region Footer

        private void b_inicio_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 2)
            {
                MessageBox.Show("No hay registros para mostrar");
            }
            else
            {
                dataGridView1.CurrentCell = dataGridView1[1, 0];
            }
        }

        private void b_anterior_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 2)
            {
                MessageBox.Show("No hay registros para mostrar");
            }
            else
            {
                Int32 FilaSeleccionada = dataGridView1.CurrentCell.RowIndex;
                if (FilaSeleccionada != 0)
                    dataGridView1.CurrentCell = dataGridView1[1, FilaSeleccionada - 1];
            }
        }

        private void b_siguiente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 2)
            {
                MessageBox.Show("No hay registros para mostrar");
            }
            else
            {
                Int32 FilaSeleccionada = dataGridView1.CurrentCell.RowIndex;
                Int32 UltimaFila = dataGridView1.NewRowIndex;
                if (FilaSeleccionada != UltimaFila - 1)
                    dataGridView1.CurrentCell = dataGridView1[1, FilaSeleccionada + 1];
            }
        }

        private void b_final_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 2)
            {
                MessageBox.Show("No hay registros para mostrar");
            }
            else
            {
                Int32 UltimaFila = dataGridView1.NewRowIndex;
                dataGridView1.CurrentCell = dataGridView1[1, UltimaFila - 1];
            }
        }

        private void b_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void b_imprimir_Click(object sender, EventArgs e)
        {
            if (imp.SetupThePrinting(printDocument1, dataGridView1, "", "Documento"))
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = printDocument1;
                MyPrintPreviewDialog.ShowDialog();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            imp.Impresion(printDocument1, e, Colegio, "Balance de Cuentas");
        }
        #endregion        
    }
}
