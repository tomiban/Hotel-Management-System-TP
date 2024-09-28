using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using Presentation.Views;
using PresentationLayer.Presenters;
using PresentationLayer.Utils;
using System.ComponentModel.DataAnnotations;
using Unity;

namespace Presentation.Presenters
{
    public class LoginPresenter : ILoginPresenter
    {
        private readonly ILoginView _view;
        private readonly IAuthService _authService;
        private readonly INavigationService _navigationService;

        public ILoginView GetLoginView() => _view;

        public LoginPresenter(ILoginView view, IAuthService authService, INavigationService navigationService)
        {
            _view = view;
            _authService = authService;
            _navigationService = navigationService;

            _view.LoginEvent += OnLogin;
            _view.RedirectToRegister += OnRegisterRedirect;
        }

        public void ShowView()
        {
            _view.ShowView();
        }

        public void HideView()
        {
            _view.HideView();
        }

        private void OnLogin(object? sender, EventArgs e)
        {
            try
            {
                var usuario = _authService.Login(_view.Username, _view.Password);

                switch (usuario.Role)
                {
                    case Role.Admin:
                        _navigationService.NavigateTo<IAdminPresenter>();  // Navegar a Admin
                        break;
                    case Role.Cliente:
                        _navigationService.NavigateTo<IGuestPresenter>();  // Navegar a Cliente
                        break;
                    default:
                        _view.ShowMessage("Rol inválido", "Error");
                        break;
                }

                _view.HideView();
            }
            catch (ValidationException ex)
            {
                _view.ShowMessage($"Validación fallida: {ex.Message}", "Error");
            }
            catch (UnauthorizedAccessException)
            {
                _view.ShowMessage("Usuario o contraseña incorrectos.", "Credenciales inválidas");
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Ocurrió un error inesperado: {ex.Message}", "Error");
            }
        }

        private void OnRegisterRedirect(object? sender, EventArgs e)
        {
            try
            {
                _navigationService.NavigateTo<IRegisterPresenter>();  // Navegar a la vista de Registro
                _view.HideView();
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Ocurrió un error al redirigir.", "Error");
            }
        }

        void ILoginPresenter.OnLogin(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void ILoginPresenter.OnRegisterRedirect(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
