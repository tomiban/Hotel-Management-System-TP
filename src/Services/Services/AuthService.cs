using Domain.Entities;
using Domain.Interfaces;
using Domain.Validation.ModelDataAnnotationCheck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services
{
    public class AuthService : IAuthService
    {
        IUsuarioRepository _usuarioRepository;
        IModelDataAnnotationCheck _modelDataAnnotationCheck;
        private Usuario _currentUser;

        public AuthService(IUsuarioRepository usuarioRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
            _usuarioRepository = usuarioRepository;
        }

        public void ValidateModel(IUsuario usuario)
        {
            _modelDataAnnotationCheck.ValidateModel(usuario);
        }

        public Usuario Login(string username, string contraseña)
        {
            var usuario = _usuarioRepository.Authenticate(username, contraseña);
            if (usuario != null)
            {
                _currentUser = usuario; // Almacenar usuario autenticado
            }
            return usuario;
        }

        public void Register(Usuario usuario)
        {
            ValidateModel(usuario);
            _usuarioRepository.Add(usuario);
        }

        public bool CheckUsername(string username)
        {
            return _usuarioRepository.GetByUsername(username);
        }

        public Usuario GetCurrentUser()
        {
            return _currentUser;
        }
    }
}
