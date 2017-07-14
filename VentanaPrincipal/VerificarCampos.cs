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
        
        public String ListarCamposVacios(Control control)
        {
            String Mensaje = "Los siguientes campos no pueden estar vacios:";
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
            String Mensaje = "Los siguientes campos no pueden estar vacios:";
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
            String Mensaje = "Los siguientes campos no pueden estar vacios:";
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

        public bool ActivarNuevo(Panel panel_texto, Panel panel_boton)
        {
            foreach (Control control in panel_texto.Controls)
            {
                if (control.GetType().Equals(typeof(TextBox)))
                {
                    if (control.Name != "tb_orden"
                        && control.Name != "tb_codigo"
                        && control.Name != "tb_fecha")
                        control.Enabled = true;
                }
            }
            foreach (Control control in panel_boton.Controls)
            {
                if (control.GetType().Equals(typeof(Button)))
                {
                    if (control.Name == "b_guardar"
                        || control.Name == "b_cancelar")
                        control.Enabled = true;
                    else
                        control.Enabled = false;
                }
            }
            return true;
        }

        public bool ActivarModificar(Panel panel_texto, Panel panel_boton)
        {
            foreach (Control control in panel_texto.Controls)
            {
                if (control.GetType().Equals(typeof(TextBox)))
                {
                    if (control.Name != "tb_orden"
                        && control.Name != "tb_codigo"
                        && control.Name != "tb_fecha")
                        control.Enabled = true;
                }
            }
            foreach (Control control in panel_boton.Controls)
            {
                if (control.GetType().Equals(typeof(Button)))
                {
                    if (control.Name == "b_eliminar" ||
                        control.Name == "b_guardar"
                        || control.Name == "b_cancelar")
                        control.Enabled = true;
                    else
                        control.Enabled = false;
                }
            }
            return true;
        }

        public bool ActivarCancelar(Panel panel_texto, Panel panel_boton)
        {
            foreach (Control control in panel_texto.Controls)
            {
                if (control.GetType().Equals(typeof(TextBox)))
                {
                    control.Enabled = false;
                }
            }
            foreach (Control control in panel_boton.Controls)
            {
                if (control.GetType().Equals(typeof(Button)))
                {
                    if (control.Name == "b_nuevo"
                        || control.Name == "b_modificar"
                        || control.Name == "b_historial"
                        || control.Name == "b_f5")
                        control.Enabled = true;
                    else
                        control.Enabled = false;
                }
            }
            return true;
        }
    }
}