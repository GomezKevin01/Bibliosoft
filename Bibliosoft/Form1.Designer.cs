
namespace Bibliosoft
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton0 = new Guna.UI.WinForms.GunaButton();
            this.gunaAdvenceTileButton1 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.inicio1 = new Bibliosoft.Inicio();
            this.prestamo1 = new Bibliosoft.Prestamo();
            this.libro1 = new Bibliosoft.libro();
            this.socio1 = new Bibliosoft.socio();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Firebrick;
            this.gunaPanel1.Controls.Add(this.gunaButton0);
            this.gunaPanel1.Controls.Add(this.gunaAdvenceTileButton1);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.gunaSeparator1);
            this.gunaPanel1.Controls.Add(this.gunaButton3);
            this.gunaPanel1.Controls.Add(this.gunaButton2);
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaPanel1.ForeColor = System.Drawing.Color.White;
            this.gunaPanel1.Location = new System.Drawing.Point(-1, -1);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(204, 548);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaButton0
            // 
            this.gunaButton0.AnimationHoverSpeed = 0.07F;
            this.gunaButton0.AnimationSpeed = 0.03F;
            this.gunaButton0.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton0.BorderColor = System.Drawing.Color.White;
            this.gunaButton0.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton0.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton0.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton0.ForeColor = System.Drawing.Color.White;
            this.gunaButton0.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton0.Image")));
            this.gunaButton0.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton0.Location = new System.Drawing.Point(2, 101);
            this.gunaButton0.Name = "gunaButton0";
            this.gunaButton0.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.gunaButton0.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton0.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton0.OnHoverImage = null;
            this.gunaButton0.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton0.Size = new System.Drawing.Size(198, 55);
            this.gunaButton0.TabIndex = 7;
            this.gunaButton0.Text = "Inicio";
            this.gunaButton0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton0.Click += new System.EventHandler(this.gunaButton0_Click);
            // 
            // gunaAdvenceTileButton1
            // 
            this.gunaAdvenceTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.BorderSize = 2;
            this.gunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceTileButton1.CheckedImage")));
            this.gunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceTileButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.Image = global::Bibliosoft.Properties.Resources.icons8_cierre_de_sesión_redondeado_hacia_la_izquierda_50;
            this.gunaAdvenceTileButton1.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaAdvenceTileButton1.LineColor = System.Drawing.Color.Red;
            this.gunaAdvenceTileButton1.Location = new System.Drawing.Point(13, 467);
            this.gunaAdvenceTileButton1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaAdvenceTileButton1.Name = "gunaAdvenceTileButton1";
            this.gunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.OnHoverImage = global::Bibliosoft.Properties.Resources.icons8_salida_501;
            this.gunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.DarkRed;
            this.gunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.Radius = 15;
            this.gunaAdvenceTileButton1.Size = new System.Drawing.Size(96, 65);
            this.gunaAdvenceTileButton1.TabIndex = 6;
            this.gunaAdvenceTileButton1.Text = "Cerrar Sesión";
            this.gunaAdvenceTileButton1.Click += new System.EventHandler(this.gunaAdvenceTileButton1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(50, 19);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(103, 29);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Bibliosoft";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaSeparator1.LineColor = System.Drawing.Color.White;
            this.gunaSeparator1.Location = new System.Drawing.Point(13, 34);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(180, 38);
            this.gunaSeparator1.TabIndex = 4;
            this.gunaSeparator1.Thickness = 2;
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BorderColor = System.Drawing.Color.White;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(3, 284);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(198, 55);
            this.gunaButton3.TabIndex = 2;
            this.gunaButton3.Text = "Prestar/Devolver";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BorderColor = System.Drawing.Color.White;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(2, 223);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(198, 55);
            this.gunaButton2.TabIndex = 1;
            this.gunaButton2.Text = "Libros (ABM)";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.White;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(2, 162);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(198, 55);
            this.gunaButton1.TabIndex = 0;
            this.gunaButton1.Text = "Socios (ABM)";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.White;
            this.gunaPanel2.Controls.Add(this.inicio1);
            this.gunaPanel2.Controls.Add(this.prestamo1);
            this.gunaPanel2.Controls.Add(this.libro1);
            this.gunaPanel2.Controls.Add(this.socio1);
            this.gunaPanel2.Location = new System.Drawing.Point(205, 51);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(549, 488);
            this.gunaPanel2.TabIndex = 2;
            // 
            // inicio1
            // 
            this.inicio1.BackColor = System.Drawing.Color.White;
            this.inicio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inicio1.Location = new System.Drawing.Point(0, 0);
            this.inicio1.Name = "inicio1";
            this.inicio1.Size = new System.Drawing.Size(549, 488);
            this.inicio1.TabIndex = 3;
            // 
            // prestamo1
            // 
            this.prestamo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prestamo1.Location = new System.Drawing.Point(0, 0);
            this.prestamo1.Name = "prestamo1";
            this.prestamo1.Size = new System.Drawing.Size(549, 488);
            this.prestamo1.TabIndex = 2;
            // 
            // libro1
            // 
            this.libro1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libro1.Location = new System.Drawing.Point(0, 0);
            this.libro1.Name = "libro1";
            this.libro1.Size = new System.Drawing.Size(549, 488);
            this.libro1.TabIndex = 5;
            // 
            // socio1
            // 
            this.socio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.socio1.Location = new System.Drawing.Point(0, 0);
            this.socio1.Name = "socio1";
            this.socio1.Size = new System.Drawing.Size(549, 488);
            this.socio1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 540);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(769, 579);
            this.MinimumSize = new System.Drawing.Size(769, 579);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
       // private socio socios1;
       // private libro libros1;
        private Prestamo prestamo1;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton1;
        private Guna.UI.WinForms.GunaButton gunaButton0;
        private Inicio inicio1;
        private socio socio1;
        private libro libro1;
    }
}

