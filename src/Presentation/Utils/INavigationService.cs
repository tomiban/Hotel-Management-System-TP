namespace PresentationLayer.Utils
{
    public interface INavigationService
    {
        void GoBack();
        void NavigateTo<TPresenter>() where TPresenter : IPresenter;
        // Método de navegación con un parámetro
        void NavigateTo<TPresenter, TParam>(TParam param) where TPresenter : IPresenter;

        TPresenter GetPresenter<TPresenter>() where TPresenter: IPresenter;
    }
}