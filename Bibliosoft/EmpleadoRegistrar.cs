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
    public partial class EmpleadoRegistrar : Form
    {
        public EmpleadoRegistrar()
        {
            InitializeComponent();
        }

        //El método gunaButton1_MouseUp realiza la operación de registro de empleado
        private void gunaButton1_MouseUp(object sender, MouseEventArgs e)
        {
            using (biblioteca1Entities db = new biblioteca1Entities())//se realiza la conexión a la base de datos
            {
                DialogResult ask;
                empleados oempleados = new empleados();
                if ((gunaTextBox1.Text == "") || (gunaTextBox2.Text == "") || (gunaTextBox5.Text == "") || (gunaTextBox4.Text == "")
                    | (gunaTextBox6.Text == "") || (gunaTextBox7.Text == "") | (gunaTextBox8.Text == ""))
                {
                    MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int dni = int.Parse(gunaTextBox1.Text);
                    string usuario = gunaTextBox6.Text;
                    var empleadoDni = from d in db.empleados
                                            where d.dni == dni
                                            select d;
                    var empleadoUsuario = from d in db.empleados
                                      where d.usuario == usuario
                                      select d;
                    if (empleadoDni.Count() > 0)
                    {
                        MessageBox.Show("El empleado ya se encuentra registrado", "DNI Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gunaTextBox1.Text = "";
                        gunaTextBox2.Text = "";
                        gunaTextBox4.Text = "";
                        gunaTextBox5.Text = "";
                        gunaTextBox6.Text = "";
                        gunaTextBox7.Text = "";
                        gunaTextBox8.Text = "";
                        gunaDateTimePicker1.Value = DateTime.Today;
                    }
                    else if (empleadoUsuario.Count() > 0)
                    {
                        MessageBox.Show("Nombre de usuario no disponible", "Ingrese otro usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gunaTextBox6.Text = "";
                        gunaTextBox7.Text = "";
                        gunaTextBox8.Text = "";
                    }
                    else
                    {
                        ask = MessageBox.Show("Seguro que desea insertar un nuevo Empleado?", "Confirmar insercion",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);/*se guarda si o no  en ask, según lo 
                                                                      devuelto en el cuadro de dialogo.*/
                        if (ask == DialogResult.Yes)
                        {
                            if (gunaTextBox7.Text == gunaTextBox8.Text)
                            {
                                oempleados.tipoEmpleado = gunaComboBox1.SelectedIndex + 1;
                                oempleados.dni = int.Parse(gunaTextBox1.Text);
                                oempleados.apeYnombre = gunaTextBox2.Text;
                                oempleados.fechaNacimiento = gunaDateTimePicker1.Value;
                                oempleados.direccion = gunaTextBox4.Text;
                                oempleados.telefono = gunaTextBox5.Text;
                                oempleados.usuario = gunaTextBox6.Text;
                                oempleados.contraseña = gunaTextBox7.Text;

                                db.empleados.Add(oempleados);
                                db.SaveChanges();
                                MessageBox.Show("El empleado: " + gunaTextBox2.Text + " fue registrado con exito", "Mensaje",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                gunaTextBox1.Text = "";
                                gunaTextBox2.Text = "";
                                gunaTextBox4.Text = "";
                                gunaTextBox5.Text = "";
                                gunaTextBox6.Text = "";
                                gunaTextBox7.Text = "";
                                gunaTextBox8.Text = "";
                                gunaDateTimePicker1.Value = DateTime.Today;
                            }
                            else
                            {
                                MessageBox.Show("Las contraseñas ingresadas no coinciden", "Reintentar", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                                gunaTextBox7.Text = "";
                                gunaTextBox8.Text = "";
                            }
                        }
                    }
                 }
            }
        }

        private void gunaTextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Restringe los espacios en blanco
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void gunaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solamente se permite el ingreso de números
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

        private void gunaTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solamente se permite el ingreso de letras
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
            //Se permite solamente el ingreso de letras y números.

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
            //Solamente se permite el ingreso de números
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

        private void EmpleadoRegistrar_Load(object sender, EventArgs e)
        {
            //Muestre en el calendario la fecha de hoy y determina una fecha limite.
            gunaDateTimePicker1.Value = DateTime.Today;
            gunaDateTimePicker1.MaxDate = DateTime.Today;
        }

    }
}
