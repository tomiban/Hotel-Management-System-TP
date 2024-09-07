using Domain.Entities;
using Domain.Interfaces;
using PresentationLayer.Views;
using Services.Services.ReservaServices;


namespace PresentationLayer.Presenters
{
    public class GuestPresenter : IGuestPresenter
    {
        IGuestView _view;


        public GuestPresenter(IGuestView view)
        {
            _view = view;
           CargarHabitaciones();
        }

        public void CargarHabitaciones()
        {
            var habitaciones = new List<Habitacion>();

            _view.CargarHabitaciones(habitaciones);
        }


        public IGuestView GetGuestView()
        {
           return _view;
        }
    }
}
