namespace Presentation.Views
{
    public interface ILoginView
    {
        string Password { get; }
        string Username { get; }

        event EventHandler LoginEvent;
        event EventHandler RedirectToRegister;


        void LimpiarCampos();
        void CloseView();
        void HideView();
        void ShowView();
        void ShowMessage(string title, string message);
    }
}
