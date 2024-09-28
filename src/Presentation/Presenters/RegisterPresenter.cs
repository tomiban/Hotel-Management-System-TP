using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using Presentation.Views;
using PresentationLayer.Utils;
using System.ComponentModel.DataAnnotations;

namespace Presentation.Presenters
{
    public class RegisterPresenter : IRegisterPresenter
    {
        private readonly IRegisterView _view;
        private readonly IAuthService _authService;
        private readonly INavigationService _navigationService;

        public RegisterPresenter(IRegisterView view, IAuthService authService, INavigationService navigationService)
        {
            _view = view;
            _authService = authService;
            _navigationService = navigationService;

            _view.RegisterEvent += OnRegister;
            _view.OnLoginRedirect += OnLoginRedirect;
        }

        public void ShowView()
        {
            _view.ShowView();
        }

        public void HideView()
        {
            _view.HideView();
        }

        public void OnLoginRedirect(object? sender, EventArgs e)
        {
            try
            {
                // Usar el NavigationService para navegar a la vista de login
                _navigationService.NavigateTo<ILoginPresenter>();
                _view.HideView();  // Ocultar la vista de registro
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Ocurrió un error al redirigir.", "Error");
            }
        }

        public void OnRegister(object? sender, EventArgs e)
        {
            try
            {
                // Validar el nombre de usuario
                _authService.CheckUsername(_view.Username);

                var newUser = new Usuario
                {
                    Nombre = _view.Nombre,
                    Apellido = _view.Apellido,
                    Username = _view.Username,
                    Contraseña = _view.Contraseña,
                    Edad = int.Parse(_view.Edad),
                    Telefono = _view.Telefono,
                    Role = _view.Role
                };

                // Registrar el nuevo usuario
                _authService.Register(newUser);
                _view.ShowMessage("Usuario registrado correctamente.", "Éxito");

                // Navegar a la vista de login
                _navigationService.NavigateTo<ILoginPresenter>();

                // Ocultar la vista de registro
                _view.HideView();
            }
            catch (ValidationException ex)
            {
                _view.ShowMessage($"{ex.Message}", "Error de validación");
            }
            catch (UnauthorizedAccessException ex)
            {
                _view.ShowMessage($"Error de autenticación: {ex.Message}", "Error de autenticación");
            }
            catch (IOException ex)
            {
                _view.ShowMessage("Error al guardar los datos. Intente nuevamente.", "Error");
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Ocurrió un error inesperado: {ex.Message}", "Error");
            }
        }
    }
}
