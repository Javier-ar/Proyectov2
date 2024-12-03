using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {
        internal class Espacio : IConcierto
        {
            private string ubicacion;
            private int puertas;
            private int salidas;
            private double area;
            private string empresaDuenia;

            public string Ubicacion { get => ubicacion; set => ubicacion = value; }
            public int Puertas { get => puertas; set => puertas = value; }
            public int Salidas { get => salidas; set => salidas = value; }
            public double Area { get => area; set => area = value; }
            public string EmpresaDuenia { get => empresaDuenia; set => empresaDuenia = value; }

            public Espacio(string ubicacion, string empresaDuenia, int puertas, int salidas, double area)
            {
                this.ubicacion = ubicacion;
                this.empresaDuenia = empresaDuenia;
                this.puertas = puertas;
                this.salidas = salidas;
                this.area = area;
            }
            public void RegistrarEspacio(string empresaDuenia, string ubicacion)
            {
                Console.WriteLine($"Se ha registrado una nuevo evento, productor {empresaDuenia} y en la siguiente ubicación {ubicacion}");
            }
            public void ComunicarEvento()
            {
                Console.WriteLine($"Atención! Para todos los oyentes, habrá un gran evento y sus entradas están a la venta, corran!.");
            }
        }
    }
}
