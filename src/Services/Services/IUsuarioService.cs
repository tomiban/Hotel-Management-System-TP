using Domain.Entities;
using Domain.Interfaces;

namespace ApplicationLayer.Services
{
    public interface IUsuarioService
    { 
        void Delete(int id);
       List<Usuario> GetAll();
        Usuario GetById(int id);
        void Update(Usuario usuario);
        void ValidateModel(IUsuario usuario);
    }
}