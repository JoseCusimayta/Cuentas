﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipal
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VentanaLogin ventanaLogin = new VentanaLogin();
            ventanaLogin.ShowDialog();
            if (ventanaLogin.DialogResult == DialogResult.OK)
                Application.Run(new VentanaMenu());
        }
    }
}