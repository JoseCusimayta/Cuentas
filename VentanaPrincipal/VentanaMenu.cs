using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipal
{
    public partial class VentanaMenu : Form
    {
        public VentanaMenu()
        {
            InitializeComponent();
        }

        private void b_ingresos_Click(object sender, EventArgs e)
        {
            VentanaIngresos ventana = new VentanaIngresos();
            ventana.ShowDialog(this);
        }

        private void b_egresos_Click(object sender, EventArgs e)
        {
            VentanaEgresos ventana = new VentanaEgresos();
            ventana.ShowDialog(this);
        }

        private void b_servicios_Click(object sender, EventArgs e)
        {
            VentanaServicios ventana = new VentanaServicios();
            ventana.ShowDialog(this);
        }

        private void b_balance_Click(object sender, EventArgs e)
        {
            VentanaBalance ventana = new VentanaBalance();
            ventana.ShowDialog(this);
        }

        private void VentanaMenu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
