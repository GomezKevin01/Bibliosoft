
/*namespace Bibliosoft
{
    partial class Configuracion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BotonCambiar = new Guna.UI.WinForms.GunaButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuración del sistema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(93, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cambiar clave de acesso para nuevo registro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Clave nueva:";
            // 
            // BotonCambiar
            // 
            this.BotonCambiar.Animated = true;
            this.BotonCambiar.AnimationHoverSpeed = 0.07F;
            this.BotonCambiar.AnimationSpeed = 0.03F;
            this.BotonCambiar.BackColor = System.Drawing.Color.Transparent;
            this.BotonCambiar.BaseColor = System.Drawing.Color.Firebrick;
            this.BotonCambiar.BorderColor = System.Drawing.Color.Black;
            this.BotonCambiar.BorderSize = 1;
            this.BotonCambiar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BotonCambiar.FocusedColor = System.Drawing.Color.Empty;
            this.BotonCambiar.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.BotonCambiar.ForeColor = System.Drawing.Color.White;
            this.BotonCambiar.Image = null;
            this.BotonCambiar.ImageSize = new System.Drawing.Size(20, 20);
            this.BotonCambiar.Location = new System.Drawing.Point(95, 160);
            this.BotonCambiar.Name = "BotonCambiar";
            this.BotonCambiar.OnHoverBaseColor = System.Drawing.Color.Red;
            this.BotonCambiar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BotonCambiar.OnHoverForeColor = System.Drawing.Color.White;
            this.BotonCambiar.OnHoverImage = null;
            this.BotonCambiar.OnPressedColor = System.Drawing.Color.Black;
            this.BotonCambiar.Radius = 8;
            this.BotonCambiar.Size = new System.Drawing.Size(96, 38);
            this.BotonCambiar.TabIndex = 68;
            this.BotonCambiar.Text = "Actualizar";
            this.BotonCambiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BotonCambiar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BotonCambiar_MouseUp);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.Firebrick;
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Arial", 11F);
            this.gunaTextBox1.Location = new System.Drawing.Point(199, 118);
            this.gunaTextBox1.MaxLength = 200;
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Size = new System.Drawing.Size(252, 30);
            this.gunaTextBox1.TabIndex = 69;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.BotonCambiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Configuracion";
            this.Size = new System.Drawing.Size(549, 488);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton BotonCambiar;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
    }
}
*/