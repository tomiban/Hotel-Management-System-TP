using Domain.Interfaces;
using Presentation.Presenters;
using Presentation.Views;
using Unity;
using Infraestructure.DataAccess.Repositories;
using Infraestructure.DataAccess.Serialization;
using Unity.Lifetime;
using PresentationLayer.Views;
using PresentationLayer.Presenters;
using ApplicationLayer.Services;
using Domain.Validation.ModelDataAnnotationCheck;
using Services.Services.ReservaServices;


namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  Punto de entrada principal para la aplicaci�n.
        /// </summary>
        [STAThread]
        static void Main()
        {

            IUnityContainer unityC = new UnityContainer()
                // Registra la vista de login (ILoginView) y la implementa con la clase Login.
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

                .RegisterType<IModelDataAnnotationCheck, ModelDataAnnotationCheck>(new ContainerControlledLifetimeManager())

                .RegisterType<IAuthService, AuthService>(new ContainerControlledLifetimeManager())
                .RegisterType<IUsuarioService, UsuarioService>(new ContainerControlledLifetimeManager())
                .RegisterType<IHabitacionServices, HabitacionServices>(new ContainerControlledLifetimeManager())
                .RegisterType<IReservaService, ReservaService>(new ContainerControlledLifetimeManager())

                .RegisterType<IBinarySerialization, BinarySerialization>(new ContainerControlledLifetimeManager())

                .RegisterType<IUsuarioRepository, UsuarioRepository>(new ContainerControlledLifetimeManager())
                .RegisterType<IHabitacionRepository, HabitacionRepository>(new ContainerControlledLifetimeManager())
                .RegisterType<IReservaRepository, ReservaRepository>(new ContainerControlledLifetimeManager()); //




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           
            ILoginPresenter loginPresenter = unityC.Resolve<LoginPresenter>();
            // Obtener la vista de login desde el presentador resuelto.
            ILoginView loginView = loginPresenter.GetLoginView();

           
            Application.Run((LoginView)loginView);
        }
    }
}

