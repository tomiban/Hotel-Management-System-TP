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
        int ObtenerNroHabitacionSeleccionado();
        void LimpiarFormulario();

        event EventHandler RedirectToCrearEditarHabitacion;
        event EventHandler RedirectToCrearEditarUsuario;
        event EventHandler EliminarHabitacion;
        event EventHandler EliminarUsuario;
        event EventHandler SearchHabitacion;
        event EventHandler SearchUsuario;
        event EventHandler EditarHabitacion;

        void ShowMessage(string title, string message);
        void SetEliminarHabitacionButtonState(bool enabled);

        void ShowView();
        void CloseView();
        void HideView();
    }

}
