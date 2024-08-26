namespace Domain.Validation.ModelDataAnnotationCheck
{
    public interface IModelDataAnnotationCheck
    {
        void ValidateModel<TDomainModel>(TDomainModel domainModel);
    }
}