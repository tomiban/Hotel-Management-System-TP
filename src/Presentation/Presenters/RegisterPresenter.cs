using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using Presentation.Views;
using System.ComponentModel.DataAnnotations;
using Unity;

namespace Presentation.Presenters
{
    public class RegisterPresenter : IRegisterPresenter
    {
        IRegisterView _view;
        IAuthService _authService;
        Lazy<ILoginPresenter> _loginPresenter;

        public RegisterPresenter(IRegisterView view, IAuthService authService, Lazy<ILoginPresenter> loginPresenter)
        {
            _view = view;
            _authService = authService;
            _loginPresenter = loginPresenter;
            _view.RegisterEvent += OnRegister;
            _view.OnLoginRedirect += OnLoginRedirect;
        }


        public IRegisterView GetRegisterView() => _view;

        public void OnLoginRedirect(object? sender, EventArgs e)
        {
            try
            {
                _loginPresenter.Value.GetLoginView().ShowView();
                _view.HideView();  // Cambia CloseView por HideView
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Ocurrio un error al redirigir.", "Error");
            }
        }


        public void OnRegister(object? sender, EventArgs e)
        {
            try
            {
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

                _authService.Register(newUser); 

                _view.ShowMessage("Usuario registrado correctamente.", "Éxito");

                _loginPresenter.Value.GetLoginView().ShowView();

                _view.HideView();
            }
            catch (ValidationException ex)
            {
                // Mostrar los errores de validación del servicio
                _view.ShowMessage($"{ex.Message}", "Error de validación");
            }
            catch (UnauthorizedAccessException ex)
            {
                // Caso de error de acceso no autorizado
                _view.ShowMessage($"Error de autenticación: {ex.Message}", "Error de autenticación");
            }
            catch (IOException ex)
            {
                _view.ShowMessage($"Error al guardar los datos. Intente nuevamente.", "Error");
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Ocurrió un error inesperado: {ex.Message}", "Error");
            }
        }


    }
}