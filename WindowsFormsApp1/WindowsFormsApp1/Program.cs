using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.OperadoresLogicos;
using WindowsFormsApp1.OperadoresAritmeticos;
using WindowsFormsApp1.OperadoresRelacionales;
using WindowsFormsApp1.Condicionales;
using WindowsFormsApp1.Ejercicios;
using WindowsFormsApp1.Listas;

namespace WindowsFormsApp1
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
            Application.Run(new MenúPrincipal());
        }
    }
}
