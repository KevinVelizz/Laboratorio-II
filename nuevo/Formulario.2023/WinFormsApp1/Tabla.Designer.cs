namespace WinFormsApp1
{
    partial class Tabla
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
            label1 = new Label();
            lstTabla = new ListBox();
            txtNumero = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lstTabla
            // 
            lstTabla.FormattingEnabled = true;
            lstTabla.ItemHeight = 15;
            lstTabla.Location = new Point(33, 48);
            lstTabla.Name = "lstTabla";
            lstTabla.Size = new Size(168, 244);
            lstTabla.TabIndex = 1;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(87, 48);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(33, 298);
            button1.Name = "button1";
            button1.Size = new Size(168, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Tabla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 362);
            Controls.Add(button1);
            Controls.Add(txtNumero);
            Controls.Add(lstTabla);
            Controls.Add(label1);
            Name = "Tabla";
            Text = "Form1";
            Load += Tabla_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstTabla;
        private TextBox txtNumero;
        private Button button1;
    }
}