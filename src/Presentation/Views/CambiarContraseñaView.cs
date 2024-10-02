using MaterialSkin;
using MaterialSkin.Controls;
using PresentationLayer.Helpers;
using PresentationLayer.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer.Views
{
    public partial class CambiarContraseñaView : MaterialForm, ICambiarContraseñaView
    {
        public string ContraseñaActual => txtContraseñaActual.Text;
        public string NuevaContraseña => txtNuevaContraseña.Text;
        public event EventHandler OnCambiarContraseña;
        public event EventHandler OnCancelarCambioContraseña;

        public void ShowMessage(string message)
        {
            MaterialMessageBox.Show(message);
        }

        public CambiarContraseñaView()
        {
            InitializeComponent();
            AttachAndRaiseViewEvents();
            var ColorScheme = new ColorScheme(
                Primary.DeepPurple600,
                Primary.DeepPurple700,
                Primary.Cyan300,
                Accent.Cyan700,
                TextShade.WHITE
);

            SkinHelper.ApplyTheme(this, MaterialSkinManager.Themes.DARK, ColorScheme);
        }

        private void AttachAndRaiseViewEvents()
        {
            btnCambiarContraseña.Click += (s, e) =>
            {
                EventHelper.RaiseEvent(this, OnCambiarContraseña, EventArgs.Empty);
            };
            btnCancelarCambioContraseña.Click += (s, e) =>
            {
                EventHelper.RaiseEvent(this, OnCancelarCambioContraseña, EventArgs.Empty);
            };
        }

        public void ShowView()
        {
            this.Show();
        }

        public void HideView()
        {
           this.Hide();
        }
    }
}
