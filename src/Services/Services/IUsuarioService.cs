using Domain.Entities;
using Domain.Interfaces;

namespace ApplicationLayer.Services
{
    internal interface IUsuarioService
    { 
        void Delete(int id);
        Task<List<Usuario>> GetAll();
        Task<Usuario> GetById(int id);
        void Update(Usuario usuario);
        void ValidateModel(IUsuario usuario);
    }
}