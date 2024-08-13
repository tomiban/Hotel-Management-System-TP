using GestionHotelWinForms.Models;
using GestionHotelWinForms.Presenters;
using GestionHotelWinForms.Repositories;
using GestionHotelWinForms.Services;
using GestionHotelWinForms.Views;

namespace GestionHotelWinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            ApplicationConfiguration.Initialize();

            // Crear servicios y repositorios necesarios
            IPersistenceService persistenceService = new MemoryPackService();
            IUsuarioRepository userRepository = new UsuarioRepository(persistenceService, "usuarios.bin");           
            INavigationService navigationService = new NavigationService(userRepository);

            // Mostrar el formulario de login
            Application.Run(navigationService.ShowLoginPanel());
        }
    }
}