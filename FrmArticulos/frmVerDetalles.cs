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
using Acceso_a_Datos;

namespace FrmArticulos
{
    public partial class frmVerDetalles : Form
    {
        private Articulo articulo = null;
        public frmVerDetalles()
        {
            InitializeComponent();
        }

        public frmVerDetalles(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalle Articulo";

        }

        private void frmVerDetalles_Load(object sender, EventArgs e)
        {
            if (articulo != null)
            {
                lblVerDescripcion.Text = articulo.Descripcion;
                lblVerMarca.Text = articulo.Marca.Descripcion;
                lblVerCategoria.Text = articulo.Categoria.Descripcion;


            }
        }
    }
}
