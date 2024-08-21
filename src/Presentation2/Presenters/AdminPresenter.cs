using Domain.Entities;
using Domain.Interfaces;
using Presentation.Views;
using Unity;

namespace Presentation.Presenters
{
    public class AdminPresenter : IAdminPresenter
    {
        private readonly IAdminView _view;
        private readonly IHabitacionRepository _habitacionRepository;
        private readonly IUnityContainer _container;

        public AdminPresenter(IAdminView view, IHabitacionRepository habitacionRepository, IUnityContainer container)
        {

            _view = view;
            _container = container;
            _habitacionRepository = habitacionRepository;

            _view.AñadirEvent += OnAñadirHab();
            CargarHabitaciones();
            CargarUsuarios();
        }

        public IAdminView View => _view;


        public EventHandler OnAñadirHab()
        {
            return null;
        }

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

    }
}
