
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IReserva
    {
        int Id { get; set; }
        int CantidadNoches { get; set; }
        DateTime FechaFin { get; set; }
        DateTime FechaInicio { get; set; }
        int IdHabitacion { get; set; }
        Habitacion Habitacion { get; set; }
        int IdUsuario { get; set; }
        Usuario Usuario { get; set; }
    }
}