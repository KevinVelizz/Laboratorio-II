using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForms
{
    public partial class Aplicacion3 : Form
    {
        public Aplicacion3()
        {
            InitializeComponent();
        }
        private void Aplicacion3_Load(object sender, EventArgs e)
        {
            this.Text = "Descuento";

            lblIngrese.Text = "Ingrese importe a cobrar:";

            lblDescuento.Text = "Descuento recibido:";
            txtDescuento.Enabled = false;

            lblTotal.Text = "Total a pagar:";
            txtPagar.Enabled = false;

            btnAceptar.Text = "Aceptar";
            btnLimpiar.Text = "Limpiar";
            gbxInformacion.Text = "Información";

            btnAceptar.Text = "Aceptar";
            btnLimpiar.Text = "Limpiar";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                foreach (Control control in item.Controls)
                {
                    if (control is TextBox)
                    {
                        control.Text = "";
                    }
                }
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtImporte.Text, out double numero) && numero > 0)
            {
                if (double.Parse(txtImporte.Text) >= 3000 && double.Parse(txtImporte.Text) <= 5000)
                {
                    double descuento = 0.1 * double.Parse(txtImporte.Text);

                    txtDescuento.Text = $"{descuento}";

                    double importeTotal = double.Parse(txtImporte.Text) - descuento;

                    txtPagar.Text = $"{importeTotal}";
                }
                else if (double.Parse(txtImporte.Text) > 5000)
                {
                    double descuento = 0.2 * double.Parse(txtImporte.Text);

                    txtDescuento.Text = $"{descuento}";

                    double importeTotal = double.Parse(txtImporte.Text) - descuento;

                    txtPagar.Text = $"{importeTotal}";
                }
                else
                {
                    txtDescuento.Text = $"{0}";
                    txtPagar.Text = txtImporte.Text;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }

        private void Aplicacion3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Estás seguro de salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Sigues en el programa");
            }
        }

        private void gbxInformacion_Enter(object sender, EventArgs e)
        {

        }
    }
}
