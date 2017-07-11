using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipal
{
    class LimpiarCampos
    {
        public void BorrarCampos(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                    ((TextBox)txt).Clear();
                else if (txt is ComboBox)
                    ((ComboBox)txt).SelectedIndex = 0;
            }
        }

        public void BorrarCampos(GroupBox e)
        {
            foreach (var txt in e.Controls)
            {
                if (txt is TextBox)
                    ((TextBox)txt).Clear();
                else if (txt is ComboBox)
                    ((ComboBox)txt).SelectedIndex = 0;
            }
        }
        public void BorrarCampos(Panel e)
        {
            foreach (var txt in e.Controls)
            {
                if (txt is TextBox)
                    ((TextBox)txt).Clear();
                else if (txt is ComboBox)
                    ((ComboBox)txt).SelectedIndex = 0;
            }
        }

        public void BorrarCampos( Form e)
        {
            foreach (var txt in e.Controls)
            {
                if (txt is TextBox)
                    ((TextBox)txt).Clear();
                else if (txt is ComboBox)
                    ((ComboBox)txt).SelectedIndex = 0;
            }
        }
    }
}
