using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services
{
    public interface INavigationService
    {
        // Métodos para mostrar cada vista
        void ShowLoginView();
        void ShowRegisterView();
        void ShowAdminView();
        void ShowCrearEditarHabitacionView();
        void ShowGuestView();
        void ShowDetallesReservaView();

        // Método para ocultar la vista actual
        void HideCurrentView();
    }

}
