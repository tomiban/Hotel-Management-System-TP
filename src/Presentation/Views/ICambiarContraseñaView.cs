using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Views
{
    public interface ICambiarContraseñaView 
    {
        string ContraseñaActual { get; }
        string NuevaContraseña { get; }

        // Evento que se dispara cuando el usuario intenta cambiar la contraseña
        event EventHandler OnCambiarContraseña;

        // Método para mostrar mensajes en la vista (éxito/error)
        void ShowMessage(string message);
        void ShowView();
    }
}
