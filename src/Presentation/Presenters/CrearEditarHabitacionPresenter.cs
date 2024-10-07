using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using Presentation.Views;
using PresentationLayer.Utils;

namespace Presentation.Presenters
{
    public class CrearEditarHabitacionPresenter : ICrearEditarHabitacionPresenter
    {
        private readonly ICrearEditarHabitacionView _view;
        private readonly IHabitacionServices _habitacionServices;
        private readonly INavigationService _navigationService;
        private bool _isEditMode = false;
        private int _editingHabitacionId = 0;

        public CrearEditarHabitacionPresenter(ICrearEditarHabitacionView view, IHabitacionServices habitacionServices, INavigationService navigationService)
        {
            _view = view;
            _habitacionServices = habitacionServices;
            _navigationService = navigationService;

            _view.SaveEvent += OnSave;
            _view.NavigateToAdminView += OnAdminRedirect;
        }

        public void ShowView()
        {
            _view.ShowView();
        }

        public void HideView()
        {
            _view.HideView();
        }

        public void OnAdminRedirect(object? sender, EventArgs e)
        {
            try
            {
                var adminPresenter = _navigationService.GetPresenter<IAdminPresenter>();
                adminPresenter.CargarHabitaciones(); 
                adminPresenter.CargarDatosDashboard();
                _navigationService.GoBack();  // Regresar a la vista de Admin
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Ocurrió un error al redirigir.", "Error");
            }
        }

        public void SetEditMode(Habitacion habitacion)
        {
            _isEditMode = true;
            _editingHabitacionId = habitacion.NroHabitacion;
            _view.SetEditMode(habitacion);
            _view.SetTitle("Editar Habitación");
            _view.SetButtonText("Actualizar Habitación");
        }

        public void SetAddMode()
        {
            _isEditMode = false;
            _editingHabitacionId = 0;
            _view.SetAddMode();
            _view.SetTitle("Añadir Habitación");
            _view.SetButtonText("Guardar Habitación");

        }

        private void OnSave(object? sender, EventArgs e)
        {
            try
            {
                var habitacion = PrepareHabitacionObject();

                if (_isEditMode)
                {
                    if (!_habitacionServices.Exists(_editingHabitacionId))
                    {
                        _view.ShowMessage("No se pudo encontrar la habitación a actualizar.", "Error");
                        return;
                    }

                    _habitacionServices.Update(habitacion);
                    _view.ShowMessage("Habitación actualizada correctamente.", "Éxito");
                 
                }
                else
                {
                    if (_habitacionServices.Exists(_view.NroHabitacion))
                    {
                        _view.ShowMessage("La habitación ya existe.", "Error");
                        return;
                    }

                    _habitacionServices.Add(habitacion);
                    _view.ShowMessage("Habitación creada correctamente.", "Éxito");
                    _view.SetAddMode();
                }

                _isEditMode = false;
                _editingHabitacionId = 0;

            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error al guardar la habitación: {ex.Message}", "Error");
            }
        }

        private Habitacion PrepareHabitacionObject()
        {
            return new Habitacion
            {
                TipoHabitacion = _view.TipoHabitacion,
                PrecioPorNoche = _view.PrecioPorNoche,
                Disponible = _view.Disponible,
                Capacidad = _view.Capacidad,
                NroHabitacion = _isEditMode ? _editingHabitacionId : _view.NroHabitacion,
                Descripcion = _view.Descripcion
            };
        }
    }
}
