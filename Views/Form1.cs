using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GestionHotelWinForms.Views
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            // CS ALTERNATIVO -> materialSkinManager.ColorScheme=new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500,MaterialSkin.Primary.Indigo700,MaterialSkin.Primary.Indigo100,MaterialSkin.Accent.Pink500,MaterialSkin.TextShade.WHITE);
            materialSkinManager.ColorScheme = materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green800, Primary.Green900,
                Primary.Green500, Accent.Green400,
                TextShade.WHITE
            );
        }
    }
}
