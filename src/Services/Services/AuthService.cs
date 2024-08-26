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
            return _usuarioRepository.Authenticate(username, contraseña);
        }

        public void Register(Usuario usuario)
        {
            ValidateModel(usuario);
            _usuarioRepository.AddAsync(usuario);
        }

        public bool CheckUsername(string username)
        {
            return _usuarioRepository.GetByUsername(username);
        }

    }
}
