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
        void CargarListaReservasActivas(List<Reserva> reservas);
        void ActualizarDashboard(int reservasActivas, double porcentajeOcupacion, int totalHabitaciones, int totalUsuarios, int nuevosUsuarios, decimal facturacionAnual);
        void ShowDialogLogout();
        int ObtenerNroHabitacionSeleccionado();


        event EventHandler RedirectToCrearEditarHabitacion;
        event EventHandler RedirectToCrearEditarUsuario;
        event EventHandler EliminarHabitacion;
        event EventHandler SearchHabitacion;
        event EventHandler SearchUsuario;
        event EventHandler EditarHabitacion;
        event EventHandler OnLogoutTabSelected;
        event Action<int> EliminarUsuario;
        event EventHandler ActualizarRol;
        Role GetSelectedUserRole();
        int GetSelectedUserId();

        void ShowMessage(string message, string tittle);
        void SetEliminarHabitacionButtonState(bool enabled);
        void SetEditarHabitacionButtonState(bool enabled);
       
        void ShowView();
        void CloseView();
        void HideView();
    }

}
