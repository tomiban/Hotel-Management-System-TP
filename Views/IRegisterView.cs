using GestionHotelWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Views
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

        void ShowMessage( string message, string title);
    }
}
