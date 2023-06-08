namespace Delegados
{
    public partial class FrmTestDelegados : Form
    {
        public Action<string> cambiarNombreDelegado;

        public FrmTestDelegados()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.cambiarNombreDelegado(this.txtNombre.Text);
        }

        private void FrmTestDelegados_Load(object sender, EventArgs e)
        {
        }

        private void FrmTestDelegados_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
