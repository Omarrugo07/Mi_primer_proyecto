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
    public partial class Ejer5 : UserControl
    {
        public Ejer5()
        {
            InitializeComponent();
        }
        //DECLARACION DE VARIABLES
        public string titulo5;
        int numero1;
        int numero2;
        string resultado;

        private void Ejer5_Load(object sender, EventArgs e)
        {
            label12.Text = titulo5;
        }

        

        private void DeclaracionVariables()
        {
            numero1 = Convert.ToInt32(TxtNum1.Text);
            numero2 = Convert.ToInt32(textNum2.Text);
        }

        private void Calculo()
        {
            if (numero1%2==0 && numero2%2==0)
            {
                lblResultado.Text = "Ambos numeros son Pares";
            }
            else if (numero1%2 ==0 && numero2%2 !=0)
            {
                lblResultado.Text = "Solo el numero uno es Par";
            } 
            else if (numero1%2 != 0 && numero2%2 == 0)
            {
                lblResultado.Text = "Solo el numero dos es Par";
            }
            else
            {
                lblResultado.Text = "Ambos numeros son Impares";
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                DeclaracionVariables();
                Calculo();
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.StackTrace);
            }
           
        }
    }
}
