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
        bool VerifyPassword(Usuario usuario, string contraseña);
        void ChangePassword(Usuario usuario, string nuevaContraseña);
        ICollection<ValidationResult> ValidateModel(IUsuario usuario);
    }
}