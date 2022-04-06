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
    public partial class LibroAñadir : Form
    {
        public LibroAñadir()
        {
            InitializeComponent();
        }

        private void LibroAñadir_Load(object sender, EventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                var autores1 = from d in biblioteca.autores
                                   select d.apellido;
                gunaComboBox1.DataSource = autores1.ToList();

                var proveedores1 = from d in biblioteca.proveedores
                              select d.nombre;
                gunaComboBox2.DataSource = proveedores1.ToList();
            }
        }

        //El método gunaButton1_MouseUp permite ingresar un nuevo libro
        private void gunaButton1_MouseUp(object sender, MouseEventArgs e)
        {
            using (biblioteca1Entities db = new biblioteca1Entities())
            {
                DialogResult ask;
                libross libros = new libross();
                if ((gunaTextBox1.Text == "") || (gunaTextBox2.Text == "") || (gunaTextBox3.Text == "")
                    || (gunaComboBox1.Text == "") | (gunaComboBox2.Text == ""))
                {
                    MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ask = MessageBox.Show("Seguro que desea insertar un nuevo Libro?", "Confirmar insercion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ask == DialogResult.Yes)
                    {
                        libros.titulo = gunaTextBox1.Text;
                        libros.año = int.Parse(gunaTextBox2.Text);
                        libros.editorial = gunaTextBox3.Text;
                        libros.idAutor = gunaComboBox1.SelectedIndex + 1;
                        libros.idProveedor = gunaComboBox2.SelectedIndex + 1;
                        libros.estado = 0;

                        db.libross.Add(libros);
                        db.SaveChanges();
                        MessageBox.Show("El libro " + gunaTextBox1.Text + " fue agregado con exito  ", "Guardar",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gunaTextBox1.Text = "";
                        gunaTextBox2.Text = "";
                        gunaTextBox3.Text = "";
                        gunaComboBox2.Text = "";
                    }
                }
            }
        }



        private void gunaTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permite solo el ingreso de números
            if (char.IsDigit(e.KeyChar))
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

        private void gunaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permite el ingreso de letras, números y espacios en blanco
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

        private void gunaTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permite el ingreso de letras, números y espacios en blanco
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

        private void gunaButton1_Click(object sender, EventArgs e) { }
        private void LibroAñadir_FormClosed(object sender, FormClosedEventArgs e) { }

    }
}
