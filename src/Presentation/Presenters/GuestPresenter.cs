using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using PresentationLayer.Components;
using PresentationLayer.Views;
using Services.Services.ReservaServices;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PresentationLayer.Presenters
{
    public class GuestPresenter : IGuestPresenter
    {
        IGuestView _view;
        IReservaService _reservaService;
        IAuthService _authService;
        IHabitacionServices _habitacionServices;

        public GuestPresenter(IGuestView view, IHabitacionServices habitacionServices, IReservaService reservaService, IAuthService authService)
        {
            _view = view;
            _reservaService = reservaService;
            _authService = authService;
            _habitacionServices = habitacionServices;
            _view.OnRealizarReserva += HandleRealizarReserva;
            CargarHabitaciones();
        }


        public void HandleRealizarReserva(object? sender, EventArgs e)
        {
            try
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
                    NroHabitacion = int.Parse(habitacionSeleccionada.NroHabitacionLabel.Text.Split(' ').Last()),
                    Username = usuarioAutenticado.Username,
                    IdUsuario = usuarioAutenticado.Id
                };

                _reservaService.AgregarReserva(reserva);

                _view.ShowMessage("Reserva registrada correctamente.", "Éxito");
                CargarHabitaciones();
            }
            catch (ValidationException ex)
            {
                _view.ShowMessage($"{ex.Message}", "Error de validación");
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"{ex.Message}", "Error");
            }
        }

        public void CargarHabitaciones()
        {
            var habitaciones = _habitacionServices.GetAll();
            _view.CargarHabitaciones(habitaciones);
        }


        public IGuestView GetGuestView()
        {
            return _view;
        }
    }
}
