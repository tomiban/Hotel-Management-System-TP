using GestionHotelWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Views
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

        void ShowMessage(string title, string message);

        void Show();
    }

}
