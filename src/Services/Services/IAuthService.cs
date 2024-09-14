using Domain.Entities;
using Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ApplicationLayer.Services
{
    public interface IAuthService
    {
        Usuario Login(string username, string contraseña);
        void Register(Usuario usuario);
        void CheckUsername(string username);
        Usuario GetCurrentUser();
        ICollection<ValidationResult> ValidateModel(IUsuario usuario);
    }
}