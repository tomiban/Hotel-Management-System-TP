using MaterialSkin.Controls;
using MaterialSkin;
using Presentation.Views;
using Domain.Entities;
using PresentationLayer.Helpers;
using PresentationLayer.Views;

namespace Presentation.Views
{
    public partial class RegisterView : BaseView, IRegisterView
    {

        public event EventHandler RegisterEvent;
        public event EventHandler OnLoginRedirect;

        public string Nombre => txtNombre.Text;

        public string Apellido => txtApellido.Text;

        public string Edad => txtEdad.Text;

        public string Telefono => txtTelefono.Text;

        public string Username => txtUsuario.Text;

        public string Contraseña => txtContraseña.Text;

        public Role Role => Role.Cliente;

        public RegisterView()
        {
            InitializeComponent();

            AssocciateAndRaiseViewEvents();
            
            btnRegistrarse.Enabled = false;
            txtNombre.TextChanged += ValidateFields;
            txtApellido.TextChanged += ValidateFields;
            txtEdad.TextChanged += ValidateFields;
            txtTelefono.TextChanged += ValidateFields;
            txtUsuario.TextChanged += ValidateFields;
            txtContraseña.TextChanged += ValidateFields;
        }

        private void AssocciateAndRaiseViewEvents()
        {
            btnRegistrarse.Click += delegate { RegisterEvent?.Invoke(this, EventArgs.Empty); };
            btnRegresar.Click += delegate { OnLoginRedirect?.Invoke(this, EventArgs.Empty); };
        }


        private void ValidateFields(object sender, EventArgs e)
        {
            // Verifica si todos los campos están llenos
            btnRegistrarse.Enabled =
                !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtApellido.Text) &&
                !string.IsNullOrWhiteSpace(txtEdad.Text) &&
                !string.IsNullOrWhiteSpace(txtTelefono.Text) &&
                !string.IsNullOrWhiteSpace(txtUsuario.Text) &&
                !string.IsNullOrWhiteSpace(txtContraseña.Text);
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
