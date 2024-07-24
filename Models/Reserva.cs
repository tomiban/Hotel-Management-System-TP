using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryPack;

namespace GestionHotelWinForms.Models
{
    [MemoryPackable]
    public partial class Reserva
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IdHabitacion { get; set; }
        public Habitacion Habitacion { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public int CantidadPersonas { get; set; }
        public int CantidadNoches { get; set; }


    }
}
