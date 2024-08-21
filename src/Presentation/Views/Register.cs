using MaterialSkin.Controls;
using MaterialSkin;
using Presentation.Views;
using Domain.Entities;

namespace Presentation.Views
{
    public partial class Register : MaterialForm, IRegisterView
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public event EventHandler RegisterEvent;
        public event EventHandler OnLoginRedirect;

        public string Nombre => txtNombre.Text;

        public string Apellido => txtApellido.Text;

        public string Edad => txtEdad.Text;

        public string Telefono => txtTelefono.Text;

        public string Username => txtUsuario.Text;

        public string Contraseña => txtContraseña.Text;

        public Role Role => Role.Admin;

        public Register()
        {

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
         Primary.DeepPurple600,   // Deep Purple más oscuro para un mejor contraste
         Primary.DeepPurple700,   // Deep Purple oscuro para el contraste principal
         Primary.Cyan700,   // Deep Purple base para fondos principales
         Accent.Cyan700,         // Acento verde 400 para destacar
         TextShade.WHITE          // Color de texto blanco para el contraste
     );
            InitializeComponent();
            AssocciateAndRaiseViewEvents();
        }

        private void AssocciateAndRaiseViewEvents()
        {
            btnRegistrarse.Click += delegate { RegisterEvent?.Invoke(this, EventArgs.Empty); };
            btnRegresar.Click += delegate { OnLoginRedirect?.Invoke(this, EventArgs.Empty); };
        }

        public void ShowMessage(string title, string message)
        {

            MaterialMessageBox.Show(this, title, message);
        }
        public void HideView()
        {
            Hide();
        }
        public void CloseView()
        {
            Close();
        }
    }
}
