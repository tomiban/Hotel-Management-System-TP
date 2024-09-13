using Domain.Entities;
using Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ApplicationLayer.Services
{
    public interface IUsuarioService
    {
        void Delete(int id);
        List<Usuario> GetAll();
        Usuario GetById(int id);
        void Update(Usuario usuario);
        ICollection<ValidationResult> ValidateModel(IUsuario usuario);
    }
}