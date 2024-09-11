using Domain.Entities;
using Domain.Interfaces;

namespace ApplicationLayer.Services
{
    public interface IAuthService
    {
        Usuario Login(string username, string contraseña);
        void Register(Usuario usuario);
        bool CheckUsername(string username);
        Usuario GetCurrentUser();
        void ValidateModel(IUsuario usuario);
    }
}