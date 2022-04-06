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
    public partial class SocioMensajePersonalizado : Form
    {
        public int id;
        public SocioMensajePersonalizado(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        // El método button1_Click abre otro formulario donde se podra modificar a un socio (correspondiente al boton modificar)
        private void button1_Click(object sender, EventArgs e)
        {
            SocioModificar sociosEliminarEditar1 = new SocioModificar(id);
            this.Hide();
            sociosEliminarEditar1.ShowDialog();
        }

        //El método button3_Click cierra el formulario emergente (correspondiente al boton cancelar)   
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            SocioBuscar buscarSocio = new SocioBuscar();
            buscarSocio.ShowDialog();
        }

        // El método button2_Click permite elimar a un socio del sistema (correspondiente al boton eliminar)
        private void button2_Click(object sender, EventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                this.Hide();
                SocioBuscar buscarSocio = new SocioBuscar();
                DialogResult ask;
                ask = MessageBox.Show("Seguro que desea eliminar un socio?", "Confirmar Eliminaciónn", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                socioss osocios = new socioss();
                osocios = biblioteca.socioss.Find(id);
                if (ask == DialogResult.Yes)
                {
                    if (osocios.prestamos.Count() == 1)
                    {
                        MessageBox.Show("El socio no puede ser eliminado, ya que tiene un prestamo asignado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        biblioteca.socioss.Remove(osocios);
                        biblioteca.SaveChanges();
                        MessageBox.Show("Socio Eliminado correctamente", "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                        this.Close();
                        buscarSocio.ShowDialog();
                    }
                }
                else
                {
                    this.Close();
                    buscarSocio.ShowDialog();
                }
            }
        }

        private void SocioMensajePersonalizado_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }


        private void label1_Click(object sender, EventArgs e) { }
        private void SocioMensajePersonalizado_FormClosing(object sender, FormClosingEventArgs e) { }
    }
}
