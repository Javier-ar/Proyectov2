using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    public interface ITrabajador
    {
        public double CalcularSueldo(double sueldoBruto, double pasaje,
            double colacion, double descuentoAfp, double salud);
        public void MostrarDetalles(int idTrabajador);

    }

}
