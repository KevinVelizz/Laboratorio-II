namespace Ejercicio03
{
    partial class FrmAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlta));
            lblUsuarios = new Label();
            lblPrecio = new Label();
            lblGenero = new Label();
            lblNombre = new Label();
            cmbUsuarios = new ComboBox();
            nupPrecio = new NumericUpDown();
            txtGenero = new TextBox();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)nupPrecio).BeginInit();
            SuspendLayout();
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.BackColor = Color.Transparent;
            lblUsuarios.Location = new Point(12, 203);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(52, 15);
            lblUsuarios.TabIndex = 17;
            lblUsuarios.Text = "Usuarios";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Location = new Point(12, 141);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 16;
            lblPrecio.Text = "Precio";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.BackColor = Color.Transparent;
            lblGenero.Location = new Point(12, 81);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(45, 15);
            lblGenero.TabIndex = 15;
            lblGenero.Text = "Genero";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Location = new Point(12, 18);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(38, 15);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "Juego";
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.BackColor = SystemColors.InactiveCaption;
            cmbUsuarios.FlatStyle = FlatStyle.Flat;
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(11, 221);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(121, 23);
            cmbUsuarios.TabIndex = 13;
            cmbUsuarios.SelectedIndexChanged += cmbUsuarios_SelectedIndexChanged;
            // 
            // nupPrecio
            // 
            nupPrecio.BackColor = SystemColors.InactiveCaption;
            nupPrecio.BorderStyle = BorderStyle.FixedSingle;
            nupPrecio.Location = new Point(12, 159);
            nupPrecio.Name = "nupPrecio";
            nupPrecio.Size = new Size(120, 23);
            nupPrecio.TabIndex = 12;
            // 
            // txtGenero
            // 
            txtGenero.BackColor = SystemColors.InactiveCaption;
            txtGenero.BorderStyle = BorderStyle.FixedSingle;
            txtGenero.Location = new Point(12, 99);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(120, 23);
            txtGenero.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.InactiveCaption;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(12, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(120, 23);
            txtNombre.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(11, 268);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(121, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(155, 321);
            Controls.Add(lblUsuarios);
            Controls.Add(lblPrecio);
            Controls.Add(lblGenero);
            Controls.Add(lblNombre);
            Controls.Add(cmbUsuarios);
            Controls.Add(nupPrecio);
            Controls.Add(txtGenero);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Name = "FrmAlta";
            Text = "FrmAlta";
            Load += FrmAlta_Load;
            ((System.ComponentModel.ISupportInitialize)nupPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected Label lblUsuarios;
        protected Label lblPrecio;
        protected Label lblGenero;
        protected Label lblNombre;
        protected ComboBox cmbUsuarios;
        protected NumericUpDown nupPrecio;
        protected TextBox txtGenero;
        protected TextBox txtNombre;
        protected Button btnGuardar;
    }
}