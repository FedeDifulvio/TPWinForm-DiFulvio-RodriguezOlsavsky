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
            if (validaciones()){

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

       public bool validaciones() 
       {

            if (AgregarCodigo.Text == "")
            {
                errorProvider1.SetError(AgregarCodigo, "falta agregar el codigo");
                return false;
            } 

            if (AgregarNombre.Text == "")
            {
                errorProvider1.SetError(AgregarNombre, "falta agregar el nombre");
                return false; 
            }


            if (AgregarDescripción.Text == "")
            {
                errorProvider1.SetError(AgregarDescripción, "falta agregar el codigo");
                return false;
            }

            if (AgregarURL.Text == "")
            {
                errorProvider1.SetError(AgregarURL, "falta agregar el URL de la imagen");
                return false;
            }

            return true; 

        }

        private void AgregarPrecio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void AgregarPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
                errorProvider1.SetError(AgregarPrecio, "El precio debe ser un número");
            }

        }

        private void AgregarCodigo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void AgregarNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void AgregarDescripción_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void AgregarURL_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
