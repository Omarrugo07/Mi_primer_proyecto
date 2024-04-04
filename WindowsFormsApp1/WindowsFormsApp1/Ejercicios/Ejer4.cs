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
    public partial class Ejer4 : UserControl
    {
        public Ejer4()
        {
            InitializeComponent();
        }

          //VARIABLES
        public string Titulo4;

        private void Ejer4_Load(object sender, EventArgs e)
        {
            label11.Text = Titulo4;
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            double total = 0;
            string detalle = "";
            
            if (RBTallaM.Checked == true)
            {
                total += 50;
                detalle += "Camisa M  50 dolares \r\n";
            }
            if (RBBlanco.Checked == true)
            {
                total += 10;
                detalle += "Color Blanco \r\n";
            }
            if (RBNegro.Checked == true)
            {
                total += 20;
                detalle += "Color Negro \r\n";
            }
            if (RBAmarillo.Checked == true)
            {
                total += 30;
                detalle += "Color Amarillo \r\n";
            }
           
            if (RBtallaL.Checked == true)
            {
                total += 25;
                detalle += "Camisa L 25 Dolares \r\n";
            }

            if (RBtallaS.Checked == true)
            { 
                total += 25;
                detalle += "Camisa S 10 Dolares \r\n";
            }
            detalle += "El total a pagar es de " + total + "\r\n";
            textDetalle.Text = detalle ;

        }
    }
}
