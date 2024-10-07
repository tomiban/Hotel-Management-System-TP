using ApplicationLayer.Services;
using Domain.Entities;
using PresentationLayer.Utils;
using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Presenters
{
    public class CambiarContraseñaPresenter : ICambiarContraseñaPresenter
    {
        private readonly ICambiarContraseñaView _view;
        private readonly IAuthService _authService;
        private readonly INavigationService _navigationService;

        public CambiarContraseñaPresenter(ICambiarContraseñaView view, IAuthService authService, INavigationService navigationService)
        {
            _view = view;
            _authService = authService;
            _navigationService = navigationService;

            // Suscribirse al evento de cambio de contraseña
            _view.OnCambiarContraseña += HandleCambiarContraseña;
            _view.OnCancelarCambioContraseña += HandleCancelarCambioContraseña;
        }

        public void ShowView()
        {
            _view.ShowView();
        }


        private void HandleCancelarCambioContraseña(object? sender, EventArgs e)
        {
            _navigationService.GoBack();
        }


        private void HandleCambiarContraseña(object? sender, EventArgs e)
        {
            try
            {
                var usuario = _authService.GetCurrentUser();

                if (!_authService.VerifyPassword(usuario, _view.ContraseñaActual))
                {
                    throw new ValidationException("La contraseña actual es incorrecta.");
                }

                if(_view.NuevaContraseña.Length < 8)
                {
                    throw new ValidationException("La contraseña debe tener al menos 8 caracteres.");
                }
               
                _authService.ChangePassword(usuario, _view.NuevaContraseña);
                _view.ShowMessage("La contraseña se ha cambiado con éxito.", "Éxito");
                _navigationService.GoBack();
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Error al cambiar la contraseña: " + ex.Message, "Error");
            }
        }

        public void HideView()
        {
            _view.HideView();
        }
    }
}
