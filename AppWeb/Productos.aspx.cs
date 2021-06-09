using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios;
using Dominio;

namespace AppWeb
{
    public partial class Productos : System.Web.UI.Page
    {
        public List<Articulos> lista; 
        public string noImage = "https://upload.wikimedia.org/wikipedia/commons/1/14/No_Image_Available.jpg";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["filter"] == null)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                try
                {
                    lista = negocio.listar();
                    Session.Add("listaArticulos", lista);
                }
                catch (Exception ex)
                {

                    Session.Add("error", ex.Message.ToString());
                    Response.Redirect("PaginaError.aspx");

                }

            }

            else if (bool.Parse(Request.QueryString["filter"]) == true)
            {
                lista = (List<Articulos>)Session["listaFiltrada"];
            }

        }
        public bool imageError(string image)
        {
            if (!(image.Contains("https:/")) || image == null)
            {
                return true;
            }
            else return false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string filtro = TextBox1.Text;
            List<Articulos> listaArticulos = (List<Articulos>)Session["listaArticulos"];
            List<Articulos> listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()));
            Session.Add("listaFiltrada", listaFiltrada);
            Response.Redirect("Productos.aspx?filter=true");

        }
    }
}