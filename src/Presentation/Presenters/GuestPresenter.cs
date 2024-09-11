using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using PresentationLayer.Components;
using PresentationLayer.Views;
using Services.Services.ReservaServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PresentationLayer.Presenters
{
    public class GuestPresenter : IGuestPresenter
    {
        IGuestView _view;
        IReservaService _reservaService;
        IAuthService _authService;
        IHabitacionServices _habitacionServices;

        public GuestPresenter(IGuestView view,IHabitacionServices habitacionServices, IReservaService reservaService, IAuthService authService)
        {
            _view = view;
            _reservaService = reservaService;
            _authService = authService;
            _habitacionServices = habitacionServices;
            _view.OnRealizarReserva += HandleRealizarReserva;
            CargarHabitaciones();
        }


        // Todo ==> Validar fechas de inicio y fin

        public void HandleRealizarReserva(object? sender, EventArgs e)
        {
            var habitacionSeleccionada = sender as HabitacionCard;
            if (habitacionSeleccionada == null)
            {
                _view.ShowMessage("Debe seleccionar una habitación.", "Error");
                return;
            }

            var usuarioAutenticado = _authService.GetCurrentUser();

            if (usuarioAutenticado == null)
            {
                _view.ShowMessage("Debe iniciar sesión antes de realizar una reserva.", "Error");
                return;
            }


            var reserva = new Reserva()
            {
                FechaInicio = habitacionSeleccionada.FechaDesdePicker.Value,
                FechaFin = habitacionSeleccionada.FechaHastaPicker.Value,
                IdHabitacion = habitacionSeleccionada.HabitacionId,
                NroHabitacion = int.Parse(habitacionSeleccionada.NroHabitacionLabel.Text.Split(' ').Last()),
                Username = usuarioAutenticado.Username,
                IdUsuario = usuarioAutenticado.Id
            };

            _reservaService.AgregarReserva(reserva);

            _view.ShowMessage("Reserva registrada correctamente.", "Éxito");
            CargarHabitaciones();
        }

        public void CargarHabitaciones()
        {
            var habitaciones = _habitacionServices.GetAll();

            //habitaciones.Add(
            //  new Habitacion() { NroHabitacion = 1, PrecioPorNoche = 500, Disponible = true, CantidadPersonas = 3, TipoHabitacion = TipoHabitacion.Premium }
            //  );

            //habitaciones.Add(
            //   new Habitacion() { NroHabitacion = 2, PrecioPorNoche = 123, Disponible = true, CantidadPersonas = 5, TipoHabitacion = TipoHabitacion.Economic }
            //   );

            //habitaciones.Add(
            //   new Habitacion() { NroHabitacion = 3, PrecioPorNoche = 80, Disponible = false, CantidadPersonas = 3, TipoHabitacion = TipoHabitacion.Economic }
            //   );

            _view.CargarHabitaciones(habitaciones);
        }


        public IGuestView GetGuestView()
        {
            return _view;
        }
    }
}
