using MaterialSkin.Controls;
using MaterialSkin;
using PresentationLayer.Helpers;
using PresentationLayer.Utils;

namespace Presentation.Views
{
    public partial class LoginView : MaterialForm, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();

            var ColorScheme = new ColorScheme(
                Primary.DeepPurple600,
                Primary.DeepPurple700,
                Primary.Cyan700,
                Accent.Cyan700,
                TextShade.WHITE);

            SkinHelper.ApplyTheme(this, MaterialSkinManager.Themes.DARK, ColorScheme);
            AssociateAndRaiseViewEvents();
        }

        public event EventHandler LoginEvent;
        public event EventHandler RedirectToRegister;

        private void AssociateAndRaiseViewEvents()
        {
            AttachLoginEvent();
            AttachRedirectEvent();
        }

        private void AttachLoginEvent()
        {
            btnLogin.Click += (s, e) =>
            {
                if (ValidateLoginInput())
                    EventHelper.RaiseEvent(this, LoginEvent, EventArgs.Empty);
            };

            txtContraseña.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter && ValidateLoginInput())
                    EventHelper.RaiseEvent(this, LoginEvent, EventArgs.Empty);
            };
        }

        private void AttachRedirectEvent()
        {
            btnNoTengoCuenta.Click += (s, e) =>
            {
                EventHelper.RaiseEvent(this, RedirectToRegister, EventArgs.Empty);
            };
        }

        public string Username => txtUsuario.Text;
        public string Password => txtContraseña.Text;

        private bool ValidateLoginInput()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                ShowMessage("El nombre de usuario no puede estar vacío.", "Error");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Password))
            {
                ShowMessage("La contraseña no puede estar vacía.", "Error");
                return false;
            }

            return true;
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
