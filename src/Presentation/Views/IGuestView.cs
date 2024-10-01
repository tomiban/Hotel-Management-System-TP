using Domain.Entities;
using PresentationLayer.Components;
using PresentationLayer.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Views
{
    public interface IGuestView
    {
        public DateTime ReservaFechaDesde { get; }
        public DateTime ReservaFechaHasta { get; }
        public HabitacionCardContainer habitacionCardContainer { get; }

        // Evento que se dispara cuando se hace clic en el botón "Reservar"
        public event EventHandler<HabitacionEventArgs> OnRealizarReserva;


   

        event EventHandler<int> ReservaSeleccionada;
        event EventHandler OnModificarReserva;  // Evento para el botón Modificar Reserva
        event EventHandler OnLogoutTabSelected;

        public event EventHandler<FiltroFechaEventArgs> OnFiltrarHabitacionesRangoFechas;

        string ObtenerCategoriaSeleccionada();
        void CargarHabitacionCards(List<HabitacionCard> habitacionCards);
        void CargarReservas(List<Reserva> reservas);
        void SetModificarReservaButtonState(bool enabled);
        void ShowMessage(string title, string message);
        void MostrarMensaje(string mensaje);
        void ShowDialogLogout();

        void CargarDatosUsuario(Usuario usuario);
        void ShowView();
        void CloseView();
        void HideView();


    }
}

