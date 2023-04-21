namespace WindowForms
{
    partial class Aplicacion5
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
            groupBox1 = new GroupBox();
            nudEdad = new NumericUpDown();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radNoBinario = new RadioButton();
            radFemenino = new RadioButton();
            radMasculino = new RadioButton();
            groupBox3 = new GroupBox();
            chkJS = new CheckBox();
            chkCmasmas = new CheckBox();
            chksiSharp = new CheckBox();
            btnIngresar = new Button();
            lstPais = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudEdad);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 131);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles de usuario";
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(78, 92);
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(106, 23);
            nudEdad.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(78, 58);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(106, 23);
            txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(78, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(106, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 94);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Direccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radNoBinario);
            groupBox2.Controls.Add(radFemenino);
            groupBox2.Controls.Add(radMasculino);
            groupBox2.Location = new Point(238, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(180, 109);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Género";
            // 
            // radNoBinario
            // 
            radNoBinario.AutoSize = true;
            radNoBinario.Location = new Point(18, 71);
            radNoBinario.Name = "radNoBinario";
            radNoBinario.Size = new Size(81, 19);
            radNoBinario.TabIndex = 2;
            radNoBinario.TabStop = true;
            radNoBinario.Text = "No binario";
            radNoBinario.UseVisualStyleBackColor = true;
            // 
            // radFemenino
            // 
            radFemenino.AutoSize = true;
            radFemenino.Location = new Point(18, 46);
            radFemenino.Name = "radFemenino";
            radFemenino.Size = new Size(78, 19);
            radFemenino.TabIndex = 1;
            radFemenino.TabStop = true;
            radFemenino.Text = "Femenino";
            radFemenino.UseVisualStyleBackColor = true;
            // 
            // radMasculino
            // 
            radMasculino.AutoSize = true;
            radMasculino.Location = new Point(18, 21);
            radMasculino.Name = "radMasculino";
            radMasculino.Size = new Size(80, 19);
            radMasculino.TabIndex = 0;
            radMasculino.TabStop = true;
            radMasculino.Text = "Masculino";
            radMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkJS);
            groupBox3.Controls.Add(chkCmasmas);
            groupBox3.Controls.Add(chksiSharp);
            groupBox3.Location = new Point(238, 161);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(180, 101);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cursos";
            // 
            // chkJS
            // 
            chkJS.AutoSize = true;
            chkJS.Location = new Point(18, 72);
            chkJS.Name = "chkJS";
            chkJS.Size = new Size(78, 19);
            chkJS.TabIndex = 6;
            chkJS.Text = "JavaScript";
            chkJS.UseVisualStyleBackColor = true;
            // 
            // chkCmasmas
            // 
            chkCmasmas.AutoSize = true;
            chkCmasmas.Location = new Point(18, 47);
            chkCmasmas.Name = "chkCmasmas";
            chkCmasmas.Size = new Size(50, 19);
            chkCmasmas.TabIndex = 5;
            chkCmasmas.Text = "C++";
            chkCmasmas.UseVisualStyleBackColor = true;
            // 
            // chksiSharp
            // 
            chksiSharp.AutoSize = true;
            chksiSharp.Location = new Point(18, 22);
            chksiSharp.Name = "chksiSharp";
            chksiSharp.Size = new Size(41, 19);
            chksiSharp.TabIndex = 4;
            chksiSharp.Text = "C#";
            chksiSharp.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(296, 278);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(122, 26);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lstPais
            // 
            lstPais.FormattingEnabled = true;
            lstPais.ItemHeight = 15;
            lstPais.Location = new Point(12, 194);
            lstPais.Name = "lstPais";
            lstPais.Size = new Size(200, 109);
            lstPais.TabIndex = 4;
            // 
            // Aplicacion5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 403);
            Controls.Add(lstPais);
            Controls.Add(btnIngresar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Aplicacion5";
            Text = "Form1";
            Load += Aplicacion5_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown nudEdad;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radNoBinario;
        private RadioButton radFemenino;
        private RadioButton radMasculino;
        private GroupBox groupBox3;
        private CheckBox chkJS;
        private CheckBox chkCmasmas;
        private CheckBox chksiSharp;
        private Button btnIngresar;
        private ListBox lstPais;
    }
}