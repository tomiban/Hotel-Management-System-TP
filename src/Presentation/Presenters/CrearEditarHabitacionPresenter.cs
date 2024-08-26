using Domain.Interfaces;
using Presentation.Views;


namespace Presentation.Presenters
{
    public class CrearEditarHabitacionPresenter
    {
        private readonly ICrearEditarHabitacion _view;
        private readonly IHabitacionRepository _habitacionRepository;

        public CrearEditarHabitacionPresenter(ICrearEditarHabitacion view, IHabitacionRepository habitacionRepository)
        {
            _view = view;
            _habitacionRepository = habitacionRepository;
        }

    }
}
