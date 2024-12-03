using Proyecto.Proyecto.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {
        public interface IProduccion
        {
            public void ContratarServicio(Evento evento);
            public void ActualizarServicio(int idEvento, string nombre, DateTime fecha, double costo, tipo_estado tipo);
            public void CancelarServicio(int idEvento);
            public double CalcularCostoTotal();
        }
    }
}
