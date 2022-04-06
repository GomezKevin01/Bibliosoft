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
    public partial class BuscarSocio : Form
    {
        public BuscarSocio()
        {
            InitializeComponent();
        }

         
        private void BuscarSocio_Load(object sender, EventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                var osocios = from d in biblioteca.socioss
                              select new { d.idSocio, d.tipoSocio, d.apellido, d.nombre, d.fechaNacimiento, d.direccion, d.telefono };
                dataGridView1.DataSource = osocios.ToList();
            }
        }

      

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int fila = e.RowIndex;


            if (fila != -1)
            {
                int id = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                mensajePersonalizado mensaje = new mensajePersonalizado(id);
                this.Hide();
                mensaje.ShowDialog();                             

                
            }
        }
       
    }
}
