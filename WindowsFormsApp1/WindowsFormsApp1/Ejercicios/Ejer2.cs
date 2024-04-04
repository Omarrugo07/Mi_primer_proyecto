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
    public partial class Ejer2 : UserControl
    {
        public Ejer2()
        {
            InitializeComponent();
        }

        private void Ejer2_Load(object sender, EventArgs e)
        {
            label5.Text = titulo2;
        }

        
        double radio;
        double Area;
        double pi = Math.PI;
        double Longitud;
        public string titulo2;

        private void AsignacionVariables()
        {
            Area = Convert.ToDouble(TxtArea.Text);
            
        }

       

        private void ObtenerRadio()
        {
            radio = Math.Sqrt(Area / pi);
            lblRadio1.Text = radio.ToString();
            lblRadio2.Text = radio.ToString();
            resulRadio.Text = radio.ToString();
        }

        private void ObtenerLongitud()
        {
            Longitud = 2 * pi * radio;
            ResulLong.Text = Longitud.ToString();
        }

        private void btnCalcularA_Click(object sender, EventArgs e)
        {
            

            try
            {
                AsignacionVariables();
                ObtenerRadio();
                ObtenerLongitud();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
              
            }
                    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
