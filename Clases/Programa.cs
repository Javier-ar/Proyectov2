using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {
        public class Programa
        {
            private int idPrograma;
            private string nombre_programa = string.Empty;
            private DateTime fecha_creacion;
            private List<Itinerario> itinerarios = new List<Itinerario>();
            private List<Evento> eventos = new List<Evento>();

            public int IdPrograma { get => idPrograma; set => idPrograma = value; }
            public string Nombre_programa { get => nombre_programa; set => nombre_programa = value; }
            public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
            public List<Evento> Eventos { get => eventos; set => eventos = value; }
            internal List<Itinerario> Itinerarios { get => itinerarios; set => itinerarios = value; }

            public Programa(int idPrograma, string nombre_programa, DateTime fecha_creacion)
            {
                this.idPrograma = idPrograma;
                this.nombre_programa = nombre_programa;
                this.fecha_creacion = fecha_creacion;
                eventos = new List<Evento>();
                itinerarios = new List<Itinerario>();
            }
            public void AgregarItinerario(Itinerario itinerario)
            {
                itinerarios.Add(itinerario);
            }
            public void MostrarItinerario()
            {
                Console.WriteLine($"Programa: {nombre_programa}. id: {idPrograma}");
                Console.WriteLine("Itinerarios: ");
                foreach (var itinerario in itinerarios)
                {
                    Console.WriteLine($"{itinerario.HoraInicio} - {itinerario.HoraFin}. Descripción: {itinerario.Detalle}. Responsable: {itinerario.Responsable}");
                }
            }
            public void AgregarEvento(Evento evento)
            {
                eventos.Add(evento);
            }
        }
    }
}
