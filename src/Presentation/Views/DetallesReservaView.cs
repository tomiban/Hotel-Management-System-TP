using Domain.Entities;
using Domain.Interfaces;
using MaterialSkin;
using MaterialSkin.Controls;
using PresentationLayer.Helpers;
using PresentationLayer.Utils;
using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public partial class DetallesReservaView : BaseView, IDetallesReservaView
    {

        // Reserva actual
        private Reserva _reservaActual;

        // Propiedades para obtener las fechas actuales del DateTimePicker
        public DateTime FechaInicio => dateTimePickerInicio.Value;
        public DateTime FechaFin => dateTimePickerFin.Value;

        // Eventos para actualizar y cancelar la reserva
        public event EventHandler OnActualizarReserva;
        public event EventHandler OnCancelarReserva;
        public event EventHandler OnRedirectToClientView;
        public event EventHandler OnFechaCambiada;

        // Nueva propiedad para controlar si las fechas han sido inicializadas
        private bool _fechasInicializadas = false;

        public DetallesReservaView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }


        private void AssociateAndRaiseViewEvents()
        {
            btnRegresarCliente.Click += (s, e) => { EventHelper.RaiseEvent(this, OnRedirectToClientView, EventArgs.Empty); };

            // Botón de actualización de reserva
            btnActualizarReserva.Click += (s, e) =>
            {
                // Validar que la fecha de inicio no sea posterior a la fecha de fin
                if (FechaInicio > FechaFin)
                {
                    this.ShowMessage("La fecha de inicio no puede ser posterior a la fecha de fin.", "Error");
                    return;
                }

                // Lanzar el evento de actualización de reserva
                EventHelper.RaiseEvent(this, OnActualizarReserva, EventArgs.Empty);
            };

            // Botón de cancelación de reserva
            btnCancelarReserva.Click += (s, e) =>
            {
                EventHelper.RaiseEvent(this, OnCancelarReserva, EventArgs.Empty);
            };

            // Eventos para cambios en las fechas
            dateTimePickerInicio.ValueChanged += (s, e) => OnFechaCambiadaHandler();
            dateTimePickerFin.ValueChanged += (s, e) => OnFechaCambiadaHandler();
        }

        // Este método ahora maneja ambos DateTimePickers
        private void OnFechaCambiadaHandler()
        {
            // Solo permitir que el evento se dispare si las fechas ya han sido inicializadas
            if (_fechasInicializadas)
            {
                EventHelper.RaiseEvent(this, OnFechaCambiada, EventArgs.Empty);
            }
        }

        // Mostrar los detalles de la reserva en los controles correspondientes
        public void MostrarDetalleReserva(Reserva reserva)
        {
            _reservaActual = reserva;  // Guardar la reserva actual para futuras actualizaciones

            // Desactivar temporalmente el evento durante la inicialización
            _fechasInicializadas = false;

            // Mostrar los detalles de la reserva en los controles
            txtNroHabitacionDetalle.Text = reserva.NroHabitacion.ToString();
            dateTimePickerInicio.Value = reserva.FechaInicio;
            dateTimePickerFin.Value = reserva.FechaFin;
            txtTipoHabitacion.Text = reserva.TipoHabitacion.ToString();
            txtDiasEstadia.Text = reserva.DiasDeEstadia.ToString();
            txtPrecioFinal.Text = $"{reserva.MontoTotal:C}";

            // Después de inicializar correctamente las fechas, habilitar el control de fechas
            _fechasInicializadas = true;
        }

        // Mostrar el precio actualizado y los días de estadía cuando se cambian las fechas
        public void MostrarPrecioActualizado(decimal nuevoPrecio)
        {
            txtPrecioFinal.Text = $"{nuevoPrecio:C}";  // Actualizar el precio total
            txtDiasEstadia.Text = $"{(FechaFin.Date - FechaInicio.Date).Days}";  // Calcular los días de estadía
        }

        // Métodos para manejar la vista
        public void ShowView()
        {
            this.Show(); // Mostrar la vista
        }

        public void CloseView()
        {
            this.Close();  // Cerrar la vista
        }

        public void ShowMessage(string message, string title)
        {
            MaterialMessageBox.Show(this, title, message);  // Mostrar un mensaje
        }

        public void HideView()
        {
            this.Hide();  // Ocultar la vista
        }
    }
}
