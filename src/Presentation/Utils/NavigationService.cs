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

        public void GoBack()
        {
            if (_navigationStack.Count > 1)
            {
                var currentPresenter = _navigationStack.Pop();
                currentPresenter.HideView();

                var previousPresenter = _navigationStack.Peek();
                previousPresenter.ShowView();
            }
        }
    }
}
