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
    public partial class VentanaBalance : Form
    {
        public VentanaBalance()
        {
            InitializeComponent();
        }

        private void b_nuevo_Click(object sender, EventArgs e)
        {

        }

        private void VentanaBalance_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
