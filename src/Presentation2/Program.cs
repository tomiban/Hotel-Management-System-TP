
using Domain.Interfaces;
using Presentation.Presenters;
using Presentation.Views;
using Unity;
using ApplicationLayer.Services;
using Infraestructure.DataAccess.Repositories;
using Infraestructure.DataAccess.Serialization;
using Unity.Injection;

namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configuraciones de la aplicación
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear y configurar el contenedor de Unity
            IUnityContainer container = new UnityContainer();

            // Registrar vistas
            container.RegisterType<ILoginView, Login>();
            container.RegisterType<IRegisterView, Register>();
            container.RegisterType<IAdminView, Admin>();

            // Registrar servicios
            container.RegisterType<IBinarySerialization, BinarySerialization>();

            // Registrar repositorios
            container.RegisterType<IUsuarioRepository, UsuarioRepository>(
                new InjectionConstructor(
                    new ResolvedParameter<IBinarySerialization>(),
                    "usuarios.bin"
                )
            );

            container.RegisterType<IHabitacionRepository, HabitacionRepository>(
                new InjectionConstructor(
                    new ResolvedParameter<IBinarySerialization>(),
                    "habitacion.bin"
                )
            );

            // Registrar presentadores
            container.RegisterType<ILoginPresenter, LoginPresenter>(
                new InjectionConstructor(
                    new ResolvedParameter<ILoginView>(),
                    new ResolvedParameter<IUsuarioRepository>(),
                    container
             // Inyectar AdminPresenter
                )
            );

            container.RegisterType<IAdminPresenter, AdminPresenter>(
                new InjectionConstructor(
                    new ResolvedParameter<IAdminView>(),
                    new ResolvedParameter<IHabitacionRepository>(),
                    container
                )
            );

            container.RegisterType<IRegisterPresenter, RegisterPresenter>(
                new InjectionConstructor(
                    new ResolvedParameter<IRegisterView>(),
                    new ResolvedParameter<IUsuarioRepository>(),
                    container
                )
            );

            // Resolver el presentador de login (el formulario principal)
            var loginPresenter = container.Resolve<ILoginPresenter>();


            // Iniciar la aplicación con la vista de Login
            Application.Run((Form)loginPresenter.View);

        }
    }
}