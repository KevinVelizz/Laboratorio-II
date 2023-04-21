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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {

            InitializeComponent();
            lblIngrese.Text = "Ingrese un número: ";
            btnLimpiar.Text = "Limpiar";
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            int numero;

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (int.TryParse(txtNumero.Text, out numero) && numero > 0)
                {
                    for (int i = 1; i < 11; i++)
                    {
                        lstTabla.Items.Add($"{i} x {txtNumero.Text} = {i * int.Parse(txtNumero.Text)}\n");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un valor numérico");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstTabla.Items.Clear();
            txtNumero.Text = "";
        }

        private void Tabla_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
