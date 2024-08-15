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

            // Servicio de persistencia binaria
            IPersistenceService persistenceService = new MemoryPackService();

            // Creacion de repositorios
            IUsuarioRepository userRepository = new UsuarioRepository(persistenceService, "usuarios.bin");
            IHabitacionRepository habitacionRepository = new HabitacionRepository(persistenceService, "habitaciones.bin");
          //IReservaRepository reservaRepository = new ReservaRepository(persistenceService, "reservas.bin");
            
            // Navegador de formularios
            INavigationService navigationService = new NavigationService(userRepository, habitacionRepository);

            // Inicio de la aplicacion
            Application.Run(navigationService.ShowLoginPanel());
        }
    }
}