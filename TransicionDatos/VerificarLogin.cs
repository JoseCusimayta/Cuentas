using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionesBD;

namespace TransicionDatos
{
    public class VerificarLogin
    {
        Login login = new Login();

        public Boolean VerificarUsuario(String usuario, String clave)
        {
            if (login.VerificarUsuario(usuario, clave) == "1")
                return true;
            else
                return false;
        }
    }
}