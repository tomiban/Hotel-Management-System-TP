using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using Presentation.Views;
using System.ComponentModel.DataAnnotations;

namespace Presentation.Presenters

{

    public class CrearEditarHabitacionPresenter : ICrearEditarHabitacionPresenter
    {
        ICrearEditarHabitacionView _view;
        Lazy<AdminPresenter> _adminPresenter;
        IHabitacionServices _habitacionServices;
        private bool _isEditMode = false;
        private int _editingHabitacionId = 0;

        public CrearEditarHabitacionPresenter(ICrearEditarHabitacionView view, Lazy<AdminPresenter> adminPresenter, IHabitacionServices habitacionServices)
        {
            _view = view;
            _adminPresenter = adminPresenter;
            _habitacionServices = habitacionServices;
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
            catch (ApplicationException ex)
            {
                _view.ShowMessage("Ocurrio un error al redirigir.", "Error");
            }
        }

        public ICrearEditarHabitacionView GetCrearEditarHabitacionView()
        {
            return _view;
        }



        public void SetEditMode(Habitacion habitacion)
        {
            _isEditMode = true;
            _editingHabitacionId = habitacion.NroHabitacion;
            _view.SetEditMode(habitacion); // Llama al método de la vista para llenar los campos
        }
        public void SetAddMode()
        {
            _isEditMode = false;
            _editingHabitacionId = 0;

            // Limpiar todos los campos del formulario para que esté listo para crear una nueva habitación
            _view.LimpiarCampos();

            // Cambiar el título y botón del formulario para indicar que está en modo "Agregar"
            _view.SetTitle("Añadir Habitación");
            _view.SetButtonText("Guardar Habitación");
        }
        public void OnSave(object? sender, EventArgs e)
        {
            try
            {
                if (_isEditMode)
                {
                    // Estamos en modo de edición, actualizar la habitación existente
                    var habitacion = _habitacionServices.GetById(_editingHabitacionId);
                    if (habitacion == null)
                    {
                        _view.ShowMessage("No se pudo encontrar la habitación a actualizar.", "Error");
                        return;
                    }

                    // Actualizar los datos de la habitación
                    habitacion.TipoHabitacion = _view.TipoHabitacion;
                    habitacion.PrecioPorNoche = _view.PrecioPorNoche;
                    habitacion.Disponible = _view.Disponible;
                    habitacion.Capacidad = _view.Capacidad;
                    habitacion.Descripcion = _view.Descripcion;
                    habitacion.NroHabitacion = _view.NroHabitacion;

                    // Llamar al servicio para actualizar la habitación
                    _habitacionServices.Update(habitacion);
                    _view.ShowMessage("Habitación actualizada correctamente.", "Información");

                }
                else
                {
                    // Modo creación: crear una nueva habitación
                    var nroDisponible = _habitacionServices.CheckNroHabitacion(_view.NroHabitacion);
                    if (nroDisponible)
                    {
                        _view.ShowMessage("La habitación ya existe.", "Error");
                        return;
                    }

                    var habitacion = new Habitacion()
                    {
                        TipoHabitacion = _view.TipoHabitacion,
                        PrecioPorNoche = _view.PrecioPorNoche,
                        Disponible = _view.Disponible,
                        Capacidad = _view.Capacidad,
                        NroHabitacion = _view.NroHabitacion,
                        Descripcion = _view.Descripcion
                    };

                    _habitacionServices.Add(habitacion);
                    _view.ShowMessage("Habitación creada correctamente.", "Información");
                    _view.LimpiarCampos();
                }

                // Después de guardar, desactivar el modo edición
                _isEditMode = false;
                _editingHabitacionId = 0;
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error al guardar la habitación: {ex.Message}", "Error");
            }
        }

    }
}
