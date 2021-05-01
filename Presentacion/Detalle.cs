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

namespace Presentacion
{
    public partial class Detalle : Form
    {
        public Detalle(Dominio.Articulos articulo)
        {
            InitializeComponent();
            detalleCodigo.Text = articulo.Codigo;
            detalleNombre.Text = articulo.Nombre;
            detalleDescripción.Text = articulo.Descripcion;
            detallePrecio.Text = articulo.Precio.ToString();
            detalleMarca.Text = articulo.Marca.Descripcion;
            detalleCategoria.Text = articulo.Categoria.Descripcion; 
        }

        private void detalleSalir_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
