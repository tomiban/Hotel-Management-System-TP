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
        private readonly IReservaService _reservaService;
        private readonly IUsuarioService _usuarioService;
        private readonly INavigationService _navigationService;

        private List<Habitacion> _habitaciones;
        private List<Reserva> _reservas;
        private List<Usuario> _usuarios;

        private bool _eventosSuscritos = false;
        private bool isEditMode = false;

        public AdminPresenter(IAdminView view, IHabitacionServices habitacionServices, IReservaService reservaService, IUsuarioService usuarioService, INavigationService navigationService)
        {
            _view = view;
            _view.EliminarUsuario += OnEliminarUsuario;
            _view.ActualizarRol += OnActualizarRol;
            _view.RedirectToCrearEditarHabitacion += OnRedirectToCrearEditarHabitacion;
            _view.EliminarHabitacion += OnEliminarHabitacion;
            _view.EditarHabitacion += OnEditHabitacion;
            _habitacionServices = habitacionServices;
            _reservaService = reservaService;
            _usuarioService = usuarioService;
            _navigationService = navigationService;

            CargarHabitaciones();
            CargarReservas();
            CargarUsuarios();
            CargarDatosDashboard();
        }

        public void CargarListaHabitaciones(List<Habitacion> habitaciones)
        {
            _view.ActualizarListaHabitaciones(habitaciones);
        }

        public void CargarListaReservasActivas(List<Reserva> reservas)
        {
            _view.CargarListaReservasActivas(reservas);
        }



        public void ShowView()
        {
            _view.ShowView();
        }

        public void HideView()
        {
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
                _navigationService.NavigateTo<ICrearEditarHabitacionPresenter, Habitacion>(habitacion);
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
                _navigationService.NavigateTo<ICrearEditarHabitacionPresenter>();
               _navigationService.GetPresenter<ICrearEditarHabitacionPresenter>().SetAddMode();
                
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error al redirigir: {ex.Message}", "Error");
            }
        }

        public void CargarHabitaciones()
        {
            var habitaciones = _habitacionServices.GetAll();
            _habitaciones = habitaciones.ToList();
            CargarListaHabitaciones(habitaciones);
        }

        public void CargarReservas()
        {
            var reservas = _reservaService.GetAllReservasActivas();
            _reservas = reservas.ToList();
            CargarListaReservasActivas(reservas);
        }

        public void CargarUsuarios()
        {
            var usuarios = _usuarioService.GetAllUsuarios();
            _usuarios = usuarios.ToList();
            CargarListaUsuarios(usuarios);
        }

        public void CargarDatosDashboard()
        {


            int totalUsuarios = _usuarios.Count;
            int totalHabitaciones = _habitaciones.Count;
            int totalReservasCurso = _reservas.Where(r =>
                r.FechaInicio <= DateTime.Today && r.FechaFin >= DateTime.Today).ToList().Count;

            // Obtener la ocupación (habitaciones ocupadas / total habitaciones)
            double porcentajeOcupacion = totalHabitaciones > 0 ? (double)totalReservasCurso / totalHabitaciones * 100 : 0;

            int totalUsuariosRecientes = _usuarios.Count(u => u.FechaRegistro >= DateTime.Today.AddDays(-7));

            decimal totalFacturado = _reservas.Sum(r => r.MontoTotal);

            _view.ActualizarDashboard(totalReservasCurso, porcentajeOcupacion, totalUsuarios, totalUsuariosRecientes, totalFacturado);

        }
        public void CargarListaUsuarios(List<Usuario> usuarios)
        {
            try
            {
                _view.ActualizarListaUsuarios(usuarios);
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Error al cargar los usuarios.", $"Error: {ex.Message}");
            }
        }
    }
}
