using Acceso_a_Datos;
using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmArticulos
{
    public partial class frmAltaArticulos : Form
    {
        private Articulo articulo = null;   
        private OpenFileDialog archivo = null;
        public frmAltaArticulos()
        {
            InitializeComponent();
        }

        public frmAltaArticulos(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloDatos datos = new ArticuloDatos();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.CodigoArticulo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.ImagenUrl = txtImagenUrl.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if(articulo.id != 0)
                {
                   // datos.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    datos.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");

                }

                Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
