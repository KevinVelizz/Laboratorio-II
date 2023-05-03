using Entidades;

namespace FormularioLav
{
    public partial class FrmLavadero : Form
    {
        Lavadero lavadero;
        List<Vehiculo> vehiculos;
        public FrmLavadero()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.vehiculos = new List<Vehiculo>();
            this.lavadero = new Lavadero(400, 600, 200);
        }

        private void FrmLavadero_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LavaderoModificacion lavaderoModificacion = new LavaderoModificacion();
            lavaderoModificacion.ShowDialog();

            if (lavaderoModificacion.DialogResult == DialogResult.OK)
            {
                this.lavadero += lavaderoModificacion.vehiculo;
                this.vehiculos.Add(lavaderoModificacion.vehiculo);
                this.lstVehiculos.Items.Add(lavaderoModificacion.vehiculo.ToString());
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.lstVehiculos.Items.Remove(this.lstVehiculos.SelectedItem);
        }

        private void btnOrdenarPatente_Click(object sender, EventArgs e)
        {
            this.vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            this.lstVehiculos.Items.Clear();

            foreach (Vehiculo vehiculo in this.vehiculos)
            {
                this.lstVehiculos.Items.Add(vehiculo.ToString());
            }
        }

        private void btnOrdenarMarca_Click(object sender, EventArgs e)
        {
            this.vehiculos.Sort(Lavadero.OrdenarVehiculoPorMarca);
            this.lstVehiculos.Items.Clear();

            foreach (Vehiculo vehiculo in this.vehiculos)
            {
                this.lstVehiculos.Items.Add(vehiculo.ToString());
            }
        }
    }
}