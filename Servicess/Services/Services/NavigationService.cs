using GestionHotelWinForms.Models;
using GestionHotelWinForms.Presenters;
using GestionHotelWinForms.Repositories;
using GestionHotelWinForms.Views;

namespace GestionHotelWinForms.Services
{
    public class NavigationService : INavigationService
    {
        private readonly IUsuarioRepository _userRepository;
        private readonly IHabitacionRepository _habitacionRepository;
       // private readonly IClienteRepository _clienteRepository;

        public NavigationService(IUsuarioRepository userRepository, IHabitacionRepository habitacionRepository)
        {
            _userRepository = userRepository;
            _habitacionRepository = habitacionRepository;
    
        }

        public Login ShowLoginPanel()
        {
            var loginPanel = new Login();
            var loginPresenter = new LoginPresenter(loginPanel, _userRepository, this);
            return loginPanel;
        }

        public Register ShowRegisterPanel()
        {
            var registerForm = new Register();
            var registerPresenter = new RegisterPresenter(registerForm, _userRepository, this);
            return registerForm;
        }

        public Admin ShowAdminPanel()
        {
            var adminPanel = new Admin();
            var adminPresenter = new AdminPresenter(adminPanel, _habitacionRepository, _userRepository, this);
            return adminPanel;
        }

        public Cliente ShowClientPanel()
        {
            var clientPanel = new Cliente();
          //  var clientPresenter = new ClientPresenter(clientPanel, _clienteRepository);
            return clientPanel;
        }

        public CrearEditarHabitacion ShowCrearEditarHabitacion()
        {
            var crearEditarHabitacion = new CrearEditarHabitacion();
            var crearEditarHabitacionPresenter = new CrearEditarHabitacionPresenter(crearEditarHabitacion, _habitacionRepository, this);
            return crearEditarHabitacion;
        }
    }
}
