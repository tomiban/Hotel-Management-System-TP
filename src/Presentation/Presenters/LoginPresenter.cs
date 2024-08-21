using Domain.Interfaces;
using Presentation.Views;
using Unity;

namespace Presentation.Presenters
{
    public class LoginPresenter : ILoginPresenter
    {
        private readonly ILoginView _view;
        private readonly IUsuarioRepository _userRepository;
        private readonly IUnityContainer _container;

        public LoginPresenter(ILoginView view, IUsuarioRepository userRepository, IUnityContainer container)
        {
            _view = view;
            _userRepository = userRepository;
            _container = container;
            _view.LoginEvent += OnLogin;
            _view.RedirectToRegister += OnRegisterRedirect;
        }

        // Propiedad pública para acceder a la vista desde fuera del presentador
        public ILoginView View => _view;

        public void OnLogin(object? sender, EventArgs e)
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

                // Aquí podrías manejar la navegación según el rol del usuario
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
                // Ocultar la vista de login
                _view.HideView();

                // Resolver y mostrar la vista de registro
                var registerView = _container.Resolve<IRegisterView>();
                registerView.Show();
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Ocurrió un error al redirigir.", "Error");
            }
        }
    }
}
