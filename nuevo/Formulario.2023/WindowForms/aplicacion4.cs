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
    public partial class aplicacion4 : Form
    {
        public aplicacion4()
        {
            InitializeComponent();
        }
        private void aplicacion4_Load(object sender, EventArgs e)
        {

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

                    if (control is ListBox listBox)
                    {
                        listBox.Items.Clear();
                    }

                    if (control is RadioButton radioButton)
                    {
                        radioButton.Checked = false;
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtAgregar.Text, out double numero))
            {
                lstNumeros.Items.Add(numero);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            List<double> doubles = new List<double>();

            foreach (double item in lstNumeros.Items)
            {
                if (double.TryParse(item.ToString(), out double numero))
                {
                    doubles.Add(numero);
                }
            }

            if (radAscendente.Checked)
            {
                lstNumeros.Items.Clear();
                doubles.Sort();

                foreach (double item in doubles)
                {
                    lstNumeros.Items.Add(item);
                }
            }
            else if (radDescendente.Checked)
            {
                lstNumeros.Items.Clear();
                doubles.Sort();
                doubles.Reverse();
                foreach (double item in doubles)
                {
                    lstNumeros.Items.Add(item);
                }
            }

        }
    }
}
