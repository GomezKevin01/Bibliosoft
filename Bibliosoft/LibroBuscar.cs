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
    public partial class LibroBuscar : Form
    {
        public LibroBuscar()
        {
            InitializeComponent();
        }

        //El método dataGridView1_CellMouseDoubleClick abre otro formulario donde se podra  
        //eliminar o modificar un libro
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = e.RowIndex;


            if (fila != -1)// determina si se selecciono un registro
            {
                int id = int.Parse(dataGridView1.Rows[fila].Cells[0].Value.ToString());
                LibroMensajePersonalizado mensaje = new LibroMensajePersonalizado(id);
                this.Hide();
                mensaje.ShowDialog();


            }
        }

        //El método refrescar actualiza el grid de libros, mostrando a todos los libros del sistema
        private void refrescar()
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                var libros = from d in biblioteca.vistaLibros
                             select d;

                dataGridView1.DataSource = libros.ToList();
                dataGridView1.Columns[0].HeaderText = "ID del Libro";
                dataGridView1.Columns[0].Width = 75;
                dataGridView1.Columns[1].Width = 185;
                dataGridView1.Columns[2].Width = 40;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 150;
                dataGridView1.Columns[5].Width = 90;
                dataGridView1.Columns[6].Width = 80;
                gunaTextBox1.Text = "";
                gunaTextBox2.Text = "";
            }
        }

        private void LibroBuscar_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        //El método gunaButton1_MouseUp busca libros por su título
        private void gunaButton1_MouseUp(object sender, MouseEventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                MessageBox.Show("Debe ingresar el título de algún libro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                using (biblioteca1Entities biblioteca = new biblioteca1Entities())
                {
                    var libros = from d in biblioteca.vistaLibros
                                 where d.Título.Contains(gunaTextBox1.Text)// & d.idLibro != 1
                                 select d;

                    dataGridView1.DataSource = libros.ToList();
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Datos incorrectos o libro inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        //El método gunaButton2_MouseUp busca libros por el nombre del autor
        private void gunaButton2_MouseUp(object sender, MouseEventArgs e)
        {
            if (gunaTextBox2.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre de algún autor!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (biblioteca1Entities biblioteca = new biblioteca1Entities())
                {
                    var libros = from d in biblioteca.vistaLibros
                                 where d.Autor.Contains(gunaTextBox2.Text)
                                 select d;

                    dataGridView1.DataSource = libros.ToList();
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Datos incorrectos o autor inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //El método gunaCircleButton1_MouseUp refresca el grid de libros
        private void gunaCircleButton1_MouseUp(object sender, MouseEventArgs e)
        {
            refrescar();
        }



        private void gunaButton1_Click(object sender, EventArgs e) { }
        private void gunaButton2_Click(object sender, EventArgs e) { }

    }
}
