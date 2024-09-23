using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using Presentation.Views;

namespace Presentation.Presenters
{
    public class CrearEditarHabitacionPresenter : ICrearEditarHabitacionPresenter
    {
        ICrearEditarHabitacionView _view;
        IHabitacionServices _habitacionServices;
        Lazy<IAdminPresenter> _adminPresenter;
        private bool _isEditMode = false;
        private int _editingHabitacionId = 0;

        public CrearEditarHabitacionPresenter(Lazy<IAdminPresenter> adminPresenter, ICrearEditarHabitacionView view, IHabitacionServices habitacionServices)
        {
            _view = view;
            _habitacionServices = habitacionServices;
            _adminPresenter = adminPresenter;
            _view.SaveEvent += OnSave;
            _view.NavigateToAdminView += OnAdminRedirect;
        }

        public void OnAdminRedirect(object? sender, EventArgs e)
        {
            try
            {
                _adminPresenter.Value.CargarHabitaciones();
                _adminPresenter.Value.ShowView();

                _view.HideView();
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

            // Pedir a la vista que se configure en modo edición
            _view.SetEditMode(habitacion);
            _view.SetTitle("Editar Habitación");
            _view.SetButtonText("Actualizar Habitación");
        }

        public void SetAddMode()
        {
            _isEditMode = false;
            _editingHabitacionId = 0;

            // Pedir a la vista que se limpie y se configure para agregar
            _view.SetAddMode();
            //_view.LimpiarCampos();
            _view.SetTitle("Añadir Habitación");
            _view.SetButtonText("Guardar Habitación");
            
        }

        public void OnSave(object? sender, EventArgs e)
        {
            try
            {
                // Preparar el objeto habitación con los datos de la vista
                var habitacion = PrepareHabitacionObject();

                if (_isEditMode)
                {
                    if (!_habitacionServices.Exists(_editingHabitacionId))
                    {
                        _view.ShowMessage("No se pudo encontrar la habitación a actualizar.", "Error");
                        return;
                    }

                    // Actualizar la habitación
                    _habitacionServices.Update(habitacion);
                    _view.ShowMessage("Habitación actualizada correctamente.", "Información");
                }
                else
                {
                    // Validar que la habitación no exista
                    if (_habitacionServices.Exists(_view.NroHabitacion))
                    {
                        _view.ShowMessage("La habitación ya existe.", "Error");
                        return;
                    }

                    // Crear nueva habitación
                    _habitacionServices.Add(habitacion);
                    _view.ShowMessage("Habitación creada correctamente.", "Información");
                    //_view.LimpiarCampos();
                }

                // Resetear el modo de edición
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
            // Preparar el objeto Habitacion usando la vista
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

        public ICrearEditarHabitacionView GetCrearEditarHabitacionView()
        {
            return _view;
        }
    }
}
