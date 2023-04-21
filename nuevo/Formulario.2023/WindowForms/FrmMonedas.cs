using Entidades;
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
    public partial class FrmMonedas : Form
    {
        private bool imagenActual = false;
        public FrmMonedas()
        {
            InitializeComponent();
        }

        private void FrmMonedas_Load(object sender, EventArgs e)
        {
            btnCandado.Image = ListImgCandado.Images[0];
            txtDolarCot.Text = "1";
            txtEuroCot.Text = "1,17";
            txtPesoCot.Text = "102,65";
            txtDolarCot.Enabled = false;
        }

        private void btnCandado_Click(object sender, EventArgs e)
        {
            if (imagenActual)
            {
                btnCandado.Image = ListImgCandado.Images[1];
                imagenActual = false;
                txtDolarCot.Enabled = false;
                txtEuroCot.Enabled = false;
                txtPesoCot.Enabled = false;
            }
            else
            {
                btnCandado.Image = ListImgCandado.Images[0];
                imagenActual = true;
                txtDolarCot.Enabled = true;
                txtEuroCot.Enabled = true;
                txtPesoCot.Enabled = true;
            }
        }

        private void txtDolarCot_MouseLeave(object sender, EventArgs e)
        {
            if (!(double.TryParse(txtDolarCot.Text, out double numero)) | numero < 0)
            {
                MessageBox.Show("Error. Ingrese nuevamente");
                txtDolarCot.Focus();
                txtDolarCot.Text = "";
            }
        }

        private void txtEuroCot_MouseLeave(object sender, EventArgs e)
        {
            if (!(double.TryParse(txtEuroCot.Text, out double numero)) | numero < 0)
            {
                MessageBox.Show("Error. Ingrese nuevamente");
                txtEuroCot.Focus();
                txtEuroCot.Text = "";
            }
        }

        private void txtPesoCot_MouseLeave(object sender, EventArgs e)
        {
            if (!(double.TryParse(txtPesoCot.Text, out double numero)) | numero < 0)
            {
                MessageBox.Show("Error. Ingrese nuevamente");
                txtPesoCot.Focus();
                txtPesoCot.Text = "";
            }
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtEuro.Text, out double numero))
            {
                if (double.TryParse(txtEuroCot.Text, out double valorCot))
                {
                    Euro euro = new Euro(numero);
                    euro.SetCotizacion(valorCot);
                    Dolar euroADolar = (Dolar)euro;
                    Pesos euroAPesos = (Pesos)euro;

                    txtEuroAEuro.Text = euro.GetCantidad().ToString();
                    txtEuroADolar.Text = euroADolar.GetCantidad().ToString();
                    txtEuroAPeso.Text = euroAPesos.GetCantidad().ToString();
                }
                else
                {
                    MessageBox.Show("Error Ingrese un valor válido.");
                }
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDolar.Text, out double numero))
            {
                Dolar dolar = new Dolar(numero);
                Euro dolarAEuro = (Euro)dolar;
                Pesos dolarAPesos = (Pesos)dolar;

                txtDolarAEuro.Text = dolarAEuro.GetCantidad().ToString();
                txtDolarADolar.Text = dolar.GetCantidad().ToString();
                txtDolarAPeso.Text = dolarAPesos.GetCantidad().ToString();
            }
            else
            {
                MessageBox.Show("Error Ingrese un valor válido.");
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPeso.Text, out double numero))
            {
                if (double.TryParse(txtPesoCot.Text, out double valorCot))
                {
                    Pesos pesos = new Pesos(numero);
                    pesos.SetCotizacion(valorCot);
                    Dolar pesoADolar = (Dolar)pesos;
                    Euro pesoAEuro = (Euro)pesos;

                    txtPesoAEuro.Text = pesoAEuro.GetCantidad().ToString();
                    txtPesoADolar.Text = pesoADolar.GetCantidad().ToString();
                    txtPesoAPeso.Text = pesos.GetCantidad().ToString();
                }
                else
                {
                    MessageBox.Show("Error Ingrese un valor válido.");
                }
            }
        }
    }
}
