namespace WindowForms
{
    partial class FrmPrincipal
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
            btnLimpiar = new Button();
            txtNumero = new TextBox();
            lstTabla = new ListBox();
            lblIngrese = new Label();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(91, 318);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "button1";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(133, 70);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // lstTabla
            // 
            lstTabla.FormattingEnabled = true;
            lstTabla.ItemHeight = 15;
            lstTabla.Location = new Point(43, 100);
            lstTabla.Name = "lstTabla";
            lstTabla.Size = new Size(190, 184);
            lstTabla.TabIndex = 2;
            // 
            // lblIngrese
            // 
            lblIngrese.AutoSize = true;
            lblIngrese.Location = new Point(12, 73);
            lblIngrese.Name = "lblIngrese";
            lblIngrese.Size = new Size(38, 15);
            lblIngrese.TabIndex = 3;
            lblIngrese.Text = "label1";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 365);
            Controls.Add(lblIngrese);
            Controls.Add(lstTabla);
            Controls.Add(txtNumero);
            Controls.Add(btnLimpiar);
            Name = "FrmPrincipal";
            Text = "Tabla";
            FormClosing += Tabla_FormClosing;
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private TextBox txtNumero;
        private ListBox lstTabla;
        private Label lblIngrese;
    }
}