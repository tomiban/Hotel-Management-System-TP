using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace ApplicationLayer.Services
{
    public interface IReservaService
    {
        void AgregarReserva(Reserva reserva);
        List<Reserva> GetAll(int id);
        Reserva GetById(int id);
        void ActualizarReserva(Reserva reserva);
        void CancelarReserva(int id);
        ICollection<ValidationResult> ValidateModel(Reserva reserva);
        bool VerificarDisponibilidadHabitacion(int nroHabitacion, DateTime fechaInicio, DateTime fechaFin);
    }
}