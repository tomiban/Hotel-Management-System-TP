using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Views
{
    public interface IGuestView
    {

        // Evento que se dispara cuando se hace clic en el botón "Reservar"
        event EventHandler OnReservaClicked;

        // Evento que se dispara cuando se selecciona una categoría del filtro
        event EventHandler OnCategoriaFiltrada;

        // Método para cargar las habitaciones (esto es opcional, pero útil)
        void CargarHabitaciones(List<Habitacion> habitaciones);



        void ShowMessage(string title, string message);

        void ShowView();
        void CloseView();
        void HideView();
    }
}
