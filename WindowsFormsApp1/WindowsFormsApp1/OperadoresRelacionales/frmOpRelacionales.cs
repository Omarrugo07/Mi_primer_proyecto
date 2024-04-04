using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.OperadoresRelacionales
{
    public partial class frmOpRelacionales : Form
    {
        public frmOpRelacionales()
        {
            InitializeComponent();
        }

        //Declaracion de variables

        int numero1;
        int numero2;
        bool resultado;


        private void frmOpRelacionales_Load(object sender, EventArgs e)
        {

        }

        private void btnMayorQue_Click(object sender, EventArgs e)
        {
            MayorQue();
        }


        private void MayorQue()
        {
            try
            {
                Asignacion();

                if (numero1 > numero2)
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

        private void Asignacion()
        {
            numero1 = Convert.ToInt32(textNum1.Text);
            numero2 = Convert.ToInt32(textNum2.Text);

        }

        private void bntMenorQue_Click(object sender, EventArgs e)
        {
            Menorque();
        }


        private void Menorque()
        {

            try
            {
                Asignacion();
                if (numero1 < numero2)
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

        private void btnMayorOigualQue_Click(object sender, EventArgs e)
        {
            mayorOigual();
        }

        private void mayorOigual()
        {
            try
            {
                Asignacion();

                if (numero1 >= numero2)
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

        private void btnMenorOigual_Click(object sender, EventArgs e)
        {
            MenorOigualQue();
        }

        private void MenorOigualQue()
        {
            try
            {
                Asignacion();

                if (numero1 <= numero2)
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

        private void igualQue()
        {
            try
            {
                Asignacion();

                if (numero1 == numero2)
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

        private void btnIgualQue_Click(object sender, EventArgs e)
        {
            igualQue();

        }

        private void btnDiferenteQue_Click(object sender, EventArgs e)
        {
            diferenteQue();
        }


        private void diferenteQue()
            {
            try
            {
                Asignacion();

                if (numero1 != numero2)
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

        private void textNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
