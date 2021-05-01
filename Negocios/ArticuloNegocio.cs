using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocios
{
    public class ArticuloNegocio 
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            string consulta = "select A.id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, M.ID MarcaID, C.Descripcion Categorias, C.ID CategoriaID, A.ImagenUrl, A.Precio from Articulos A inner join Categorias C on A.IdCategoria = C.Id inner join Marcas M on M.Id = A.IdMarca ";


            try
            {
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulos articulo = new Articulos();
                    articulo.ID = (int)datos.Lector["id"];
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    articulo.imagenURL = (string)datos.Lector["ImagenUrl"];
                    articulo.Precio = (decimal)datos.Lector["Precio"];
                    articulo.Marca = new Marca((int)datos.Lector["MarcaID"], (string)datos.Lector["Marca"]);
                    articulo.Categoria = new Categorias((int)datos.Lector["CategoriaID"], (string)datos.Lector["Categorias"]);

                    lista.Add(articulo);

                }
                return lista;

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

        public void AgregarArticulo(Articulos articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            string consulta = "Insert into Articulos (codigo, nombre, descripcion, idmarca, idcategoria, imagenURL, precio) " +
            "values ('" + articulo.Codigo + "', '"+ articulo.Nombre +"', '"+ articulo.Descripcion +"',"+ articulo.Marca.ID +"," +
            " "+ articulo.Categoria.ID +", '"+ articulo.imagenURL +"', "+ articulo.Precio +")";

            try
            {
                datos.setearConsulta(consulta);
                datos.ejecutarAccion();
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
    
        public void EliminarArticulo(string id)
        {
            AccesoDatos datos = new AccesoDatos();
            string consulta = "DELETE from Articulos where id="+ id;

            try
            {
                datos.setearConsulta(consulta);
                datos.ejecutarAccion();
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
