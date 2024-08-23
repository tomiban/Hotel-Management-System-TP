using Domain.Entities;
using Domain.Interfaces;
using Presentation.Views;
using Unity;

namespace Presentation.Presenters
{
    public class RegisterPresenter : IRegisterPresenter
    {

        IRegisterView _view;
        IUsuarioRepository _userRepository;
        Lazy<ILoginPresenter> _loginPresenter;

        public RegisterPresenter(IRegisterView view, IUsuarioRepository userRepository, Lazy<ILoginPresenter> loginPresenter)
        {
            _view = view;
            _userRepository = userRepository;
            _loginPresenter = loginPresenter;
            _view.RegisterEvent += OnRegister;
            _view.OnLoginRedirect += OnLoginRedirect;
        }


        public IRegisterView GetRegisterView() => _view;

        public void OnLoginRedirect(object? sender, EventArgs e)
        {
            try
            {
                _view.CloseView();
                _loginPresenter.Value.GetLoginView().ShowView();

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