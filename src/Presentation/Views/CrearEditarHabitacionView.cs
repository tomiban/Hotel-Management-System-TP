using Domain.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using PresentationLayer.Helpers;
using PresentationLayer.Utils;
using System;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class CrearEditarHabitacionView : MaterialForm, ICrearEditarHabitacionView
    {
        public CrearEditarHabitacionView()
        {
            InitializeComponent();

            var colorScheme = new ColorScheme(
                 Primary.DeepPurple600,
                 Primary.DeepPurple700,
                 Primary.Cyan700,
                 Accent.Cyan700,
                 TextShade.WHITE);

            SkinHelper.ApplyTheme(this, MaterialSkinManager.Themes.DARK, colorScheme);

            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnGuardarHab.Click += (s, e) => EventHelper.RaiseEvent(this, SaveEvent, EventArgs.Empty);
            btnRegresarAdmin.Click += (s, e) => EventHelper.RaiseEvent(this, NavigateToAdminView, EventArgs.Empty);
        }

        public void LimpiarCampos()
        {
            // Limpiar los campos
            txtNroHabitacion.Text = string.Empty;
            switchDisponibilidad.Checked = false;
            cmbTipoHabitacion.SelectedIndex = -1;  // Seleccionar ninguno
            txtPrecioHabitacion.Text = string.Empty;
            txtCantidadPersonas.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }

        public void SetEditMode(Habitacion habitacion)
        {
            // Cargar los datos de la habitación en los controles
            txtNroHabitacion.Text = habitacion.NroHabitacion.ToString();

            // Asignar el valor del enum directamente en el ComboBox
            cmbTipoHabitacion.SelectedItem = habitacion.TipoHabitacion;

            // Asignar el resto de valores
            switchDisponibilidad.Checked = habitacion.Disponible;
            txtPrecioHabitacion.Text = habitacion.PrecioPorNoche.ToString();
            txtCantidadPersonas.Text = habitacion.Capacidad.ToString();
            txtDescripcion.Text = habitacion.Descripcion;
        }

        public void SetAddMode()
        {
           txtNroHabitacion.Enabled = true;
        }



        // Propiedades que permiten que el Presenter acceda a los datos de la vista
        public int NroHabitacion => Convert.ToInt32(txtNroHabitacion.Text);
        public TipoHabitacion TipoHabitacion => (TipoHabitacion)cmbTipoHabitacion.SelectedItem;
        public bool Disponible => switchDisponibilidad.Checked;
        public decimal PrecioPorNoche => Convert.ToDecimal(txtPrecioHabitacion.Text);
        public int Capacidad => Convert.ToInt32(txtCantidadPersonas.Text);
        public string Descripcion => txtDescripcion.Text;

        public event EventHandler SaveEvent;
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

        public void SetTitle(string title)
        {
            materialLabel2.Text = title;
        }

        public void SetButtonText(string text)
        {
            btnGuardarHab.Text = text;
        }

        private void CrearEditarHabitacionView_Load(object sender, EventArgs e)
        {
            cmbTipoHabitacion.DataSource = Enum.GetValues(typeof(TipoHabitacion));  // Se cargan los valores del enum
        }
    }
}
