using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views
{
    public interface IAdminView
    {
        void ActualizarListaUsuarios(List<Usuario> items);
        void ActualizarListaHabitaciones(List<Habitacion> items);
        void ObtenerDatos();
        int ObtenerIdSeleccionado();
        void LimpiarFormulario();

        event EventHandler AñadirEvent;
        event EventHandler EditarEvent;
        event EventHandler EliminarEvent;
        event EventHandler SearchEvent;
     


        void ShowMessage(string title, string message);

        void ShowView();
        void CloseView();
        void HideView();
    }

}
