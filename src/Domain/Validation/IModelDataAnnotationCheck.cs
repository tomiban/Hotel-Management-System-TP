using System.ComponentModel.DataAnnotations;

namespace Domain.Validation.ModelDataAnnotationCheck
{
    public interface IModelDataAnnotationCheck
    {
        ICollection<ValidationResult> ValidateModel<TDomainModel>(TDomainModel domainModel);
    }
}