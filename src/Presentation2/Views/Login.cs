using MaterialSkin;
using MaterialSkin.Controls;
using Presentation.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class Login : MaterialForm, ILoginView
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Login()
        {
            InitializeComponent();
            AssocciateAndRaiseViewEvents();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            //materialSkinManager.ColorScheme = materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Green800, Primary.Green900,
            //    Primary.Green500, Accent.Green400,
            //    TextShade.WHITE
            //);
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
        }

        public string Username => txtUsuario.Text;

        public string Password => txtContraseña.Text;

        public event EventHandler LoginEvent;
        public event EventHandler RedirectToRegister;

        private void AssocciateAndRaiseViewEvents()
        {
            btnLogin.Click += delegate { LoginEvent?.Invoke(this, EventArgs.Empty); };
            txtContraseña.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    LoginEvent?.Invoke(this, EventArgs.Empty);
            };
            btnNoTengoCuenta.Click += delegate { RedirectToRegister?.Invoke(this, EventArgs.Empty); };
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
