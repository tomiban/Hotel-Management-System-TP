using Domain.Entities;
using Domain.Interfaces;
using Presentation.Views;

namespace Presentation.Presenters
{ 
    public class AdminPresenter: IAdminPresenter
    {
        private readonly IAdminView _view;

        private readonly IHabitacionRepository _habitacionRepository;
        private readonly IUsuarioRepository _usuarioRepository;
     

        public AdminPresenter(IAdminView view, IHabitacionRepository habitacionRepository, IUsuarioRepository usuarioRepository)
        {
            _view = view;

            _habitacionRepository = habitacionRepository;
            _usuarioRepository = usuarioRepository;
            _view.AñadirEvent += OnAñadirHab();
            CargarHabitaciones();
            CargarUsuarios();
        }

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
