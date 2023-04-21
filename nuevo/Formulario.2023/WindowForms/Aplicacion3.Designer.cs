namespace WindowForms
{
    partial class Aplicacion3
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
            gbxInformacion = new GroupBox();
            lblTotal = new Label();
            lblDescuento = new Label();
            txtPagar = new TextBox();
            txtDescuento = new TextBox();
            lblIngrese = new Label();
            txtImporte = new TextBox();
            btnAceptar = new Button();
            btnLimpiar = new Button();
            gbxInformacion.SuspendLayout();
            SuspendLayout();
            // 
            // gbxInformacion
            // 
            gbxInformacion.Controls.Add(lblTotal);
            gbxInformacion.Controls.Add(lblDescuento);
            gbxInformacion.Controls.Add(txtPagar);
            gbxInformacion.Controls.Add(txtDescuento);
            gbxInformacion.Controls.Add(lblIngrese);
            gbxInformacion.Controls.Add(txtImporte);
            gbxInformacion.Location = new Point(12, 33);
            gbxInformacion.Name = "gbxInformacion";
            gbxInformacion.Size = new Size(310, 223);
            gbxInformacion.TabIndex = 0;
            gbxInformacion.TabStop = false;
            gbxInformacion.Text = "groupBox1";
            gbxInformacion.Enter += gbxInformacion_Enter;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(68, 170);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "label3";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(68, 127);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(38, 15);
            lblDescuento.TabIndex = 6;
            lblDescuento.Text = "label2";
            // 
            // txtPagar
            // 
            txtPagar.Location = new Point(195, 167);
            txtPagar.Name = "txtPagar";
            txtPagar.Size = new Size(100, 23);
            txtPagar.TabIndex = 5;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(195, 124);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 4;
            // 
            // lblIngrese
            // 
            lblIngrese.AutoSize = true;
            lblIngrese.Location = new Point(53, 61);
            lblIngrese.Name = "lblIngrese";
            lblIngrese.Size = new Size(38, 15);
            lblIngrese.TabIndex = 3;
            lblIngrese.Text = "label1";
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(195, 58);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(100, 23);
            txtImporte.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(43, 276);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "button1";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(196, 276);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "button2";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Aplicacion3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 354);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAceptar);
            Controls.Add(gbxInformacion);
            Name = "Aplicacion3";
            Text = "Form3";
            FormClosing += Aplicacion3_FormClosing;
            Load += Aplicacion3_Load;
            gbxInformacion.ResumeLayout(false);
            gbxInformacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxInformacion;
        private TextBox txtImporte;
        private Button btnAceptar;
        private Button btnLimpiar;
        private Label lblTotal;
        private Label lblDescuento;
        private TextBox txtPagar;
        private TextBox txtDescuento;
        private Label lblIngrese;
    }
}