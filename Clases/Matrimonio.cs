using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Proyecto
{
    namespace Proyecto.Eventos
    {
        public enum matri_tipo
        {
            CLASICO,
            VINTAGE,
            MODERNO,
            MONOCROMATICO,
            COLORIDO
        }
        public class Matrimonio : Evento
        {
            private int numeroInvitados;
            private string novio;
            private string novia;
            private string ubicacionCeremonia;
            private matri_tipo tipo_matri;
            public int NumeroInvitados { get => numeroInvitados; set => numeroInvitados = value; }
            public string Novio { get => novio; set => novio = value; }
            public string Novia { get => novia; set => novia = value; }
            public string UbicacionCeremonia { get => ubicacionCeremonia; set => ubicacionCeremonia = value; }
            public matri_tipo Tipo_matri { get => tipo_matri; set => tipo_matri = value; }

            public Matrimonio(int numeroInvitados, string novio, string novia, string ubicacionCeremonia, 
                matri_tipo tipo_matri, int idEvento, string nombre, DateTime fecha, double costo, tipo_estado tipo_e) : base(idEvento,costo,nombre,fecha,tipo_e)
            {
                this.numeroInvitados = numeroInvitados;
                this.novio = novio;
                this.novia = novia;
                this.ubicacionCeremonia = ubicacionCeremonia;
                this.tipo_matri = tipo_matri;
            }

            public void MostrarDetalles()
            {
                Console.WriteLine($"Novio y Novia: {novio} {novia}. invitados: {numeroInvitados}. ubicación de la ceremonia: {ubicacionCeremonia}. tipo matrimonio: {tipo_matri}. ");
            }
        }

    }
}
