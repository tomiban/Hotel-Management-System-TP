using Domain.Entities;
using PresentationLayer.Views;

namespace PresentationLayer.Presenters
{
    public interface IDetallesReservaPresenter
    {
        IDetallesReservaView GetDetallesReservaView();
        void SetEditMode(Reserva reserva);
        event EventHandler OnReservaModificada;
    }
}