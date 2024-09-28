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
        IUsuarioService _usuarioService;
        private readonly IHabitacionServices _habitacionServices;
        private readonly INavigationService _navigationService;
        private bool _eventosSuscritos = false;
        private bool isEditMode = false;

        public AdminPresenter(IAdminView view, IHabitacionServices habitacionServices, INavigationService navigationService, IUsuarioService usuarioService)
        {
            _view = view;
            _view.EliminarUsuario += OnEliminarUsuario;
            _view.ActualizarRol += OnActualizarRol;
            _habitacionServices = habitacionServices;
            _usuarioService = usuarioService; 
            _navigationService = navigationService;

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
    }
}
