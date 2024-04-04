using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Ejercicios
{
    public partial class MenúPrincipal : Form
    {
        public MenúPrincipal()
        {
            InitializeComponent();
        }

        private void MenúPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio1();
              
        }

       
        private void Ejercicio1()
        {
            panelVisor.Controls.Clear();
            Ejer1 ctl = new Ejer1();
            ctl.Titulo = button1.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
           
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            panelVisor.Controls.Clear();
            Ejer2 ctl = new Ejer2();
            ctl.titulo2 = button2.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelVisor.Controls.Clear();
            Ejer3 ctl = new Ejer3();
            ctl.Titulo3 = button3.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void panelVisor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelVisor.Controls.Clear();
            Ejer4 ctl = new Ejer4();
            ctl.Titulo4 = button4.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelVisor.Controls.Clear();
            Ejer5 ctl = new Ejer5();
            ctl.titulo5 = button5.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelVisor.Controls.Clear();
            Ejer6 ctl = new Ejer6();
            ctl.titulo6 = button6.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }
    }
}
