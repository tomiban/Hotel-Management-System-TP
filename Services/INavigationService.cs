using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Services
{
    public interface INavigationService
    {
        void ShowLoginPanel();
        void ShowRegisterPanel();
        void ShowAdminPanel();
        void ShowClientPanel();
    }
}
