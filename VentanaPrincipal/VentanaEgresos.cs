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
        String Colegio = "Registro de los Egresos";
        public VentanaEgresos()
        {
            InitializeComponent();
            TablaEgresos(null);
            DiseñoTablas();
        }

        #region Tablas

        private void TablaEgresos(string condicion)
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

            dataGridView1.Columns[6].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
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
                    if (!string.IsNullOrEmpty( row.Cells[0].Value.ToString()))
                    {
                        tb_codigo.Text = row.Cells[0].Value.ToString();
                        dateTimePicker1.Text = row.Cells[1].Value.ToString();
                        cb_colegio.Text = row.Cells[2].Value.ToString();
                        tb_talon.Text = row.Cells[3].Value.ToString();
                        tb_boleta.Text = row.Cells[4].Value.ToString();
                        tb_descipcion.Text = row.Cells[5].Value.ToString();
                        tb_monto.Text = row.Cells[6].Value.ToString();
                    }
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

        #region Activacion de los botones
        private void cb_colegio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo != "Celda" && !string.IsNullOrWhiteSpace(cb_colegio.Text))
            {
                Colegio = "Colegio " + cb_colegio.Text;
                TablaEgresos("and colegio= '" + cb_colegio.Text + "'");
            }
        }
        private void b_nuevo_Click(object sender, EventArgs e)
        {
            modo = "Guardar";
            verificarCampos.ActivarNuevo(panel1, panel2);
            limpiarCampos.BorrarCampos(panel1);
            tb_codigo.Text = egresos.NuevoCodigo();
            TablaEgresos("and colegio= '" + cb_colegio.Text + "'");
            dateTimePicker1.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void b_cancelar_Click(object sender, EventArgs e)
        {
            modo = "Original";
            verificarCampos.ActivarCancelar(panel1, panel2);
            limpiarCampos.BorrarCampos(panel1);
            TablaEgresos(null);
            Colegio = "Registro de los egresos";
        }
        private void b_modificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_codigo.Text))
            {
                modo = "Modificar";
                string codigo = egresos.Modificar(tb_codigo.Text);
                tb_codigo.Text = codigo;
                verificarCampos.ActivarModificar(panel1, panel2);
            }
            else
            {
                MessageBox.Show("Dato no seleccionado para modificar");
            }
        }
        private void b_historial_Click(object sender, EventArgs e)
        {
            HistorialEgresos ventana = new HistorialEgresos();
            ventana.Show();
        }
        private void b_f5_Click(object sender, EventArgs e)
        {
            limpiarCampos.BorrarCampos(panel1);
            cb_colegio.Text = "";
            TablaEgresos(null);
            Colegio = "Registro de los egresos";
        }
        #endregion

        #region Funciones de guardar y eliminar
        private void b_guardar_Click(object sender, EventArgs e)
        {
            if (verificarCampos.ValidarCamposVacios(panel1))
            {
                MessageBox.Show(egresos.IngresarEgresos(modo, tb_codigo.Text, dateTimePicker1.Text, tb_talon.Text, tb_boleta.Text, tb_monto.Text, tb_descipcion.Text, cb_colegio.Text));
                TablaEgresos(null);
                if (modo == "Modificar")
                {
                    verificarCampos.ActivarCancelar(panel1, panel2);
                }
            }
            else
            {
                MessageBox.Show(verificarCampos.ListarCamposVacios(panel1));
            }
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(egresos.EliminarEgresos(tb_codigo.Text, dateTimePicker1.Text, tb_talon.Text, tb_boleta.Text, tb_monto.Text, tb_descipcion.Text, cb_colegio.Text));
            TablaEgresos(null);
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
            imp.Impresion(printDocument1, e, Colegio, "Egresos");
        }
        #endregion


    }
}