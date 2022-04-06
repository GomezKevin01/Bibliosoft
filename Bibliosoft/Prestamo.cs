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
    public partial class Prestamo : UserControl
    {
        public Prestamo()
        {
            InitializeComponent();
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceTileButton1_MouseUp(object sender, MouseEventArgs e)
        {
            LibroPrestar libroPrestar = new LibroPrestar();
            libroPrestar.ShowDialog();
        }

        private void gunaAdvenceTileButton2_MouseUp(object sender, MouseEventArgs e)
        {
            LibroDevolver libroDevolver = new LibroDevolver();
            libroDevolver.ShowDialog();
        }
    }
}
