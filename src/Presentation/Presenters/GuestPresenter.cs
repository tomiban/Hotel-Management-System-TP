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
        private Reserva _reservaSeleccionada;

        public GuestPresenter(IGuestView view, IHabitacionServices habitacionServices, IReservaService reservaService, IAuthService authService, INavigationService navigationService)
        {
            _view = view;
            _reservaService = reservaService;
            _authService = authService;
            _habitacionServices = habitacionServices;
            _navigationService = navigationService;

            // Suscripción a eventos de la vista
            SubscribeToViewEvents();

            // Carga inicial de datos
            CargarDatosIniciales();
            CargarDatosUsuario();
        }

        private void SubscribeToViewEvents()
        {
            _view.OnFiltrarHabitacionesRangoFechas += HandleFiltrarHabitacionesRangoFechas;
            _view.OnRealizarReserva += HandleRealizarReserva;
            _view.ReservaSeleccionada += HandleReservaSeleccionada;
            _view.OnModificarReserva += HandleModificarReserva;
            _view.OnLogoutTabSelected += HandleLogoutTabSelected;
            _view.OnRedirectToCambiarContraseña += HandleModificarContraseña;
        }

        private void CargarDatosIniciales()
        {
            try
            {
                CargarDatosUsuario();
                CargarReservas();
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Error", $"Error al cargar los datos iniciales: {ex.Message}");
            }
        }

        private void CargarDatosUsuario()
        {
            var usuarioAutenticado = _authService.GetCurrentUser();
            if (usuarioAutenticado != null)
            {
                _view.CargarDatosUsuario(usuarioAutenticado);
            }
        }

        public void ShowView()
        {
            _view.ShowView();
        }

        public void HideView()
        {
            _view.HideView();
        }

        // Manejo de Logout
        private void HandleLogoutTabSelected(object? sender, EventArgs e)
        {
            _view.ShowDialogLogout();
        }

        private void HandleFiltrarHabitacionesRangoFechas(object? sender, FiltroFechaEventArgs e)
        {
            try
            {
                CargarHabitaciones(e.FechaDesde, e.FechaHasta, e.CategoriaSeleccionada);
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Error", $"Ocurrió un error al filtrar las habitaciones: {ex.Message}");
            }
        }

        // Método centralizado para cargar habitaciones
        public void CargarHabitaciones(DateTime? fechaDesde = null, DateTime? fechaHasta = null, string categoriaSeleccionada = "Todas las habitaciones")
        {
            fechaDesde = _view.ReservaFechaDesde;
            fechaHasta = _view.ReservaFechaHasta;

            var habitacionesDisponibles = _habitacionServices.FiltrarHabitacionesDisponibles(fechaDesde.Value, fechaHasta.Value);

            // Filtrar por categoría si es necesario
            if (!string.IsNullOrEmpty(categoriaSeleccionada) && categoriaSeleccionada != "Todas las habitaciones")
            {
                habitacionesDisponibles = habitacionesDisponibles
                    .Where(h => h.TipoHabitacion.ToString() == categoriaSeleccionada)
                    .ToList();
            }

            // Crear tarjetas de habitaciones
            var habitacionCards = habitacionesDisponibles.Select(h => new HabitacionCard(h)).ToList();

            // Cargar las tarjetas filtradas en la vista
            _view.CargarHabitacionCards(habitacionCards);
        }

        // Maneja la selección de una reserva
        private void HandleReservaSeleccionada(object? sender, int reservaId)
        {
            try
            {
                _reservaSeleccionada = _reservaService.GetById(reservaId);

                if (_reservaSeleccionada != null)
                {
                    _view.SetModificarReservaButtonState(_reservaSeleccionada.Estado == EstadoReserva.Activa);
                }
                else
                {
                    _view.ShowMessage("Error", "No se encontró la reserva seleccionada.");
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Error", $"Ocurrió un error al cargar los detalles de la reserva: {ex.Message}");
            }
        }

        // Maneja el clic en "Modificar Reserva"
        private void HandleModificarReserva(object? sender, EventArgs e)
        {
            if (_reservaSeleccionada?.Estado == EstadoReserva.Activa)
            {
                _view.HideView();
                _navigationService.NavigateTo<IDetallesReservaPresenter, Reserva>(_reservaSeleccionada);
            }
            else
            {
                _view.ShowMessage("Error", "La reserva seleccionada no se puede modificar.");
            }
        }

        // Maneja la creación de una nueva reserva
        private void HandleRealizarReserva(object? sender, HabitacionEventArgs e)
        {
            try
            {
                var usuarioAutenticado = _authService.GetCurrentUser();
                if (usuarioAutenticado == null)
                {
                    _view.ShowMessage("Error", "Debe iniciar sesión antes de realizar una reserva.");
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
                _view.ShowMessage("Éxito", "Reserva registrada correctamente.");

         
                CargarReservas();
                CargarHabitaciones();

            }
            catch (ValidationException ex)
            {
                _view.ShowMessage("Error de validación", ex.Message);
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Error", $"Ocurrió un error al realizar la reserva: {ex.Message}");
            }
        }

        private void HandleModificarContraseña(object? sender, EventArgs e)
        {
            _navigationService.NavigateTo<ICambiarContraseñaPresenter>();
        }
        public void CargarReservas()
        {
            var usuarioAutenticado = _authService.GetCurrentUser();
            var reservasUsuario = _reservaService.GetAllReservasUser(usuarioAutenticado.Id);
            _view.CargarReservas(reservasUsuario);
        }
    }
}
