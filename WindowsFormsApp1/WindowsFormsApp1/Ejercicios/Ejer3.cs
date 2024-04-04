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
    public partial class Ejer3 : UserControl
    {
        public Ejer3()
        {
            InitializeComponent();
        }

        double peso;
        double altura;
        string estado;
        double resultado;
        public string Titulo3;


        private void Ejer3_Load(object sender, EventArgs e)
        {
            label10.Text = Titulo3;
        }

        private void AsignacionVariables()
        {
            TxtPeso.Text = TxtPeso.Text.Replace(".", ",");
            textAltura.Text = textAltura.Text.Replace(".", ",");
            peso = Convert.ToDouble(TxtPeso.Text);
            altura = Convert.ToDouble(textAltura.Text);
           
             
        }

        private void Operacion1()
        {
            resultado = peso / Math.Pow(altura,2);
            txtResultado.Text = resultado.ToString("N2");
            
                                                        
            
        }

        private void Operacion()
        {
            
                if (resultado < 18.5)
                {
                    estado  = "peso normal";
                    textEstado.Text = estado;

                }
                else if (resultado >= 18.5 && resultado <= 24.9)
                {
                    estado = "peso saludable";
                    textEstado.Text = estado;
                }
                else if (resultado >= 25 && resultado <= 29.9)
                {
                    estado = "  Sobre peso";
                    textEstado.Text = estado;
                }

                else if (resultado >= 30)
                {
                    estado = " Se encuentra en estado de obesidad";
                    textEstado.Text = estado;
                }
            
             
            
        }

        private void btnCalcularPeso_Click(object sender, EventArgs e)
        {
            

            try
            {
                AsignacionVariables();
                Operacion1();
                Operacion();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
