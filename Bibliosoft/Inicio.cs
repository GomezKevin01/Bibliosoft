using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bibliosoft
{
    public partial class Inicio : UserControl
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            using(biblioteca1Entities biblioteca = new biblioteca1Entities())
            {
                var profesores = from d in biblioteca.socioss
                                 where d.tipoSocio == 1
                                 select d.idSocio;
                var alumnos = from d in biblioteca.socioss
                              where d.tipoSocio == 2
                              select d.idSocio;

                var prestamosVencidos = from d in biblioteca.prestamos
                                where d.fechaVencimiento < DateTime.Today
                                select d.idPrestamo;
                var prestamos = from d in biblioteca.prestamos
                                select d.idPrestamo;

                cantAlumnos.Text = alumnos.Count().ToString();
                cantProfesores.Text = profesores.Count().ToString();
                cantPrestados.Text = prestamos.Count().ToString();
                cantVencidos.Text = prestamosVencidos.Count().ToString();

                //En la region estan las operaciones necesarias para obtener los prestamos de un mes especifico
                #region 
                var prestamoEnero = from d in biblioteca.prestamosPersistente
                                    where d.fechaPrestamo.Value.ToString().Substring(0,7) == DateTime.Today.Year +  "-01"  
                                    select d.idPrestamo;

                var prestamoFebrero = from d in biblioteca.prestamosPersistente
                                      where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-02"
                                      select d.idPrestamo;

                var prestamoMarzo = from d in biblioteca.prestamosPersistente
                                    where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-03"
                                    select d.idPrestamo;

                var prestamoAbril= from d in biblioteca.prestamosPersistente
                                   where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-04"
                                   select d.idPrestamo;

                var prestamoMayo = from d in biblioteca.prestamosPersistente
                                   where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-05"
                                   select d.idPrestamo;

                var prestamoJunio= from d in biblioteca.prestamosPersistente
                                   where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-06"
                                   select d.idPrestamo;

                var prestamoJulio= from d in biblioteca.prestamosPersistente
                                   where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-07"
                                   select d.idPrestamo;

                var prestamoAgosto= from d in biblioteca.prestamosPersistente
                                    where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-08"
                                    select d.idPrestamo;

                var prestamoSeptiembre= from d in biblioteca.prestamosPersistente
                                        where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-09"
                                        select d.idPrestamo;

                var prestamoOctubre = from d in biblioteca.prestamosPersistente
                                      where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-10"
                                      select d.idPrestamo;

                var prestamoNoviembre = from d in biblioteca.prestamosPersistente
                                        where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-11"
                                        select d.idPrestamo;

                var prestamoDiciembre= from d in biblioteca.prestamosPersistente
                                       where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-12"
                                       select d.idPrestamo;
                #endregion
                chart1.Palette = ChartColorPalette.BrightPastel;
                string[] meses = {"Enero","Febrero","Marzo","Abril","Mayo","Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
                int[] cantidad = { prestamoEnero.Count(),prestamoFebrero.Count(),prestamoMarzo.Count(),prestamoAbril.Count(),prestamoMayo.Count(),prestamoJunio.Count(),
                prestamoJulio.Count(),prestamoAgosto.Count(),prestamoSeptiembre.Count(),prestamoOctubre.Count(),prestamoNoviembre.Count(),prestamoDiciembre.Count()};           
                for(int i = 0; i < meses.Length; i++)
                {
                    Series series = chart1.Series.Add(meses[i]);// Se agregan los meses como series                   
                    series.XAxisType = AxisType.Secondary;//Eje X en la parte de arriba
                    series.YValueType = ChartValueType.Int32;//Eje Y de tipo entero
                    series.IsValueShownAsLabel = true;//Muestra la cantidad de prestamos del mes
                    //series.Label = cantidad[i].ToString();//Muestra la cantidad de prestamos del mes                   
                    series.ChartType = SeriesChartType.Column;//Determina el tipo de grafico
                    series.LabelForeColor = Color.Red;//Determina el color de la cantidad de prestamos
                    series.LabelBackColor = Color.White;//Determina el color de fondo de la cant. de prest.                  
                    series.Font = new Font("Fuente Negrita", 12, FontStyle.Bold);//Determina la fuente de la cant. de prestamos
                    series.IsXValueIndexed = true;
                    if (cantidad[i] != 0)
                    {
                        series.Points.Add(cantidad[i]);//Agrega los prestamos por mes
                    }
                }
            }
        }

        //Actualiza los datos y el grafico de la pantalla de inicio
        private void BotonAñadir_MouseUp(object sender, MouseEventArgs e)
        {
            using (biblioteca1Entities biblioteca = new biblioteca1Entities())
            {               
                Series series = chart1.Series.Add("");
                series.Points.Clear();//Vacia los puntos (cantidad de prestamos por mes)
                chart1.Series.Clear();//vacia las series (meses)

                var profesores = from d in biblioteca.socioss
                                 where d.tipoSocio == 1
                                 select d.idSocio;
                var alumnos = from d in biblioteca.socioss
                              where d.tipoSocio == 2
                              select d.idSocio;

                var prestamosVencidos = from d in biblioteca.prestamos
                                        where d.fechaVencimiento < DateTime.Today
                                        select d.idPrestamo;
                var prestamos = from d in biblioteca.prestamos
                                select d.idPrestamo;

                cantAlumnos.Text = alumnos.Count().ToString();
                cantProfesores.Text = profesores.Count().ToString();
                cantPrestados.Text = prestamos.Count().ToString();
                cantVencidos.Text = prestamosVencidos.Count().ToString();

                //En la region estan las operaciones necesarias para obtener los prestamos de un mes especifico
                #region 
                var prestamoEnero = from d in biblioteca.prestamosPersistente
                                    where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-01"
                                    select d.idPrestamo;

                var prestamoFebrero = from d in biblioteca.prestamosPersistente
                                      where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-02"
                                      select d.idPrestamo;

                var prestamoMarzo = from d in biblioteca.prestamosPersistente
                                    where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-03"
                                    select d.idPrestamo;

                var prestamoAbril = from d in biblioteca.prestamosPersistente
                                    where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-04"
                                    select d.idPrestamo;

                var prestamoMayo = from d in biblioteca.prestamosPersistente
                                   where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-05"
                                   select d.idPrestamo;

                var prestamoJunio = from d in biblioteca.prestamosPersistente
                                    where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-06"
                                    select d.idPrestamo;

                var prestamoJulio = from d in biblioteca.prestamosPersistente
                                    where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-07"
                                    select d.idPrestamo;

                var prestamoAgosto = from d in biblioteca.prestamosPersistente
                                     where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-08"
                                     select d.idPrestamo;

                var prestamoSeptiembre = from d in biblioteca.prestamosPersistente
                                         where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-09"
                                         select d.idPrestamo;

                var prestamoOctubre = from d in biblioteca.prestamosPersistente
                                      where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-10"
                                      select d.idPrestamo;

                var prestamoNoviembre = from d in biblioteca.prestamosPersistente
                                        where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-11"
                                        select d.idPrestamo;

                var prestamoDiciembre = from d in biblioteca.prestamosPersistente
                                        where d.fechaPrestamo.Value.ToString().Substring(0, 7) == DateTime.Today.Year + "-12"
                                        select d.idPrestamo;
                #endregion

                string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };


                int[] cantidad = { prestamoEnero.Count(),prestamoFebrero.Count(),prestamoMarzo.Count(),prestamoAbril.Count(),prestamoMayo.Count(),prestamoJunio.Count(),
                prestamoJulio.Count(),prestamoAgosto.Count(),prestamoSeptiembre.Count(),prestamoOctubre.Count(),prestamoNoviembre.Count(),prestamoDiciembre.Count()};
                for (int i = 0; i < meses.Length; i++)
                {                   
                    series = chart1.Series.Add(meses[i]);// Se agregan los meses como series                   
                    series.XAxisType = AxisType.Secondary;//Eje X en la parte de arriba
                    series.YValueType = ChartValueType.Int32;//Eje Y de tipo entero
                    series.IsValueShownAsLabel = true;//Muestra la cantidad de prestamos del mes
                    //series.Label = cantidad[i].ToString();//Muestra la cantidad de prestamos del mes                   
                    series.ChartType = SeriesChartType.Column;//Determina el tipo de grafico
                    series.LabelForeColor = Color.Red;//Determina el color de la cantidad de prestamos
                    series.LabelBackColor = Color.White;//Determina el color de fondo de la cant. de prest.                  
                    series.Font = new Font("Fuente Negrita", 12, FontStyle.Bold);//Determina la fuente de la cant. de prestamos
                    series.IsXValueIndexed = true;
                    if (cantidad[i] != 0)
                    {
                        series.Points.Add(cantidad[i]);//Agrega los prestamos por mes
                    }
                }
            }
        }
    }
}
