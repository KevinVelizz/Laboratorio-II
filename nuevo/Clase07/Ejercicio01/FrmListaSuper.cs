using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Ejercicio01
{
    public partial class FrmListaSuper : Form
    {
        List<string> listaSupermercado;
        string dataPath;

        public FrmListaSuper()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.listaSupermercado = new List<string>();
            this.dataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            ToolTip toolTipAgregar = new ToolTip();
            ToolTip toolTipEliminar = new ToolTip();
            ToolTip toolTipModificar = new ToolTip();
            toolTipAgregar.SetToolTip(btnAgregar, "Agregar objeto");
            toolTipEliminar.SetToolTip(btnEliminar, "Eliminar objeto");
            toolTipModificar.SetToolTip(btnModificar, "Modificar objeto");

            this.DeserealizarLista();

        }

        private void DeserealizarLista()
        {
            if (File.Exists(dataPath + @"\listaSupermercado.xml"))
            {
                try
                {
                    using (XmlTextReader sr = new XmlTextReader(this.dataPath + @"\listaSupermercado.xml"))
                    {
                        XmlSerializer serializer = new XmlSerializer((typeof(List<string>)));

                        this.listaSupermercado = (List<string>)serializer.Deserialize(sr);
                    }

                    this.ActualizarListaSupermercado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR: {ex.StackTrace}");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion FormObjeto = new FrmAltaModificacion("Agregar objeto", "", "Agregar");
            FormObjeto.ShowDialog();

            if (FormObjeto.DialogResult == DialogResult.OK)
            {
                listaSupermercado.Add(FormObjeto.Objeto);
                this.SerializarListaSupermercado();
                this.ActualizarListaSupermercado();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstObjetos.SelectedItem != null)
            {
                int indexSelect = lstObjetos.SelectedIndex;
                //Elimina el item seleccionado por medio de su index.
                listaSupermercado.RemoveAt(indexSelect);
                this.SerializarListaSupermercado();
                this.ActualizarListaSupermercado();
            }
            else
            {
                MessageBox.Show("Seleccione un elemento.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion FormObjeto = new FrmAltaModificacion("Modificar objeto", (string)lstObjetos.SelectedItem, "Modificar");
            if (lstObjetos.SelectedItem != null)
            {
                
                int indexSelect = lstObjetos.SelectedIndex;
                FormObjeto.ShowDialog();
                
                if(FormObjeto.DialogResult == DialogResult.OK)
                {
                    listaSupermercado[indexSelect] = FormObjeto.Objeto;
                    this.SerializarListaSupermercado();
                    this.ActualizarListaSupermercado();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un elemento de la lista.");
            }
        }

        private void ActualizarListaSupermercado()
        {
            lstObjetos.DataSource = null;
            lstObjetos.DataSource = listaSupermercado;
        }

        private void SerializarListaSupermercado()
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(this.dataPath + @"\listaSupermercado.xml", Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<string>)));
                    ser.Serialize(writer, listaSupermercado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.StackTrace}");
            }
        }
    }
}
