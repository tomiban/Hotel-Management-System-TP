using Domain.Entities;
using Domain.Interfaces;
using Domain.Validation.ModelDataAnnotationCheck;
using System.ComponentModel.DataAnnotations;

namespace ApplicationLayer.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IModelDataAnnotationCheck _modelDataAnnotationCheck;
        private Usuario _currentUser;
        

        public AuthService(IUsuarioRepository usuarioRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
            _usuarioRepository = usuarioRepository;
        }


        public ICollection<ValidationResult> ValidateModel(IUsuario usuario)
        {
            return _modelDataAnnotationCheck.ValidateModel(usuario);
        }

        public Usuario Login(string username, string contraseña)
        {
            var usuario = _usuarioRepository.Authenticate(username, contraseña);
            if (usuario == null)
            {
                throw new UnauthorizedAccessException("Credenciales inválidas.");
            }

            _currentUser = usuario;
            return usuario;
        }


        public void Register(Usuario usuario)
        {
            var validationResults = ValidateModel(usuario);
            if (validationResults.Any())
            {
                throw new ValidationException(string.Join("\n", validationResults.Select(v => v.ErrorMessage)));
            }
            _usuarioRepository.Add(usuario);
        }


        public void CheckUsername(string username)
        {
            if (_usuarioRepository.GetByUsername(username))
            {
                throw new ValidationException("El nombre de usuario ya existe.");
            }
        }

        public Usuario GetCurrentUser()
        {
            if (_currentUser == null)
            {
                throw new InvalidOperationException("No hay ningún usuario autenticado.");
            }
            return _currentUser;
        }

        public bool VerifyPassword(Usuario usuario, string contraseña)
        {
            // Verificar si la contraseña ingresada coincide con la contraseña almacenada (hash)
            return usuario.Contraseña == contraseña;
        }

        public void ChangePassword(Usuario usuario, string nuevaContraseña)
        {
            usuario.Contraseña = nuevaContraseña;
            _usuarioRepository.Update(usuario);  // Guardar el cambio en la base de datos
        }
    }
}
