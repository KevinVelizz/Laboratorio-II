using Entidades;

namespace Eventos
{
    public partial class FrmAvisador : Form
    {
        private Persona persona;
        public FrmAvisador()
        {
            InitializeComponent();
            
        }

        private void FrmAvisador_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (this.persona is not null)
            {
                this.persona.Apellido = this.txtApellido.Text;
                this.persona.Nombre = this.txtNombre.Text;
            }
            else
            {
                this.persona = new Persona();
                this.persona.EventoString += NotificarCambio;
                this.persona.Apellido = this.txtApellido.Text;
                this.persona.Nombre = this.txtNombre.Text;
                this.btnCrear.Text = "Actualizar";
            }
            this.lblNombreCompleto.Visible = true;
            lblNombreCompleto.Text = $"{this.persona.Mostrar()}";
        }

        private void NotificarCambio(string cambio)
        {
            MessageBox.Show($"{persona.Nombre} - {persona.Apellido} {cambio}");
        }
    }
}