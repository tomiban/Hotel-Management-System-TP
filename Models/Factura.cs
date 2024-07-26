using MemoryPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Models
{
    [MemoryPackable]
    public partial class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdReserva { get; set; }
        public Reserva Reserva { get; set; }
        public double MontoTotal
        {
            get
            {
                return Reserva.Habitacion.PrecioPorNoche * Reserva.CantidadNoches;
            }
        }
    }
}
