namespace WindowForms
{
    public partial class FrmSaludo : Form
    {
        public FrmSaludo()
        {
            InitializeComponent();
        }

        private void FrmSaludo_Load(object sender, EventArgs e)
        {
            btnSaludo.Text = "Haga Click Aquí";
            lblSaludo.Visible = false;

        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblSaludo.Visible = true;
            lblSaludo.Text = "Hola Mundo WinForm";
        }

        private void lblSaludo_Click(object sender, EventArgs e)
        {

        }
    }
}