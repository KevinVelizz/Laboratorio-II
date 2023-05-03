namespace FormularioLav
{
    partial class FrmLavadero
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
            btnBorrar = new Button();
            btnAgregar = new Button();
            lstVehiculos = new ListBox();
            btnOrdenarMarca = new Button();
            btnOrdenarPatente = new Button();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.Location = new Point(471, 58);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(52, 40);
            btnBorrar.TabIndex = 0;
            btnBorrar.Text = "-";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(471, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(52, 40);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(12, 12);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(440, 289);
            lstVehiculos.TabIndex = 2;
            // 
            // btnOrdenarMarca
            // 
            btnOrdenarMarca.Location = new Point(334, 325);
            btnOrdenarMarca.Name = "btnOrdenarMarca";
            btnOrdenarMarca.Size = new Size(118, 23);
            btnOrdenarMarca.TabIndex = 3;
            btnOrdenarMarca.Text = "Ordenar por marca";
            btnOrdenarMarca.UseVisualStyleBackColor = true;
            btnOrdenarMarca.Click += btnOrdenarMarca_Click;
            // 
            // btnOrdenarPatente
            // 
            btnOrdenarPatente.Location = new Point(12, 325);
            btnOrdenarPatente.Name = "btnOrdenarPatente";
            btnOrdenarPatente.Size = new Size(129, 23);
            btnOrdenarPatente.TabIndex = 4;
            btnOrdenarPatente.Text = "Ordenar por patente";
            btnOrdenarPatente.UseVisualStyleBackColor = true;
            btnOrdenarPatente.Click += btnOrdenarPatente_Click;
            // 
            // FrmLavadero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 410);
            Controls.Add(btnOrdenarPatente);
            Controls.Add(btnOrdenarMarca);
            Controls.Add(lstVehiculos);
            Controls.Add(btnAgregar);
            Controls.Add(btnBorrar);
            Name = "FrmLavadero";
            Text = "Lavadero";
            Load += FrmLavadero_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBorrar;
        private Button btnAgregar;
        private ListBox lstVehiculos;
        private Button btnOrdenarMarca;
        private Button btnOrdenarPatente;
    }
}