namespace WinFormsApp1
{
    public partial class FrmSaludo : Form
    {
        public FrmSaludo()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmSaludo_Load);
        }

        private void FrmSaludo_Load(object sender, EventArgs e)
        {
            this.Text = "Saludo desde un Form";
            btnSaludo.Text = "Haga Click Aquí";
            lblSaludo.Visible = false;
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = "¡¡¡Hola mundo WinForm!!!";
            lblSaludo.Visible = true;
        }

    }
}