using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace ApplicationLayer.Services
{
    public interface IReservaService
    {
        void AgregarReserva(Reserva reserva);
        List<Reserva> GetAll(int id);
        ICollection<ValidationResult> ValidateModel(Reserva reserva);
        bool VerificarDisponibilidadHabitacion(int nroHabitacion, DateTime fechaInicio, DateTime fechaFin);
    }
}