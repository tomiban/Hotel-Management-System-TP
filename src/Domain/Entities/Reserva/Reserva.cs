using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;
using MemoryPack;

namespace Domain.Entities
{
    [MemoryPackable]
    public partial class Reserva : IReserva
    {
        private static int _contadorId;
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es requerida.")]
        [DataType(DataType.Date, ErrorMessage = "La fecha de inicio debe ser una fecha válida.")]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "La fecha de fin es requerida.")]
        [DataType(DataType.Date, ErrorMessage = "La fecha de fin debe ser una fecha válida.")]
        public DateTime FechaFin { get; set; }

        [Required(ErrorMessage = "El ID de la habitación es requerido.")]
        public int NroHabitacion { get; set; }

        public int UserId { get; set; }

        public string Username { get; set; }

        public decimal PrecioPorNoche { get; set; }

        public int DiasDeEstadia => FechaInicio > FechaFin ? throw new Exception("La fecha de inicio no puede ser posterior a la fecha de fin.") : (int)(FechaFin - FechaInicio).TotalDays;

        public Decimal MontoTotal => DiasDeEstadia * PrecioPorNoche;


        

        public Reserva()
        {
            Id = ++_contadorId; // Incrementar el contador de ID de manera estática
            
        }
    }
}
