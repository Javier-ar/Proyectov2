using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    namespace Proyecto.Eventos
    {
        internal class Graduacion : Evento
        {
            private string institucion;
            private int promocion;
            private int numeroEgresados;
            private string ubicacionInstitucion;

            public string Institucion { get => institucion; set => institucion = value; }
            public int Promocion { get => promocion; set => promocion = value; }
            public int NumeroEgresados { get => numeroEgresados; set => numeroEgresados = value; }
            public string UbicacionInstitucion { get => ubicacionInstitucion; set => ubicacionInstitucion = value; }

            public Graduacion(string institucion, string ubicacionInstitucion,
            int promocion, int numeroEgresados, bool catering, int idEvento, string nombre, DateTime fecha, 
            double costo, tipo_estado tipo_e) : base(idEvento, costo, nombre, fecha, tipo_e)
            {
                this.institucion = institucion;
                this.ubicacionInstitucion = ubicacionInstitucion;
                this.promocion = promocion;
                this.numeroEgresados = numeroEgresados;

            }
            public void MostrarDetalles()
            {
                Console.WriteLine($"En esta graduación de la institucion {institucion} ubicada en {ubicacionInstitucion} la promoción del {promocion} complace anunciar que {numeroEgresados} terminaran su etapa!");
            }
        }
    }
}
