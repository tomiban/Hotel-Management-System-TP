using GestionHotelWinForms.Models;
using GestionHotelWinForms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Services
{
    public interface INavigationService
    {
        Login ShowLoginPanel();
        Register ShowRegisterPanel();
        Admin ShowAdminPanel();
        // ShowClientPanel();
    }
}
