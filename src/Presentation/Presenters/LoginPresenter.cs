using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using Presentation.Views;
using PresentationLayer.Presenters;
using Unity;

namespace Presentation.Presenters
{
    public class LoginPresenter : ILoginPresenter
    {
        ILoginView _view;
        Lazy<IRegisterPresenter> _registerPresenter;
        Lazy<IAdminPresenter> _adminPresenter;
        Lazy<IGuestPresenter> _guestPresenter;
        IAuthService _authService;

        public ILoginView GetLoginView()
        {
            return _view;
        }


        public LoginPresenter(ILoginView view, Lazy<IRegisterPresenter> registerPresenter, Lazy<IAdminPresenter> adminPresenter, Lazy<IGuestPresenter> guestPresenter, IAuthService authService)
        {
            _view = view;
            _registerPresenter = registerPresenter;
            _adminPresenter = adminPresenter;
            _guestPresenter = guestPresenter;
            _view.LoginEvent += OnLogin;
            _view.RedirectToRegister += OnRegisterRedirect;
            _authService = authService;
        }


        public void OnLogin(object? sender, EventArgs e)
        {
            try
            {
                var usuario = _authService.Login(_view.Username, _view.Password);

                if (usuario == null)
                {
                    _view.ShowMessage("Usuario o contraseña incorrectos.", "Error");
                    return;
                }

                _view.HideView();

                if (usuario.Role == Role.Admin)
                {
                    _adminPresenter.Value.GetAdminView().ShowView();
                }
                else if (usuario.Role == Role.Guest)
                {
                    _guestPresenter.Value.GetGuestView().ShowView();
                }
                else
                {
                    _view.ShowMessage("Rol inválido", "Error");
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Ocurrió un error al iniciar sesión.", "Error");
            }
        }

        public void OnRegisterRedirect(object? sender, EventArgs e)
        {
            try
            {

                _registerPresenter.Value.GetRegisterView().ShowView();
                _view.HideView();
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Ocurrió un error al redirigir.", "Error");
            }
        }

        public void ShowLoginView()
        {
            _view.ShowView();
        }

    }
}
