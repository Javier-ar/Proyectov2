using Avalonia.Controls;
using Avalonia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {
        public class Actividad
        {
            private string nombre;
            private string descripcion;
            private int duracion;
            private int orden;

            public string Nombre { get => nombre; set => nombre = value; }
            public string Descripcion { get => descripcion; set => descripcion = value; }
            public int Duracion { get => duracion; set => duracion = value; }
            public int Orden { get => orden; set => orden = value; }

            public Actividad(string nombre, string descripcion,
            int duracion, int orden)
            {
                this.nombre = nombre;
                this.descripcion = descripcion;
                this.duracion = duracion;
                this.orden = orden;
            }
        }
    }
}
