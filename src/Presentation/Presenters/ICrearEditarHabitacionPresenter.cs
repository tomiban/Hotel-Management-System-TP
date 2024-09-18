using Domain.Entities;
using Presentation.Views;

namespace Presentation.Presenters
{
    public interface ICrearEditarHabitacionPresenter
    {
        ICrearEditarHabitacionView GetCrearEditarHabitacionView();
        void OnAdminRedirect(object? sender, EventArgs e);
        void SetEditMode(Habitacion habitacion);
    }
}   