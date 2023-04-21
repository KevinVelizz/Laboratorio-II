namespace WindowForms
{
    partial class aplicacion4
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
            btnAgregar = new Button();
            btnOrdenar = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            lstNumeros = new ListBox();
            groupBox2 = new GroupBox();
            radAscendente = new RadioButton();
            radDescendente = new RadioButton();
            groupBox3 = new GroupBox();
            txtAgregar = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(119, 37);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(119, 40);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 23);
            btnOrdenar.TabIndex = 1;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(44, 281);
            button3.Name = "button3";
            button3.Size = new Size(137, 29);
            button3.TabIndex = 2;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnLimpiar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstNumeros);
            groupBox1.Location = new Point(218, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(178, 241);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de números";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.ItemHeight = 15;
            lstNumeros.Location = new Point(18, 22);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(143, 199);
            lstNumeros.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radAscendente);
            groupBox2.Controls.Add(radDescendente);
            groupBox2.Controls.Add(btnOrdenar);
            groupBox2.Location = new Point(12, 175);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Orden";
            // 
            // radAscendente
            // 
            radAscendente.AutoSize = true;
            radAscendente.Checked = true;
            radAscendente.Location = new Point(6, 22);
            radAscendente.Name = "radAscendente";
            radAscendente.Size = new Size(87, 19);
            radAscendente.TabIndex = 6;
            radAscendente.TabStop = true;
            radAscendente.Text = "Ascendente";
            radAscendente.UseVisualStyleBackColor = true;
            // 
            // radDescendente
            // 
            radDescendente.AutoSize = true;
            radDescendente.Location = new Point(6, 57);
            radDescendente.Name = "radDescendente";
            radDescendente.Size = new Size(93, 19);
            radDescendente.TabIndex = 7;
            radDescendente.Text = "Descendente";
            radDescendente.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtAgregar);
            groupBox3.Controls.Add(btnAgregar);
            groupBox3.Location = new Point(12, 69);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ingrese un nuevo número";
            // 
            // txtAgregar
            // 
            txtAgregar.Location = new Point(6, 37);
            txtAgregar.Name = "txtAgregar";
            txtAgregar.Size = new Size(100, 23);
            txtAgregar.TabIndex = 2;
            // 
            // aplicacion4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 383);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Name = "aplicacion4";
            Text = "Form1";
            Load += aplicacion4_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private Button btnOrdenar;
        private Button button3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ListBox lstNumeros;
        private RadioButton radAscendente;
        private RadioButton radDescendente;
        private TextBox txtAgregar;
    }
}