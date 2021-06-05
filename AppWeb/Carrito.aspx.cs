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
        public List<int> listaID;
        int id;
        int bandera;
        public List<Articulos> listaCarrito = new List<Articulos>();
        public List<Articulos> listaArticulos;


        protected void Page_Load(object sender, EventArgs e)
        {
            listaArticulos = (List<Articulos>)Session["listaArticulos"];
            listaID = (List<int>)Session["listaID"];

            if (listaID==null)
            {
                listaID = new List<int>(); 
            }   

            if(Request.QueryString["ban"]== null)
            {
                bandera = 2; 
            }
            else if(int.Parse(Request.QueryString["ban"]) == 3)
            {
                bandera = 3; 
            }
            else
            {
                bandera = 1;   
            }

            if (bandera == 1)
            {
                id = int.Parse(Request.QueryString["id"]);

                if (listaID.Find(x => x == id) == 0)
                {
                    listaID.Add(id);
                    Session.Add("listaID", listaID);    
                }

                actualizarListaCarrito(listaID);

            } 
            else if(bandera == 3)
            {
                id = int.Parse(Request.QueryString["id"]);
                listaID.Remove(id);
                actualizarListaCarrito(listaID);
                Session.Add("listaID", listaID);
                
            } 
            else if (bandera == 2)
            {
                actualizarListaCarrito(listaID);
            }

            
        } 

        public void actualizarListaCarrito(List<int> listaID)
        {
            foreach(int item in listaID)
            {
                listaCarrito.Add(listaArticulos.Find(articulo=> articulo.ID == item));  
               
            }
        }
    }
}