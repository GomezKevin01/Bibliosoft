using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliosoft
{
    public partial class Form1 : Form
    {
        public int tipEmpleado;
        public Form1(int tipEmpleado)
        {
            InitializeComponent();
            this.tipEmpleado = tipEmpleado;
        }

        //El mètodo Form1_Load habilita o desabilita botones dependiendo del tipo de empleado que ingreso al sistema
        private void Form1_Load(object sender, EventArgs e)
        {
            if (tipEmpleado == 1)//Si es bibliotecario
            {
                gunaLabel2.Text = "Bibliotecario";
                gunaButton2.Enabled = false;
                gunaButton4.Enabled = false;
                gunaButton5.Enabled = false;
            }
            else if (tipEmpleado == 2)//Si es encargado de stock
            {
                gunaLabel2.Text = "Encargado Stock";
                gunaButton1.Enabled = false;
                gunaButton3.Enabled = false;
                gunaButton4.Enabled = false;
                gunaButton5.Enabled = false;
            }            
        }

        //El metodo gunaAdvenceTileButton1_Click cierra el formulario principal y abre el formulario de logeo
        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {          
            Login logeo = new Login();
            logeo.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//Al presionar la X cierra el programa
        }

        //El método gunaButton2_Click manda al frente el formulario correspondiente al boton presionado
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            libro1.BringToFront();//Manda el formulario al frente
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            prestamo1.BringToFront();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            socio1.BringToFront();
        }

        private void gunaButton0_Click(object sender, EventArgs e)
        {
            inicio1.BringToFront();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            empleado1.BringToFront();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            ajustes1.BringToFront();
        }
    }
}
