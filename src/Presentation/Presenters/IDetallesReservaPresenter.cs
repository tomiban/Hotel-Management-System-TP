using Domain.Entities;
using PresentationLayer.Utils;
using PresentationLayer.Views;

namespace PresentationLayer.Presenters
{
    public interface IDetallesReservaPresenter: IPresenter
    {
        IDetallesReservaView GetDetallesReservaView();
        void SetEditMode(Reserva reserva);
        event EventHandler OnReservaModificada;
    }
}