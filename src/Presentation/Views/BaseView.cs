using MaterialSkin;
using MaterialSkin.Controls;
using PresentationLayer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Views
{
    public partial class BaseView : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public BaseView()
        {
            var ColorScheme = new ColorScheme(
                Primary.DeepPurple600,
                Primary.DeepPurple700,
                Primary.Cyan300,
                Accent.Cyan700,
                TextShade.WHITE
            );

            SkinHelper.ApplyTheme(this, MaterialSkinManager.Themes.DARK, ColorScheme);
            this.FormClosing += GuestView_FormClosing;

        }

        // Evento que se ejecutará cuando se intente cerrar el formulario
        private void GuestView_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verificar que el formulario se está cerrando por la "X"
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Terminar completamente la aplicación
                Application.Exit();
            }
        }

        private void InitializeComponent()
        {

        }
    }
}
