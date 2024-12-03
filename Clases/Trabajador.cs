using Proyecto.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Personas
    {
        public enum tipo_t
        {
            COORDINADOR,
            SERVICIO,
            TECNICO,
            DECORADOR
        }
        public class Trabajador : Persona, ITrabajador
        {
            private int idTrabajador;
            private string afp;
            private double sueldoBruto;
            private double pasaje;
            private double colacion;
            private double descuentoAfp;
            private double salud;
            private tipo_t tipoTrabajador;
            private List<Trabajador> trabajadores = new List<Trabajador>();

            public int IdTrabajador { get => idTrabajador; set => idTrabajador = value; }
            public string Afp { get => afp; set => afp = value; }
            public double SueldoBruto { get => sueldoBruto; set => sueldoBruto = value; }
            public double Pasaje { get => pasaje; set => pasaje = value; }
            public double Colacion { get => colacion; set => colacion = value; }
            public double DescuentoAfp { get => descuentoAfp; set => descuentoAfp = value; }
            public double Salud { get => salud; set => salud = value; }
            public tipo_t TipoTrabajador { get => tipoTrabajador; set => tipoTrabajador = value; }
            public List<Trabajador> Trabajadores { get => trabajadores; set => trabajadores = value; }

            public Trabajador()
            {

            }
            public Trabajador(int idTrabajador, string afp, double sueldoBruto, double pasaje,
                double colacion, double descuentoAfp, double salud, tipo_t tipoTrabajador, int rut, int verificador, 
                string nombre, string apellidoPaterno, string apellidoMaterno, int telefono, DateTime fechaNacimiento) : base (rut, verificador, nombre, apellidoPaterno, apellidoMaterno,telefono, fechaNacimiento)
            {
                this.idTrabajador = idTrabajador;
                this.afp = afp;
                this.sueldoBruto = sueldoBruto;
                this.pasaje = pasaje;
                this.colacion = colacion;
                this.descuentoAfp = descuentoAfp;
                this.salud = salud;
                this.tipoTrabajador = tipoTrabajador;
                trabajadores = new List<Trabajador>();
            }

            public double CalcularSueldo(double sueldoBruto, double pasaje,
            double colacion, double descuentoAfp, double salud)
            {
                double afp, sueldoLiquido, descuentoSalud;
                afp = sueldoBruto * descuentoAfp;
                descuentoSalud = sueldoBruto * salud; 
                sueldoLiquido = sueldoBruto - afp - descuentoSalud + colacion + pasaje;
                return sueldoLiquido;
            
            }

            public void MostrarDetalles(int idTrabajador)
            {
                var trabajador = Trabajadores.FirstOrDefault(e => e.IdTrabajador == idTrabajador);
                if (trabajador != null)
                {
                    Console.WriteLine($"Nombre: {trabajador.Nombre}. Apellido: {trabajador.ApellidoPaterno}. Rut: {trabajador.Rut} - {trabajador.Verificador}");
                }
                else
                {
                    Console.WriteLine("Trabajador no encontrado.");
                }
            }
        }
    }

}
