using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using PresentationLayer.Components;
using PresentationLayer.Events;
using PresentationLayer.Factories;
using PresentationLayer.Helpers;
using PresentationLayer.Views;
using Services.Services.ReservaServices;
using System.CodeDom;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PresentationLayer.Presenters
{
    public class GuestPresenter : IGuestPresenter
    {
        IGuestView _view;
        Lazy<IDetallesReservaPresenter> _detallesReservaPresenter;
        IReservaService _reservaService;
        IAuthService _authService;
        IHabitacionServices _habitacionServices;
        Reserva _reservaActual;

        public GuestPresenter(IGuestView view, Lazy<IDetallesReservaPresenter> detallesReservaPresenter, IHabitacionServices habitacionServices, IReservaService reservaService, IAuthService authService)
        {
            _view = view;
            _reservaService = reservaService;
            _authService = authService;
            _habitacionServices = habitacionServices;
            _detallesReservaPresenter = detallesReservaPresenter;  // Asignar Lazy<T> correctamente
            _view.OnFiltrarHabitacionesRangoFechas += HandleFiltrarHabitacionesRangoFechas;
            _view.OnRealizarReserva += HandleRealizarReserva;
            _view.ReservaSeleccionada += HandleReservaSeleccionada;
            // Suscribirse al evento que indica que una reserva ha sido modificada
            _detallesReservaPresenter.Value.OnReservaModificada += OnReservaModificada;

            CargarReservas();
        }



        private void HandleFiltrarHabitacionesRangoFechas(object? sender, FiltroFechaEventArgs e)
        {
            try
            {
                var habitacionesDisponibles = _habitacionServices.FiltrarHabitacionesDisponibles(e.FechaDesde, e.FechaHasta);

                // Crear las tarjetas de las habitaciones disponibles
                var habitacionCards = habitacionesDisponibles
                    .Select(h => new HabitacionCard(h))
                    .ToList();

                // Actualizar la vista con las nuevas tarjetas filtradas
                _view.CargarHabitacionCards(habitacionCards);
                
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Error", $"Ocurrió un error al filtrar las habitaciones: {ex.Message}");
            }
        }

        // Maneja el evento de reserva modificada
        private void OnReservaModificada(object sender, EventArgs e)
        {
            CargarReservas();
        }


        private void HandleReservaSeleccionada(object? sender, int reservaId)
        {
            try
            {
                if (reservaId > 0)
                {
                    var reserva = _reservaService.GetById(reservaId);

                    if (reserva == null)
                    {
                        _view.ShowMessage("No se encontró la reserva seleccionada.", "Error");
                        return;
                    }

                    _reservaActual = reserva;


                    _detallesReservaPresenter.Value.SetEditMode(_reservaActual);
                    _detallesReservaPresenter.Value.GetDetallesReservaView().ShowView();  // Acceder a .Value
                }
                else
                {
                    _view.ShowMessage("ID de reserva no válido.", "Error");
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Ocurrió un error al intentar cargar los detalles de la reserva: {ex.Message}", "Error");
            }
        }

        public void HandleRealizarReserva(object? sender, HabitacionEventArgs e)
        {
            try
            {

                var usuarioAutenticado = _authService.GetCurrentUser();

                if (usuarioAutenticado == null)
                {
                    _view.ShowMessage("Debe iniciar sesión antes de realizar una reserva.", "Error");
                    return;
                }
                var reserva = new Reserva()
                {
                    FechaInicio = _view.ReservaFechaDesde,
                    FechaFin = _view.ReservaFechaHasta,
                    NroHabitacion = e.Habitacion.NroHabitacion,
                    TipoHabitacion = e.Habitacion.TipoHabitacion,
                    UserId = usuarioAutenticado.Id,
                    Username = usuarioAutenticado.Username,
                    PrecioPorNoche = e.Habitacion.PrecioPorNoche,
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
            var reservasUsuario = _reservaService.GetAll(usuarioAutenticado.Id);

            _view.CargarReservas(reservasUsuario);
        }


        public IGuestView GetGuestView()
        {
            return _view;
        }
    }
}
