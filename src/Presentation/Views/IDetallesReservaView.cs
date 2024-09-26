using Domain.Entities;
using System;

namespace PresentationLayer.Views
{
    public interface IDetallesReservaView
    {
        event EventHandler OnActualizarReserva;
        event EventHandler OnCancelarReserva;
        event EventHandler OnRedirectToClientView;

        void MostrarDetalleReserva(Reserva reserva);  // Método para mostrar la información de la reserva
        void ShowView();  // Mostrar la vista
        void CloseView();  // Cerrar la vista
        void ShowMessage(string message, string title);  // Mostrar un mensaje
        void HideView();  // Esconder la vista
    }
}
