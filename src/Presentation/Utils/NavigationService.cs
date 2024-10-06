using Domain.Entities;
using Presentation.Presenters;
using PresentationLayer.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace PresentationLayer.Utils
{
    public class NavigationService : INavigationService
    {
        private readonly IUnityContainer _container;
        private readonly Stack<IPresenter> _navigationStack;

        public NavigationService(IUnityContainer container)
        {
            _container = container;
            _navigationStack = new Stack<IPresenter>();
        }

        public void NavigateTo<TPresenter>() where TPresenter : IPresenter
        {
            var presenter = _container.Resolve<TPresenter>();
            presenter.ShowView();

            if (_navigationStack.Count > 0)
            {
                _navigationStack.Peek().HideView();
            }

            _navigationStack.Push(presenter);
        }

        // Método de navegación con parámetro
        public void NavigateTo<TPresenter, TParam>(TParam param) where TPresenter : IPresenter
        {
            var presenter = _container.Resolve<TPresenter>();

            if (param == null)
            {
                throw new ArgumentNullException(nameof(param), "El parámetro no puede ser nulo.");
            }

            // Asignar el parámetro al presentador, por ejemplo:
            if (presenter is IDetallesReservaPresenter detallesReservaPresenter)
            {
                detallesReservaPresenter.SetEditMode(param as Reserva);
            }

            if (presenter is ICrearEditarHabitacionPresenter crearEditarHabitacionPresenter)
            {
                crearEditarHabitacionPresenter.SetEditMode(param as Habitacion);  // Pasar la habitación al modo edición
            }

            presenter.ShowView();

            if (_navigationStack.Count > 0)
            {
                _navigationStack.Peek().HideView();
            }

            _navigationStack.Push(presenter);
        }

   
        public TPresenter GetPresenter<TPresenter>() where TPresenter : IPresenter
        {
            return _navigationStack.OfType<TPresenter>().FirstOrDefault();
        }


        public void GoBack()
        {
            if (_navigationStack.Count > 1)
            {
                var currentPresenter = _navigationStack.Pop();
                currentPresenter.HideView();

                var previousPresenter = _navigationStack.Peek();
                previousPresenter.ShowView();
            }
            else
            {
                _navigationStack.Peek().ShowView(); 
            }
        }
    }
}
