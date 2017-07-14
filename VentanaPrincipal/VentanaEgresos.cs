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
    public partial class VentanaEgresos : Form
    {
        VerificarCampos verificarCampos = new VerificarCampos();
        Egresos egresos = new Egresos();
        Imprimir imp = new Imprimir();
        LimpiarCampos limpiarCampos = new LimpiarCampos();
        DataTable datatable;
        String modo = "Original";
        String Titulo = "Registro de los Egresos";
        public VentanaEgresos()
        {
            InitializeComponent();
        }
        
        #region Tablas

        private void TablaIngresos(string condicion)
        {
            datatable = egresos.TablaEgresos(condicion);
            if (datatable == null)
            {
                MessageBox.Show("No se encuentra la tabla Ingresos");
            }
            else
            {
                dataGridView1.DataSource = datatable;
            }
        }
        public void DiseñoTablas()
        {
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Ivory;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[4].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarcelda(e);
        }
        public void seleccionarcelda(DataGridViewCellEventArgs e)
        {
            if (modo == "Original")
            {
                modo = "Celda";
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    tb_codigo.Text = row.Cells[0].Value.ToString();
                    cb_colegio.Text = row.Cells[1].Value.ToString();
                    tb_talon.Text = row.Cells[2].Value.ToString();
                    tb_boleta.Text = row.Cells[3].Value.ToString();
                    tb_monto.Text = row.Cells[4].Value.ToString();
                    tb_descipcion.Text = row.Cells[5].Value.ToString();
                    dateTimePicker1.Text = row.Cells[6].Value.ToString();
                }
                modo = "Original";
            }
        }

        #endregion

        #region Ventana General
        private void VentanaEgresos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        #endregion

        #region Estilos del Texto
        private void tb_talon_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificarCampos.SoloNumeros(e);
        }

        private void tb_boleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificarCampos.SoloNumeros(e);
        }

        private void tb_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificarCampos.SoloDecimal(e);
        }
        #endregion

        private void b_nuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
