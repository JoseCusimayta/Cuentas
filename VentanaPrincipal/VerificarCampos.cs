using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipal
{
    class VerificarCampos
    {
        String Mensaje = "Los siguientes campos no pueden estar vacios:";
        public String ListarCamposVacios(Control control)
        {
            foreach (var txt in control.Controls)
            {
                if (txt is TextBox)
                {
                    TextBox text = ((TextBox)txt);
                    if (String.IsNullOrWhiteSpace(text.Text))
                    {
                        Mensaje = Mensaje + "\n " + text.Tag;
                    }
                }
            }
            return Mensaje;
        }

        public String ListarCamposVacios(GroupBox e)
        {            
            foreach (var txt in e.Controls)
            {
                if (txt is TextBox)
                {
                    TextBox text = ((TextBox)txt);
                    if (String.IsNullOrWhiteSpace(text.Text))
                    {
                        Mensaje = Mensaje + "\n " + text.Tag;
                    }
                }
            }
            return Mensaje;
        }

        public String ListarCamposVacios(Panel e)
        {
            foreach (var txt in e.Controls)
            {
                if (txt is TextBox)
                {
                    TextBox text = ((TextBox)txt);
                    if (String.IsNullOrWhiteSpace(text.Text))
                    {
                        Mensaje = Mensaje + "\n " + text.Tag;
                    }
                }
            }
            return Mensaje;
        }

        public bool ValidarCamposVacios(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control.GetType().Equals(typeof(TextBox)))
                {
                    if (control.Text.Equals(""))
                    {
                        return false;
                    }
                }
                else if (control.GetType().Equals(typeof(ComboBox)))
                {
                    if (control.Text.Equals(""))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void SoloLetras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
                v.Handled = false;
            else if (Char.IsSeparator(v.KeyChar))
                v.Handled = false;
            else if (Char.IsControl(v.KeyChar))
                v.Handled = false;
            else
                v.Handled = true;
        }
        public void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
                v.Handled = false;
            else if (Char.IsSeparator(v.KeyChar))
                v.Handled = true;
            else if (Char.IsControl(v.KeyChar))
                v.Handled = false;
            else
                v.Handled = true;
        }
        public void SoloDecimal(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
                v.Handled = false;
            else if (Char.IsSeparator(v.KeyChar))
                v.Handled = true;
            else if (Char.IsControl(v.KeyChar))
                v.Handled = false;
            else if (v.KeyChar.ToString().Equals("."))
                v.Handled = false;
            else if (v.KeyChar.ToString().Equals(","))
                v.Handled = false;
            else
                v.Handled = true;
        }
        public void SoloNumeroYLetras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
                v.Handled = false;
            else if (Char.IsControl(v.KeyChar))
                v.Handled = false;
            else if (Char.IsDigit(v.KeyChar))
                v.Handled = false;
            else
                v.Handled = true;
        }
    }
}
