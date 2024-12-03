using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {
        public class Itinerario
        {
            private int horaInicio;
            private int horaFin;
            private string detalle;
            private string responsable;
            private string requisitosPrevios;
            private List<Actividad> actividades;

            public int HoraInicio { get => horaInicio; set => horaInicio = value; }
            public int HoraFin { get => horaFin; set => horaFin = value; }
            public string Detalle { get => detalle; set => detalle = value; }
            public string Responsable { get => responsable; set => responsable = value; }
            public string RequisitosPrevios { get => requisitosPrevios; set => requisitosPrevios = value; }
            public List<Actividad> Actividades { get => actividades; set => actividades = value; }

            public Itinerario(int horaInicio, int horaFin, string detalle,
            string responsable, string requisitosPrevios)
            {
                this.horaFin = horaFin;
                this.horaInicio = horaInicio;
                this.detalle = detalle;
                this.responsable = responsable;
                this.requisitosPrevios = requisitosPrevios;
                actividades = new List<Actividad>();

            }

            public void AgregarActividad(Actividad actividad)
            {
                actividades.Add(actividad);
            }
        }
    }
}
