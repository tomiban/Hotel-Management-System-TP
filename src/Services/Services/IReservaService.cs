using Domain.Entities;

namespace ApplicationLayer.Services
{
    public interface IReservaService
    {
        void AgregarReserva(Reserva reserva);
        void ValidateModel(Reserva reserva);
    }
}