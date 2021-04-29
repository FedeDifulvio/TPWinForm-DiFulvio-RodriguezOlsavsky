using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocios
{
    public class NegocioCategoria
    {
        public List<Categorias> ListaCategoria()
        {
            List<Categorias> ListaCategoria = new List<Categorias>();
            AccesoDatos datos = new AccesoDatos();
            string consulta = "select id, Descripcion from Categorias";

            try
            {
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    int id = (int)datos.Lector["id"];
                    string Descripcion = (string)datos.Lector["Descripcion"];
                    ListaCategoria.Add(new Categorias(id, Descripcion));
                }
                return ListaCategoria;
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                datos.cerrarConexion();
            }

        }
    }
}

