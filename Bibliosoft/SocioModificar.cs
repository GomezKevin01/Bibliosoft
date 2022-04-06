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
    public partial class SocioModificar : Form
    {
        public int id;
        public SocioModificar(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void refrescar()
        {
            gunaDateTimePicker1.Value = DateTime.Today;
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
                gunaTextBox5.Text = socios1.dni.ToString();
                gunaTextBox1.Text = socios1.apellido;
                gunaTextBox2.Text = socios1.nombre;
                gunaDateTimePicker1.Value = socios1.fechaNacimiento.Value;
                gunaTextBox3.Text = socios1.direccion;
                gunaTextBox4.Text = socios1.telefono;
            }
        }
        private void SociosEliminarEditar_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void SociosEliminarEditar_FormClosing(object sender, FormClosingEventArgs e)
        {
            SocioBuscar buscarSocio = new SocioBuscar();
            this.Hide();
            buscarSocio.ShowDialog();  
        }

        //El método gunaButton1_MouseUp realiza la modificación de socios
        private void gunaButton1_MouseUp(object sender, MouseEventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                DialogResult ask;
                socioss osocios = new socioss();
                osocios = biblioteca.socioss.Find(id);
                if ((gunaTextBox1.Text == "") || (gunaTextBox2.Text == "") || 
                    (gunaTextBox3.Text == "") | (gunaTextBox4.Text == ""))
                {
                    MessageBox.Show("Debe Completar todos los campos", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int dni = int.Parse(gunaTextBox5.Text);
                    var socioDni = from d in biblioteca.socioss
                                      where d.dni == dni & d.dni != osocios.dni
                                      select d;
                    if (socioDni.Count() == 1)
                    {
                        MessageBox.Show("El socio ya se encuentra registrado", "DNI Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        refrescar();
                    }
                    else
                    {
                        ask = MessageBox.Show("Seguro que desea modificar los datos del socio?",
                        "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                            osocios.dni = int.Parse(gunaTextBox5.Text);
                            osocios.apellido = gunaTextBox1.Text;
                            osocios.nombre = gunaTextBox2.Text;
                            osocios.fechaNacimiento = gunaDateTimePicker1.Value;
                            osocios.direccion = gunaTextBox3.Text;
                            osocios.telefono = gunaTextBox4.Text;

                            biblioteca.Entry(osocios).State = System.Data.Entity.EntityState.Modified;
                            biblioteca.SaveChanges();

                            MessageBox.Show("Datos del socio modificados correctamente", "Modificado",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
         }

        private void gunaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Restringe el ingreso de números
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
        }

        private void gunaTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Restringe el ingreso de números
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
        }

        private void gunaTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Restringe el ingreso de letras y espacios en blanco
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

        private void gunaTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permite el ingreso de letras, espacios en blanco y números
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

        private void gunaTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Restringe el ingreso de letras y espacios en blanco
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


        private void SociosEliminarEditar_FormClosed(object sender, FormClosedEventArgs e) { }
        private void gunaButton1_Click(object sender, EventArgs e) { }
        private void gunaTextBox5_TextChanged(object sender, EventArgs e) { }
    }
}
