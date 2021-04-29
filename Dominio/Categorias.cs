using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categorias
    {

        public int ID { get; set; }
        public string Descripcion { get; set; }

        public Categorias(string descripcion)
        {
            Descripcion = descripcion; 
        }

        public Categorias(int id, string descripcion)
        {
            ID = id;
            Descripcion = descripcion;
        }
        public override string ToString()
        {
            return Descripcion; 
        }
    }
}
