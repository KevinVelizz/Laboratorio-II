namespace Ejercicio01
{
    public partial class FrmAltaModificacion : Form
    {
        public FrmAltaModificacion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    
        public FrmAltaModificacion(string title, string textObject, string textButton) : this()
        {
            this.Text = title;
            this.txtObjeto.Text = textObject;
            this.btnConfirmar.Text = textButton;
        }

        public string Objeto
        {
            get { return txtObjeto.Text; }
            //set { txtObjeto.Text = value;}
        }

        private void FrmAltaModificacion_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ShowIcon = false;
            this.txtObjeto.MaxLength = 50;
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtObjeto.Text is null | txtObjeto.Text == "")
                {
                    MessageBox.Show("Error.");
                    txtObjeto.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtObjeto.Text is null | txtObjeto.Text == "")
            {
                MessageBox.Show("Error.");
                txtObjeto.Focus();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}