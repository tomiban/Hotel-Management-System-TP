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
        private readonly IUsuarioRepository _userRepository;

        public LoginPresenter(ILoginView view, IUsuarioRepository userRepository)
        {
            _view = view;
            _userRepository = userRepository;
            _view.LoginEvent += OnLogin;
            _view.RedirectToRegister+= OnRegisterRedirect;  
        }

        private void OnLogin(object? sender, EventArgs e)
        {
            var userExist = _userRepository.Authenticate(_view.Username, _view.Password);
            
            if (userExist == false)
            {
                _view.ShowMessage("Usuario o contraseña incorrectos.", "Error");
                return;
            }
            var usuario = _userRepository.GetByUsername(_view.Username);
            if (usuario.Role == Role.Admin)
            {
                _view.ShowAdminPanel();
            }
            else if (usuario.Role == Role.Client)
            {
                _view.ShowClientPanel();
            }            
            //_view.LoginSuccess();
        }

        private void OnRegisterRedirect(object? sender, EventArgs e)
        {
            var registerForm = new Register();
            registerForm.Show();
            _view.HideView();
        }

    
    }
}
