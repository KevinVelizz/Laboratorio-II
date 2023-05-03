using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormularioLav
{
    public partial class LavaderoModificacion : Form
    {
        public Vehiculo vehiculo;
        public string vehiculoSeleccionado;
        public LavaderoModificacion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public LavaderoModificacion(string titulo, string texto, string textoBoton) : this()
        {
            this.Text = titulo;
            this.txtVehiculo.Text = texto;
            this.btnAceptar.Text = textoBoton;

        }

        private void LavaderoModificacion_Load(object sender, EventArgs e)
        {
            foreach (EVehiculos vehiculo in Enum.GetValues(typeof(EVehiculos)))
            {
                this.cboTipo.Items.Add(vehiculo.ToString());
            }
            this.cboTipo.Text = "Seleccione";
            this.txtCantAsientos.Visible = false;
            this.txtTara.Visible = false;
            this.txtCilindrada.Visible = false;
            this.txtVehiculo.Visible = false;
            this.txtCantRuedas.Visible = false;

            this.lblMarca.Visible = false;
            this.cboMarca.Visible = false;

            this.lblCantidadAsientos.Visible = false;
            this.lblCantRuedas.Visible = false;
            this.lblCilindrada.Visible = false;
            this.lblTara.Visible = false;
            this.lblPatente.Visible = false;

        }

        private void cboTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.lblMarca.Visible = true;
            this.cboMarca.Visible = true;
            this.vehiculoSeleccionado = (string)this.cboTipo.SelectedItem;
            this.cboMarca.DataSource = Enum.GetValues(typeof(EMarcas));
            this.cboMarca.Text = "Seleccione";
            this.txtCantRuedas.Visible = true;
            this.lblCantRuedas.Visible = true;
            this.txtVehiculo.Visible = true;
            this.lblPatente.Visible = true;

            if (this.vehiculoSeleccionado == "Auto")
            {
                /* Auto */
                this.txtCantAsientos.Visible = true;
                this.lblCantidadAsientos.Visible = true;

                /* Moto */
                this.lblCilindrada.Visible = false;
                this.txtCilindrada.Visible = false;

                /* Camion */
                this.txtTara.Visible = false;
                this.lblTara.Visible = false;
            }
            else if (this.vehiculoSeleccionado == "Moto")
            {
                /* Auto */
                this.txtCantAsientos.Visible = false;
                this.lblCantidadAsientos.Visible = false;

                /* Moto */
                this.lblCilindrada.Visible = true;
                this.lblCilindrada.Location = new System.Drawing.Point(this.txtCilindrada.Location.X - 78, 140);

                this.txtCilindrada.Visible = true;
                this.txtCilindrada.Location = new System.Drawing.Point(125, 140);

                /* Camion */
                this.txtTara.Visible = false;
                this.lblTara.Visible = false;
            }

            else if (this.vehiculoSeleccionado == "Camion")
            {
                /* Auto */
                this.txtCantAsientos.Visible = false;
                this.lblCantidadAsientos.Visible = false;

                /* Moto */
                this.lblCilindrada.Visible = false;
                this.txtCilindrada.Visible = false;

                /* Camion */
                this.txtTara.Visible = true;
                this.txtTara.Location = new System.Drawing.Point(125, 140);

                this.lblTara.Visible = true;
                this.lblTara.Location = new System.Drawing.Point(this.txtCilindrada.Location.X - 47, 140);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtVehiculo.Text == "" || cboMarca.SelectedItem is null || cboTipo is null)
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            else
            {
                EMarcas marcas = (EMarcas)this.cboMarca.SelectedValue;
                if (this.vehiculoSeleccionado == "Auto")
                {
                    this.vehiculo = new Auto(int.Parse(txtCantAsientos.Text), txtVehiculo.Text, byte.Parse(txtCantRuedas.Text), marcas);
                }
                else if (this.vehiculoSeleccionado == "Moto")
                {
                    this.vehiculo = new Moto(int.Parse(txtCilindrada.Text), txtVehiculo.Text, byte.Parse(txtCantRuedas.Text), marcas);
                }
                else
                {
                    this.vehiculo = new Camion(float.Parse(txtTara.Text), txtVehiculo.Text, byte.Parse(txtCantRuedas.Text), marcas);
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
