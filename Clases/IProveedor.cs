using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {
        public interface IProveedor
        {
            public void BuscarProveedorPorNombre(string nombre_ingresado);
            public void CantidadTrabajadoresDisponibles();
            public void MostrarProveedor(int idpro);
        }
    }
}
