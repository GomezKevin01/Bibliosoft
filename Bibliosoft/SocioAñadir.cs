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
    public partial class SocioAñadir : Form
    {
        public SocioAñadir()
        {
            InitializeComponent();
        }

        private void AñadirSocio_Load(object sender, EventArgs e)
        {           
            gunaDateTimePicker1.Value = DateTime.Today;//Muestre en el calendario la fecha de hoy
            gunaDateTimePicker1.MaxDate = DateTime.Today;//Determina una fecha limite.
        }

        //El método gunaButton1_MouseUp añade un nuevo socio
        private void gunaButton1_MouseUp(object sender, MouseEventArgs e)
        {
            using (biblioteca1Entities db = new biblioteca1Entities())//se realiza la conexión a la base de datos
            {
                DialogResult ask;
                socioss osocios = new socioss();
                if ((gunaTextBox1.Text == "") | (gunaTextBox2.Text == "") | (gunaTextBox3.Text == "") | (gunaTextBox4.Text == ""))
                {
                    MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    int dni = int.Parse(gunaTextBox5.Text);
                    var socioDni = from d in db.socioss
                                   where d.dni == dni
                                   select d;
                    if (socioDni.Count() > 0)
                    {
                        MessageBox.Show("El socio ya se encuentra registrado", "DNI Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gunaTextBox1.Text = "";
                        gunaTextBox2.Text = "";
                        gunaTextBox3.Text = "";
                        gunaTextBox4.Text = "";
                        gunaTextBox5.Text = "";
                        gunaDateTimePicker1.Value = DateTime.Today;//Muestre en el calendario la fecha de hoy
                    }
                    else
                    {
                        ask = MessageBox.Show("Seguro que desea insertar un nuevo Socio?", "Confirmar insercion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);/*se guarda si o no  en ask, según lo 
                                                                      devuelto en el cuadro de dialogo.*/
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
                            //se le asignan los valores correspondientes a cada atributo de la tabla socios
                            osocios.dni = int.Parse(gunaTextBox5.Text);//Convierte la cadena en un int
                            osocios.apellido = gunaTextBox1.Text;
                            osocios.nombre = gunaTextBox2.Text;
                            osocios.fechaNacimiento = gunaDateTimePicker1.Value;
                            osocios.direccion = gunaTextBox3.Text;
                            osocios.telefono = gunaTextBox4.Text;

                            db.socioss.Add(osocios);//se prepara para añadir un nuevo socio
                            db.SaveChanges();//termina de añadir un nuevo socio
                            MessageBox.Show(gunaTextBox1.Text + " " + gunaTextBox2.Text + " es un nuevo socio", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            //se eliminan los valores de los textboxs
                            gunaTextBox1.Text = "";
                            gunaTextBox2.Text = "";
                            gunaTextBox3.Text = "";
                            gunaTextBox4.Text = "";
                            gunaTextBox5.Text = "";
                        }
                    }
                }
            }
        }


        //En los demas métodos se realizan restricciones de ingreso de caracteres...
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

        private void gunaTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
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



        //METODOS SIN USAR
        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void SocioAñadir_FormClosing(object sender, FormClosingEventArgs e) { }
        private void gunaButton1_Click(object sender, EventArgs e) { }
        private void gunaLabel1_Click(object sender, EventArgs e) { }
        private void gunaLabel6_Click(object sender, EventArgs e) { }
        private void gunaTextBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }


    }
}
