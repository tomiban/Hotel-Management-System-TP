using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using PresentationLayer.Components;
using PresentationLayer.Events;
using PresentationLayer.Utils;
using PresentationLayer.Views;
using System.ComponentModel.DataAnnotations;
using static Domain.Entities.Reserva;

namespace PresentationLayer.Presenters
{
    public class GuestPresenter : IGuestPresenter
    {
        private readonly IGuestView _view;
        private readonly IReservaService _reservaService;
        private readonly IAuthService _authService;
        private readonly IHabitacionServices _habitacionServices;
        private readonly INavigationService _navigationService;
        private Reserva _reservaSeleccionada;  //

        public GuestPresenter(IGuestView view, IHabitacionServices habitacionServices, IReservaService reservaService, IAuthService authService, INavigationService navigationService)
        {
            _view = view;
            _reservaService = reservaService;
            _authService = authService;
            _habitacionServices = habitacionServices;
            _navigationService = navigationService;

            _view.OnFiltrarHabitacionesRangoFechas += HandleFiltrarHabitacionesRangoFechas;
            _view.OnRealizarReserva += HandleRealizarReserva;
            _view.ReservaSeleccionada += HandleReservaSeleccionada;
            _view.OnModificarReserva += HandleModificarReserva;
            _view.OnLogoutTabSelected += HandleLogoutTabSelected;

            CargarReservas();
        }

        private void HandleLogoutTabSelected(object? sender, EventArgs e)
        {
            _view.ShowDialogLogout();
        }

        public void ShowView()
        {
            _view.ShowView();
        }

        public void HideView()
        {
            _view.HideView();
        }

        private void HandleFiltrarHabitacionesRangoFechas(object? sender, FiltroFechaEventArgs e)
        {
            try
            {
                var habitacionesDisponibles = _habitacionServices.FiltrarHabitacionesDisponibles(e.FechaDesde, e.FechaHasta);
                var habitacionCards = habitacionesDisponibles.Select(h => new HabitacionCard(h)).ToList();
                _view.CargarHabitacionCards(habitacionCards);
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Error", $"Ocurrió un error al filtrar las habitaciones: {ex.Message}");
            }
        }
        // Método que maneja la selección de una reserva
        private void HandleReservaSeleccionada(object? sender, int reservaId)
        {
            try
            {
                var reserva = _reservaService.GetById(reservaId);

                if (reserva != null)
                {
                    _reservaSeleccionada = reserva;  // Almacenar la reserva seleccionada

                    // Habilitar/deshabilitar el botón según el estado de la reserva
                    if (reserva.Estado == EstadoReserva.Activa)
                    {
                        _view.SetModificarReservaButtonState(true);  // Habilitar el botón
                    }
                    else
                    {
                        _view.SetModificarReservaButtonState(false);  // Deshabilitar el botón
                    }
                }
                else
                {
                    _view.ShowMessage("No se encontró la reserva seleccionada.", "Error");
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Ocurrió un error al intentar cargar los detalles de la reserva: {ex.Message}", "Error");
            }
        }

        // Método que maneja el clic en el botón "Modificar Reserva"
        private void HandleModificarReserva(object? sender, EventArgs e)
        {
            if (_reservaSeleccionada != null && _reservaSeleccionada.Estado == EstadoReserva.Activa)
            {
                _view.HideView();
                _navigationService.NavigateTo<IDetallesReservaPresenter, Reserva>(_reservaSeleccionada);  // Navegar a la vista de detalles
            }
            else
            {
                _view.ShowMessage("La reserva seleccionada no se puede modificar.", "Error");
            }
        }

        private void HandleRealizarReserva(object? sender, HabitacionEventArgs e)
        {
            try
            {
                var usuarioAutenticado = _authService.GetCurrentUser();
                if (usuarioAutenticado == null)
                {
                    _view.ShowMessage("Debe iniciar sesión antes de realizar una reserva.", "Error");
                    return;
                }

                var reserva = new Reserva
                {
                    FechaInicio = _view.ReservaFechaDesde,
                    FechaFin = _view.ReservaFechaHasta,
                    NroHabitacion = e.Habitacion.NroHabitacion,
                    TipoHabitacion = e.Habitacion.TipoHabitacion,
                    UserId = usuarioAutenticado.Id,
                    Username = usuarioAutenticado.Username,
                    PrecioPorNoche = e.Habitacion.PrecioPorNoche
                };

                _reservaService.AgregarReserva(reserva);
                _view.ShowMessage("Reserva registrada correctamente.", "Éxito");

                CargarReservas();
                _habitacionServices.FiltrarHabitacionesDisponibles(_view.ReservaFechaDesde, _view.ReservaFechaHasta);
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

        public void CargarReservas()
        {
            var usuarioAutenticado = _authService.GetCurrentUser();
            var reservasUsuario = _reservaService.GetAllReservasUser(usuarioAutenticado.Id);
            _view.CargarReservas(reservasUsuario);
        }

    
    }
}
