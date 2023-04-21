using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Tabla : Form
    {
        public Tabla()
        {
            InitializeComponent();
            this.Load += new EventHandler(Tabla_Load);

        }

        private void Tabla_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                int numero = Convert.ToInt32(txtNumero.Text);
                lstTabla.Items.Clear();
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = i * numero;
                    lstTabla.Items.Add(numero + " x " + i + " = " + resultado);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            lstTabla.Items.Clear();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea cerrar la aplicación?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
