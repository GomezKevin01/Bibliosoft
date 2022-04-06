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
    public partial class SocioBuscar : Form
    {
        public SocioBuscar()
        {
            InitializeComponent();
        }
        
        //El método refrescar actualiza el grid de socios, mostrando a todos los socios del sistema
        private void refrescar()
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                var osocios = from d in biblioteca.vistaSocios
                              select new
                              {
                                  d.idSocio,
                                  d.tipoDeSocio,
                                  d.DNI,
                                  d.Apellido,
                                  d.Nombre,
                                  d.fechaNacimiento,
                                  d.Dirección,
                                  d.Telefono
                              };

                dataGridView1.DataSource = osocios.ToList();
                dataGridView1.Columns[0].HeaderText = "Id del socio";
                dataGridView1.Columns[1].HeaderText = "Tipo de socio";
                dataGridView1.Columns[5].HeaderText = "Fecha de nacimiento";
                dataGridView1.Columns[0].Width = 70;
                dataGridView1.Columns[1].Width = 70;
                dataGridView1.Columns[2].Width = 70;
                dataGridView1.Columns[3].Width = 115;
                dataGridView1.Columns[4].Width = 115;
                dataGridView1.Columns[5].Width = 90;
                dataGridView1.Columns[6].Width = 170;
                dataGridView1.Columns[7].Width = 90;
                gunaTextBox1.Text = "";
                gunaTextBox2.Text = "";
            }
        }
        private void BuscarSocio_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        //El método dataGridView1_CellDoubleClick abre un formulario que permite modificar o eliminar a un socio
        //(tiene lugar cuando se presiona doble click sobre un socio en el grid)
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {         
            int fila = e.RowIndex;

            if (fila != -1)
            {
                int id = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                SocioMensajePersonalizado mensaje = new SocioMensajePersonalizado(id);
                this.Hide();
                mensaje.ShowDialog();                                           
            }
        }

        // El método gunaButton1_MouseUp busca socios por nombre
        private void gunaButton1_MouseUp(object sender, MouseEventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre de algún socio!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (biblioteca1Entities biblioteca = new biblioteca1Entities())
                {
                    var osocios = from d in biblioteca.vistaSocios
                                  where d.Nombre.Contains(gunaTextBox1.Text) | d.Apellido.Contains(gunaTextBox1.Text)
                                        | gunaTextBox1.Text.Contains(d.Nombre) | gunaTextBox1.Text.Contains(d.Apellido)
                                  select d;
                    dataGridView1.DataSource = osocios.ToList();
                    dataGridView1.Columns[0].HeaderText = "Id del socio";
                    dataGridView1.Columns[1].HeaderText = "Tipo de socio";
                    dataGridView1.Columns[5].HeaderText = "Fecha de nacimiento";
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Datos incorrectos o usuario sin registrar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //El método gunaButton2_MouseUp busca socios por DNI
        private void gunaButton2_MouseUp(object sender, MouseEventArgs e)
        {
            if (gunaTextBox2.Text == "")
            {
                MessageBox.Show("Debe ingresar el DNI de algún socio!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (biblioteca1Entities biblioteca = new biblioteca1Entities())
                {
                    var osocios = from d in biblioteca.vistaSocios
                                  where d.DNI.ToString().Contains(gunaTextBox2.Text)
                                  select d;
                    dataGridView1.DataSource = osocios.ToList();
                    dataGridView1.Columns[0].HeaderText = "Id del socio";
                    dataGridView1.Columns[1].HeaderText = "Tipo de socio";
                    dataGridView1.Columns[5].HeaderText = "Fecha de nacimiento";
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Datos incorrectos o usuario sin registrar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void gunaCircleButton1_MouseUp(object sender, MouseEventArgs e)
        {
            refrescar();
        }



        // METODOS SIN USO:
        private void gunaButton1_Click(object sender, EventArgs e) { }
        private void gunaButton2_Click(object sender, EventArgs e) { }
        private void gunaLabel1_Click(object sender, EventArgs e) { }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e) { } 
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) { }
        private void SocioBuscar_MouseUp(object sender, MouseEventArgs e) { }
    }
}
