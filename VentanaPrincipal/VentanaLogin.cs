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
    public partial class VentanaLogin : Form
    {
        VerificarLogin verificarLogin = new VerificarLogin();
        Int32 intentos = 0;
        public VentanaLogin()
        {
            
            InitializeComponent();
        }

        private void b_ingresar_Click(object sender, EventArgs e)
        {
            if (verificarLogin.VerificarUsuario(tb_usuario.Text, tb_clave.Text) && intentos<5)
            {
                MessageBox.Show("Conexion Establecida");
                DialogResult=DialogResult.OK;
            }
            else
            {
                intentos++;
                if (intentos >= 5)
                {
                    MessageBox.Show("Se ha excedido el número máximo de intentos permitido, se procederá a cerrar el programa");
                    DialogResult = DialogResult.Abort;
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas, número de intentos: "+intentos);
                }
            }
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
