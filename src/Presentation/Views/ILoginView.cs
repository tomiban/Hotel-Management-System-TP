

namespace Presentation.Views
{
    public interface ILoginView
    {
        public string Username { get; }
        public string Password { get; }
        event EventHandler LoginEvent;
        event EventHandler RedirectToRegister;
        public void ShowMessage(string title, string message);
        public void CloseView();
        public void HideView();
         void Show();

    }
}
