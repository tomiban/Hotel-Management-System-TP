
using Domain.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using Presentation.Views;
using PresentationLayer.Helpers;
using PresentationLayer.Utils;

namespace Presentation.Views
{
    public partial class AdminView : MaterialForm, IAdminView
    {

        public event EventHandler RedirectToCrearEditarHabitacion;
        public event EventHandler RedirectToCrearEditarUsuario;
        public event EventHandler EliminarHabitacion;
        public event EventHandler EliminarUsuario;
        public event EventHandler SearchHabitacion;
        public event EventHandler SearchUsuario;
        public event EventHandler EditarHabitacion;

        public AdminView()
        {
            InitializeComponent();
            btnBorrarHab.Enabled = false;
            btnEditarHab.Enabled = false;

            var colorScheme = new ColorScheme(
            Primary.DeepPurple600,
            Primary.DeepPurple700,
            Primary.Cyan700,
            Accent.Cyan700,
            TextShade.WHITE
        );

            SkinHelper.ApplyTheme(this, MaterialSkinManager.Themes.DARK, colorScheme);

            AttachAndRaiseViewEvents();
            AttachDeleteEvents();
            AttachEditEvents();

            //listHabitaciones.SelectedIndexChanged += OnHabitacionSeleccionada;
            listHabitaciones.SelectedIndexChanged += OnHabitacionSelectionChanged;

        }

        private void OnHabitacionSelectionChanged(object sender, EventArgs e)
        {
            btnBorrarHab.Enabled = listHabitaciones.SelectedItems.Count > 0;
            btnEditarHab.Enabled = listHabitaciones.SelectedItems.Count > 0;
        }

        private void AttachDeleteEvents()
        {
            btnBorrarHab.Click += (s, e) => EventHelper.RaiseEvent(this, EliminarHabitacion, EventArgs.Empty);
        }

        private void AttachEditEvents()
        {
            btnEditarHab.Click += (s, e) =>
            {
                EventHelper.RaiseEvent(this, EditarHabitacion, EventArgs.Empty);
            };
        }
        public void SetEliminarHabitacionButtonState(bool enabled)
        {
            btnBorrarHab.Enabled = enabled;
        }
        public void SetEditarHabitacionButtonState(bool enabled)
        {
            btnEditarHab.Enabled = enabled;
        }

        private void AttachAndRaiseViewEvents()
        {
            btnAgregarHab.Click += (s, e) =>
            {
                EventHelper.RaiseEvent(this, RedirectToCrearEditarHabitacion, EventArgs.Empty);
            };
            btnAgregarUsu.Click += (s, e) =>
            {
                EventHelper.RaiseEvent(this, RedirectToCrearEditarUsuario, EventArgs.Empty);
            };
        }

        public void ActualizarListaUsuarios(List<Usuario> items)
        {
            listUsuarios.Items.Clear();
            var usuarios = new List<Usuario>()
            {

            };
            foreach (var item in usuarios)
            {
                ListViewItem listItem = new ListViewItem(item.Id.ToString());
                listItem.SubItems.Add(item.Nombre);
                listItem.SubItems.Add(item.Apellido);
                listItem.SubItems.Add(item.Edad.ToString());
                listItem.SubItems.Add(item.Telefono.ToString());
                listItem.SubItems.Add(item.Role.ToString());
                listUsuarios.Items.Add(listItem);
            }
        }

        public void ActualizarListaHabitaciones(List<Habitacion> habitaciones)
        {
            listHabitaciones.Columns.Clear();
            listHabitaciones.Items.Clear();
            listHabitaciones.Columns.Add("Número de Habitación", 200, HorizontalAlignment.Left);
            listHabitaciones.Columns.Add("Tipo", 155, HorizontalAlignment.Left);
            listHabitaciones.Columns.Add("Capacidad", 200, HorizontalAlignment.Left);
            listHabitaciones.Columns.Add("Disponibilidad", 150, HorizontalAlignment.Left);
            listHabitaciones.Columns.Add("Precio por noche", 200, HorizontalAlignment.Left);


            foreach (var hab in habitaciones)
            {
                ListViewItem listItem = new ListViewItem(hab.NroHabitacion.ToString());
                listItem.SubItems.Add(hab.TipoHabitacion.ToString());
                listItem.SubItems.Add(string.Concat(hab.Capacidad.ToString(), " personas"));
                listItem.SubItems.Add(hab.Disponible ? "Disponible" : "Ocupada");
                listItem.SubItems.Add(hab.PrecioPorNoche.ToString("C"));
                listHabitaciones.Items.Add(listItem);
            }
        }
        public void ActualizarDashboard(int reservasActivas, double porcentajeOcupacion, int totalUsuarios, int nuevosUsuarios, decimal facturacionAnual)
        {
            // Actualizar el texto y la barra de progreso para "Reservas"
            lblTotalReservas.Text = reservasActivas.ToString();
            captionLblOcupacion.Text = $"{porcentajeOcupacion}% Ocupación";
            progressBarOcupacion.Value = (int)porcentajeOcupacion;

            // Actualizar los valores para "Usuarios Totales"
            lblTotalUsuarios.Text = totalUsuarios.ToString();
            captionLblUsuarios.Text = $"{nuevosUsuarios} Nuevos Usuarios";

            // Actualizar la facturación
            lblTotalFacturado.Text = $"{facturacionAnual:C}"; // Mostrar el monto formateado con símbolo de moneda
        }

        public void CargarListaReservasActivas(List<Reserva> reservas)
        {
            listReservasActivas.Columns.Clear();
            listReservasActivas.Items.Clear();

            // Definir columnas de la lista
            listReservasActivas.Columns.Add("Número de Habitación", 200, HorizontalAlignment.Left);
            listReservasActivas.Columns.Add("Nombre de Usuario", 155, HorizontalAlignment.Left);
            listReservasActivas.Columns.Add("Fecha de Inicio", 200, HorizontalAlignment.Left);
            listReservasActivas.Columns.Add("Fecha de Fin", 200, HorizontalAlignment.Left);


            // Cargar las reservas activas en el ListView
            foreach (var reserva in reservas)
            {
                ListViewItem listItem = new ListViewItem(reserva.NroHabitacion.ToString());
                listItem.SubItems.Add(reserva.Username);
                listItem.SubItems.Add(reserva.FechaInicio.ToShortDateString());
                listItem.SubItems.Add(reserva.FechaFin.ToShortDateString());


                listReservasActivas.Items.Add(listItem);
            }
        }


        public void ShowMessage(string title, string message)
        {

            MaterialMessageBox.Show(this, title, message);
        }


        public int ObtenerNroHabitacionSeleccionado()
        {
            if (listHabitaciones.SelectedItems.Count == 0)
            {
                throw new ApplicationException("No hay ninguna habitación seleccionada.");
            }

            // Obtenemos el primer ítem seleccionado
            var selectedItem = listHabitaciones.SelectedItems[0];
            int id = int.Parse(selectedItem.Text); // El Nro de la habitación está en la primera columna
            return id;
        }


        public void HideView()
        {
            this.Hide();
        }
        public void CloseView()
        {
            this.Close();
        }

        public void ShowView()
        {
            this.Show();
        }

    }
}
