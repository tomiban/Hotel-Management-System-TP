using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using Presentation.Views;
using Unity;

namespace Presentation.Presenters
{
    public class AdminPresenter : IAdminPresenter
    {
        IUsuarioService _usuarioService;
        IAdminView _view;
        Lazy<ICrearEditarHabitacionPresenter> _crearEditarHabitacionPresenter;
        IHabitacionServices _habitacionServices;
        private bool _eventosSuscritos = false;
        private bool isEditMode = false;
        public AdminPresenter(IAdminView view, Lazy<ICrearEditarHabitacionPresenter> crearEditarHabitacionPresenter, IHabitacionServices habitacionService, IUsuarioService usuarioService)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));  // Asegúrate de que la vista no es null
            _usuarioService = usuarioService ?? throw new ArgumentNullException(nameof(usuarioService));  // Verifica que el servicio no sea null
            _habitacionServices = habitacionService ?? throw new ArgumentNullException(nameof(habitacionService));  // Verifica que el servicio no sea null
            _crearEditarHabitacionPresenter = crearEditarHabitacionPresenter ?? throw new ArgumentNullException(nameof(crearEditarHabitacionPresenter));


            _view.EliminarUsuario += OnEliminarUsuario;
            _view.ActualizarRol += OnActualizarRol;
            //_view.EditarGuardarUsuario += OnEditarGuardarUsuario;
            CargarHabitaciones();
           CargarUsuarios();
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

        private void OnActualizarRol(object? sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del usuario seleccionado
                int userId = _view.GetSelectedUserId();
                if (userId == -1)
                {
                    _view.ShowMessage("No hay usuario seleccionado.", "Error");
                    return;
                }

                // Obtener el nuevo rol seleccionado
                Role newRole = _view.GetSelectedUserRole();

                // Obtener el usuario desde el servicio
                var usuario = _usuarioService.GetUsuarioById(userId);
                if (usuario != null)
                {
                    // Actualizar el rol del usuario
                    usuario.Role = newRole;

                    // Actualizar el usuario en el repositorio
                    _usuarioService.UpdateUsuario(usuario);

                    // Mostrar mensaje de éxito
                    _view.ShowMessage("Rol del usuario actualizado correctamente.", "Información");

                    // Refrescar la lista de usuarios
                    CargarUsuarios();
                }
                else
                {
                    _view.ShowMessage("Usuario no encontrado.", "Error");
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error al actualizar el rol: {ex.Message}", "Error");
            }
        }

        private void OnEliminarUsuario(int userId)
        {
            try
            {
                _usuarioService.DeleteUsuario(userId);  // Llamar a UsuarioService para eliminar el usuario
                CargarUsuarios();  // Refrescar la lista de usuarios después de eliminar
                _view.ShowMessage("Usuario eliminado correctamente.", "Información");
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error al eliminar el usuario: {ex.Message}", "Error");
            }
        }
        private void OnEliminarHabitacion(object? sender, EventArgs e)
        {
            try
            {
                int id = _view.ObtenerNroHabitacionSeleccionado(); // Obtener el ID de la habitación seleccionada
                _habitacionServices.Delete(id); // Llamar al servicio para eliminar la habitación
                CargarHabitaciones(); // Refrescar la lista
                _view.ShowMessage("Habitación eliminada correctamente.", "Información");
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
            try
            {
                var usuarios = _usuarioService.GetAllUsuarios(); // Método para obtener todos los usuarios
                _view.ActualizarListaUsuarios(usuarios);
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Error al cargar los usuarios.", $"Error: {ex.Message}");
            }
        }
        public IAdminView GetAdminView()
        {
            return _view;
        }
    }
}
