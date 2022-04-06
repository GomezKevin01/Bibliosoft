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
    public partial class EmpleadoMensajePersonalizado : Form
    {
        public int id;
        public EmpleadoMensajePersonalizado(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        // El método button1_Click abre otro formulario donde se podra modificar un empleado (correspondiente al boton modificar)
        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadoModificar empleadoModificar= new EmpleadoModificar(id);
            this.Hide();
            empleadoModificar.ShowDialog();
        }

        // El método button2_Click permite elimar un empleado del sistema (correspondiente al boton eliminar)
        private void button2_Click(object sender, EventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                this.Hide();
                EmpleadoBuscar empleadoBuscar = new EmpleadoBuscar();
                DialogResult ask;
                ask = MessageBox.Show("Seguro que desea eliminar un Empleado?", "Confirmar Eliminaciónn", MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (ask == DialogResult.Yes)
                {
                    empleados oempleados = new empleados();
                    oempleados = biblioteca.empleados.Find(id);
                    biblioteca.empleados.Remove(oempleados);
                    biblioteca.SaveChanges();
                    MessageBox.Show("Empleado eliminado correctamente", "Eliminado!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    this.Close();
                    empleadoBuscar.ShowDialog();
                }
                else
                {
                    this.Close();
                    empleadoBuscar.ShowDialog();
                }
            }
        }

        //El método button3_Click cierra el formulario emergente (correspondiente al boton cancelar)       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            EmpleadoBuscar empleadoBuscar = new EmpleadoBuscar();
            empleadoBuscar.ShowDialog();
        }


        private void EmpleadoMensajePersonalizado_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void EmpleadoMensajePersonalizado_FormClosing(object sender, FormClosingEventArgs e) {}
    }
}
