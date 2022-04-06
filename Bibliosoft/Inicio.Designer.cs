
namespace Bibliosoft
{
    partial class Inicio
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.cantVencidos = new Guna.UI.WinForms.GunaLabel();
            this.cantPrestados = new Guna.UI.WinForms.GunaLabel();
            this.cantAlumnos = new Guna.UI.WinForms.GunaLabel();
            this.cantProfesores = new Guna.UI.WinForms.GunaLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.BotonAñadir = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 49);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel de información general:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(56, 62);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(194, 19);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Cantidad de profesores:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(56, 107);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(177, 19);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Cantidad de alumnos:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.Location = new System.Drawing.Point(56, 155);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(206, 19);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Cant. de libros prestados:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.Location = new System.Drawing.Point(56, 204);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(199, 19);
            this.gunaLabel4.TabIndex = 8;
            this.gunaLabel4.Text = "Cant. de prest. vencidos:";
            // 
            // cantVencidos
            // 
            this.cantVencidos.AutoSize = true;
            this.cantVencidos.BackColor = System.Drawing.Color.Firebrick;
            this.cantVencidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cantVencidos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cantVencidos.ForeColor = System.Drawing.Color.White;
            this.cantVencidos.Location = new System.Drawing.Point(268, 202);
            this.cantVencidos.Name = "cantVencidos";
            this.cantVencidos.Size = new System.Drawing.Size(16, 21);
            this.cantVencidos.TabIndex = 9;
            this.cantVencidos.Text = "-";
            // 
            // cantPrestados
            // 
            this.cantPrestados.AutoSize = true;
            this.cantPrestados.BackColor = System.Drawing.Color.Firebrick;
            this.cantPrestados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cantPrestados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cantPrestados.ForeColor = System.Drawing.Color.White;
            this.cantPrestados.Location = new System.Drawing.Point(268, 153);
            this.cantPrestados.Name = "cantPrestados";
            this.cantPrestados.Size = new System.Drawing.Size(16, 21);
            this.cantPrestados.TabIndex = 10;
            this.cantPrestados.Text = "-";
            // 
            // cantAlumnos
            // 
            this.cantAlumnos.AutoSize = true;
            this.cantAlumnos.BackColor = System.Drawing.Color.Firebrick;
            this.cantAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cantAlumnos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cantAlumnos.ForeColor = System.Drawing.Color.White;
            this.cantAlumnos.Location = new System.Drawing.Point(268, 105);
            this.cantAlumnos.Name = "cantAlumnos";
            this.cantAlumnos.Size = new System.Drawing.Size(16, 21);
            this.cantAlumnos.TabIndex = 11;
            this.cantAlumnos.Text = "-";
            // 
            // cantProfesores
            // 
            this.cantProfesores.AutoSize = true;
            this.cantProfesores.BackColor = System.Drawing.Color.Firebrick;
            this.cantProfesores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cantProfesores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cantProfesores.ForeColor = System.Drawing.Color.White;
            this.cantProfesores.Location = new System.Drawing.Point(268, 60);
            this.cantProfesores.Name = "cantProfesores";
            this.cantProfesores.Size = new System.Drawing.Size(16, 21);
            this.cantProfesores.TabIndex = 12;
            this.cantProfesores.Text = "-";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.AutoFitMinFontSize = 9;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            legend3.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 226);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.Size = new System.Drawing.Size(549, 272);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.White;
            this.gunaLabel5.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gunaLabel5.Location = new System.Drawing.Point(-39, 239);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(459, 16);
            this.gunaLabel5.TabIndex = 15;
            this.gunaLabel5.Text = "                                   Cantidad de prestamos por mes:                " +
    "        ";
            // 
            // BotonAñadir
            // 
            this.BotonAñadir.Animated = true;
            this.BotonAñadir.AnimationHoverSpeed = 0.07F;
            this.BotonAñadir.AnimationSpeed = 0.03F;
            this.BotonAñadir.BackColor = System.Drawing.Color.Transparent;
            this.BotonAñadir.BaseColor = System.Drawing.Color.Firebrick;
            this.BotonAñadir.BorderColor = System.Drawing.Color.Black;
            this.BotonAñadir.BorderSize = 1;
            this.BotonAñadir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BotonAñadir.FocusedColor = System.Drawing.Color.Empty;
            this.BotonAñadir.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.BotonAñadir.ForeColor = System.Drawing.Color.White;
            this.BotonAñadir.Image = null;
            this.BotonAñadir.ImageSize = new System.Drawing.Size(20, 20);
            this.BotonAñadir.Location = new System.Drawing.Point(422, 436);
            this.BotonAñadir.Name = "BotonAñadir";
            this.BotonAñadir.OnHoverBaseColor = System.Drawing.Color.Red;
            this.BotonAñadir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BotonAñadir.OnHoverForeColor = System.Drawing.Color.White;
            this.BotonAñadir.OnHoverImage = null;
            this.BotonAñadir.OnPressedColor = System.Drawing.Color.Black;
            this.BotonAñadir.Radius = 8;
            this.BotonAñadir.Size = new System.Drawing.Size(95, 38);
            this.BotonAñadir.TabIndex = 68;
            this.BotonAñadir.Text = "Refrescar ";
            this.BotonAñadir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BotonAñadir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BotonAñadir_MouseUp);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BotonAñadir);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.cantProfesores);
            this.Controls.Add(this.cantAlumnos);
            this.Controls.Add(this.cantPrestados);
            this.Controls.Add(this.cantVencidos);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Inicio";
            this.Size = new System.Drawing.Size(549, 488);
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel cantVencidos;
        private Guna.UI.WinForms.GunaLabel cantPrestados;
        private Guna.UI.WinForms.GunaLabel cantAlumnos;
        private Guna.UI.WinForms.GunaLabel cantProfesores;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaButton BotonAñadir;
    }
}
