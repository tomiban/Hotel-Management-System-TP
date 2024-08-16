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
    public class CrearEditarHabitacionPresenter
    {
        private readonly ICrearEditarHabitacion _view;
        private readonly INavigationService _navigationService;
        private readonly IHabitacionRepository _habitacionRepository;

        public CrearEditarHabitacionPresenter(ICrearEditarHabitacion view, IHabitacionRepository habitacionRepository, INavigationService navigationService)
        {
            _view = view;
            _habitacionRepository = habitacionRepository;
            _navigationService = navigationService;
        }



    }
}
