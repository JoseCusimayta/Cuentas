using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipal
{
    public partial class VentanaIngresos : Form
    {
        VerificarCampos verificarCampos = new VerificarCampos();
        public VentanaIngresos()
        {
            InitializeComponent();
        }

        private void VentanaIngresos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void b_nuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
            Reactivar(panel1);
            tb_fecha.Enabled = false;
        }

        void Nuevo()
        {
        }
        public bool Reactivar(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control.GetType().Equals(typeof(TextBox)))
                {
                    control.Enabled = true;
                }
            }
            return true;
        }

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

        private void tb_monto_Leave(object sender, EventArgs e)
        {
            string letra = tb_monto.Text.Replace(".", ",");
            double numero;
            try
            {
                numero = Convert.ToDouble(letra);
                tb_monto.Text = numero.ToString("C", CultureInfo.CurrentCulture);
            }
            catch
            {
                MessageBox.Show("El monto ingresado no es el correcto");
                tb_monto.Text = letra.Replace(".", "");
            }
            
        }
    }
}
