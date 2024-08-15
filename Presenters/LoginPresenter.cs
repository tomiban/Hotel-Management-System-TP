using GestionHotelWinForms.Models;
using GestionHotelWinForms.Repositories;
using GestionHotelWinForms.Services;
using GestionHotelWinForms.Views;


namespace GestionHotelWinForms.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly IUsuarioRepository _userRepository;
        private readonly INavigationService _navigationService;

        public LoginPresenter(ILoginView view, IUsuarioRepository userRepository, INavigationService navigationService)
        {
            _view = view;
            _userRepository = userRepository;
            _navigationService = navigationService;
            _view.LoginEvent += OnLogin;
            _view.RedirectToRegister += OnRegisterRedirect;
        }

        private void OnLogin(object? sender, EventArgs e)
        {
            try
            {
                var userExist = _userRepository.Authenticate(_view.Username, _view.Password);

                if (!userExist)
                {
                    _view.ShowMessage("Usuario o contraseña incorrectos.", "Error");
                    return;
                }

                var usuario = _userRepository.GetByUsername(_view.Username);
                _view.HideView();

                if (usuario.Role == Role.Admin)
                {
                    _navigationService.ShowAdminPanel().Show();
                }
                else if (usuario.Role == Role.Client)
                {
                    //_navigationService.ShowClientPanel().Show()
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Ocurrió un error al iniciar sesión.", "Error");
            }
        }

        private void OnRegisterRedirect(object? sender, EventArgs e)
        {
            try
            {
                _navigationService.ShowRegisterPanel().Show();
                _view.HideView();
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Ocurrió un error al redirigir.", "Error");        
            }
        }

    }
}
