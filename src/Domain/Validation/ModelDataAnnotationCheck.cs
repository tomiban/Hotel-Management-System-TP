using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validation.ModelDataAnnotationCheck
{
    public class ModelDataAnnotationCheck : IModelDataAnnotationCheck
    {
        public void ValidateModel<TDomainModel>(TDomainModel domainModel)
        {
            ICollection<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(domainModel, null, null);

            StringBuilder stringBuilder = new StringBuilder();

            if (!Validator.TryValidateObject(domainModel, validationContext, validationResults, validateAllProperties: true))
            {
                foreach (var result in validationResults)
                {
                    stringBuilder.AppendLine(result.ErrorMessage);
                }
            }

            if (validationResults.Count > 0)
            {
                throw new ValidationException(stringBuilder.ToString());
            }
        }
    }
}
