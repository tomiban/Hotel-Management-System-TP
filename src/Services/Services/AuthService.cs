using Domain.Entities;
using Domain.Interfaces;
using Domain.Validation.ModelDataAnnotationCheck;
using System;
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
            try
            {
                var usuario = _usuarioRepository.Authenticate(username, contraseña);
                if (usuario != null)
                {
                    _currentUser = usuario; // Almacenar usuario autenticado
                    return usuario;
                }
                else
                {
                    throw new UnauthorizedAccessException("Credenciales inválidas.");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error inesperado durante el inicio de sesión.", ex);
            }
        }

        public void Register(Usuario usuario)
        {
            var validationResults = ValidateModel(usuario);
            if (validationResults.Any())
            {
                throw new ValidationException("Error en la validación del usuario: " + string.Join(", ", validationResults.Select(v => v.ErrorMessage)));
            }
            try
            {
                _usuarioRepository.Add(usuario);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado durante el registro.", ex);
            }
        }

        public bool CheckUsername(string username)
        {
            try
            {
                return _usuarioRepository.GetByUsername(username);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al verificar el nombre de usuario.", ex);
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
    }
}
