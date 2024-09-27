using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Validation.ModelDataAnnotationCheck;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Presentation.Views;
using PresentationLayer.Views;


namespace ApplicationLayer.Services
{
    public class NavigationService : INavigationService
    {
        private Form _currentView;  // Almacena la vista activa actual

        private readonly IGuestView _guestView;
        private readonly IAdminView _adminView;
        private readonly ICrearEditarHabitacionView _crearEditarHabitacionView;
        private readonly IDetallesReservaView _detallesReservaView;
        private readonly ILoginView _loginView;
        private readonly IRegisterView _registerView;

        public NavigationService(IGuestView guestView, IAdminView adminView,
                                 IDetallesReservaView detallesReservaView, ILoginView loginView)
        {
            _guestView = guestView;
            _adminView = adminView;
            _detallesReservaView = detallesReservaView;
            _loginView = loginView;
        }

        public void ShowGuestView()
        {
            HideCurrentView();  // Ocultar la vista actual antes de mostrar la nueva
            _guestView.ShowView();
            _currentView = (Form)_guestView;  // Actualizar la vista actual
        }

        public void ShowAdminView()
        {
            HideCurrentView();
            _adminView.ShowView();
            _currentView = (Form)_adminView;
        }

        public void ShowDetallesReservaView()
        {
            HideCurrentView();
            _detallesReservaView.ShowView();
            _currentView = (Form)_detallesReservaView;
        }

        public void ShowLoginView()
        {
            HideCurrentView();
            _loginView.ShowView();
            _currentView = (Form)_loginView;
        }

        public void HideCurrentView()
        {
            if (_currentView != null)
            {
                _currentView.Hide();  // Ocultar la vista actual
            }
        }

        public void ShowRegisterView()
        {
            HideCurrentView();
            _registerView.ShowView();
            _currentView = (Form)_registerView;
        }

        public void ShowCrearEditarHabitacionView()
        {
            HideCurrentView();
            _crearEditarHabitacionView.ShowView();
            _currentView = (Form)_crearEditarHabitacionView;
        }
    }


}
