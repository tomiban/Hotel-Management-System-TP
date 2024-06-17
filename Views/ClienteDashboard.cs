using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotelWinForms.Views
{
    public partial class clienteDashboard : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public clienteDashboard()
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

        private void materialCard6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
