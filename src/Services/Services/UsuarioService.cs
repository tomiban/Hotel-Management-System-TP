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
    public class UsuarioService : IUsuarioService
    {
        IUsuarioRepository _usuarioRepository;
        IModelDataAnnotationCheck _modelDataAnnotationCheck;
        public UsuarioService(IUsuarioRepository usuarioRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
            _usuarioRepository = usuarioRepository;
        }

        public void ValidateModel(IUsuario usuario)
        {
            _modelDataAnnotationCheck.ValidateModel(usuario);
        }

        public void Add(Usuario usuario)
        {
            _usuarioRepository.AddAsync(usuario);
        }

        public void Update(Usuario usuario)
        {
            _usuarioRepository.UpdateAsync(usuario);
        }

        public void Delete(int id)
        {
            _usuarioRepository.DeleteAsync(id);
        }

        public Task<List<Usuario>> GetAll()
        {
            return _usuarioRepository.GetAllAsync();
        }

        public Task<Usuario> GetById(int id)
        {
            return _usuarioRepository.GetByIdAsync(id);
        }

    }
}
