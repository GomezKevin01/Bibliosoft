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
    public partial class mensajePersonalizado : Form
    {
        public int id;
        public mensajePersonalizado(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SociosEliminarEditar sociosEliminarEditar1 = new SociosEliminarEditar(id);
            this.Hide();
            sociosEliminarEditar1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            BuscarSocio buscarSocio = new BuscarSocio();
            buscarSocio.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                BuscarSocio buscarSocio = new BuscarSocio();
                DialogResult ask;
                ask = MessageBox.Show("Seguro que desea eliminar un socio?", "Confirmar Eliminaciónn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    socioss osocios = new socioss();
                    osocios = biblioteca.socioss.Find(id);
                    biblioteca.socioss.Remove(osocios);
                    biblioteca.SaveChanges();
                    MessageBox.Show("Socio Eliminado correctamente", "Eliminadoo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    buscarSocio.ShowDialog();
                }
                else
                {
                    this.Close();
                    buscarSocio.ShowDialog();
                }
            }
        }
    }
}
