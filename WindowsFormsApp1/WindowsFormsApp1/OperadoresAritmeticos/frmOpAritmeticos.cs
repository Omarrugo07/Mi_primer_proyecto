using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.OperadoresAritmeticos
{
    public partial class frmOpAritmeticos : Form
    {
        public frmOpAritmeticos()
        {
            InitializeComponent();
        }


     //Declaracion de variables
        double numero1;
        double numero2;
        double resultado;
        

        private void frmOpAritmeticos_Load(object sender, EventArgs e)
        {


        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Suma();

        }


        private void Suma()
        {
            try
            {
                if (string.IsNullOrEmpty(texNum1.Text))
                {
                    texNum1.Text = "0";
                    
                }

                if (string.IsNullOrEmpty(textNum2.Text))
                {
                    textNum2.Text = "0";
                    
                }
                //25,0
                texNum1.Text = texNum1.Text.Replace(".", ",");
                textNum2.Text = textNum2.Text.Replace(".", ",");
                numero1 = Convert.ToDouble(texNum1.Text);
                numero2 = Convert.ToDouble(textNum2.Text);
                
                resultado = numero1 + numero2;
                total.Text = Convert.ToString(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            
            }
        
        }


  
        private void btnResta_Click(object sender, EventArgs e)
        {
            Resta();
        }

        private void Resta()
        {
            try
            {
                if (string.IsNullOrEmpty(texNum1.Text))
                {
                    texNum1.Text = "0";
                }

                if (string.IsNullOrEmpty(textNum2.Text))
                {
                    textNum2.Text = "0";
                }

                texNum1.Text = texNum1.Text.Replace(".", ",");
                textNum2.Text = textNum2.Text.Replace(".", ",");
                numero1 = Convert.ToDouble(texNum1.Text);
                numero2 = Convert.ToDouble(textNum2.Text);
                resultado = numero1 - numero2;
                total.Text = Convert.ToString(resultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                
            }

            
        }


        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            multiplicacion();
        }

        private void multiplicacion()
        {
            if (string.IsNullOrEmpty(texNum1.Text))
            {
                texNum1.Text = "0";
            }

            if (string.IsNullOrEmpty(textNum2.Text))
            {
                textNum2.Text = "0";
            }

            numero1 = Convert.ToInt32(texNum1.Text);
            numero2 = Convert.ToInt32(textNum2.Text);
            resultado = numero1 * numero2;
            total.Text = Convert.ToString(resultado);
        }



        private void btnDivision_Click(object sender, EventArgs e)
        {
            division();
        }

        private void division()
        {
            if (string.IsNullOrEmpty(texNum1.Text))
            {
                texNum1.Text = "0";
            }

            if (string.IsNullOrEmpty(textNum2.Text))
            {
                textNum2.Text = "0";
            }

            numero1 = Convert.ToInt32(texNum1.Text);
            numero2 = Convert.ToInt32(textNum2.Text);
            resultado = Convert.ToDouble(numero1) / Convert.ToDouble(numero2);
            total.Text = Convert.ToString(resultado);

        }

        private void texNum1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

