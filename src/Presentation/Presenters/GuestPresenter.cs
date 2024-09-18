using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using PresentationLayer.Components;
using PresentationLayer.Factories;
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
                _view.ShowMessage(ex.Message, "Error");
            }
        }

        // Cargar las habitaciones y crear las tarjetas usando la fábrica
        public void CargarHabitaciones()
        {
            var habitaciones = _habitacionServices.GetAll(); // Obtener todas las habitaciones
            var habitacionCards = new List<HabitacionCard>();

            // Usar la fábrica para crear las tarjetas de habitaciones
            foreach (var habitacion in habitaciones)
            {
                var habitacionCard = HabitacionCardFactory.CreateHabitacionCard(habitacion);

                // Conectar el evento OnReservarButtonClicked al manejador de eventos
                habitacionCard.OnReservarButtonClicked += HandleRealizarReserva;

                habitacionCards.Add(habitacionCard);
            }

            // Pasar las tarjetas al método de la vista para mostrarlas
            _view.CargarHabitacionCards(habitacionCards);
        }


        public IGuestView GetGuestView()
        {
            return _view;
        }
    }
}
