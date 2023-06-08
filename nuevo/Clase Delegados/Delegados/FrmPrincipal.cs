using static Delegados.FrmMostrar;

namespace Delegados
{
    public partial class FrmPrincipal : Form
    {

        private FrmTestDelegados frmTestDelegados;
        private FrmMostrar frmMostrar;


        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            frmTestDelegados.cambiarNombreDelegado += frmMostrar.ActualizarNombre;
            this.frmTestDelegados.MdiParent = this;
            this.frmMostrar.MdiParent = this;
            this.mostrarToolStripMenuItem.Enabled = true;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmTestDelegados.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmMostrar.Show();
        }
    }
}