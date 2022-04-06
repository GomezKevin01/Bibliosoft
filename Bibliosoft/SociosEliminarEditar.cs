using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliosoft.Properties;
namespace Bibliosoft
{
    public partial class SociosEliminarEditar : Form
    {
        public int id;
        public SociosEliminarEditar(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                DialogResult ask;
                socioss osocios = new socioss();
                osocios = biblioteca.socioss.Find(id);

                if ((gunaTextBox1.Text == "") | (gunaTextBox2.Text == "") | (gunaTextBox3.Text == "") | (gunaTextBox4.Text == ""))
                {
                    MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    ask = MessageBox.Show("Seguro que desea modificar los datos del socio?", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

                        biblioteca.Entry(osocios).State = System.Data.Entity.EntityState.Modified;
                        biblioteca.SaveChanges();



                        MessageBox.Show("Datos del socio modificados correctamente", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                       

                        
                    }

                }
            }
        }

        private void SociosEliminarEditar_Load(object sender, EventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                socioss socios1 = new socioss();
                socios1 = biblioteca.socioss.Find(id);
              
                    if (socios1.tipoSocio == 1)
                    {
                        gunaRadioButton1.Checked = true;
                    }
                    else
                    {
                        gunaRadioButton2.Checked = true;
                    }

                    gunaTextBox1.Text = socios1.apellido;
                    gunaTextBox2.Text = socios1.nombre;
                    gunaDateTimePicker1.Value = socios1.fechaNacimiento.Value;
                    gunaTextBox3.Text = socios1.direccion;
                    gunaTextBox4.Text = socios1.telefono;
               
            }
        }

        private void SociosEliminarEditar_FormClosing(object sender, FormClosingEventArgs e)
        {
            BuscarSocio buscarSocio = new BuscarSocio();
            this.Hide();
            buscarSocio.ShowDialog();
            


            
        }

        private void SociosEliminarEditar_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }

        private void gunaButton2_Click(object sender, EventArgs e)
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
