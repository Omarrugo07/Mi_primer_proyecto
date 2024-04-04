using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Condicionales
{
    public partial class frmCondicionales : Form
    {
        public frmCondicionales()
        {
            InitializeComponent();
        }

        private void frmCondicionales_Load(object sender, EventArgs e)
        {

        }
        int numero;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AsignarValores();
            Calcular();
        }

        private void Calcular()
        {
            if (numero > 0 )
            {
                lblResultado.Text = "El numero es positivo";
            }
            else if (numero == 0)
            {
                lblResultado.Text = "El numero es un valor 0";
            } 
            else  
            {
                lblResultado.Text = " el numero es negativo ";
            }
        }

        private void AsignarValores()
        {
            numero = Convert.ToInt32(textNumero.Text);
        }
    }
}
