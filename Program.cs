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
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var registerForm = new Register();
            IPersistenceService persistenceService = new MemoryPackService();
            IUsuarioRepository repository = new UsuarioRepository(persistenceService, "usuarios.bin");
            var registerPresenter = new RegisterPresenter(registerForm, repository);
            Application.Run(registerForm);
        }
    }
}