using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Personas
    {
        public class Sistema_Comercial
        {
            private string responsable = string.Empty;
            private List<Cliente> clientes;

            public string Responsable { get => responsable; set => responsable = value; }
            public List<Cliente> Clientes { get => clientes; set => clientes = value; }

            public Sistema_Comercial()
            {

            }
            public Sistema_Comercial(string responsable)
            {
                this.responsable = responsable;
                Clientes = new List<Cliente>();
            }
            public void IngresarCliente(Cliente cliente)
            {
                Clientes.Add(cliente);
                Console.WriteLine("Cliente ingresado con exito");
            }
            public void ModificarCliente(int idCliente, int presupuesto, int rut, int verificador, string nombre, int telefono,
                string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento)
            {
                var cliente = Clientes.FirstOrDefault(e => e.IdCliente == idCliente);
                if (cliente != null)
                {
                    cliente.Presupuesto = presupuesto;
                    cliente.Rut = rut;
                    cliente.Verificador = verificador;
                    cliente.Nombre = nombre;
                    cliente.Telefono = telefono;
                    cliente.ApellidoPaterno = apellidoPaterno;
                    cliente.ApellidoMaterno = apellidoMaterno;
                    cliente.FechaNacimiento = fechaNacimiento;
                }
                else
                {
                    Console.WriteLine("Cliente no encontrado.");
                }
            }
            public void EliminarCliente(int idCliente)
            {
                var cliente= Clientes.FirstOrDefault(e => e.IdCliente == idCliente);
                if (cliente != null)
                {
                    Clientes.Remove(cliente);
                    Console.WriteLine($"El Cliente {cliente.Nombre} ha sido eliminado");
                }
                else
                {
                    Console.WriteLine("Cliente no encontrado.");
                }
            }
        }
    }
}
