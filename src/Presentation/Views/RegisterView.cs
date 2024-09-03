using MaterialSkin.Controls;
using MaterialSkin;
using Presentation.Views;
using Domain.Entities;
using PresentationLayer.Helpers;

namespace Presentation.Views
{
    public partial class RegisterView : MaterialForm, IRegisterView
    {

        public event EventHandler RegisterEvent;
        public event EventHandler OnLoginRedirect;

        public string Nombre => txtNombre.Text;

        public string Apellido => txtApellido.Text;

        public string Edad => txtEdad.Text;

        public string Telefono => txtTelefono.Text;

        public string Username => txtUsuario.Text;

        public string Contraseña => txtContraseña.Text;

        public Role Role => Role.Admin;

        public RegisterView()
        {
            InitializeComponent();

            var colorScheme = new ColorScheme(
             Primary.DeepPurple600,   // Deep Purple más oscuro para un mejor contraste
             Primary.DeepPurple700,   // Deep Purple oscuro para el contraste principal
             Primary.Cyan700,   // Deep Purple base para fondos principales
             Accent.Cyan700,         // Acento verde 400 para destacar
             TextShade.WHITE          // Color de texto blanco para el contraste
            );

            SkinHelper.ApplyTheme(this, MaterialSkinManager.Themes.DARK, colorScheme);

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
            this.Hide();
        }
        public void CloseView()
        {
            this.Close();
        }

        public void ShowView()
        {
            this.Show();
        }

       
    }
}
