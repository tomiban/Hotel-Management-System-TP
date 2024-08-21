using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;
using MemoryPack;

namespace Domain.Entities
{
    [MemoryPackable]
    public partial class Reserva : IReserva
    {
        private int _contadorId;
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es requerida.")]
        [DataType(DataType.Date, ErrorMessage = "La fecha de inicio debe ser una fecha válida.")]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "La fecha de fin es requerida.")]
        [DataType(DataType.Date, ErrorMessage = "La fecha de fin debe ser una fecha válida.")]
        public DateTime FechaFin { get; set; }

        [Required(ErrorMessage = "El ID de la habitación es requerido.")]
        public int IdHabitacion { get; set; }

        [Required(ErrorMessage = "La habitación es requerida.")]
        public Habitacion Habitacion { get; set; }

        [Required(ErrorMessage = "El ID del usuario es requerido.")]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "El usuario es requerido.")]
        public Usuario Usuario { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La cantidad de noches debe ser al menos 1.")]
        public int CantidadNoches { get; set; }

        public Reserva()
        {
            _contadorId++;
            Id = _contadorId;
        }
    }
}
