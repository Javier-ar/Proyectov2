using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {
        public enum tipo_proveedor
        {
            MUSICA,
            CATERING,
            SEGURIDAD,
            INFRAESTRUCTURA
        }
        public class Proveedor : IProveedor
        {
            private int idProveedor;
            private string nombre;
            private string servicio;
            private int cantidadTrabajadores;
            private tipo_proveedor tipo_proveedor;

            public int IdProveedor { get => idProveedor; set => idProveedor = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Servicio { get => servicio; set => servicio = value; }
            public int CantidadTrabajadores { get => cantidadTrabajadores; set => cantidadTrabajadores = value; }
            internal tipo_proveedor Tipo_proveedor { get => tipo_proveedor; set => tipo_proveedor = value; }

            public Proveedor(int idProveedor, string nombre, string servicio,
            int cantidadTrabajadores, tipo_proveedor tipo_proveedor)
            {
                this.idProveedor = idProveedor;
                this.nombre = nombre;
                this.servicio = servicio;
                this.cantidadTrabajadores = cantidadTrabajadores;
                this.tipo_proveedor = tipo_proveedor;
            }

            public void BuscarProveedorPorNombre(string nombre_ingresado)
            {
                if (nombre_ingresado == nombre)
                {
                    Console.WriteLine($"El proveedor {nombre} existe en el registro. Servicio: {servicio}");
                }
                else
                {
                    Console.WriteLine($"Proveedor no encontrado");
                }
            }
            public void CantidadTrabajadoresDisponibles()
            {
                Console.WriteLine($"Esta empresa cuenta con la cantidad de {cantidadTrabajadores} trabajadores.");
            }
            public void MostrarProveedor(int idpro)
            { 
                if(idpro == idProveedor)
                {
                    Console.WriteLine($"El proveedor {nombre} se encarga de {servicio}");
                }
                else
                {
                    Console.WriteLine($"Proveedor no encontrado");
                }
            }
        }
    }
}
