using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Validation.ModelDataAnnotationCheck;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;
    private readonly IModelDataAnnotationCheck _modelDataAnnotationCheck;

    public UsuarioService(IUsuarioRepository usuarioRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
    {
        _modelDataAnnotationCheck = modelDataAnnotationCheck;
        _usuarioRepository = usuarioRepository;
    }

    public ICollection<ValidationResult> ValidateModel(IUsuario usuario)
    {
        return _modelDataAnnotationCheck.ValidateModel(usuario);
    }

    public void Update(Usuario usuario)
    {
        var validationResults = ValidateModel(usuario);
        if (validationResults.Any())
        {
            throw new ValidationException(string.Join("\n", validationResults.Select(v => v.ErrorMessage)));
        }

        _usuarioRepository.Update(usuario);
    }

    public List<Usuario> GetAllUsuarios()
    {
        return _usuarioRepository.GetAll();
    }

    public Usuario GetUsuarioById(int id)
    {
        return _usuarioRepository.GetById(id);
    }
    public void UpdateUsuario(Usuario usuario)
    {
        _usuarioRepository.Update(usuario); // Actualizar el usuario en el repositorio
    }

    public void DeleteUsuario(int id)
    {
        _usuarioRepository.Delete(id); // Eliminar el usuario del repositorio
    }
}
