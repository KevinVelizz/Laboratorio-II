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

namespace WindowForms
{
    public partial class Aplicacion5 : Form
    {
        public Aplicacion5()
        {
            InitializeComponent();
        }

        private void Aplicacion5_Load(object sender, EventArgs e)
        {
            lstPais.Items.Add("Argentina");
            lstPais.Items.Add("Chile");
            lstPais.Items.Add("Uruguay");

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Saber los cursos hechos.
            string cursoHechoC = "";
            string cursoHechoCmas = "";
            string cursoHechoJS = "";

            // Valor seleccionado en listBox
            Object valorSelect = lstPais.SelectedItem;

            //Por si no elige un genero llenarlo como vacio, en caso de seleccionar uno, mostrarlo.
            string genero = "";
            foreach (Control item in this.Controls)
            {
                foreach (Control control in item.Controls)
                {
                    if (control is RadioButton radioButton)
                    {
                        if (radioButton.Checked)
                        {
                            genero = radioButton.Text;
                        }
                    }

                    //Saber los cursos hechos.
                  
                    if (control is CheckBox)
                    {
                        if (chksiSharp.Checked)
                        {
                            cursoHechoC = chksiSharp.Text;
                        }
                        if (chkCmasmas.Checked)
                        {
                            cursoHechoCmas = chkCmasmas.Text;
                        }
                        if (chkJS.Checked)
                        {
                            cursoHechoJS = chkJS.Text;
                        }
                    }
                }
            }
            Ingresante ingresante = new Ingresante(new string[3] {cursoHechoC,cursoHechoCmas,cursoHechoJS}, txtDireccion.Text, ((double)nudEdad.Value), genero, txtNombre.Text, valorSelect.ToString());
            MessageBox.Show(ingresante.Mostrar());
        }
    }
}
