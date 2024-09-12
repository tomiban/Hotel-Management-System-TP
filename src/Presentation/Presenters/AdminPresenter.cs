using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using Presentation.Views;
using System;
using System.Collections.Generic;

namespace Presentation.Presenters
{
    public class AdminPresenter : IAdminPresenter, IDisposable
    {
        private readonly IAdminView _view;
        private readonly Lazy<ICrearEditarHabitacionPresenter> _crearEditarHabitacionPresenter;
        private readonly IHabitacionServices _habitacionServices;

        public AdminPresenter(IAdminView view, Lazy<ICrearEditarHabitacionPresenter> crearEditarHabitacionPresenter, IHabitacionServices habitacionService)
        {
            _view = view;
            _habitacionServices = habitacionService;
            _crearEditarHabitacionPresenter = crearEditarHabitacionPresenter;

            SubscribeEvents();
            CargarHabitaciones();
        }

        private void SubscribeEvents()
        {
            _view.RedirectToCrearEditarHabitacion += OnRedirectToCrearEditarHabitacion;
            _view.EliminarHabitacion += OnEliminarHabitacion;
        }

        public void Dispose()
        {
            _view.RedirectToCrearEditarHabitacion -= OnRedirectToCrearEditarHabitacion;
            _view.EliminarHabitacion -= OnEliminarHabitacion;
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
                _view.HideView();
                Dispose();
                _crearEditarHabitacionPresenter.Value.GetCrearEditarHabitacionView().ShowView();
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Ocurrió un error al redirigir.", "Error");
            }
        }

        public void CargarHabitaciones()
        {
            var habitaciones = _habitacionServices.GetAll();
            _view.ActualizarListaHabitaciones(habitaciones);
        }

        public void CargarUsuarios()
        {
            var usuarios = new List<Usuario>(); // Aquí podrías cargar los usuarios desde un servicio si lo tienes
            _view.ActualizarListaUsuarios(usuarios);
        }

        public IAdminView GetAdminView()
        {
            return _view;
        }
    }
}
