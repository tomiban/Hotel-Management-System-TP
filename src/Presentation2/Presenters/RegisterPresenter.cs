using Domain.Entities;
using Domain.Interfaces;
using Presentation.Views;
using Unity;

namespace Presentation.Presenters
{
    public class RegisterPresenter : IRegisterPresenter
    {
        private readonly IRegisterView _view;
        private readonly IUsuarioRepository _userRepository;
        private readonly IUnityContainer _container;

        public RegisterPresenter(IRegisterView view, IUsuarioRepository userRepository, IUnityContainer container)
        {
            _view = view;
            _userRepository = userRepository;
            _container = container;
            _view.RegisterEvent += OnRegister;
            _view.OnLoginRedirect += OnLoginRedirect;
        }

        public IRegisterView View => _view;

        public void OnLoginRedirect(object? sender, EventArgs e)
        {
            try
            {

                _view.CloseView();

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