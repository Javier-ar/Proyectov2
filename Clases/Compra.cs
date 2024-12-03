using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Compras
    {
        public class Compra
        {
            private int id;
            private DateTime fecha;
            private List<Entrada> entradas = new List<Entrada>();

            public int Id { get => id; set => id = value; }
            public DateTime Fecha { get => fecha; set => fecha = value; }
            public List<Entrada> Entradas { get => entradas; set => entradas = value; }

            public Compra(int id, DateTime fecha)
            {
                this.id = id;
                this.fecha = fecha;
                entradas = new List<Entrada>();

            }
            public void CompraEntrada(Entrada entrada)
            {
                Entradas.Add(entrada);
            }
        }
    }
}
