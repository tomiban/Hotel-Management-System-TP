using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Validation.ModelDataAnnotationCheck;
using System.ComponentModel.DataAnnotations;

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
        try
        {
            return _modelDataAnnotationCheck.ValidateModel(usuario);
        }
        catch (Exception ex)
        {
            // Manejo general de excepciones si ocurre un error inesperado en la validación
            throw new ApplicationException("Ocurrió un error inesperado al validar el modelo", ex);
        }
    }

    public void Add(Usuario usuario)
    {
        var validationResults = ValidateModel(usuario);
        if (validationResults.Any())
        {
            // Devolver los errores de validación o manejar de acuerdo a tus necesidades
            throw new ValidationException("Error en la validación del modelo: " + string.Join(", ", validationResults.Select(v => v.ErrorMessage)));
        }
        try
        {
            _usuarioRepository.Add(usuario);
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Ocurrió un error inesperado al agregar el usuario", ex);
        }
    }

    public void Update(Usuario usuario)
    {
        var validationResults = ValidateModel(usuario);
        if (validationResults.Any())
        {
            // Devolver los errores de validación o manejar de acuerdo a tus necesidades
            throw new ValidationException("Error en la validación del modelo: " + string.Join(", ", validationResults.Select(v => v.ErrorMessage)));
        }
        try
        {
            _usuarioRepository.Update(usuario);
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Ocurrió un error inesperado al actualizar el usuario", ex);
        }
    }

    // Los métodos Delete, GetAll, y GetById no requieren cambios significativos relacionados con la validación

    public void Delete(int id)
    {
        try
        {
            _usuarioRepository.Delete(id);
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Ocurrió un error inesperado al eliminar el usuario", ex);
        }
    }

    public List<Usuario> GetAll()
    {
        try
        {
            return _usuarioRepository.GetAll();
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Ocurrió un error al obtener los usuarios.", ex);
        }
    }

    public Usuario GetById(int id)
    {
        try
        {
            return _usuarioRepository.GetById(id);
        }
        catch (Exception ex)
        {
            throw new ApplicationException($"Ocurrió un error al obtener el usuario con id {id}.", ex);
        }
    }
}
