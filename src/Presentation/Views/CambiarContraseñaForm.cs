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

namespace PresentationLayer.Views
{
    public partial class CambiarContraseñaForm : BaseView
    {
        public string ContraseñaActual => txtContraseñaActual.Text;
        public string NuevaContraseña => txtNuevaContraseña.Text;

        public CambiarContraseñaForm()
        {
            InitializeComponent();
            btnCambiarContraseña.Click += btnCambiarContraseña_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ContraseñaActual) || string.IsNullOrWhiteSpace(NuevaContraseña))
            {
                MessageBox.Show("Debe completar ambos campos.");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
