﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransicionDatos;

namespace VentanaPrincipal
{
    public partial class VentanaIngresos : Form
    {
        VerificarCampos verificarCampos = new VerificarCampos();
        Ingresos ingresos = new Ingresos();
        Imprimir imp = new Imprimir();
        LimpiarCampos limpiarCampos = new LimpiarCampos();
        DataTable datatable;
        String modo = "Original";
        String Titulo = "Registro de los Ingresos";
        public VentanaIngresos()
        {
            InitializeComponent();
            TablaIngresos(null);
            DiseñoTablas();
        }

        #region Tablas

        private void TablaIngresos(string condicion)
        {
            datatable = ingresos.TablaIngresos(condicion);
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
        private void VentanaIngresos_KeyUp(object sender, KeyEventArgs e)
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
                Titulo = "Colegio " + cb_colegio.Text;
                TablaIngresos("and colegio= '" + cb_colegio.Text + "'");
            }
        }
        private void b_nuevo_Click(object sender, EventArgs e)
        {
            modo = "Guardar";
            verificarCampos.ActivarNuevo(panel1, panel2);
            limpiarCampos.BorrarCampos(panel1);
            tb_codigo.Text = ingresos.NuevoCodigo();
            TablaIngresos("and colegio= '" + cb_colegio.Text + "'");
            dateTimePicker1.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void b_cancelar_Click(object sender, EventArgs e)
        {
            modo = "Original";
            verificarCampos.ActivarCancelar(panel1, panel2);
            limpiarCampos.BorrarCampos(panel1);
            TablaIngresos(null);
            Titulo = "Registro de los ingresos";
        }
        private void b_modificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_codigo.Text))
            {
                modo = "Modificar";
                verificarCampos.ActivarModificar(panel1, panel2);
            }
            else
            {
                MessageBox.Show("Dato no seleccionado para modificar");
            }
        }
        private void b_historial_Click(object sender, EventArgs e)
        {
            HistorialIngresos ventana = new HistorialIngresos();
            ventana.Show();
        }
        private void b_f5_Click(object sender, EventArgs e)
        {
            limpiarCampos.BorrarCampos(panel1);
            cb_colegio.Text = "";
            TablaIngresos(null);
            Titulo = "Registro de los ingresos";
        }
        #endregion

        #region Funciones de guardar y eliminar
        private void b_guardar_Click(object sender, EventArgs e)
        {
            if (verificarCampos.ValidarCamposVacios(panel1))
            {
                MessageBox.Show(ingresos.IngresarIngresos(modo, tb_codigo.Text, dateTimePicker1.Text, tb_talon.Text, tb_boleta.Text, tb_monto.Text, tb_descipcion.Text, cb_colegio.Text));
                TablaIngresos(null);
            }
            else
            {
                MessageBox.Show(verificarCampos.ListarCamposVacios(panel1));
            }
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ingresos.EliminarIngresos(tb_codigo.Text, dateTimePicker1.Text, tb_talon.Text, tb_boleta.Text, tb_monto.Text, tb_descipcion.Text, cb_colegio.Text));
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
            if (imp.SetupThePrinting(printDocument1, dataGridView1, "Ingresos", "Documento"))
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = printDocument1;
                MyPrintPreviewDialog.ShowDialog();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            imp.Impresion(printDocument1, e, Titulo);
        }
        #endregion        
    }
}