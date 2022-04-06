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
    public partial class LibroMensajePersonalizado : Form
    {
        public int id;
        public LibroMensajePersonalizado(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        // El método button1_Click abre otro formulario donde se podra modificar un libro (correspondiente al boton modificar)
        private void button1_Click(object sender, EventArgs e)
        {
            LibroModificar libroModificar= new LibroModificar(id);
            this.Hide();
            libroModificar.ShowDialog();
        }

        //El método button3_Click cierra el formulario emergente (correspondiente al boton cancelar)   
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            LibroBuscar libroBuscar = new LibroBuscar();
            libroBuscar.ShowDialog();
        }

        // El método button2_Click permite elimar un libro del sistema (correspondiente al boton eliminar)
        private void button2_Click(object sender, EventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                this.Hide();
                LibroBuscar libroBuscar = new LibroBuscar();
                DialogResult ask;
                ask = MessageBox.Show("Seguro que desea eliminar un Libro?", "Confirmar Eliminaciónn",MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                libross libros = new libross();
                libros = biblioteca.libross.Find(id);
                if (ask == DialogResult.Yes)
                {
                    if (libros.estado == 1)
                    {
                        MessageBox.Show("El libro NO se puede eliminar, ya que se encuentra prestado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        biblioteca.libross.Remove(libros);
                        biblioteca.SaveChanges();
                        MessageBox.Show("Libro eliminado correctamente", "Eliminadoo", MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                        this.Close();
                        libroBuscar.ShowDialog();
                    }
                }
                else
                {
                    this.Close();
                    libroBuscar.ShowDialog();
                }
            }
        }

        private void LibroMensajePersonalizado_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }


        private void label1_Click(object sender, EventArgs e) { }
        private void LibroMensajePersonalizado_FormClosing(object sender, FormClosingEventArgs e) { }
    }
}
