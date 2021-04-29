using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocios
{
    public class NegocioMarca
    {
       public List<Marca> ListaMarca()
        {
            List<Marca> ListaMarca = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            string consulta = "select id, Descripcion from Marcas";

            try
            {
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read()) {
                    
                    int id = (int)datos.Lector["id"];
                    string Descripcion = (string)datos.Lector["Descripcion"];
                    ListaMarca.Add(new Marca(id, Descripcion));
                }
                return ListaMarca;
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
