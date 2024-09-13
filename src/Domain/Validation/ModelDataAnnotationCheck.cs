using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Validation.ModelDataAnnotationCheck
{
    public class ModelDataAnnotationCheck : IModelDataAnnotationCheck
    {
        public ICollection<ValidationResult> ValidateModel<TDomainModel>(TDomainModel domainModel)
        {
            ICollection<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(domainModel, null, null);

            // Realizamos la validación
            bool isValid = Validator.TryValidateObject(domainModel, validationContext, validationResults, validateAllProperties: true);

            // Retornamos los resultados de validación
            return validationResults;
        }
    }
}
