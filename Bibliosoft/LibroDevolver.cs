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
    public partial class LibroDevolver : Form
    {
        public LibroDevolver()
        {
            InitializeComponent();
        }

        private void LibroDevolver_Load(object sender, EventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                var socios = from d in biblioteca.socioss
                             select d.dni;


                comboBox1.DataSource = socios.ToList();
                comboBox1.Text = "";
                dataGridView0.DataSource = "";
            }
        }

        //El método comboBox1_SelectedIndexChanged muestra en el grid de prestamos, los prestamos correspondientes al socio seleccionado
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                int dni = int.Parse(comboBox1.SelectedItem.ToString());
                
                var prestados = from d in biblioteca.prestamosPorSocio
                             where d.dni == dni
                             select d;


                //int n = dataGridView1.Rows.Add();//se guarda el indice de la nueva fila
                dataGridView0.DataSource = prestados.ToList();
                dataGridView0.Columns[0].HeaderText = "ID del prestamo";
                dataGridView0.Columns[2].HeaderText = "DNI";
                dataGridView1.DataSource = "";
               
            }
        }

        //El método dataGridView0_CellDoubleClick muestra el detalle del prestamo seleccionado en el grid de detalles
        private void dataGridView0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;//guarda el número de la fila seleccionada
            if (fila != -1)
            {
                int idPres = int.Parse(dataGridView0.Rows[fila].Cells[0].Value.ToString());//guarda el contenido de la 
                                                                                           //celda 0 de la fila seleccionada.   
                using (biblioteca1Entities biblioteca = new biblioteca1Entities())
                {
                    var prestamos = from d in biblioteca.verPrestamos
                                    where d.ID_del_prestamo == idPres 
                                    select d;
                    dataGridView1.DataSource = prestamos.ToList();
                    dataGridView1.Columns[0].HeaderText = "ID del prestamo";
                    dataGridView1.Columns[1].HeaderText = "ID del Libro";
                }
            }
        }

        // El método gunaButton2_MouseUp realiza la operación de devolución de libros
        private void gunaButton2_MouseUp(object sender, MouseEventArgs e) 
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Debe seleccionar algún socio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un prestamo para poder realizar la devolución!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            else 
            {
                using (biblioteca1Entities biblioteca = new biblioteca1Entities())
                {
                    DialogResult ask;
                    ask = MessageBox.Show("Seguro que desea realizar una devolución?", "Confirmar Devolución", MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
                    if (ask == DialogResult.Yes)
                    {
                        int idPres = int.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());
                        prestamos oprestamos = new prestamos();
                        detallePrestamo detalle = new detallePrestamo();
                        libross libros = new libross();
                        oprestamos = biblioteca.prestamos.Find(idPres);

                        var detalle2 = from d in biblioteca.detallePrestamo
                                       where d.idPrestamo == idPres
                                       select d;//se seleccionan los registros que cumplan con la condición 
                        using (var transaccion = biblioteca.Database.BeginTransaction())//Se encapsula la operación de 
                        {                                                               //prestamo en una transacción
                            try
                            {
                                foreach (DataGridViewRow grid in dataGridView1.Rows)//recorre fila por fila para guardar los datos
                                {
                                    int idLibro = int.Parse(grid.Cells[1].Value.ToString());
                                    libros = biblioteca.libross.Find(idLibro);
                                    libros.estado = 0;
                                    biblioteca.Entry(libros).State = System.Data.Entity.EntityState.Modified;
                                    detalle = detalle2.First();
                                    biblioteca.detallePrestamo.Remove(detalle);
                                    biblioteca.SaveChanges();
                                }
                                biblioteca.prestamos.Remove(oprestamos);
                                biblioteca.SaveChanges();
                                transaccion.Commit();//confirma la transacción
                                MessageBox.Show("Devolución realizada correctamente", "Mensaje", MessageBoxButtons.OK,
                                                MessageBoxIcon.Exclamation);

                                dataGridView0.DataSource = "";//Se limpia el grid de prestamos
                                dataGridView1.DataSource = "";//Se limpia el grid de detalle
                                comboBox1.Text = "";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No se logro realizar la devolución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                transaccion.Rollback();// en caso de un error vuelve a un estado anterior consistente de la base de datos

                            }
                        }

                    }
                }
            }
        }
    }
}
