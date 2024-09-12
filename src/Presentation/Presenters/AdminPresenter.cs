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
            //CargarUsuarios();

            SubscribeEvents();

        }

        public void SubscribeEvents()
        {
            if (!_eventosSuscritos)
            {
                _view.RedirectToCrearEditarHabitacion += OnRedirectToCrearEditarHabitacion;
                _view.EliminarHabitacion += OnEliminarHabitacion;
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


        public void OnRedirectToCrearEditarHabitacion(object? sender, EventArgs e)
        {
            try
            {
               HideView();
                _crearEditarHabitacionPresenter.Value.GetCrearEditarHabitacionView().ShowView();
             
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Ocurrio un error al redirigir.", "Error");
        
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
