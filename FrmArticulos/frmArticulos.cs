using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Acceso_a_Datos;

namespace FrmArticulos
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public frmArticulos()
        {
            InitializeComponent();
        }

        

      

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Precio");
        }

        private void cargar()
        {
            ArticuloDatos datos = new ArticuloDatos();
            try
            {
                listaArticulos = datos.listar();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulos.Load(imagen);
            }
            catch (Exception )
            {

                pbxArticulos.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
          

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulos alta = new frmAltaArticulos();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
             Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulos modificar = new frmAltaArticulos(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();
            Articulo seleccionado;
            try
            {
               DialogResult respuesta = MessageBox.Show("¿De verdad queres eliminarlo?","Eliminando", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {

                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                datos.eliminar(seleccionado.Id);
                cargar();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Marca.Descripcion.ToLower().Contains(filtro.ToLower()));

            }
            else
            {
                listaFiltrada = listaArticulos;
            }


            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if(opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("igual a");


            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");

            }

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {

            ArticuloDatos datos = new ArticuloDatos();  
            try
            {

            string campo = cboCampo.SelectedItem.ToString();
            string criterio = cboCriterio.SelectedItem.ToString();
            string filtro = txtFiltroDb.Text;
            dgvArticulos.DataSource = datos.filtrar(campo, criterio,filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
