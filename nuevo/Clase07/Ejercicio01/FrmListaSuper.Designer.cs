namespace Ejercicio01
{
    partial class FrmListaSuper
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
            lstObjetos = new ListBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // lstObjetos
            // 
            lstObjetos.FormattingEnabled = true;
            lstObjetos.ItemHeight = 15;
            lstObjetos.Location = new Point(12, 7);
            lstObjetos.Name = "lstObjetos";
            lstObjetos.Size = new Size(257, 574);
            lstObjetos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(289, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(52, 38);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(289, 56);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(52, 38);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "-";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(289, 100);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(52, 38);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "M";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FrmListaSuper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 585);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lstObjetos);
            Name = "FrmListaSuper";
            Text = "Lista del supermercado";
            Load += FrmListaSuper_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstObjetos;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
    }
}