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
        public void ShowMessage(string title, string message);
        

    }
}
