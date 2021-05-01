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
    public partial class frmModificar : Form
    {
        int id;
        public frmModificar(Articulos articulo)
        {
            InitializeComponent();
            NegocioMarca negocioMarca = new NegocioMarca();
            NegocioCategoria negocioCategoria = new NegocioCategoria();
            try
            {
                id = articulo.ID;
                ModificarCodigo.Text = articulo.Codigo;
                ModificarNombre.Text = articulo.Nombre;
                ModificarDescripción.Text = articulo.Descripcion;
                ModificarPrecio.Text = articulo.Precio.ToString();
                ModificarURL.Text = articulo.imagenURL;
                ModificarMarca.DataSource = negocioMarca.ListaMarca();
                ModificarMarca.ValueMember = "ID";
                ModificarMarca.DisplayMember = "Descripcion";
                ModificarMarca.SelectedValue = articulo.Marca.ID;
                ModificarCategoria.DataSource = negocioCategoria.ListaCategoria();
                ModificarCategoria.ValueMember = "ID";
                ModificarCategoria.DisplayMember = "Descripcion";
                ModificarCategoria.SelectedValue = articulo.Categoria.ID;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }            
            

        }

        private void ModificarPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
                errorProviderM.SetError(ModificarPrecio, "El precio debe ser un número");
            }
        }

        private void btnCancelarM_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulos articulo = new Articulos();
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                articulo.ID = id;
                articulo.Codigo = ModificarCodigo.Text;
                articulo.Nombre = ModificarNombre.Text;
                articulo.Descripcion = ModificarDescripción.Text;
                articulo.Precio = decimal.Parse(ModificarPrecio.Text);
                articulo.imagenURL = ModificarURL.Text;
                articulo.Marca = (Marca)ModificarMarca.SelectedItem;
                articulo.Categoria = (Categorias)ModificarCategoria.SelectedItem;
                articuloNegocio.ModificarArticulo(articulo);
                MessageBox.Show("¡Modificado con éxito!", "Modificar", MessageBoxButtons.OK);
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
