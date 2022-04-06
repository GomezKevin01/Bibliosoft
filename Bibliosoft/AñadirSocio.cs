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
    public partial class AñadirSocio : Form
    {
        public AñadirSocio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AñadirSocio_Load(object sender, EventArgs e)
        {
           
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            using (biblioteca1Entities db = new biblioteca1Entities()) {
                
                DialogResult ask;
                socioss osocios = new socioss();

                if ((gunaTextBox1.Text == "") | (gunaTextBox2.Text == "") | (gunaTextBox3.Text == "") | (gunaTextBox4.Text == ""))
                {
                    MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    ask = MessageBox.Show("Seguro que desea insertar un nuevo Socio?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ask == DialogResult.Yes)
                    {
                        if (gunaRadioButton1.Checked == true)
                        {
                            osocios.tipoSocio = 1;
                        }
                        else
                        {
                            osocios.tipoSocio = 2;
                        }

                        osocios.apellido = gunaTextBox1.Text;
                        osocios.nombre = gunaTextBox2.Text;
                        osocios.fechaNacimiento = gunaDateTimePicker1.Value;
                        osocios.direccion = gunaTextBox3.Text;
                        osocios.telefono = gunaTextBox4.Text;

                        db.socioss.Add(osocios);
                        db.SaveChanges();
                        MessageBox.Show(gunaTextBox1.Text + " " + gunaTextBox2.Text + " es un nuevo socio", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gunaTextBox1.Text = "";
                        gunaTextBox2.Text = "";
                        gunaTextBox3.Text = "";
                        gunaTextBox4.Text = "";
                    }
                }                               
            }
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

           /* if (gunaTextBox1.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];

            else if (gunaTextBox1.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];*/
        }

        private void gunaTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            /*if (gunaTextBox1.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];

            else if (gunaTextBox1.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];*/
        }

        private void gunaTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void gunaTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }
    }
}
