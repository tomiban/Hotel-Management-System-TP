using Domain.Entities;
using PresentationLayer.Components;
using PresentationLayer.Events;
using PresentationLayer.Helpers;
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


        // Evento que se dispara cuando se selecciona una categoría del filtro
        event EventHandler OnFiltrarCategoria;

        event EventHandler<int> ReservaSeleccionada;

        public event EventHandler<FiltroFechaEventArgs> OnFiltrarHabitacionesRangoFechas;

        // Método para cargar las habitaciones (esto es opcional, pero útil)
        void CargarHabitacionCards(List<HabitacionCard> habitacionCards);

        void CargarReservas(List<Reserva> reservas);

        void ShowMessage(string title, string message);
        void MostrarMensaje(string mensaje);

        void ShowView();
        void CloseView();
        void HideView();
    }
}

