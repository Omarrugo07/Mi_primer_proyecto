using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Ejercicios
{
    public partial class Ejer1 : UserControl
    {
        public Ejer1()
        {
            InitializeComponent();
        }

        

        double a;
        double b;
        double c;
        double resultado;
        public string Titulo;

        private void AsignacionVariables()
        {
            a = Convert.ToDouble(textA.Text);
            b = Convert.ToDouble(textB.Text);
            c = Convert.ToDouble(textC.Text);
            

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
            try
            {
                AsignacionVariables();
                Calcular();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                
            }

        }

        private void Calcular(){

            resultado = ((c + 5) * (Math.Pow(b, 2) - 3 * a * c) * Math.Pow(a, 2)) / (4* a);
            Resul.Text = resultado.ToString();
           
         }

        private void Ejer1_Load(object sender, EventArgs e)
        {
            lblEjercicio.Text = Titulo;
        }

       

       
    }
}
