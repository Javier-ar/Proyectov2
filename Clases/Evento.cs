using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {   
        public enum tipo_estado
        {
            PLANEADO,
            EN_PROGRESO,
            FINALIZADO,
            CANCELADO
        }
        public class Evento
        {
            private int idEvento;
            private string nombre;
            private DateTime fecha;
            private double costo;
            private tipo_estado tipo_e;
            public int IdEvento { get => idEvento; set => idEvento = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public DateTime Fecha { get => fecha; set => fecha = value; }
            public double Costo { get => costo; set => costo = value; }
            public tipo_estado Tipo_e { get => tipo_e; set => tipo_e = value; }

            public Evento()
            {
                this.nombre = string.Empty;
            }
            public Evento(int idEvento, double costo, string nombre,
            DateTime fecha, tipo_estado tipo_e)
            {
                this.idEvento = idEvento;
                this.costo = costo;
                this.nombre = nombre;
                this.fecha = fecha;
                this.tipo_e = tipo_e;
            }

        }
    }
}
