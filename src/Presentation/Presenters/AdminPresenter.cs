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

        public AdminPresenter(IAdminView view, Lazy<ICrearEditarHabitacionPresenter> crearEditarHabitacionPresenter, IHabitacionServices habitacionService)
        {
            _view = view;

            _habitacionServices = habitacionService;
            _crearEditarHabitacionPresenter = crearEditarHabitacionPresenter;
          
           CargarHabitaciones();
            //CargarUsuarios();

            _view.RedirectToCrearEditarHabitacion += OnRedirectToCrearEditarHabitacion;
    
        }


        public void OnRedirectToCrearEditarHabitacion(object? sender, EventArgs e)
        {
            try
            {
                _view.HideView();
                _crearEditarHabitacionPresenter.Value.GetCrearEditarHabitacionView().ShowView();
             
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Ocurrio un error al redirigir.", "Error");
        
            }
        }

        public async void CargarHabitaciones()
        {
            var habitaciones = await _habitacionServices.GetAll();

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
