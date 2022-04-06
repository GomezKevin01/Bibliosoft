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
    public partial class EmpleadoModificar : Form
    {
        public int id;
        public EmpleadoModificar(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void EmpleadoModificar_Load(object sender, EventArgs e)
        {
            refrescar();
        }
        private void refrescar()
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                empleados oempleados = new empleados();
                oempleados = biblioteca.empleados.Find(id);

                gunaComboBox1.SelectedIndex = oempleados.tipoEmpleado - 1;
                gunaTextBox1.Text = oempleados.dni.ToString();
                gunaTextBox2.Text = oempleados.apeYnombre;
                gunaTextBox4.Text = oempleados.direccion;
                gunaTextBox5.Text = oempleados.telefono;
                gunaTextBox6.Text = oempleados.usuario;
                gunaTextBox7.Text = oempleados.contraseña;
                gunaDateTimePicker1.Value = oempleados.fechaNacimiento;

            }
        }

        // El método gunaButton1_MouseUp modifica un empleado
        private void gunaButton1_MouseUp(object sender, MouseEventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                DialogResult ask;
                empleados oempleados = new empleados();
                oempleados = biblioteca.empleados.Find(id);
                if ((gunaTextBox1.Text == "") || (gunaTextBox2.Text == "") || (gunaTextBox5.Text == "") || (gunaTextBox4.Text == "")
                    | (gunaTextBox6.Text == "") | (gunaTextBox7.Text == "") )
                {
                    MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int dni = int.Parse(gunaTextBox1.Text);
                    string usuario = gunaTextBox6.Text;
                    var empleadoDni = from d in biblioteca.empleados 
                                      where (d.dni == dni) & (d.dni != oempleados.dni)
                                      select d;
                    var empleadoUsuario = from d in biblioteca.empleados
                                          where d.usuario == usuario & d.usuario != oempleados.usuario
                                          select d;
                    if (empleadoDni.Count() == 1)
                    {
                        MessageBox.Show("El empleado ya se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        refrescar();
                    }
                    else if (empleadoUsuario.Count() == 1)
                    {
                        MessageBox.Show("Nombre de usuario no disponible", "Ingrese otro usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gunaTextBox6.Text = oempleados.usuario;
                        gunaTextBox7.Text = oempleados.contraseña;
                    }
                    else
                    {
                        ask = MessageBox.Show("Seguro que desea modificar los datos del Empleado?", "Confirmar Modificación",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            oempleados.tipoEmpleado = gunaComboBox1.SelectedIndex + 1;
                            oempleados.dni = int.Parse(gunaTextBox1.Text);
                            oempleados.apeYnombre = gunaTextBox2.Text;
                            oempleados.direccion = gunaTextBox4.Text;
                            oempleados.telefono = gunaTextBox5.Text;
                            oempleados.usuario = gunaTextBox6.Text;
                            oempleados.contraseña = gunaTextBox7.Text;
                            oempleados.fechaNacimiento = gunaDateTimePicker1.Value;

                            biblioteca.Entry(oempleados).State = System.Data.Entity.EntityState.Modified;
                            biblioteca.SaveChanges();

                            MessageBox.Show("Datos del empleado modificados correctamente", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }

        private void EmpleadoModificar_FormClosing(object sender, FormClosingEventArgs e)
        {
            EmpleadoBuscar empleadoBuscar = new EmpleadoBuscar();
            this.Hide();
            empleadoBuscar.ShowDialog();
        }
    }
}
