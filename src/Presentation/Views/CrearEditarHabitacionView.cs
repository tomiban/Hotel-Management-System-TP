using Domain.Entities;
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

namespace Presentation.Views
{
    public partial class CrearEditarHabitacionView : MaterialForm, ICrearEditarHabitacionView
    {

        public CrearEditarHabitacionView()
        {
            InitializeComponent();

            var ColorScheme = new ColorScheme(
                 Primary.DeepPurple600,   // Deep Purple más oscuro para un mejor contraste
                 Primary.DeepPurple700,   // Deep Purple oscuro para el contraste principal
                 Primary.Cyan700,   // Deep Purple base para fondos principales
                 Accent.Cyan700,         // Acento verde 400 para destacar
                 TextShade.WHITE);

            SkinHelper.ApplyTheme(this, MaterialSkinManager.Themes.DARK, ColorScheme);

            AssociateAndRaiseViewEvents();
        }


        private void AssociateAndRaiseViewEvents()
        {
            btnGuardarHab.Click += (s, e) => EventHelper.RaiseEvent(this, SaveEvent, EventArgs.Empty);
            btnRegresarAdmin.Click += (s, e) => EventHelper.RaiseEvent(this, NavigateToAdminView, EventArgs.Empty);
        }

        public int NroHabitacion => Convert.ToInt32(txtNroHabitacion.Text);

        public TipoHabitacion TipoHabitacion => (TipoHabitacion)Enum.Parse(typeof(TipoHabitacion), cmbTipoHabitacion.SelectedItem.ToString());

        public bool Disponible => switchDisponibilidad.Checked;

        public decimal PrecioPorNoche => Convert.ToDecimal(txtPrecioHabitacion.Text);

        public int Capacidad => Convert.ToInt32(txtCantidadPersonas.Text);

        public string Descripcion => txtDescripcion.Text;

        public event EventHandler SaveEvent;
        public event EventHandler BackEvent;
        public event EventHandler ViewClosed;
        public event EventHandler NavigateToAdminView;

        public void ShowView()
        {
            this.Show();
        }

        public void HideView()
        {
            this.Hide();
        }

        public void CloseView()
        {
            this.Close();
        }

        public void ShowMessage(string title, string message)
        {
            MaterialMessageBox.Show(this, title, message);
        }

    }
}
