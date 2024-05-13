using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominios
{
   public class Elemento
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }
        //se crea la prop. elemento para modelar el formulario con su tipo.

        public override string ToString()
        //tenemos que decirle que tiene que mostrar.
        {
            return Descripcion;
        }

    }
}
