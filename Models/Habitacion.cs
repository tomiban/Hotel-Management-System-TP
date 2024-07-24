using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryPack;

namespace GestionHotelWinForms.Models
{

    [MemoryPackable]
    public partial class Habitacion
    {

        public int Id { get; set; }
        public int NroHabitacion { get; set; }
        public TipoHabitacion TipoHabitacion { get; set; }
        public bool Disponible { get; set; }
        public int PrecioPorNoche { get; set; }
    }

    public enum TipoHabitacion
    {
        Premium,
        Standard,
        Economic
    }
}
