using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Personas
    {
        public class Sistema_RRHH
        {
            private string encargado = string.Empty;
            private List<Trabajador> trabajadores;

            public string Encargado { get => encargado; set => encargado = value; }
            public List<Trabajador> Trabajadores{ get => trabajadores; set => trabajadores = value; }

            public Sistema_RRHH(string responsable)
            {
                this.encargado = responsable;
                trabajadores = new List<Trabajador>();
            }
            public void IngresarTrabajador(Trabajador trabajador)
            {
                Trabajadores.Add(trabajador);
                Console.WriteLine("Trabajador ingresado con exito");
            }
            public void ModificarTrabajador(int idTrabajador, string afp, double sueldoBruto, double pasaje,
                double colacion, tipo_t tipoTrabajador, int rut, int verificador,
                string nombre, int telefono, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento)
            {
                var trabajador = Trabajadores.FirstOrDefault(e => e.IdTrabajador == idTrabajador);
                if (trabajador != null)
                {
                    trabajador.Afp = afp;
                    trabajador.SueldoBruto = sueldoBruto;
                    trabajador.Pasaje = pasaje;
                    trabajador.Colacion = colacion;
                    trabajador.TipoTrabajador = tipoTrabajador;
                    trabajador.Rut = rut;
                    trabajador.Verificador = verificador;
                    trabajador.Nombre = nombre;
                    trabajador.Telefono = telefono;
                    trabajador.ApellidoPaterno = apellidoPaterno;
                    trabajador.ApellidoMaterno = apellidoMaterno;
                    trabajador.FechaNacimiento = fechaNacimiento;
                }
                else
                {
                    Console.WriteLine("Trabajador no encontrado.");
                }
            }
            public void EliminarCliente(int idTrabajador)
            {
                var trabajador = Trabajadores.FirstOrDefault(e => e.IdTrabajador == idTrabajador);
                if (trabajador != null)
                {
                    Trabajadores.Remove(trabajador);
                    Console.WriteLine($"El Trabajador {trabajador.Nombre} ha sido eliminado");
                }
                else
                {
                    Console.WriteLine("Trabajador no encontrado.");
                }
            }
        }
    }
}
