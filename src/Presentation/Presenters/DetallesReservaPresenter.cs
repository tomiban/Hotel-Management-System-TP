using ApplicationLayer.Services;
using Domain.Entities;
using PresentationLayer.Presenters;
using PresentationLayer.Utils;
using PresentationLayer.Views;
using System.ComponentModel.DataAnnotations;

public class DetallesReservaPresenter : IDetallesReservaPresenter
{
    private readonly IDetallesReservaView _view;
    private readonly IReservaService _reservaService;
    private readonly INavigationService _navigationService;
    private Reserva _reservaActual;

    public event EventHandler OnReservaModificada;

    // Constructor
    public DetallesReservaPresenter(IDetallesReservaView view, IReservaService reservaService, INavigationService navigationService)
    {
        _view = view;
        _reservaService = reservaService;
        _navigationService = navigationService;

        _view.OnActualizarReserva += HandleActualizarReserva;
        _view.OnCancelarReserva += HandleCancelarReserva;
        _view.OnRedirectToClientView += HandleRedirectToClientView;
        _view.OnFechaCambiada += HandleFechaCambiada;
    }

    public void ShowView()
    {
        _view.ShowView();
    }

    public void HideView()
    {
        _view.HideView();
    }

    private void HandleFechaCambiada(object? sender, EventArgs e)
    {
        try
        {
            ValidarFechas();
            _reservaActual.FechaInicio = _view.FechaInicio;
            _reservaActual.FechaFin = _view.FechaFin;
            decimal nuevoPrecio = _reservaService.RecalcularDiasYPrecio(_reservaActual);
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
            var presenter = _navigationService.GetPresenter<IGuestPresenter>();
            presenter.CargarReservas();
            _navigationService.GoBack();
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al redirigir a la vista de clientes: {ex.Message}", "Error");
        }
    }

    public void SetEditMode(Reserva reserva)
    {
        _reservaActual = reserva;
        _view.MostrarDetalleReserva(reserva);
    }

    private void HandleActualizarReserva(object sender, EventArgs e)
    {
        try
        {
            ValidarFechas();
        
            _reservaService.ActualizarReserva(_reservaActual);
            _view.ShowMessage("Reserva actualizada con éxito.", "Éxito");

            EventHelper.RaiseEvent(this, OnReservaModificada, EventArgs.Empty);
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al actualizar la reserva: {ex.Message}", "Error");
        }
    }

    private void HandleCancelarReserva(object sender, EventArgs e)
    {
        try
        {
            _reservaService.CancelarReserva(_reservaActual.Id);
            _view.ShowMessage("Reserva cancelada con éxito.", "Éxito");

            OnReservaModificada?.Invoke(this, EventArgs.Empty);

            HandleRedirectToClientView(null, null);
        }
        catch (Exception ex)
        {
            _view.ShowMessage($"Error al cancelar la reserva: {ex.Message}", "Error");
        }
    }

    private void ValidarFechas()
    {
        if (_view.FechaInicio < DateTime.Today)
        {
            throw new ValidationException("La fecha de inicio no puede ser anterior a la fecha de hoy.");
        }

        if (_view.FechaInicio > _view.FechaFin)
        {
           throw new ValidationException("La fecha de inicio no puede ser posterior a la fecha de fin.");
        }
    }
}
