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
        public frmModificar(Dominio.Articulos articulo)
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
            if (validaciones())
            {
                try
                {
                    Dominio.Articulos articulo = new Dominio.Articulos();
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

        public bool validaciones()
        {

            if (ModificarCodigo.Text == "")
            {
                errorProviderM.SetError(ModificarCodigo, "falta agregar el codigo");
                return false;
            }

            if (ModificarNombre.Text == "")
            {
                errorProviderM.SetError(ModificarNombre, "falta agregar el nombre");
                return false;
            }


            if (ModificarDescripción.Text == "")
            {
                errorProviderM.SetError(ModificarDescripción, "falta agregar el codigo");
                return false;
            }

            if (ModificarPrecio.Text == "")
            {
                errorProviderM.SetError(ModificarPrecio, "falta agregar el Precio");
                return false;
            }

            if (ModificarURL.Text == "")
            {
                errorProviderM.SetError(ModificarURL, "falta agregar el URL de la imagen");
                return false;
            }

            return true;

        }

        private void ModificarCodigo_TextChanged(object sender, EventArgs e)
        {
            errorProviderM.Clear();
        }

        private void ModificarNombre_TextChanged(object sender, EventArgs e)
        {
            errorProviderM.Clear();
        }

        private void ModificarDescripción_TextChanged(object sender, EventArgs e)
        {
            errorProviderM.Clear();
        }

        private void ModificarPrecio_TextChanged(object sender, EventArgs e)
        {
            errorProviderM.Clear();
        }

      

    }
}
