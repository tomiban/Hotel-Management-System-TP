

using Domain.Entities;

namespace Presentation.Views
{
    public interface IRegisterView
    {
        //Properties
       
        string Nombre { get; }
        string Apellido { get; }
        public string Edad { get; }
        public string Telefono { get; }
        string Username { get; }
        string Contraseña { get; }
        Role Role { get; }


        event EventHandler RegisterEvent;
        event EventHandler OnLoginRedirect;

        void ShowMessage( string message, string title);

        void CloseView();
        void HideView();

        void Show();
    }
}
