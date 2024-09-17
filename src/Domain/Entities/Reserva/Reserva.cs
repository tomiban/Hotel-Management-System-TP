using System;
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

        [Required(ErrorMessage = "El ID del usuario es requerido.")]
        public int IdUsuario { get; set; }
        public string Username { get; set; }
        public Habitacion Habitacion { get; set; }

        public Reserva()
        {
            Id = ++_contadorId;
        }

        public int DiasDeEstadia
        {
            get
            {
                if (FechaFin < FechaInicio)
                {
                    throw new InvalidOperationException("La fecha de fin no puede ser anterior a la fecha de inicio.");
                }
                return (FechaFin - FechaInicio).Days;
            }
        }
    }
}
