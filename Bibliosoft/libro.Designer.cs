
namespace Bibliosoft
{
    partial class libro
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaAdvenceTileButton1 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.gunaAdvenceTileButton2 = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una opción:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 49);
            this.panel1.TabIndex = 5;
            // 
            // gunaAdvenceTileButton1
            // 
            this.gunaAdvenceTileButton1.Animated = true;
            this.gunaAdvenceTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.BorderSize = 1;
            this.gunaAdvenceTileButton1.CheckedBaseColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.CheckedImage = null;
            this.gunaAdvenceTileButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.gunaAdvenceTileButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.Image = global::Bibliosoft.Properties.Resources.icons8_añadir_libro_50;
            this.gunaAdvenceTileButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaAdvenceTileButton1.LineColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.Location = new System.Drawing.Point(133, 204);
            this.gunaAdvenceTileButton1.Name = "gunaAdvenceTileButton1";
            this.gunaAdvenceTileButton1.OnHoverBaseColor = System.Drawing.Color.Firebrick;
            this.gunaAdvenceTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton1.OnHoverImage = global::Bibliosoft.Properties.Resources.añadir_libro_blanco;
            this.gunaAdvenceTileButton1.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton1.Radius = 15;
            this.gunaAdvenceTileButton1.Size = new System.Drawing.Size(108, 80);
            this.gunaAdvenceTileButton1.TabIndex = 11;
            this.gunaAdvenceTileButton1.Text = "Añadir Libro";
            this.gunaAdvenceTileButton1.UseTransfarantBackground = true;
            this.gunaAdvenceTileButton1.Click += new System.EventHandler(this.gunaAdvenceTileButton1_Click);
            this.gunaAdvenceTileButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gunaAdvenceTileButton1_MouseUp);
            // 
            // gunaAdvenceTileButton2
            // 
            this.gunaAdvenceTileButton2.Animated = true;
            this.gunaAdvenceTileButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceTileButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceTileButton2.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.BorderSize = 1;
            this.gunaAdvenceTileButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceTileButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.CheckedImage = null;
            this.gunaAdvenceTileButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceTileButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceTileButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceTileButton2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.gunaAdvenceTileButton2.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.Image = global::Bibliosoft.Properties.Resources.icons8_busca_mas_50;
            this.gunaAdvenceTileButton2.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaAdvenceTileButton2.LineColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.Location = new System.Drawing.Point(307, 204);
            this.gunaAdvenceTileButton2.Name = "gunaAdvenceTileButton2";
            this.gunaAdvenceTileButton2.OnHoverBaseColor = System.Drawing.Color.Firebrick;
            this.gunaAdvenceTileButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceTileButton2.OnHoverImage = global::Bibliosoft.Properties.Resources.buscar_blanco;
            this.gunaAdvenceTileButton2.OnHoverLineColor = System.Drawing.Color.Firebrick;
            this.gunaAdvenceTileButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceTileButton2.Radius = 15;
            this.gunaAdvenceTileButton2.Size = new System.Drawing.Size(108, 80);
            this.gunaAdvenceTileButton2.TabIndex = 12;
            this.gunaAdvenceTileButton2.Text = "Buscar Libro";
            this.gunaAdvenceTileButton2.Click += new System.EventHandler(this.gunaAdvenceTileButton2_Click);
            this.gunaAdvenceTileButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gunaAdvenceTileButton2_MouseUp);
            // 
            // libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaAdvenceTileButton2);
            this.Controls.Add(this.gunaAdvenceTileButton1);
            this.Controls.Add(this.panel1);
            this.Name = "libro";
            this.Size = new System.Drawing.Size(549, 488);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton1;
        private Guna.UI.WinForms.GunaAdvenceTileButton gunaAdvenceTileButton2;
    }
}
