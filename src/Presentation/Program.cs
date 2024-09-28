using Domain.Interfaces;
using Presentation.Presenters;
using Presentation.Views;
using Unity;
using ApplicationLayer.Services;
using Infraestructure.DataAccess.Repositories;
using Infraestructure.DataAccess.Serialization;
using Domain.Validation.ModelDataAnnotationCheck;
using Services.Services.ReservaServices;
using PresentationLayer.Presenters;
using PresentationLayer.Utils;
using PresentationLayer.Views;
using Unity.Lifetime;

namespace Presentation
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            try
            {
                IUnityContainer unityC = new UnityContainer()
              .AddExtension(new Diagnostic())

              // Repositorios
              .RegisterType<IBinarySerialization, BinarySerialization>(new ContainerControlledLifetimeManager())
              .RegisterType<IUsuarioRepository, UsuarioRepository>(new ContainerControlledLifetimeManager())
              .RegisterType<IHabitacionRepository, HabitacionRepository>(new ContainerControlledLifetimeManager())
              .RegisterType<IReservaRepository, ReservaRepository>(new ContainerControlledLifetimeManager())

              // Servicios
              .RegisterType<IAuthService, AuthService>(new ContainerControlledLifetimeManager())
              .RegisterType<IUsuarioService, UsuarioService>(new ContainerControlledLifetimeManager())
              .RegisterType<IHabitacionServices, HabitacionServices>(new ContainerControlledLifetimeManager())
              .RegisterType<IReservaService, ReservaService>(new ContainerControlledLifetimeManager())

              .RegisterType<IModelDataAnnotationCheck, ModelDataAnnotationCheck>(new ContainerControlledLifetimeManager())

              // Registrar el NavigationService
              .RegisterType<INavigationService, NavigationService>(new ContainerControlledLifetimeManager())

              .RegisterType<ILoginView, LoginView>(new ContainerControlledLifetimeManager())
              .RegisterType<ILoginPresenter, LoginPresenter>(new ContainerControlledLifetimeManager())

              .RegisterType<IRegisterView, RegisterView>(new ContainerControlledLifetimeManager())
              .RegisterType<IRegisterPresenter, RegisterPresenter>(new ContainerControlledLifetimeManager())

              .RegisterType<IAdminView, AdminView>(new ContainerControlledLifetimeManager())
              .RegisterType<IAdminPresenter, AdminPresenter>(new ContainerControlledLifetimeManager())

              .RegisterType<IGuestView, GuestView>(new ContainerControlledLifetimeManager())
              .RegisterType<IGuestPresenter, GuestPresenter>(new ContainerControlledLifetimeManager())

              .RegisterType<ICrearEditarHabitacionView, CrearEditarHabitacionView>(new ContainerControlledLifetimeManager())
              .RegisterType<ICrearEditarHabitacionPresenter, CrearEditarHabitacionPresenter>(new ContainerControlledLifetimeManager())

              .RegisterType<IDetallesReservaView, DetallesReservaView>(new ContainerControlledLifetimeManager())
              .RegisterType<IDetallesReservaPresenter, DetallesReservaPresenter>(new ContainerControlledLifetimeManager());


                // Iniciar el sistema visual de Windows Forms
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Resolver el servicio de navegación y comenzar en el LoginPresenter
                var navigationService = unityC.Resolve<INavigationService>();
                navigationService.NavigateTo<ILoginPresenter>();

                // Iniciar la aplicación
                Application.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}\n{ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
