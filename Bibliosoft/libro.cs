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
    public partial class libro : UserControl
    {

        public libro()
        {
            InitializeComponent();

        }

        private void gunaAdvenceTileButton1_MouseUp(object sender, MouseEventArgs e)
        {
            LibroAñadir libroAñadir = new LibroAñadir();
            libroAñadir.ShowDialog();
        }

        private void gunaAdvenceTileButton2_MouseUp(object sender, MouseEventArgs e)
        {
            LibroBuscar libroBuscar = new LibroBuscar();
            libroBuscar.ShowDialog();
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e) { }
        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e) { }
    }
}
