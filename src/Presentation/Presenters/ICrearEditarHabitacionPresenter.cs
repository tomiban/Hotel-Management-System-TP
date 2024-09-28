using Domain.Entities;
using Presentation.Views;
using PresentationLayer.Utils;

namespace Presentation.Presenters
{
    public interface ICrearEditarHabitacionPresenter: IPresenter
    {
        void OnAdminRedirect(object? sender, EventArgs e);
        void SetAddMode();
        void SetEditMode(Habitacion habitacion);
    }
}   