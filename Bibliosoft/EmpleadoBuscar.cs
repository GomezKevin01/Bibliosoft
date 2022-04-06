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
    public partial class EmpleadoBuscar : Form
    {
        public EmpleadoBuscar()
        {
            InitializeComponent();
        }

        //El método refrescar actualiza los campos del grid de empleados, mostrando a todos los empleados del sistema
        private void refrescar()
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                var oempleados = from d in biblioteca.vistaEmpleados
                              select new
                              {
                                  d.ID_del_Empleado,
                                  d.Tipo_de_Empleado,
                                  d.DNI,
                                  d.Apellido_y_nombre,
                                  d.Usuario,
                                  d.Fecha_de_nacimiento,
                                  d.Dirección,
                                  d.Telefono
                              };

                dataGridView1.DataSource = oempleados.ToList();
                dataGridView1.Columns[0].HeaderText = "ID del Empleado";//Cambio el título de la columna
                dataGridView1.Columns[1].HeaderText = "Tipo Empleado";
                dataGridView1.Columns[3].HeaderText = "Apellido y Nombre";
                dataGridView1.Columns[5].HeaderText = "Fecha de nacimiento";
                gunaTextBox1.Text = "";
                gunaTextBox2.Text = "";
            }
        }
        private void EmpleadoBuscar_Load(object sender, EventArgs e)
        {
            refrescar();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;

            if (fila != -1)
            {
                int id = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                EmpleadoMensajePersonalizado mensaje = new EmpleadoMensajePersonalizado(id);
                this.Hide();
               mensaje.ShowDialog();
            }
        }

        //El método gunaButton1_MouseUp realiza una busqueda de empleados por nombre
        private void gunaButton1_MouseUp(object sender, MouseEventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre de algún empleado!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (biblioteca1Entities biblioteca = new biblioteca1Entities())
                {
                    var oempleados = from d in biblioteca.vistaEmpleados
                                     where d.Apellido_y_nombre.Contains(gunaTextBox1.Text) | gunaTextBox1.Text.Contains(d.Apellido_y_nombre)
                                     select new
                                     {
                                         d.ID_del_Empleado,
                                         d.Tipo_de_Empleado,
                                         d.DNI,
                                         d.Apellido_y_nombre,
                                         d.Usuario,
                                         d.Fecha_de_nacimiento,
                                         d.Dirección,
                                         d.Telefono
                                     };
                    dataGridView1.DataSource = oempleados.ToList();
                    dataGridView1.Columns[0].HeaderText = "ID del Empleado";
                    dataGridView1.Columns[1].HeaderText = "Tipo Empleado";
                    dataGridView1.Columns[3].HeaderText = "Apellido y Nombre";
                    dataGridView1.Columns[5].HeaderText = "Fecha de nacimiento";
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Datos incorrectos o empleado sin registrar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //El método gunaButton2_MouseUp realiza una busqueda de empleados por DNI
        private void gunaButton2_MouseUp(object sender, MouseEventArgs e)
        {
            if (gunaTextBox2.Text == "")
            {
                MessageBox.Show("Debe ingresar el DNI de algún empleado!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (biblioteca1Entities biblioteca = new biblioteca1Entities())
                {
                    var oempleados = from d in biblioteca.vistaEmpleados
                                  where d.DNI.ToString().Contains(gunaTextBox2.Text)
                                     select new
                                     {
                                         d.ID_del_Empleado,
                                         d.Tipo_de_Empleado,
                                         d.DNI,
                                         d.Apellido_y_nombre,
                                         d.Usuario,
                                         d.Fecha_de_nacimiento,
                                         d.Dirección,
                                         d.Telefono
                                     };
                    dataGridView1.DataSource = oempleados.ToList();
                    dataGridView1.Columns[0].HeaderText = "ID del Empleado";
                    dataGridView1.Columns[1].HeaderText = "Tipo Empleado";
                    dataGridView1.Columns[3].HeaderText = "Apellido y Nombre";
                    dataGridView1.Columns[5].HeaderText = "Fecha de nacimiento";
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Datos incorrectos o empleado sin registrar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void gunaCircleButton1_MouseUp(object sender, MouseEventArgs e)
        {
            refrescar();
        }

        private void gunaTextBox1_MouseUp(object sender, MouseEventArgs e) { }
    }
}
