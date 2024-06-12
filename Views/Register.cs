using MaterialSkin.Controls;
using MaterialSkin;
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
    public partial class Register : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Register()
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

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {

        }
    }
}
