using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio; 

namespace AppWeb
{
    public partial class Carrito : System.Web.UI.Page
    {

        public decimal PrecioFinal = 0;
        bool carritoVacio = false;
        public List<Articulos> listaCarrito;
        public List<Articulos> listaArticulos;


        protected void Page_Load(object sender, EventArgs e)
        {
            listaArticulos = (List<Articulos>)Session["listaArticulos"];
            listaCarrito = (List<Articulos>)Session["listaCarrito"];

            if (listaCarrito == null)
            {
                listaCarrito = new List<Articulos>();
            }

            if (Request.QueryString["ban"] == null)
            {
                verificarCarritoVacio();
            }
            else if (int.Parse(Request.QueryString["ban"]) == 3)
            {
                eliminarDelCarrito();
            }
            else if (int.Parse(Request.QueryString["ban"]) == 4)
            {
                sumarCantidadArticulo();
            }
            else if (int.Parse(Request.QueryString["ban"]) == 1)
            {
                agregarAlCarrito();
            }

            if (carritoVacio)
            {
                Response.Redirect("carritoVacio.aspx");
            }


        }



        public void agregarAlCarrito()
        {
            int id = int.Parse(Request.QueryString["id"]);

            if (listaCarrito.Find(x => x.ID == id) == null)
            {
                listaCarrito.Add(listaArticulos.Find(articulo => articulo.ID == id));
                Session.Add("listaCarrito", listaCarrito);
            }
            carritoVacio = false;
        }

        public void eliminarDelCarrito()
        {

            int id = int.Parse(Request.QueryString["id"]);
            Articulos eliminado = listaCarrito.Find(articulo => articulo.ID == id);
            listaCarrito.Remove(eliminado);
            // Session.Add("listaCarrito", listaCarrito);

            verificarCarritoVacio();
        }

        public void sumarCantidadArticulo()
        {
            int idModificado = int.Parse(Request.QueryString["id"]);
            Articulos Modificado = listaCarrito.Find(articulo => articulo.ID == idModificado);

            int index = listaCarrito.IndexOf(Modificado);

            listaCarrito.RemoveAt(index);
            Modificado.Cantidad++;
            listaCarrito.Insert(index, Modificado);
            //  Session.Add("listaCarrito", listaCarrito);
        }

        public void verificarCarritoVacio()
        {
            if (listaCarrito.Count == 0)
            {
                carritoVacio = true;
            }
        }

    }

}