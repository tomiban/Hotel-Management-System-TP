using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using Presentation.Views;
using PresentationLayer.Utils;
using Unity;

namespace Presentation.Presenters
{
    public class AdminPresenter : IAdminPresenter
    {
        private readonly IAdminView _view;
        private readonly IHabitacionServices _habitacionServices;
        private readonly INavigationService _navigationService;
        private bool _eventosSuscritos = false;

        public AdminPresenter(IAdminView view, IHabitacionServices habitacionServices, INavigationService navigationService)
        {
            _view = view;
            _habitacionServices = habitacionServices;
            _navigationService = navigationService;

            CargarHabitaciones();
            SubscribeEvents();
        }

        public void SubscribeEvents()
        {
            if (!_eventosSuscritos)
            {
                _view.RedirectToCrearEditarHabitacion += OnRedirectToCrearEditarHabitacion;
                _view.EliminarHabitacion += OnEliminarHabitacion;
                _view.EditarHabitacion += OnEditHabitacion;
                _eventosSuscritos = true;
            }
        }

        public void UnsubscribeEvents()
        {
            if (_eventosSuscritos)
            {
                _view.RedirectToCrearEditarHabitacion -= OnRedirectToCrearEditarHabitacion;
                _view.EliminarHabitacion -= OnEliminarHabitacion;
                _eventosSuscritos = false;
            }
        }

        public void ShowView()
        {
            SubscribeEvents();
            _view.ShowView();
        }

        public void HideView()
        {
            UnsubscribeEvents();
            _view.HideView();
        }

        private void OnEliminarHabitacion(object? sender, EventArgs e)
        {
            try
            {
                int id = _view.ObtenerNroHabitacionSeleccionado();
                _habitacionServices.Delete(id);  // Eliminar la habitación seleccionada
                CargarHabitaciones();  // Refrescar la lista de habitaciones
                _view.ShowMessage("Habitación eliminada correctamente.", "Información");
                _view.SetEliminarHabitacionButtonState(false);
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error: {ex.Message}", "No se pudo eliminar la habitación");
            }
        }

        private void OnEditHabitacion(object? sender, EventArgs e)
        {
            try
            {
                int nroHabitacion = _view.ObtenerNroHabitacionSeleccionado();
                var habitacion = _habitacionServices.GetById(nroHabitacion);

                if (habitacion == null)
                {
                    _view.ShowMessage("No se encontró la habitación seleccionada.", "Error");
                    return;
                }

                // Usar el NavigationService para navegar a Crear/Editar Habitación en modo edición
                _navigationService.NavigateTo<ICrearEditarHabitacionPresenter>();
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error al intentar editar la habitación: {ex.Message}", "Error");
            }
        }

        private void OnRedirectToCrearEditarHabitacion(object? sender, EventArgs e)
        {
            try
            {
                // Usar el NavigationService para navegar a Crear/Editar Habitación en modo creación
                _navigationService.NavigateTo<ICrearEditarHabitacionPresenter>();
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error al redirigir: {ex.Message}", "Error");
            }
        }

        public void CargarHabitaciones()
        {
            var habitaciones = _habitacionServices.GetAll();
            _view.ActualizarListaHabitaciones(habitaciones);
        }

        public IAdminView GetAdminView()
        {
            return _view;
        }

        public void CargarUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
