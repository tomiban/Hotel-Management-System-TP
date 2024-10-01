using Domain.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using PresentationLayer.Components;
using PresentationLayer.Events;
using PresentationLayer.Helpers;
using PresentationLayer.Utils;
using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class GuestView : BaseView, IGuestView
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        HabitacionCardContainer HabitacionCardContainer;

        public DateTime ReservaFechaDesde => dtpFechaHasta.Value;
        public DateTime ReservaFechaHasta => dtpFechaHasta.Value;

        public HabitacionCardContainer habitacionCardContainer { get => HabitacionCardContainer; }
        public GuestView()
        {
            InitializeComponent();

            var ColorScheme = new ColorScheme(
                Primary.DeepPurple600,
                Primary.DeepPurple700,
                Primary.Cyan300,
                Accent.Cyan700,
                TextShade.WHITE
            );

            SkinHelper.ApplyTheme(this, MaterialSkinManager.Themes.DARK, ColorScheme);

            HabitacionCardContainer = new HabitacionCardContainer();
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(HabitacionCardContainer);
            dtpFechaHasta.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today.AddDays(7);
            AttachAndRaiseViewEvents();
            MostrarMensaje("Debe aplicar un filtro para ver las habitaciones disponibles...");
       
            tcCliente.SelectedIndexChanged += TabControl_SelectedIndexChanged;

            CargarTipoHabitaciones();

        }

        private void TabControl_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (tcCliente.SelectedTab == tpLogout)
            {
                EventHelper.RaiseEvent(this, OnLogoutTabSelected, EventArgs.Empty);
            }
        }


        private void AttachAndRaiseViewEvents()
        {
            cmbFiltroHabitaciones.SelectedIndexChanged += (s, e) =>
           { 
                var categoriaSeleccionada = ObtenerCategoriaSeleccionada();
                var filtroArgs = new FiltroFechaEventArgs(dtpFechaDesde.Value, dtpFechaHasta.Value, categoriaSeleccionada);
                EventHelper.RaiseEvent(this, OnFiltrarHabitacionesRangoFechas, filtroArgs);
            };

            btnBuscarHabitaciones.Click += (s, e) =>
            {
                if (ValidarFechas())
                {
                    var categoriaSeleccionada = ObtenerCategoriaSeleccionada();
                    EventHelper.RaiseEvent(this, OnFiltrarHabitacionesRangoFechas,
                        new FiltroFechaEventArgs(dtpFechaDesde.Value, dtpFechaHasta.Value, categoriaSeleccionada));
                }
            };

            btnModificarReserva.Click += (s, e) => EventHelper.RaiseEvent(this, OnModificarReserva, EventArgs.Empty);
            
            listReservas.MouseClick += (s, e) =>
            {
                var reservaId = (int)listReservas.SelectedItems[0].Tag;
                EventHelper.RaiseEvent(this, ReservaSeleccionada, reservaId);
            };
        }

        // Obtener la categoría seleccionada
        public string ObtenerCategoriaSeleccionada()
        {
            return cmbFiltroHabitaciones.SelectedItem?.ToString() ?? "Todas las habitaciones";
        }

        // Validar fechas ingresadas
        private bool ValidarFechas()
        {
            if (dtpFechaDesde.Value == null || dtpFechaHasta.Value == null)
            {
                MessageBox.Show("Por favor, ingrese una fecha de inicio y una fecha de fin.");
                return false;
            }
            if (dtpFechaHasta.Value < dtpFechaDesde.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.");
                return false;
            }
            if (DateTime.Today > dtpFechaDesde.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser anterior a la fecha actual.");
                return false;
            }
            return true;
        }

        public event EventHandler<int> ReservaSeleccionada; // Cambiar a EventHandler<int> para pasar el ID de la reserva
        public event EventHandler<FiltroFechaEventArgs> OnFiltrarHabitacionesRangoFechas;
        public event EventHandler<HabitacionEventArgs> OnRealizarReserva;
        public event EventHandler OnModificarReserva;
        public event EventHandler OnLogoutTabSelected;
        
        public void CargarTipoHabitaciones()
        {
            cmbFiltroHabitaciones.Items.Clear();
            cmbFiltroHabitaciones.Items.Add("Todas las habitaciones");
            TipoHabitacion[] tipoHabitaciones = (TipoHabitacion[])Enum.GetValues(typeof(TipoHabitacion));
            foreach (var tipo in tipoHabitaciones)
            {
                cmbFiltroHabitaciones.Items.Add(tipo.ToString());
            }
            cmbFiltroHabitaciones.SelectedIndex = 0;
        }

        public void CargarDatosUsuario(Usuario usuario)
        {
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtTelefono.Text = usuario.Telefono;
            txtUsername.Text = usuario.Username;
            txtPassword.Text = usuario.Contraseña;
        }

        public void CargarHabitacionCards(List<HabitacionCard> habitacionCards)
        {
            habitacionCardContainer.Clear(); // Limpiar las tarjetas previas

            // Si no hay habitaciones, mostramos el mensaje correspondiente
            if (habitacionCards.Count == 0)
            {
                this.MostrarMensaje("No hay habitaciones disponibles en este rango de fechas.");
            }
            else
            {
                foreach (var card in habitacionCards)
                {
                    // Suscribir al evento OnRealizarReserva para cada tarjeta
                    card.OnRealizarReserva += (sender, e) =>
                    {
                        // Elevar el evento hacia el Presenter desde la vista
                        EventHelper.RaiseEvent(this, OnRealizarReserva, e);
                    };

                    habitacionCardContainer.Add(card); 
                }

            }
        }

        public void CloseView()
        {
            this.Close();
        }

        public void HideView()
        {
            this.Hide();
        }

        public void ShowMessage(string title, string message)
        {
            MaterialMessageBox.Show(this, title, message);
        }

        public void ShowView()
        {
            this.Show();
        }

        public void CargarReservas(List<Reserva> reservas)
        {
            listReservas.Items.Clear();
            listReservas.Columns.Clear();

            listReservas.Columns.Add("Nro", 100);
            listReservas.Columns.Add("Habitacion", 100);
            listReservas.Columns.Add("Categoria", 154);
            listReservas.Columns.Add("Check In", 170);
            listReservas.Columns.Add("Check Out", 170);
            listReservas.Columns.Add("Precio Final", 120);
            listReservas.Columns.Add("Estado", 100);

            int contador = 1;

            foreach (var reserva in reservas)
            {
                // Crear el ListViewItem y añadir las subcolumnas
                ListViewItem listItem = new ListViewItem(contador.ToString());
                listItem.SubItems.Add(reserva.NroHabitacion.ToString());
                listItem.SubItems.Add(reserva.TipoHabitacion.ToString());
                listItem.SubItems.Add(reserva.FechaInicio.ToShortDateString());
                listItem.SubItems.Add(reserva.FechaFin.ToShortDateString());
                listItem.SubItems.Add($"{reserva.MontoTotal:C} ARS");
                listItem.SubItems.Add(reserva.Estado.ToString());

                // Guardar el ID de la reserva en el Tag del ListViewItem
                listItem.Tag = reserva.Id;

                listReservas.Items.Add(listItem);
                contador++;
            }

        }

        public void MostrarMensaje(string mensaje)
        {
            habitacionCardContainer.Clear();  // Limpiar cualquier contenido previo
            habitacionCardContainer.MostrarMensaje(mensaje); // Mostrar el mensaje en el contenedor
        }

        public void SetModificarReservaButtonState(bool enabled)
        {
            btnModificarReserva.Enabled = enabled;  // Habilitar o deshabilitar el botón
        }


        public void ShowDialogLogout()
        {
            // Mostrar el diálogo de confirmación
            var dialog = new MaterialDialog(this, "Confirmar Salida",
                "¿Está seguro que desea salir de la aplicación?", "Salir", true, "Cancelar", true);

            dialog.StartPosition = FormStartPosition.CenterParent;
            var result = dialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                tcCliente.SelectedIndex = 0; // Redirigir a la primera pestaña si elige cancelar
            }
        }
    }
}
