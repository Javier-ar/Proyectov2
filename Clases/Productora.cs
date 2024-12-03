using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {
        public enum tipo_servicio
        {
            AUDIOVISUAL,
            ILUMINACION, 
            LOGISTICA,
            OTROS
        }
        public class Productora : IProduccion
        {
            private string nombre;
            private string representante = string.Empty;
            private int telefono;
            private string email = string.Empty;
            private string direccion = string.Empty;
            private tipo_servicio tipoServicio;
            private double costoServicio;
            private List<Evento> eventos = new List<Evento>();
            public string Nombre { get => nombre; set => nombre = value; }
            public string Representante { get => representante; set => representante = value; }
            public int Telefono { get => telefono; set => telefono = value; }
            public string Email { get => email; set => email = value; }
            public string Direccion { get => direccion; set => direccion = value; }
            public double CostoServicio { get => costoServicio; set => costoServicio = value; }
            internal tipo_servicio TipoServicio { get => tipoServicio; set => tipoServicio = value; }
            public List<Evento> Eventos { get => eventos; set => eventos = value; }

            public Productora(string nombre, string representante, int telefono, string email, string direccion, tipo_servicio tipoServicio, double costoServicio)
            {
               this.nombre = nombre;
               this.representante = representante;
               this.telefono = telefono;
               this.direccion = direccion;
               this.tipoServicio = tipoServicio;
               this.costoServicio = costoServicio;
               Eventos = new List<Evento>();
            }
            public void ContratarServicio(Evento evento)
            {
                Eventos.Add(evento);
                Console.WriteLine($"Servicio para el evento {evento.Nombre} ha sido añadido.");

            }
            public void ActualizarServicio(int idEvento, string nombre, DateTime fecha, double costo, tipo_estado tipo)
            {
                var evento = Eventos.FirstOrDefault(e => e.IdEvento == idEvento);
                if (evento != null)
                {
                    evento.Nombre = nombre;
                    evento.Fecha = fecha;
                    evento.Costo = costo;
                    evento.Tipo_e = tipo;
                }
                else
                {
                    Console.WriteLine("Evento no encontrado.");
                }
            }
            public void CancelarServicio(int idEvento)
            {
                var evento = Eventos.FirstOrDefault(e => e.IdEvento == idEvento);
                if (evento != null)
                {
                    Eventos.Remove(evento);
                    Console.WriteLine($"El servicio para el evento {evento.Nombre} ha sido cancelado");
                }
                else
                {
                    Console.WriteLine("Evento no encontrado.");
                }
            }
            public double CalcularCostoTotal()
            {
                return eventos.Sum(e => e.Costo);
            }
        }
    }       
}

