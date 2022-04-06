
namespace Bibliosoft
{
    partial class LibroPrestar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelApeYnombre = new System.Windows.Forms.Label();
            this.labelTipoSocio = new System.Windows.Forms.Label();
            this.labelSuscripcion = new System.Windows.Forms.Label();
            this.labelCantLibros = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BotonAñadir = new Guna.UI.WinForms.GunaButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI socio:";
            // 
            // gunaButton2
            // 
            this.gunaButton2.Animated = true;
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.Firebrick;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.BorderSize = 1;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(257, 177);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 8;
            this.gunaButton2.Size = new System.Drawing.Size(108, 38);
            this.gunaButton2.TabIndex = 23;
            this.gunaButton2.Text = "Prestar";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gunaButton2_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Titulo libro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(394, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(394, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 36);
            this.label4.TabIndex = 35;
            this.label4.Text = "Apellido \r\ny nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(394, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "Tipo de socio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(394, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "Suscripción:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(394, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Libros añadidos:";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.labelDni.ForeColor = System.Drawing.Color.Firebrick;
            this.labelDni.Location = new System.Drawing.Point(438, 57);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(34, 18);
            this.labelDni.TabIndex = 44;
            this.labelDni.Text = "DNI";
            // 
            // labelApeYnombre
            // 
            this.labelApeYnombre.AutoSize = true;
            this.labelApeYnombre.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.labelApeYnombre.ForeColor = System.Drawing.Color.Firebrick;
            this.labelApeYnombre.Location = new System.Drawing.Point(477, 108);
            this.labelApeYnombre.Name = "labelApeYnombre";
            this.labelApeYnombre.Size = new System.Drawing.Size(46, 18);
            this.labelApeYnombre.TabIndex = 45;
            this.labelApeYnombre.Text = "socio";
            // 
            // labelTipoSocio
            // 
            this.labelTipoSocio.AutoSize = true;
            this.labelTipoSocio.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.labelTipoSocio.ForeColor = System.Drawing.Color.Firebrick;
            this.labelTipoSocio.Location = new System.Drawing.Point(508, 138);
            this.labelTipoSocio.Name = "labelTipoSocio";
            this.labelTipoSocio.Size = new System.Drawing.Size(35, 18);
            this.labelTipoSocio.TabIndex = 46;
            this.labelTipoSocio.Text = "tipo";
            // 
            // labelSuscripcion
            // 
            this.labelSuscripcion.AutoSize = true;
            this.labelSuscripcion.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.labelSuscripcion.ForeColor = System.Drawing.Color.Firebrick;
            this.labelSuscripcion.Location = new System.Drawing.Point(496, 168);
            this.labelSuscripcion.Name = "labelSuscripcion";
            this.labelSuscripcion.Size = new System.Drawing.Size(90, 18);
            this.labelSuscripcion.TabIndex = 47;
            this.labelSuscripcion.Text = "suscripción";
            // 
            // labelCantLibros
            // 
            this.labelCantLibros.AutoSize = true;
            this.labelCantLibros.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.labelCantLibros.ForeColor = System.Drawing.Color.Firebrick;
            this.labelCantLibros.Location = new System.Drawing.Point(525, 197);
            this.labelCantLibros.Name = "labelCantLibros";
            this.labelCantLibros.Size = new System.Drawing.Size(16, 18);
            this.labelCantLibros.TabIndex = 48;
            this.labelCantLibros.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLibro,
            this.titulo,
            this.fecha,
            this.fechaVencimiento,
            this.eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(29, 237);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(696, 404);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IdLibro
            // 
            this.IdLibro.HeaderText = "ID del Libro";
            this.IdLibro.Name = "IdLibro";
            this.IdLibro.ReadOnly = true;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titúlo del libro";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha del Prestamo";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // fechaVencimiento
            // 
            this.fechaVencimiento.HeaderText = "Fecha del vencimiento";
            this.fechaVencimiento.Name = "fechaVencimiento";
            this.fechaVencimiento.ReadOnly = true;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Quitar Libro";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 25);
            this.comboBox1.TabIndex = 51;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(394, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 18);
            this.label9.TabIndex = 64;
            this.label9.Text = "Id:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.labelId.ForeColor = System.Drawing.Color.Firebrick;
            this.labelId.Location = new System.Drawing.Point(425, 25);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 18);
            this.labelId.TabIndex = 65;
            this.labelId.Text = "id";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(121, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(245, 25);
            this.comboBox2.TabIndex = 66;
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
            this.BotonAñadir.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold);
            this.BotonAñadir.ForeColor = System.Drawing.Color.White;
            this.BotonAñadir.Image = null;
            this.BotonAñadir.ImageSize = new System.Drawing.Size(20, 20);
            this.BotonAñadir.Location = new System.Drawing.Point(120, 177);
            this.BotonAñadir.Name = "BotonAñadir";
            this.BotonAñadir.OnHoverBaseColor = System.Drawing.Color.Red;
            this.BotonAñadir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BotonAñadir.OnHoverForeColor = System.Drawing.Color.White;
            this.BotonAñadir.OnHoverImage = null;
            this.BotonAñadir.OnPressedColor = System.Drawing.Color.Black;
            this.BotonAñadir.Radius = 8;
            this.BotonAñadir.Size = new System.Drawing.Size(108, 38);
            this.BotonAñadir.TabIndex = 67;
            this.BotonAñadir.Text = "Añadir";
            this.BotonAñadir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BotonAñadir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BotonAñadir_MouseUp);
            // 
            // LibroPrestar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 653);
            this.Controls.Add(this.BotonAñadir);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelCantLibros);
            this.Controls.Add(this.labelSuscripcion);
            this.Controls.Add(this.labelTipoSocio);
            this.Controls.Add(this.labelApeYnombre);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LibroPrestar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibroPrestar";
            this.Load += new System.EventHandler(this.LibroPrestar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelApeYnombre;
        private System.Windows.Forms.Label labelTipoSocio;
        private System.Windows.Forms.Label labelSuscripcion;
        private System.Windows.Forms.Label labelCantLibros;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.ComboBox comboBox2;
        private Guna.UI.WinForms.GunaButton BotonAñadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimiento;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}