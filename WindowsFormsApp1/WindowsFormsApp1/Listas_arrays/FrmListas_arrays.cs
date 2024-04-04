using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Listas
{
    public partial class FrmListas : Form
    {
        public FrmListas()
        {
            InitializeComponent();
        }

       

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            AgregarListas();
            
        }

        private void AgregarListas()
        {
            List<string> nombres = new List<string>();
            nombres.Add("Oscar");
            nombres.Add("juan");
            nombres.Add("felipe");
            foreach (string data in nombres) 
            {
                Listado.Items.Add(data);
            }
        }

        private void AgregarArrays()
        {
            string[] nombres = new string[5] { "Oscar", "juan", "felipe", "Marcelo", "Daniela" };
            foreach (string data in nombres)
            {
                Listado.Items.Add(data);
            }
        }

        private void FrmListas_Load(object sender, EventArgs e)
        {
            DibujarTecladoNumerico();
        }

        private void DibujarTecladoNumerico()
        {
            char[] numeros;
            numeros = "0123456789".ToArray();
            PanelNumerico.Controls.Clear();
            foreach(char numero in numeros)
            {
                Button btnnumero = new Button();
                btnnumero.Text = numero.ToString();
                btnnumero.Size = new Size(84, 73);
                btnnumero.FlatStyle = FlatStyle.Flat;
                btnnumero.ForeColor = Color.White;
                btnnumero.BackColor = Color.DimGray;
                btnnumero.FlatAppearance.BorderColor = Color.Yellow;
                btnnumero.FlatAppearance.BorderSize = 2;
                PanelNumerico.Controls.Add(btnnumero);
                btnnumero.Click += Btnnumero_Click;
            }
        }

        private void Btnnumero_Click(object sender, EventArgs e)
        {
            string numero = ((Button)sender).Text;
            textPantalla.Text += numero;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
