using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocios;

namespace Presentacion
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            NegocioMarca negocioMarca = new NegocioMarca();
            NegocioCategoria negocioCategoria = new Negocios.NegocioCategoria();

            try
            {
                AgregarMarca.DataSource = negocioMarca.ListaMarca();
                AgregarCategoria.DataSource = negocioCategoria.ListaCategoria();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelarA_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulos articulo = new Articulos();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                articulo.Codigo = AgregarCodigo.Text;
                articulo.Nombre = AgregarNombre.Text;
                articulo.Descripcion = AgregarDescripción.Text;
                articulo.Precio = decimal.Parse(AgregarPrecio.Text);
                articulo.imagenURL = AgregarURL.Text;
                articulo.Marca = (Marca)AgregarMarca.SelectedItem;
                articulo.Categoria = (Categorias)AgregarCategoria.SelectedItem;

                negocio.AgregarArticulo(articulo);
                MessageBox.Show("Agregado con éxito");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
