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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            gunaTextBox2.UseSystemPasswordChar = true;
            gunaElipsePanel1.BaseColor = Color.FromArgb(100, 0, 0, 0);
        }

        // El método gunaPictureBox1_Click cambia la visibilidad de la contraseña.
        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            if (gunaTextBox2.UseSystemPasswordChar == true)
            {
                gunaTextBox2.UseSystemPasswordChar = false;
            }
            else { 
                gunaTextBox2.UseSystemPasswordChar = true;
            }
        }

        //El método gunaButton1_Click verifica el usuario y contraseña, y si son validos abre el menu principal
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "" | gunaTextBox2.Text == ""){
                MessageBox.Show("Complete los dos campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                using (biblioteca1Entities biblioteca1 = new biblioteca1Entities())
                {
                    var empleados1 = from d in biblioteca1.empleados
                                   where d.usuario == gunaTextBox1.Text & gunaTextBox2.Text.Equals(d.contraseña)
                                   select d;
                    if (empleados1.Count() == 1)
                    {
                        empleados oempleados = new empleados();
                        oempleados = empleados1.First();
                        int tipEmpleado = oempleados.tipoEmpleado;
                        this.Hide();
                        Form1 inicio = new Form1(tipEmpleado);
                        inicio.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//cierra el programa
        }
       
        private void gunaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //No se permite espacios en blanco
           if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        //Evento click
        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();//Esconde un formulario
            BibliotecaClave bibliotecaClave = new BibliotecaClave();           
            bibliotecaClave.ShowDialog();//Abre otro formulario
            this.Show();//Muestra el formulario escondido 

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e) { }
    }
}
    