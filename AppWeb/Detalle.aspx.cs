using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocios;

namespace AppWeb
{
    public partial class Detalle : System.Web.UI.Page
    {
        public Articulos detalle;
        public string noImage = "https://upload.wikimedia.org/wikipedia/commons/1/14/No_Image_Available.jpg";
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            List<Articulos> articulos = (List<Articulos>)Session["lista"];
            detalle = articulos.Find(x => x.ID == id);
        }

        public bool imageError(string image)
        {
            if (!(image.Contains("https:/")) || image == null)
            {
                return true;
            }
            else return false;
        }
    }
}