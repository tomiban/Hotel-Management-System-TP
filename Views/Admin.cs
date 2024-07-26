using System.Windows.Forms;
using GestionHotelWinForms.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GestionHotelWinForms.Views
{
    public partial class Admin : MaterialForm, IAdminView<Usuario>, IAdminView<Habitacion>
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public Admin()
        {
            InitializeComponent();
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

        public event EventHandler AñadirEvent;
        public event EventHandler EditarEvent;
        public event EventHandler EliminarEvent;

        public void ActualizarLista(List<Usuario> items)
        {
            throw new NotImplementedException();
        }

        public void ActualizarLista(List<Habitacion> items)
        {
            throw new NotImplementedException();
        }

        public void LimpiarFormulario()
        {
            throw new NotImplementedException();
        }

        public Usuario ObtenerDatos()
        {
            throw new NotImplementedException();
        }

        public int ObtenerIdSeleccionado()
        {
            throw new NotImplementedException();
        }

        public void ShowMessage(string title, string message)
        {
            throw new NotImplementedException();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        Habitacion IAdminView<Habitacion>.ObtenerDatos()
        {
            throw new NotImplementedException();
        }
    }
}
