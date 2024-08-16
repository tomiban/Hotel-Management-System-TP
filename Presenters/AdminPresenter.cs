using GestionHotelWinForms.Models;
using GestionHotelWinForms.Repositories;
using GestionHotelWinForms.Services;
using GestionHotelWinForms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Presenters
{
    public class AdminPresenter
    {
        private readonly IAdminView _view;

        private readonly IHabitacionRepository _habitacionRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly INavigationService _navigationService;

        public AdminPresenter(IAdminView view, IHabitacionRepository habitacionRepository, IUsuarioRepository usuarioRepository , INavigationService navigationService)
        {
            _view = view;
    
            _habitacionRepository = habitacionRepository;
            _usuarioRepository = usuarioRepository;
            _navigationService = navigationService;
            _view.AñadirEvent += OnAñadirHab();
            //_view.EditarEvent += OnEditarHab();
            //_view.EliminarEvent += OnEliminarHab();
            CargarHabitaciones();
            CargarUsuarios();
        }

        private EventHandler OnAñadirHab()
        {


            return null;
            //try
            //{
            //    _view.ActualizarListaHabitaciones();

            //}
            //catch (Exception ex)
            //{
            //    _view.ShowMessage("Ocurrio un error al añadir habitacion.", "Error");
            //}
        }

        private void CargarHabitaciones()
        {
            var habitaciones = new List<Habitacion>();
            _view.ActualizarListaHabitaciones(habitaciones);
        }

        private void CargarUsuarios()
        {
            var usuarios = new List<Usuario>();
            _view.ActualizarListaUsuarios(usuarios);
        }

        //private void OnAñadirHab()
        //{

        //}
    }
}
