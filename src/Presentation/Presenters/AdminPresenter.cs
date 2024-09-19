using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using Presentation.Views;
using Unity;

namespace Presentation.Presenters
{
    public class AdminPresenter : IAdminPresenter
    {
        IAdminView _view;
        Lazy<ICrearEditarHabitacionPresenter> _crearEditarHabitacionPresenter;
        IHabitacionServices _habitacionServices;
        private bool _eventosSuscritos = false;
        public AdminPresenter(IAdminView view, Lazy<ICrearEditarHabitacionPresenter> crearEditarHabitacionPresenter, IHabitacionServices habitacionService)
        {
            _view = view;

            _habitacionServices = habitacionService;
            _crearEditarHabitacionPresenter = crearEditarHabitacionPresenter;
          
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
                int id = _view.ObtenerNroHabitacionSeleccionado(); // Obtener el ID de la habitación seleccionada
                _habitacionServices.Delete(id); // Llamar al servicio para eliminar la habitación
                CargarHabitaciones(); // Refrescar la lista
                _view.ShowMessage("Habitación eliminada", "La habitación ha sido eliminada correctamente.");
                _view.SetEliminarHabitacionButtonState(false);
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Error", $"No se pudo eliminar la habitación: {ex.Message}");
            }
        }

        public void OnEditHabitacion(object? sender, EventArgs e)
        {
            try
            {
                // Obtener el número de habitación seleccionada
                int nroHabitacion = _view.ObtenerNroHabitacionSeleccionado();
                var habitacion = _habitacionServices.GetById(nroHabitacion);
                _view.SetEditarHabitacionButtonState(false);

                if (habitacion == null)
                {
                    _view.ShowMessage("No se encontró la habitación seleccionada.", "Error");
                    return;
                }

                // Redirigir a la vista de Crear/Editar Habitaciones
                HideView();
                var crearEditarView = _crearEditarHabitacionPresenter.Value.GetCrearEditarHabitacionView();

                // Llenar los campos de la vista con la habitación seleccionada
                _crearEditarHabitacionPresenter.Value.SetEditMode(habitacion);  // Activa el modo de edición
                crearEditarView.ShowView();
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error al intentar editar la habitación: {ex.Message}", "Error");
            }
        }

        public void OnRedirectToCrearEditarHabitacion(object? sender, EventArgs e)
        {
            try
            {
                // Ocultar la vista actual (AdminView)
                HideView();

                // Redirigir a la vista de Crear/Editar habitaciones
                var crearEditarView = _crearEditarHabitacionPresenter.Value.GetCrearEditarHabitacionView();

                // Asegurarse de que esté en modo de creación (no edición)
                _crearEditarHabitacionPresenter.Value.SetAddMode();

                // Mostrar la vista de crear/editar habitación
                crearEditarView.ShowView();
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Ocurrió un error al redirigir.", "Error");
            }
        }


        public  void CargarHabitaciones()
        {
            var habitaciones =  _habitacionServices.GetAll();

            _view.ActualizarListaHabitaciones(habitaciones);
        }

        public void CargarUsuarios()
        {
            var usuarios = new List<Usuario>();
            _view.ActualizarListaUsuarios(usuarios);
        }

        public IAdminView GetAdminView()
        {
            return _view;
        }
    }
}
