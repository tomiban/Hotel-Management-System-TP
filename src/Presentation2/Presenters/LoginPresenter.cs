using Domain.Entities;
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

                if (usuario.Role == Role.Admin)
                {
                    var adminPresenter = _container.Resolve<IAdminPresenter>();
                    adminPresenter.View.Show();
                }
                else if (usuario.Role == Role.Client)
                {
                    //var loginPresenter = _container.Resolve<IClientPresenter>();
                    //loginPresenter.View.Show();
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
                // Ocular la vista de login en lugar de cerrarla inmediatamente
          
                // Resolver y mostrar la vista de registro
                var registerPresenter = _container.Resolve<IRegisterPresenter>();
                var registerForm = (Form)registerPresenter.View;

                // Mostrar la vista de registro
                // Mostrar la vista de registro como un diálogo modal
                registerForm.Show();
                _view.CloseView();


            }
            catch (Exception ex)
            {
                _view.ShowMessage("Ocurrió un error al redirigir.", "Error");
            }
        }
    }
}
