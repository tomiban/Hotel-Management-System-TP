using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace ApplicationLayer.Services
{
    public interface IReservaService
    {
        void AgregarReserva(Reserva reserva);
        ICollection<ValidationResult> ValidateModel(Reserva reserva);
    }
}