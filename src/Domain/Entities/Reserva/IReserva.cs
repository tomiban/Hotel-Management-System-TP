
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IReserva
    {
        int Id { get; set; }
        DateTime FechaInicio { get; set; }
        DateTime FechaFin { get; set; }
        int NroHabitacion { get; set; }
        int IdUsuario { get; set; }
        string Username { get; set; }
     
    }
}