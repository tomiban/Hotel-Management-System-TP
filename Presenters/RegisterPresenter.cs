using GestionHotelWinForms.Models;
using GestionHotelWinForms.Repositories;
using GestionHotelWinForms.Services;
using GestionHotelWinForms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotelWinForms.Presenters
{
    public class RegisterPresenter
    {
        private readonly IRegisterView _view;
        private readonly IUsuarioRepository _userRepository;
        private readonly INavigationService _navigationService;

        public RegisterPresenter(IRegisterView view, IUsuarioRepository userRepository, INavigationService navigationService)
        {
            _view = view;
            _userRepository = userRepository;
            _navigationService = navigationService;
            _view.RegisterEvent += OnRegister;
            _view.OnLoginRedirect += OnLoginRedirect;
        }

        private void OnLoginRedirect(object? sender, EventArgs e)
        {
            try
            {
                _navigationService.ShowLoginPanel().Show();
                _view.CloseView();
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Ocurrio un error al redirigir.", "Error");
            }
        }

        private void OnRegister(object? sender, EventArgs e)
        {
            try
            {
                var existingUser = _userRepository.GetByUsername(_view.Username);

                if (existingUser != null)
                {
                    _view.ShowMessage("El nombre de usuario ya existe.", "Error");
                    return;
                }

                var newUser = new Usuario
                {
                    Nombre = _view.Nombre,
                    Apellido = _view.Apellido,
                    Username = _view.Username,
                    Contraseña = _view.Contraseña,
                    Role = _view.Role
                };

                _userRepository.AddAsync(newUser);

                _view.ShowMessage("Usuario registrado correctamente.", "Éxito");
                _navigationService.ShowLoginPanel().Show();
                _view.HideView();
            }
            catch (IOException ex)
            {
                _view.ShowMessage("Error al guardar los datos. Intente nuevamente.", "Error");

            }
            catch (Exception ex)
            {
                _view.ShowMessage("Ocurrió un error al registrarse.", "Error");

            }
        }

    }
}