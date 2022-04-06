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
    public partial class LibroModificar : Form
    {
        public int id;
        public LibroModificar(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void LibroModificar_Load(object sender, EventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                var autores1 = from d in biblioteca.autores
                                   select d.nombre;

                var proveedores1 = from d in biblioteca.proveedores
                                   select d.nombre;

                libross libros = new libross();
                libros = biblioteca.libross.Find(id);

                gunaTextBox1.Text = libros.titulo;
                gunaTextBox2.Text = libros.año.ToString();
                gunaTextBox3.Text = libros.editorial;
                gunaComboBox1.DataSource = autores1.ToList();
                gunaComboBox1.SelectedIndex = libros.idAutor - 1;
                gunaComboBox2.DataSource = proveedores1.ToList();
                gunaComboBox2.SelectedIndex = libros.idProveedor - 1;
                gunaComboBox3.SelectedIndex = libros.estado ?? default(int);
            }
        }

        // El método gunaButton1_MouseUp realiza la operación de modificar libro
        private void gunaButton1_MouseUp(object sender, MouseEventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                DialogResult ask;
                libross libros = new libross();
                libros = biblioteca.libross.Find(id);
                if ((gunaTextBox1.Text == "") || (gunaTextBox2.Text == "") || (gunaTextBox3.Text == "")
                   || (gunaComboBox1.Text == "") | (gunaComboBox2.Text == ""))
                {
                    MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ask = MessageBox.Show("Seguro que desea modificar los datos del Libro?", "Confirmar Modificación", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ask == DialogResult.Yes)
                    {
                        libros.titulo = gunaTextBox1.Text;
                        libros.año = int.Parse(gunaTextBox2.Text);
                        libros.editorial = gunaTextBox3.Text;
                        libros.idAutor = gunaComboBox1.SelectedIndex + 1;
                        libros.idProveedor = gunaComboBox2.SelectedIndex + 1;
                        libros.estado = gunaComboBox3.SelectedIndex;

                        biblioteca.Entry(libros).State = System.Data.Entity.EntityState.Modified;
                        biblioteca.SaveChanges();

                        MessageBox.Show("Datos del Libro modificados correctamente", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        private void LibroModificar_FormClosing(object sender, FormClosingEventArgs e)
        {
            LibroBuscar libroBuscar = new LibroBuscar();
             this.Hide();
             libroBuscar.ShowDialog();

        }


        // Los métodos siguientes son para restringir el ingreso de algunos tipos de datos
        // El método gunaTextBox2_KeyPress no permite el ingreso de letras y espacios en el textbox correspondiente al DNI
        private void gunaTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
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

        // El método gunaTextBox1_KeyPress estringe todo menos decimales, letras, espacios  en blanco y caracteres de control
        private void gunaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        // El método gunaTextBox3_KeyPress estringe todo menos decimales, letras, espacios  en blanco y caracteres de control
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

        private void gunaButton1_Click(object sender, EventArgs e) { }
    }
}
