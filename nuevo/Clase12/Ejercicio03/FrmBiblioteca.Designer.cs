namespace Ejercicio03
{
    partial class FrmBiblioteca
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiblioteca));
            btnSalir = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAlta = new Button();
            dtgvBiblioteca = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgvBiblioteca).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(500, 251);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(97, 31);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.Control;
            btnModificar.BackgroundImage = (Image)resources.GetObject("btnModificar.BackgroundImage");
            btnModificar.BackgroundImageLayout = ImageLayout.Stretch;
            btnModificar.FlatAppearance.BorderColor = Color.Black;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Location = new Point(12, 18);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(108, 29);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar Juegos";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(489, 17);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 31);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar Juegos";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAlta
            // 
            btnAlta.BackgroundImage = (Image)resources.GetObject("btnAlta.BackgroundImage");
            btnAlta.BackgroundImageLayout = ImageLayout.Stretch;
            btnAlta.FlatStyle = FlatStyle.Flat;
            btnAlta.Location = new Point(243, 17);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(108, 29);
            btnAlta.TabIndex = 9;
            btnAlta.Text = "Alta Juegos";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // dtgvBiblioteca
            // 
            dtgvBiblioteca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBiblioteca.BackgroundColor = SystemColors.InactiveCaption;
            dtgvBiblioteca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBiblioteca.Location = new Point(12, 71);
            dtgvBiblioteca.Name = "dtgvBiblioteca";
            dtgvBiblioteca.RowHeadersWidth = 80;
            dtgvBiblioteca.Size = new Size(585, 158);
            dtgvBiblioteca.TabIndex = 8;
            // 
            // FrmBiblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 306);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAlta);
            Controls.Add(dtgvBiblioteca);
            Name = "FrmBiblioteca";
            Text = "Form1";
            Load += FrmBiblioteca_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvBiblioteca).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAlta;
        private DataGridView dtgvBiblioteca;
    }
}