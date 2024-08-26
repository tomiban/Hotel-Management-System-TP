using Domain.Entities;
using Domain.Interfaces;
using Presentation.Views;
using Unity;

namespace Presentation.Presenters
{
    public class AdminPresenter : IAdminPresenter
    {
        IAdminView _view;
        IHabitacionRepository _habitacionRepository;

        public AdminPresenter(IAdminView view, IHabitacionRepository habitacionRepository)
        {
            _view = view;
            _habitacionRepository = habitacionRepository;
            //_view.AñadirEvent += OnAñadirHab();
            CargarHabitaciones();
            CargarUsuarios();
        }

        //public EventHandler OnAñadirHab()
        //{
        //    return null;
        //}

        public void CargarHabitaciones()
        {
            var habitaciones = new List<Habitacion>();

            _view.ActualizarListaHabitaciones(habitaciones);
        }

        public void CargarUsuarios()
        {
            var usuarios = new List<Usuario>();
            _view.ActualizarListaUsuarios(usuarios);
        }

        public IAdminView GetAdminView()
        {
            return _view;
        }
    }
}
