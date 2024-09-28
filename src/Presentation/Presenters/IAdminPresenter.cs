using Presentation.Views;
using PresentationLayer.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public interface IAdminPresenter: IPresenter
    {
        void CargarHabitaciones();
        void CargarUsuarios();
        void ShowView();
        //EventHandler OnAñadirHab();
    }
}
