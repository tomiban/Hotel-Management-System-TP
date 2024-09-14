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

        public  void OnSave(object? sender, EventArgs e)
        {
            try
            {
              var nroDisponible =   _habitacionServices.CheckNroHabitacion(_view.NroHabitacion);
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
                _view.ShowMessage("Habitación guardada correctamente.", "Información");
                _view.LimpiarCampos();
            }
            catch (ValidationException ex)
            {
                _view.ShowMessage($"{ex.Message}", "Error de validación");
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"{ex.Message}", "Error");
            }
           

        }


    }

}
