using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Views
{
    public interface ILoginView
    {
        public string Username { get; }
        public string Password { get; }
        event EventHandler LoginEvent;
        event EventHandler RedirectToRegister;
        public void ShowMessage(string title, string message);
        public void RegisterPanel();
        public void ShowAdminPanel();
        public void ShowClientPanel();
        public void HideView();
        

    }
}
