
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IReserva
    {
        int Id { get; set; }
        DateTime FechaInicio { get; set; }
        DateTime FechaFin { get; set; }
        int NroHabitacion { get; set; }
        int UserId { get; set; }
        string Username { get; set; }
        public int DiasDeEstadia { get; }
        public Decimal MontoTotal { get; }
    }
}