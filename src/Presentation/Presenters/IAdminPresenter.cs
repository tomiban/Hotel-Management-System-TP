using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public interface IAdminPresenter
    {
        IAdminView GetAdminView();
        void CargarHabitaciones();
        void CargarUsuarios();
        //EventHandler OnAñadirHab();
    }
}
