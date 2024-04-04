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
    public partial class Ejer6 : UserControl
    {
        public Ejer6()
        {
            InitializeComponent();
        }

        //VARIABLES 
        public string titulo6;
        string operacion;
        double num1;
        double num2;
        double resultado;
        bool punto = true;



        private void Ejer6_Load(object sender, EventArgs e)
        {
            label13.Text = titulo6;
            lblEjercicio.Text = titulo6;
            Dibujar_teclado_numerico();
        }

        private void Dibujar_teclado_numerico()
        {
            char[] numeros;
            numeros = "7894561230,".ToArray();
            foreach (char numero in numeros)
            {
                Button btnNumero = new Button();
                btnNumero.Text = numero.ToString();
                btnNumero.BackgroundImage = Properties.Resources.boton_negro_recortado;
                btnNumero.BackgroundImageLayout = ImageLayout.Zoom;
                btnNumero.FlatAppearance.BorderSize = 0;
                btnNumero.Cursor = Cursors.Hand;
                btnNumero.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btnNumero.FlatAppearance.MouseOverBackColor = Color.Transparent;
                btnNumero.Size = new Size(42, 42);
                btnNumero.FlatStyle = FlatStyle.Flat;
                btnNumero.ForeColor = Color.White;
                btnNumero.BackColor = Color.Transparent;
                btnNumero.FlatAppearance.BorderSize = 0;
                panelNumerico.Controls.Add(btnNumero);
                btnNumero.Click += BtnNumero_Click;

            }

        }

        private void BtnNumero_Click(object sender, EventArgs e)
        {
            string numero = ((Button)sender).Text;
            if(numero == ",")
            {
                punto = true;
                if (Pantalla.Text.Contains(","))
                {
                    punto = false;
                }
                if (punto == true)
                {
                    if (Pantalla.Text !="")
                    {
                        Pantalla.Text += ",";
                    }
                }
            }
            else
            {
                if (Pantalla.Text == "0")
                {
                    Pantalla.Clear();
                }
                Pantalla.Text += numero;
            }
        }

            


        private void btn_division_Click(object sender, EventArgs e)
        {
            operacion = btn_division.Text;
            DefinirOperacion();

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {

            operacion = btnSuma.Text;
            DefinirOperacion();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = btnMultiplicacion.Text;
            DefinirOperacion();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = btnResta.Text;
            DefinirOperacion();
        }

        private void btnProcentaje_Click(object sender, EventArgs e)
        {
            operacion = btnProcentaje.Text;
            DefinirOperacion();
        }


        private void DefinirOperacion()
        {
            AsignarDatos();
            if (num2 > 0)
            {
                lblNum1.Text = Pantalla.Text;
                lblOperacion.Text = operacion;
                Pantalla.Text = "0";
                lblNum1.Visible = true;
                lblOperacion.Visible = true;

            }

        }




        private void AsignarDatos()
        {
            num1 = Convert.ToDouble(lblNum1.Text);
            num2 = Convert.ToDouble(Pantalla.Text);

        }

        private void btbResultado_Click(object sender, EventArgs e)
        {

            Calcular();

        }

        private void Calcular()
        {
            AsignarDatos();
            if (lblOperacion.Text == btn_division.Text)
            {
                Dividir();
            }
            if (lblOperacion.Text == btnSuma.Text)
            {
                Suma();
            }
            if (lblOperacion.Text == btnMultiplicacion.Text)
            {
                Multiplicacion();
            }
            if (lblOperacion.Text == btnResta.Text)
            {
                Resta();
            }
            if (lblOperacion.Text == btnProcentaje.Text)
            {
                Porcentaje();
            }


        }

        private void Dividir()
        {

            resultado = num1 / num2;
            Pantalla.Text = resultado.ToString();
            Pantalla.Clear();
            lblNum1.Text = "0";
            lblOperacion.Text = "";

        }

        private void Suma()
        {

            resultado = num1 + num2;
            Pantalla.Text = resultado.ToString();
            lblNum1.Text = "0";
            lblOperacion.Text = "";

        }

        private void Multiplicacion()
        {
            resultado = num1 * num2;
            Pantalla.Text = resultado.ToString();
            lblNum1.Text = "0";
            lblOperacion.Text = "";
        }

        private void Resta()
        {
            resultado = num1 - num2;
            Pantalla.Text = resultado.ToString();
            lblNum1.Text = "0";
            lblOperacion.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            
            lblNum1.Text = "0";
            Pantalla.Text = "0";
            
        }

        private void Porcentaje ()
        {
            resultado = num1 * num2 / 100;
            Pantalla.Text = resultado.ToString();
            lblNum1.Text = "0";
            lblOperacion.Text = "";
           
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Pantalla.Text);
        }
    }
}
