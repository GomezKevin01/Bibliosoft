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
    public partial class socio : UserControl
    {
        public socio()
        {
            InitializeComponent();
        }

        private void gunaAdvenceTileButton1_MouseUp(object sender, MouseEventArgs e)
        {
            SocioAñadir oAñadirSocio = new SocioAñadir();
            oAñadirSocio.ShowDialog();
        }

        private void gunaAdvenceTileButton2_MouseUp(object sender, MouseEventArgs e)
        {
            SocioBuscar buscarsocios = new SocioBuscar();
            buscarsocios.ShowDialog();
        }


        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e) { }
        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e) { }
        private void socio_Load(object sender, EventArgs e) { }
    }
}
