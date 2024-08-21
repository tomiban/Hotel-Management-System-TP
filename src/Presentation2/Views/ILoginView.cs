namespace Presentation.Views
{
    public interface ILoginView
    {
        string Username { get; }
        string Password { get; }
        event EventHandler LoginEvent;
        event EventHandler RedirectToRegister;
        void ShowMessage(string title, string message);
        void CloseView();
        void HideView();
    }
}
