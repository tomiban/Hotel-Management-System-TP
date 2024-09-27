using ApplicationLayer.Services;
using Domain.Entities;
using PresentationLayer.Presenters;
using PresentationLayer.Views;

public class DetallesReservaPresenter : IDetallesReservaPresenter
{
    private readonly IDetallesReservaView _view;
    private readonly IReservaService _reservaService;
    private Reserva _reservaActual;

    // Evento que será lanzado cuando la reserva sea actualizada o cancelada
    public event EventHandler OnReservaModificada;

    // Constructor
    public DetallesReservaPresenter(IDetallesReservaView view, IReservaService reservaService)
    {
        _view = view;
        _reservaService = reservaService;

        // Suscribirse a los eventos de la vista
        _view.OnActualizarReserva += HandleActualizarReserva;
        _view.OnCancelarReserva += HandleCancelarReserva;
        _view.OnRedirectToClientView += HandleRedirectToClientView;
        _view.OnFechaCambiada += HandleFechaCambiada;
    }

    private void HandleFechaCambiada(object? sender, EventArgs e)
    {
        try
        {
            _reservaActual.FechaInicio = _view.FechaInicio;
            _reservaActual.FechaFin = _view.FechaFin;
            decimal nuevoPrecio = _reservaService.RecalcularDiasYPrecio(_reservaActual);

            // Actualizar la vista con el nuevo precio
            _view.MostrarPrecioActualizado(nuevoPrecio);
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al recalcular el precio: {ex.Message}", "Error");
        }
    }

    private void HandleRedirectToClientView(object? sender, EventArgs e)
    {
        try
        {
            _view.HideView();

        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al redirigir a la vista de clientes: {ex.Message}", "Error");
        }
    }

    // Método para cargar y mostrar los detalles de una reserva
    public void SetEditMode(Reserva reserva)
    {
        _reservaActual = reserva;  // Guardar la reserva actual para futuras acciones
        _view.MostrarDetalleReserva(reserva);  // Mostrar los detalles de la reserva en la vista
    }

    // Maneja la actualización de la reserva
    private void HandleActualizarReserva(object sender, EventArgs e)
    {
        try
        {
            _reservaService.ActualizarReserva(_reservaActual);  // Llamada al servicio para actualizar la reserva
            _view.ShowMessage("Reserva actualizada con éxito.", "Éxito");

            // Lanzar evento cuando la reserva es actualizada
            OnReservaModificada?.Invoke(this, EventArgs.Empty);

            _view.HideView();  // Cerrar la vista después de actualizar
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al actualizar la reserva: {ex.Message}", "Error");
        }
    }

    // Maneja la cancelación de la reserva
    private void HandleCancelarReserva(object sender, EventArgs e)
    {
        try
        {
            _reservaService.CancelarReserva(_reservaActual.Id);  // Llamada al servicio para cancelar la reserva
            _view.ShowMessage("Reserva cancelada con éxito.", "Éxito");

            // Lanzar evento cuando la reserva es cancelada
            OnReservaModificada?.Invoke(this, EventArgs.Empty);

            _view.HideView();  // Cerrar la vista después de cancelar
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al cancelar la reserva: {ex.Message}", "Error");
        }
    }

    public IDetallesReservaView GetDetallesReservaView()
    {
        return _view;
    }
}
