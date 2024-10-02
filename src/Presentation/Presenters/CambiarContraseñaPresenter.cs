using ApplicationLayer.Services;
using PresentationLayer.Utils;
using PresentationLayer.Views;
using System;
using System.Collections.Generic;
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
        }

        public void HideView()
        {
            throw new NotImplementedException();
        }

        public void ShowView()
        {
            _view.ShowView();
        }

        private void HandleCambiarContraseña(object? sender, EventArgs e)
        {
            var usuario = _authService.GetCurrentUser();

            // Verificar la contraseña actual
            if (!_authService.VerifyPassword(usuario, _view.ContraseñaActual))
            {
                _view.ShowMessage("La contraseña actual es incorrecta.");
                return;
            }

            // Cambiar la contraseña por la nueva
            _authService.ChangePassword(usuario, _view.NuevaContraseña);
            _view.ShowMessage("La contraseña se ha cambiado con éxito.");
        }
    }
}
