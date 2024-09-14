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

    public void Delete(int id)
    {
        _usuarioRepository.Delete(id);
    }

    public List<Usuario> GetAll()
    {
        return _usuarioRepository.GetAll();
    }

    public Usuario GetById(int id)
    {
        return _usuarioRepository.GetById(id);
    }
}
