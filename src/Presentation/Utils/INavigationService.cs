namespace PresentationLayer.Utils
{
    public interface INavigationService
    {
        void GoBack();
        void NavigateTo<TPresenter>() where TPresenter : IPresenter;
    }
}