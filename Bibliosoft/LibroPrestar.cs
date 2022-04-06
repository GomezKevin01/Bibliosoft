using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliosoft
{
    public partial class LibroPrestar : Form
    {
        public LibroPrestar()
        {
            InitializeComponent();
        }

        private void LibroPrestar_Load(object sender, EventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                var socios = from d in biblioteca.socioss
                    select d.dni;

                var libros = from d in biblioteca.libross
                             where d.estado != 1
                             orderby d.titulo ascending
                             select d.titulo + " - ID: " + d.idLibro;

                comboBox1.DataSource = socios.ToList();
                comboBox2.DataSource = libros.ToList();
                labelApeYnombre.Text = "-";
                labelDni.Text = "-";
                labelTipoSocio.Text = "-";
                labelSuscripcion.Text = "-";
                labelId.Text = "-";
                comboBox1.Text = "";
                comboBox2.Text = "";

            }
        }


        // El método comboBox1_SelectedIndexChanged cambia los valores de los labels si el contenido del combobox1 cambia
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                int dni = int.Parse(comboBox1.SelectedItem.ToString());
                socioss socios1 = new socioss();
                var socios = from d in biblioteca.socioss
                             where d.dni == dni
                             select d;

                socios1 = socios.First();
                labelId.Text = socios1.idSocio.ToString();
                labelDni.Text = socios1.dni.ToString();
                labelApeYnombre.Text = socios1.apellido + " " + socios1.nombre;
                if (socios1.tipoSocio == 2)
                {
                    labelTipoSocio.Text = "Estudiante";
                }
                else
                {
                    labelTipoSocio.Text = "Docente";
                }
            }
        }
   
        //El método dataGridView1_CellClick elimina una fila de los libros a prestar
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columna = e.ColumnIndex;
            int fila = e.RowIndex;


            if (columna == 4 && fila != -1)
            {              
                dataGridView1.Rows.RemoveAt(fila);
                labelCantLibros.Text = dataGridView1.Rows.Count.ToString();               
            }
        }

        //El método gunaButton2_MouseUp realiza la operación de prestamo
        private void gunaButton2_MouseUp(object sender, MouseEventArgs e)
        {
            if (labelId.Text == "-")
            {
                MessageBox.Show("Debe seleccionar un socio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (int.Parse(labelCantLibros.Text) == 0)
            {
                MessageBox.Show("Debe agregar al menos un libro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult ask;
                ask = MessageBox.Show("Seguro que desea realizar un prestamo?", "Confirmar insercion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    using (biblioteca1Entities biblioteca = new biblioteca1Entities())
                    {
                        int idSocio = int.Parse(labelId.Text);
                        var prestamosVencidos = from d in biblioteca.prestamos
                                                where d.fechaVencimiento < DateTime.Today & d.idSocio == idSocio
                                                select d;
                        if (prestamosVencidos.Count() > 0)//verifica si el socio tiene algún prestamo vencido
                        {
                            MessageBox.Show("El socio tiene un prestamo vencido", "Error al prestar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            //Se limpian los valores de los labels, textboxs y grids despues del error
                            labelApeYnombre.Text = "-";
                            labelDni.Text = "-";
                            labelTipoSocio.Text = "-";
                            labelSuscripcion.Text = "-";
                            labelId.Text = "-";
                            comboBox1.Text = "";
                            comboBox2.Text = "";
                            labelCantLibros.Text = "";
                            dataGridView1.DataSource = "";
                            dataGridView1.DataSource = null;//limpia completamente el grid
                        }
                        else {
                            using (var transaccion = biblioteca.Database.BeginTransaction())//Se encapsula la operación de 
                            {                                                               //prestamo en una transacción
                                try
                                {
                                    //configuracion oconfiguracion = new configuracion();
                                    //oconfiguracion = biblioteca.configuracion.First();
                                    var configuracion = from d in biblioteca.configuracion
                                                        select d;
                                    prestamos oprestamos = new prestamos();
                                    libross libros = new libross();                                   
                                    oprestamos.idSocio = int.Parse(labelId.Text);
                                    oprestamos.fechaPrestamo = DateTime.Today;
                                    if (biblioteca.configuracion.Count() == 0)
                                    {
                                        oprestamos.fechaVencimiento = DateTime.Today.AddMonths(1);
                                    }
                                    else
                                    {
                                        int diasParaProxVencimiento = configuracion.First().diasProxVencimiento;
                                        oprestamos.fechaVencimiento = DateTime.Today.AddDays(diasParaProxVencimiento);
                                    }
                                    biblioteca.prestamos.Add(oprestamos);

                                    //region realiza las operaciones necesarias para trazar el grafico de la pantalla de inicio.
                                    #region
                                    prestamosPersistente oprestamosPersistente = new prestamosPersistente();
                                    //oprestamosPersistente.idSocio = int.Parse(labelId.Text);
                                    oprestamosPersistente.fechaPrestamo = DateTime.Today;
                                    /*if (biblioteca.configuracion.Count() == 0)
                                    {
                                        oprestamosPersistente.fechaVencimiento = DateTime.Today.AddMonths(1);
                                    }
                                    else
                                    {
                                        int diasParaProxVencimiento = configuracion.First().diasProxVencimiento;
                                        oprestamosPersistente.fechaVencimiento = DateTime.Today.AddDays(diasParaProxVencimiento);
                                    }*/
                                    biblioteca.prestamosPersistente.Add(oprestamosPersistente);
                                    #endregion
                                    biblioteca.SaveChanges();
                                    foreach (DataGridViewRow grid in dataGridView1.Rows)//recorre fila por fila para guardar los datos
                                    {
                                        int idLibro = int.Parse(grid.Cells[0].Value.ToString());

                                        detallePrestamo detalle = new detallePrestamo();
                                        detalle.idPrestamo = oprestamos.idPrestamo;
                                        detalle.idLibro = idLibro;
                                        libros = biblioteca.libross.Find(idLibro);
                                        libros.estado = 1;
                                        biblioteca.Entry(libros).State = System.Data.Entity.EntityState.Modified;
                                        biblioteca.detallePrestamo.Add(detalle);
                                        biblioteca.SaveChanges();
                                    }
                                    transaccion.Commit();//confirma la transacción
                                    MessageBox.Show("Prestamo realizado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    var actualizarLibros = from d in biblioteca.libross
                                                           where d.estado != 1
                                                           orderby d.titulo ascending
                                                           select d.titulo + " - ID: " + d.idLibro;
                                    comboBox2.DataSource = actualizarLibros.ToList();//Actualiza el combobox de los libros

                                    //Pasos necesaio para imprimir el comprobante del prestamo 
                                    ask = MessageBox.Show("Desea imprimir el comprobante?", "Confirmar insercion",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (ask == DialogResult.Yes)
                                    {
                                        printDocument1 = new PrintDocument();
                                        PrinterSettings ps = new PrinterSettings();
                                        printDocument1.PrinterSettings = ps;
                                        printDocument1.PrintPage += imprimir;//Llama al método imprimir (agregando al documento los detalles del prestamo)
                                        printDocument1.DocumentName = "Prestamo N°: " + oprestamos.idPrestamo;
                                        printDocument1.Print();
                                    }
                                    //Se limpian los valores de los labels, textboxs y grids despues de cargar los datos
                                    labelApeYnombre.Text = "-";
                                    labelDni.Text = "-";
                                    labelTipoSocio.Text = "-";
                                    labelSuscripcion.Text = "-";
                                    labelId.Text = "-";
                                    comboBox1.Text = "";
                                    comboBox2.Text = "";
                                    labelCantLibros.Text = "";
                                    dataGridView1.DataSource = "";
                                    dataGridView1.DataSource = null;//limpia completamente el grid
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("No se logro realizar el prestamo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    transaccion.Rollback();// en caso de un error vuelve a un estado anterior consistente de la base de datos

                                }
                            }
                        }
                    }
                }
            }
        }

        //Obtiene todos los datos necesarios que iran al comprobante del prestamo
        private void imprimir (object sender, PrintPageEventArgs e)
        {
            using (biblioteca1Entities biblioteca1 = new biblioteca1Entities())
            {
                var idPrestamo = from d in biblioteca1.prestamos
                                 orderby  d.idPrestamo descending
                                 select d.idPrestamo;            
                int id = idPrestamo.First();//Obtiene el id del ultimo prestamo

                Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
                int y = 20;
                e.Graphics.DrawString("********************Bibliosoft********************", font, Brushes.Black, new RectangleF(0, 20, 500, 25));
                e.Graphics.DrawString("*********Comprobante del Prestamo**********", font, Brushes.Black, new RectangleF(0, y += 25, 500, 25));
                e.Graphics.DrawString("Id del Prestamo: " + id, font, Brushes.Black, new RectangleF(0, y += 25, 500, 25));
                e.Graphics.DrawString("Fecha: " + DateTime.Today.ToShortDateString() + "     Hora: " + DateTime.Now.ToString("HH:mm:ss"), font, Brushes.Black, new RectangleF(0, y += 25, 500, 25));
                e.Graphics.DrawString("Socio: " + labelApeYnombre.Text, font, Brushes.Black, new RectangleF(0, y += 25, 500, 25));
                e.Graphics.DrawString("DNI: " + labelDni.Text, font, Brushes.Black, new RectangleF(0, y += 25, 500, 25));
                e.Graphics.DrawString("Detalle del prestamo:", font, Brushes.Black, new RectangleF(0, y += 40, 500, 25));
                foreach (DataGridViewRow grid in dataGridView1.Rows)
                {
                    e.Graphics.DrawString("Título del libro: " + grid.Cells[1].Value, font, Brushes.Black, new RectangleF(0, y += 25, 500, 25));
                }
                e.Graphics.DrawString("Fecha de vencimiento del prestamo: " + dataGridView1.Rows[0].Cells[3].Value, font, Brushes.Black, new RectangleF(0, y += 25, 500, 25));
            }
        }

        // El método BotonAñadir_MouseUp añade libros al dataGridView1
        private void BotonAñadir_MouseUp(object sender, MouseEventArgs e)
        {           

            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {                
                if (comboBox2.Text == "")
                {
                    MessageBox.Show("Debe seleccionar algún libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool datoExistente = false;
                    string datosLibro = comboBox2.SelectedItem.ToString();

                    var libros = from d in biblioteca.vistaLibros
                                 where datosLibro.Equals(d.Título + " - ID: " + d.ID_del_libro)
                                 select d;

                    foreach (DataGridViewRow grid in dataGridView1.Rows)
                    {
                        if (datosLibro.Equals(grid.Cells[1].Value.ToString() + " - ID: " + grid.Cells[0].Value.ToString()))
                        {
                            MessageBox.Show("El libro ya se encuentra añadido a la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            datoExistente = true;
                            break;
                        }
                    }
                    if (datoExistente == false)
                    {
                        //configuracion oconfiguracion = new configuracion();
                        //oconfiguracion = biblioteca.configuracion.First();
                        var configuracion = from d in biblioteca.configuracion
                                            select d;

                        int n = dataGridView1.Rows.Add();//se guarda el indice de la nueva fila
                        dataGridView1.Rows[n].Cells[0].Value = libros.First().ID_del_libro;
                        dataGridView1.Rows[n].Cells[1].Value = libros.First().Título;
                        dataGridView1.Rows[n].Cells[2].Value = DateTime.Today.ToShortDateString();
                        if (configuracion.Count() == 0)
                        {
                            dataGridView1.Rows[n].Cells[3].Value = DateTime.Today.AddMonths(1).ToShortDateString(); ;
                        }
                        else
                        {
                            int diasParaProxVencimiento = configuracion.First().diasProxVencimiento;
                            dataGridView1.Rows[n].Cells[3].Value = DateTime.Today.AddDays(diasParaProxVencimiento).ToShortDateString(); ;
                        }                  
                        dataGridView1.Rows[n].Cells[4].Value = "Quitar";
                        labelCantLibros.Text = dataGridView1.Rows.Count.ToString();
                    }
                }
            }
        }
    }
}
