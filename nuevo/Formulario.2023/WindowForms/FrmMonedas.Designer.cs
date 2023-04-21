namespace WindowForms
{
    partial class FrmMonedas
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonedas));
            ListImgCandado = new ImageList(components);
            btnCandado = new Button();
            btnConvertEuro = new Button();
            btnConvertDolar = new Button();
            btnConvertPeso = new Button();
            txtPeso = new TextBox();
            txtEuro = new TextBox();
            txtDolar = new TextBox();
            lblEuro = new Label();
            lblDolar = new Label();
            lblPeso = new Label();
            txtEuroCot = new TextBox();
            txtDolarCot = new TextBox();
            txtPesoCot = new TextBox();
            txtEuroAEuro = new TextBox();
            txtEuroADolar = new TextBox();
            txtEuroAPeso = new TextBox();
            txtDolarAEuro = new TextBox();
            txtDolarADolar = new TextBox();
            txtDolarAPeso = new TextBox();
            txtPesoAEuro = new TextBox();
            txtPesoADolar = new TextBox();
            txtPesoAPeso = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // ListImgCandado
            // 
            ListImgCandado.ColorDepth = ColorDepth.Depth8Bit;
            ListImgCandado.ImageStream = (ImageListStreamer)resources.GetObject("ListImgCandado.ImageStream");
            ListImgCandado.TransparentColor = Color.Transparent;
            ListImgCandado.Images.SetKeyName(0, "abierto.png");
            ListImgCandado.Images.SetKeyName(1, "cerrado.png");
            // 
            // btnCandado
            // 
            btnCandado.Location = new Point(162, 11);
            btnCandado.Name = "btnCandado";
            btnCandado.Size = new Size(75, 23);
            btnCandado.TabIndex = 0;
            btnCandado.UseVisualStyleBackColor = true;
            btnCandado.Click += btnCandado_Click;
            // 
            // btnConvertEuro
            // 
            btnConvertEuro.Location = new Point(162, 77);
            btnConvertEuro.Name = "btnConvertEuro";
            btnConvertEuro.Size = new Size(75, 23);
            btnConvertEuro.TabIndex = 1;
            btnConvertEuro.Text = "-->";
            btnConvertEuro.UseVisualStyleBackColor = true;
            btnConvertEuro.Click += btnConvertEuro_Click;
            // 
            // btnConvertDolar
            // 
            btnConvertDolar.Location = new Point(162, 111);
            btnConvertDolar.Name = "btnConvertDolar";
            btnConvertDolar.Size = new Size(75, 23);
            btnConvertDolar.TabIndex = 2;
            btnConvertDolar.Text = "-->";
            btnConvertDolar.UseVisualStyleBackColor = true;
            btnConvertDolar.Click += btnConvertDolar_Click;
            // 
            // btnConvertPeso
            // 
            btnConvertPeso.Location = new Point(162, 140);
            btnConvertPeso.Name = "btnConvertPeso";
            btnConvertPeso.Size = new Size(75, 23);
            btnConvertPeso.TabIndex = 3;
            btnConvertPeso.Text = "-->";
            btnConvertPeso.UseVisualStyleBackColor = true;
            btnConvertPeso.Click += btnConvertPeso_Click;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(56, 137);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 4;
            // 
            // txtEuro
            // 
            txtEuro.Location = new Point(56, 81);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new Size(100, 23);
            txtEuro.TabIndex = 5;
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(56, 110);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(100, 23);
            txtDolar.TabIndex = 6;
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Location = new Point(9, 84);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(31, 15);
            lblEuro.TabIndex = 7;
            lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            lblDolar.AutoSize = true;
            lblDolar.Location = new Point(9, 113);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new Size(35, 15);
            lblDolar.TabIndex = 8;
            lblDolar.Text = "Dólar";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(9, 140);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
            lblPeso.TabIndex = 9;
            lblPeso.Text = "Peso";
            // 
            // txtEuroCot
            // 
            txtEuroCot.Location = new Point(257, 12);
            txtEuroCot.Name = "txtEuroCot";
            txtEuroCot.Size = new Size(100, 23);
            txtEuroCot.TabIndex = 10;
            txtEuroCot.MouseLeave += txtEuroCot_MouseLeave;
            // 
            // txtDolarCot
            // 
            txtDolarCot.Location = new Point(373, 12);
            txtDolarCot.Name = "txtDolarCot";
            txtDolarCot.Size = new Size(100, 23);
            txtDolarCot.TabIndex = 11;
            txtDolarCot.MouseLeave += txtDolarCot_MouseLeave;
            // 
            // txtPesoCot
            // 
            txtPesoCot.Location = new Point(490, 11);
            txtPesoCot.Name = "txtPesoCot";
            txtPesoCot.Size = new Size(100, 23);
            txtPesoCot.TabIndex = 12;
            txtPesoCot.MouseLeave += txtPesoCot_MouseLeave;
            // 
            // txtEuroAEuro
            // 
            txtEuroAEuro.Location = new Point(257, 78);
            txtEuroAEuro.Name = "txtEuroAEuro";
            txtEuroAEuro.Size = new Size(100, 23);
            txtEuroAEuro.TabIndex = 13;
            // 
            // txtEuroADolar
            // 
            txtEuroADolar.Location = new Point(373, 77);
            txtEuroADolar.Name = "txtEuroADolar";
            txtEuroADolar.Size = new Size(100, 23);
            txtEuroADolar.TabIndex = 14;
            // 
            // txtEuroAPeso
            // 
            txtEuroAPeso.Location = new Point(490, 76);
            txtEuroAPeso.Name = "txtEuroAPeso";
            txtEuroAPeso.Size = new Size(100, 23);
            txtEuroAPeso.TabIndex = 15;
            // 
            // txtDolarAEuro
            // 
            txtDolarAEuro.Location = new Point(257, 107);
            txtDolarAEuro.Name = "txtDolarAEuro";
            txtDolarAEuro.Size = new Size(100, 23);
            txtDolarAEuro.TabIndex = 16;
            // 
            // txtDolarADolar
            // 
            txtDolarADolar.Location = new Point(373, 110);
            txtDolarADolar.Name = "txtDolarADolar";
            txtDolarADolar.Size = new Size(100, 23);
            txtDolarADolar.TabIndex = 17;
            // 
            // txtDolarAPeso
            // 
            txtDolarAPeso.Location = new Point(490, 110);
            txtDolarAPeso.Name = "txtDolarAPeso";
            txtDolarAPeso.Size = new Size(100, 23);
            txtDolarAPeso.TabIndex = 18;
            // 
            // txtPesoAEuro
            // 
            txtPesoAEuro.Location = new Point(257, 140);
            txtPesoAEuro.Name = "txtPesoAEuro";
            txtPesoAEuro.Size = new Size(100, 23);
            txtPesoAEuro.TabIndex = 19;
            // 
            // txtPesoADolar
            // 
            txtPesoADolar.Location = new Point(373, 141);
            txtPesoADolar.Name = "txtPesoADolar";
            txtPesoADolar.Size = new Size(100, 23);
            txtPesoADolar.TabIndex = 20;
            // 
            // txtPesoAPeso
            // 
            txtPesoAPeso.Location = new Point(490, 141);
            txtPesoAPeso.Name = "txtPesoAPeso";
            txtPesoAPeso.Size = new Size(100, 23);
            txtPesoAPeso.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 60);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 22;
            label1.Text = "Euro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 59);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 23;
            label2.Text = "Dólar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(525, 58);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 24;
            label3.Text = "Peso";
            // 
            // FrmMonedas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 180);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPesoAPeso);
            Controls.Add(txtPesoADolar);
            Controls.Add(txtPesoAEuro);
            Controls.Add(txtDolarAPeso);
            Controls.Add(txtDolarADolar);
            Controls.Add(txtDolarAEuro);
            Controls.Add(txtEuroAPeso);
            Controls.Add(txtEuroADolar);
            Controls.Add(txtEuroAEuro);
            Controls.Add(txtPesoCot);
            Controls.Add(txtDolarCot);
            Controls.Add(txtEuroCot);
            Controls.Add(lblPeso);
            Controls.Add(lblDolar);
            Controls.Add(lblEuro);
            Controls.Add(txtDolar);
            Controls.Add(txtEuro);
            Controls.Add(txtPeso);
            Controls.Add(btnConvertPeso);
            Controls.Add(btnConvertDolar);
            Controls.Add(btnConvertEuro);
            Controls.Add(btnCandado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMonedas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMonedas";
            Load += FrmMonedas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList ListImgCandado;
        private Button btnCandado;
        private Button btnConvertEuro;
        private Button btnConvertDolar;
        private Button btnConvertPeso;
        private TextBox txtPeso;
        private TextBox txtEuro;
        private TextBox txtDolar;
        private Label lblEuro;
        private Label lblDolar;
        private Label lblPeso;
        private TextBox txtEuroCot;
        private TextBox txtDolarCot;
        private TextBox txtPesoCot;
        private TextBox txtEuroAEuro;
        private TextBox txtEuroADolar;
        private TextBox txtEuroAPeso;
        private TextBox txtDolarAEuro;
        private TextBox txtDolarADolar;
        private TextBox txtDolarAPeso;
        private TextBox txtPesoAEuro;
        private TextBox txtPesoADolar;
        private TextBox txtPesoAPeso;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}