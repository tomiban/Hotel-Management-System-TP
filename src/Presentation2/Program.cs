using Domain.Interfaces;
using Presentation.Presenters;
using Presentation.Views;
using Unity;
using Infraestructure.DataAccess.Repositories;
using Infraestructure.DataAccess.Serialization;
using Unity.Lifetime;


namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Crear y configurar el contenedor de Unity
            // Crear y configurar el contenedor de Unity
            // El contenedor Unity es utilizado para manejar la inyección de dependencias en la aplicación.
            // Aquí se registran los tipos que Unity resolverá en tiempo de ejecución.
            IUnityContainer unityC = new UnityContainer()
                // Registra la vista de login (ILoginView) y la implementa con la clase Login.
                .RegisterType<ILoginView, LoginView>(new ContainerControlledLifetimeManager())

                // Registra el presentador de login (ILoginPresenter) y lo implementa con la clase LoginPresenter.
                .RegisterType<ILoginPresenter, LoginPresenter>(
                    new ContainerControlledLifetimeManager()
                )
                // Registra la vista de registro (IRegisterView) y la implementa con la clase Register.
                .RegisterType<IRegisterView, RegisterView>(new ContainerControlledLifetimeManager())
                // Registra el presentador de registro (IRegisterPresenter) y lo implementa con la clase RegisterPresenter.
                .RegisterType<IRegisterPresenter, RegisterPresenter>(new ContainerControlledLifetimeManager())
                // Registrar el repositorio de Usuario
                .RegisterType<IAdminView, AdminView>(new ContainerControlledLifetimeManager())
                .RegisterType<IAdminPresenter, AdminPresenter>(new ContainerControlledLifetimeManager())
                .RegisterType<IBinarySerialization, BinarySerialization>(new ContainerControlledLifetimeManager())
                .RegisterType<IHabitacionRepository, HabitacionRepository>(new ContainerControlledLifetimeManager())
                .RegisterType<IUsuarioRepository, UsuarioRepository>(
                    new ContainerControlledLifetimeManager()
                );


          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Resolver el presentador de login (que también maneja la vista de login)
            ILoginPresenter loginPresenter = unityC.Resolve<ILoginPresenter>();
            // Obtener la vista de login desde el presentador resuelto.
            ILoginView loginView = loginPresenter.GetLoginView();

            // Iniciar la aplicación con la vista de Login como la ventana principal.
            Application.Run((LoginView)loginView);
        }
    }
}

