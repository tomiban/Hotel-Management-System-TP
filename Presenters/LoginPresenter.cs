using GestionHotelWinForms.Models;
using GestionHotelWinForms.Repositories;
using GestionHotelWinForms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly IRepository<Usuario> _userRepository;

        public LoginPresenter(ILoginView view, IRepository<Usuario> userRepository)
        {
            _view = view;
            _userRepository = userRepository;
        }
         private void Login()
        {
            var username = _view.Username;
            var password = _view.Password;
        }
    }
}
