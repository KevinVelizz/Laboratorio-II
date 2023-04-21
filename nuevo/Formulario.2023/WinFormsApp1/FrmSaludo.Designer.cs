namespace WinFormsApp1
{
    partial class FrmSaludo
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
            btnSaludo = new Button();
            lblSaludo = new Label();
            SuspendLayout();
            // 
            // btnSaludo
            // 
            btnSaludo.Location = new Point(323, 251);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(168, 67);
            btnSaludo.TabIndex = 0;
            btnSaludo.Text = "button1";
            btnSaludo.UseVisualStyleBackColor = true;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Location = new Point(384, 164);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(38, 15);
            lblSaludo.TabIndex = 1;
            lblSaludo.Text = "label1";
            // 
            // FrmSaludo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSaludo);
            Controls.Add(btnSaludo);
            Name = "FrmSaludo";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaludo;
        private Label lblSaludo;
    }
}