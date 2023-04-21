namespace Ejercicio01
{
    partial class FrmAltaModificacion
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
            btnConfirmar = new Button();
            txtObjeto = new TextBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(12, 61);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(166, 31);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Aceptar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtObjeto
            // 
            txtObjeto.Location = new Point(12, 34);
            txtObjeto.Name = "txtObjeto";
            txtObjeto.Size = new Size(331, 23);
            txtObjeto.TabIndex = 1;
            txtObjeto.TextChanged += FrmAltaModificacion_Load;
            txtObjeto.KeyPress += txtObjeto_KeyPress;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(184, 61);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(159, 30);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAltaModificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 104);
            Controls.Add(btnCancelar);
            Controls.Add(txtObjeto);
            Controls.Add(btnConfirmar);
            Name = "FrmAltaModificacion";
            Text = "Form1";
            Load += FrmAltaModificacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private TextBox txtObjeto;
        private Button btnCancelar;
    }
}