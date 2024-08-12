using GestionHotelWinForms.Presenters;
using GestionHotelWinForms.Repositories;
using GestionHotelWinForms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Services
{
    public class NavigationService : INavigationService
    {
        private readonly IUsuarioRepository _userRepository;

        public NavigationService(IUsuarioRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void ShowRegisterPanel()
        {
            // Crear la vista y el presentador para el registro
            var registerForm = new Register();
            var registerPresenter = new RegisterPresenter(registerForm, _userRepository, this);

            // Mostrar el formulario de registro
            registerForm.Show();
        }

        public void ShowAdminPanel()
        {
            // Crear la vista y el presentador para el panel de administrador
            var adminPanel = new Admin();
         //   var adminPresenter = new AdminPresenter(adminPanel, _userRepository);

            // Mostrar el panel de administrador
            adminPanel.Show();
        }

        public void ShowClientPanel()
        {
            // Crear la vista y el presentador para el panel de cliente
            var clientPanel = new Cliente();
         //   var clientPresenter = new ClientPresenter(clientPanel, _userRepository);

            // Mostrar el panel de cliente
            clientPanel.Show();
        }

        public void ShowLoginPanel()
        {
            // Crear la vista y el presentador para el login
            var loginPanel = new Login();
            var loginPresenter = new LoginPresenter(loginPanel, _userRepository, this);

            // Mostrar el panel de login
            loginPanel.Show();
        }
    }
}
