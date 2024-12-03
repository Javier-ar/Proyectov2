using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Compras
    {
        public  class Entrada
        {
            private double precio;

            public double Precio { get => precio; set => precio = value; }

            public Entrada(double precio)
            {
                this.precio = precio;
            }
        }
    }
}
