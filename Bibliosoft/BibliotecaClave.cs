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
    public partial class BibliotecaClave : Form
    {
        public BibliotecaClave()
        {
            InitializeComponent();
        }

        //El método button1_Click determina si la cable de acceso para registrar un nuevo empleado es correcta
        private void button1_Click(object sender, EventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                var accesoNuevoEmpleado = from d in biblioteca.configuracion
                                          select d;
                if (accesoNuevoEmpleado.Count() == 0)
                {
                    if (textBox1.Text == "1234")
                    {
                        this.Hide();
                        EmpleadoRegistrar empleadoRegistrar = new EmpleadoRegistrar();
                        empleadoRegistrar.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Clave de acceso incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                    }
                }
                else
                {
                    if(textBox1.Text == accesoNuevoEmpleado.First().claveRigistroEmpleado)
                    {
                        this.Hide();
                        EmpleadoRegistrar empleadoRegistrar = new EmpleadoRegistrar();
                        empleadoRegistrar.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Clave de acceso incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                    }
                }
            }
        }
    }
}
