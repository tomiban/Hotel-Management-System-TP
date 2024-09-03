using ApplicationLayer.Services;
using Domain.Entities;
using Domain.Interfaces;
using Presentation.Views;

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

        //TODO: Editar datos formulario segun es crear o editar
        //TODO: Bindear datos de la lista a la lista de material
        //TODO: Buscar forma para que en editar se carguen los datos de esa habitacion}


        public void OnAdminRedirect(object? sender, EventArgs e)
        {
            try
            {
                _adminPresenter.Value.GetAdminView().ShowView();
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

        public async void OnSave(object? sender, EventArgs e)
        {
            try
            {
              var nroDisponible = await  _habitacionServices.CheckNroHabitacion(_view.NroHabitacion);
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
                    CantidadPersonas = 3,
                    NroHabitacion = _view.NroHabitacion
                };

                _habitacionServices.Add(habitacion);
                _view.ShowMessage("Habitación guardada correctamente.", "Información");
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Ocurrio un error al guardar la habitación.", "Error");
            }

        }


    }

}
