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
    public partial class Ajustes : UserControl
    {
        public Ajustes()
        {
            InitializeComponent();
        }

        //El método BotonActualizar_MouseUp cambia la clave de acceso para registrar empleados 
        private void BotonActualizar_MouseUp(object sender, MouseEventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                configuracion oconfiguracion = new configuracion();
                if(biblioteca.configuracion.Count() == 0)
                {
                    oconfiguracion.claveRigistroEmpleado = gunaTextBox1.Text;
                    oconfiguracion.diasProxVencimiento = 30;
                    biblioteca.configuracion.Add(oconfiguracion);
                    biblioteca.SaveChanges();
                    MessageBox.Show("Clave cambiada con exito", "Clave actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gunaTextBox1.Text = "";
                }
                else
                {
                    oconfiguracion = biblioteca.configuracion.First();
                    oconfiguracion.claveRigistroEmpleado = gunaTextBox1.Text;
                    biblioteca.Entry(oconfiguracion).State = System.Data.Entity.EntityState.Modified;
                    biblioteca.SaveChanges();
                    MessageBox.Show("Clave cambiada con exito", "Clave actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gunaTextBox1.Text = "";
                }
            }
        }

        private void gunaTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solamente se permite el ingreso de números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        // El método gunaButton1_MouseUp actualiza el lapso de vencimiento para todos los prestamos futuros
        private void gunaButton1_MouseUp(object sender, MouseEventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                configuracion oconfiguracion = new configuracion();
                if(gunaTextBox2.Text == "")
                {
                    MessageBox.Show("Debe ingresar algún valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (biblioteca.configuracion.Count() == 0)
                {
                    oconfiguracion.claveRigistroEmpleado = 1234.ToString();
                    oconfiguracion.diasProxVencimiento = int.Parse(gunaTextBox2.Text);
                    biblioteca.configuracion.Add(oconfiguracion);
                    biblioteca.SaveChanges();
                    MessageBox.Show("Lapso de vencimiento de prestamos actualizado en " + gunaTextBox2.Text + " días", "Lapso actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gunaTextBox1.Text = "";
                }
                else
                {
                    oconfiguracion = biblioteca.configuracion.First();
                    oconfiguracion.diasProxVencimiento = int.Parse(gunaTextBox2.Text);
                    biblioteca.Entry(oconfiguracion).State = System.Data.Entity.EntityState.Modified;
                    biblioteca.SaveChanges();
                    MessageBox.Show("Lapso de vencimiento de prestamos actualizado en " + gunaTextBox2.Text + " días", "Lapso actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gunaTextBox2.Text = "";
                }
            }
        }
    }
}
