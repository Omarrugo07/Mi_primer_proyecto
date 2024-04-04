using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.OperadoresLogicos
{
    public partial class frmOperadoresLogicos : Form
    {
        public frmOperadoresLogicos()
        {
            InitializeComponent();
        }

        private void frmOperadoresLogicos_Load(object sender, EventArgs e)
        {

        }

        int numero1;
        int numero2;
        bool resultado; 

        private void AsignacionVariables() 
        {
            
            numero1 =  Convert.ToInt32(textNum1.Text);
            numero2 = Convert.ToInt32(textNum2.Text);
            
            
            
        }


        private void botonY()  
        {
            AsignacionVariables();
            
            try
            {
                if (numero1  >= 5 && numero2 <= 10 )
                {
                    resultado = true;
                } 
               
                else
                {
                    resultado = false;
                }
                    total.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
              
            }
                    
        }

                        
            

        private void btnY_Click(object sender, EventArgs e)
        {
            botonY();
        }

        private void botonO()
        {
            AsignacionVariables();
            try
            {
                if (numero1 >= 5 || numero2 <= 10)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                total.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);

            }
        }

        private void bntO_Click(object sender, EventArgs e)
        {
            botonO();
        }


        private void Negacion()
        {
            AsignacionVariables();
            try
            {
                if (!(numero1 >= 5) && numero2 <= 10)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                total.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);

            }
        }


        private void btnNegacion_Click(object sender, EventArgs e)
        {
            Negacion();
        }
    }
}
