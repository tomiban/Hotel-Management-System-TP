using Domain.Entities;
using PresentationLayer.Utils;
using PresentationLayer.Views;

namespace PresentationLayer.Presenters
{
    public interface IDetallesReservaPresenter: IPresenter
    {
        void SetEditMode(Reserva reserva);
        event EventHandler OnReservaModificada;
    }
}