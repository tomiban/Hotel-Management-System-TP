using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GestionHotelWinForms.Views
{
    public partial class Admin : MaterialForm
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

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
