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


        public Form ShowRegisterPanel()
        {
            var registerForm = new Register();
            var registerPresenter = new RegisterPresenter(registerForm, _userRepository, this);
            return registerForm;
        }

        public Form ShowAdminPanel()
        {
            var adminPanel = new Admin();
          //  var adminPresenter = new AdminPresenter(adminPanel, _userRepository);
            return adminPanel;
        }

        public Form ShowClientPanel()
        {
            var clientPanel = new Cliente();
          //  var clientPresenter = new ClientPresenter(clientPanel, _userRepository);
            return clientPanel;
        }

        public Form ShowLoginPanel()
        {
            var loginPanel = new Login();
            var loginPresenter = new LoginPresenter(loginPanel, _userRepository, this);
            return loginPanel;
        }
    }
}
