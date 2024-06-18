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
    public partial class Cliente : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Cliente()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
         Primary.DeepPurple600,   // Deep Purple más oscuro para un mejor contraste
         Primary.DeepPurple700,   // Deep Purple oscuro para el contraste principal
         Primary.Cyan300,   // Deep Purple base para fondos principales
         Accent.Cyan700,         // Acento verde 400 para destacar
         TextShade.WHITE          // Color de texto blanco para el contraste
     );
        }

        private void materialCard6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
