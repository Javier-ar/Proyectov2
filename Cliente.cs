using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Personas
    {
        public class Cliente : Persona
        {
            private int idCliente;
            private int presupuesto;

            public int IdCliente { get => idCliente; set => idCliente = value; }
            public int Presupuesto { get => presupuesto; set => presupuesto = value; }

            public Cliente()
            {

            }
            public Cliente(int idCliente, int presupuesto, int rut, int verificador, string nombre,
                string apellidoPaterno,string apellidoMaterno, int telefono, DateTime fechaNacimiento ) : base (rut, verificador, nombre ,apellidoPaterno, apellidoMaterno, telefono, fechaNacimiento)
            {
                this.idCliente = idCliente;
                this.presupuesto = presupuesto;
            }
            public void MostrarDetalles()
            {
                Console.WriteLine($"Nombre: {this.Nombre}. Apellido: {this.ApellidoPaterno}. Rut: {this.Rut} - {this.Verificador}. Presupuesto: {this.presupuesto}");
            }
        }
    }

}
