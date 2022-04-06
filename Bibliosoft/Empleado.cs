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
    public partial class Empleado : UserControl
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void gunaAdvenceTileButton1_MouseUp(object sender, MouseEventArgs e)
        {
            EmpleadoRegistrar empleadoRegistrar = new EmpleadoRegistrar();
            empleadoRegistrar.ShowDialog();
        }

        private void gunaAdvenceTileButton2_MouseUp(object sender, MouseEventArgs e)
        {
            EmpleadoBuscar empleadoBuscar = new EmpleadoBuscar();
            empleadoBuscar.ShowDialog();
        }
    }
}
