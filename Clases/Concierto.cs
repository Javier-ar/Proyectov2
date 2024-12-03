using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {
        public class Concierto : Evento 
        {
            private string generoMusical;
            private int duracionEstimada;

            public string GeneroMusical { get => generoMusical; set => generoMusical = value; }
            public int DuracionEstimada { get => duracionEstimada; set => duracionEstimada = value; }


            public Concierto(int duracionEstimada, string generoMusical, int idEvento, double costo, string nombre,
            DateTime fecha, tipo_estado tipo) : base(idEvento,costo,nombre,fecha,tipo)
            {
                this.duracionEstimada = duracionEstimada;
                this.generoMusical = generoMusical;

            }
            public void MostrarElementosProhibidos()
            {
                Console.WriteLine("Los articulos prohibidos son: Armas blancas y de fuego, botellas, bebidas alcoholicas, drogas.");
            }
            public  void MostrarDetalles()
            {
                Console.WriteLine($"Concierto: tendrá una duración de {duracionEstimada} y el genero musical que se tocará es: {generoMusical}");
            }
        }
    }
}
