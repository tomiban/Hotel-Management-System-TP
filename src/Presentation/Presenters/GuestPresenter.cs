using PresentationLayer.Views;
using Services.Services.ReservaServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Presenters
{
    public class GuestPresenter : IGuestPresenter
    {
        IGuestView _view;
        //private readonly IReservaRepository _reservationRepository;
        public GuestPresenter(IGuestView view)
        {
            _view = view;
            //_reservationRepository = reservationRepository;
        }

        public IGuestView GetGuestView()
        {
           return _view;
        }
    }
}
