using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Views
{
    public partial class BaseView: MaterialForm
    {
        public BaseView()
        {

            this.FormClosing += GuestView_FormClosing;
            this.WindowState = FormWindowState.Maximized;
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
    }
}
