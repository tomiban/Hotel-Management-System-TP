using Domain.Entities;
using Domain.Interfaces;
using MaterialSkin;
using MaterialSkin.Controls;
using PresentationLayer.Helpers;
using PresentationLayer.Utils;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public partial class DetallesReservaView : MaterialForm, IDetallesReservaView
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        // Reserva actual
        private Reserva _reservaActual;

        // Eventos para actualizar y cancelar la reserva
        public event EventHandler OnActualizarReserva;
        public event EventHandler OnCancelarReserva;
        public event EventHandler OnRedirectToClientView;

        public DetallesReservaView()
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
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnRegresarCliente.Click += (s, e) => { EventHelper.RaiseEvent(this, OnRedirectToClientView, EventArgs.Empty); };
            // Botón de actualización de reserva
            btnActualizarReserva.Click += (s, e) =>
            {
                // Validar fechas al final, antes de actualizar
                if (dateTimePickerInicio.Value > dateTimePickerFin.Value)
                {
                    this.ShowMessage("La fecha de inicio no puede ser posterior a la fecha de fin.", "Error");
                    return;
                }

                // Actualizar los valores de la reserva con las nuevas fechas
                _reservaActual.FechaInicio = dateTimePickerInicio.Value;
                _reservaActual.FechaFin = dateTimePickerFin.Value;

                // Lanzar el evento de actualización de reserva
                EventHelper.RaiseEvent(this, OnActualizarReserva, EventArgs.Empty);

            };

           

            // Botón de cancelación de reserva
            btnCancelarReserva.Click += (s, e) =>
            {
                EventHelper.RaiseEvent(this, OnCancelarReserva, EventArgs.Empty);
            };

            // Eventos para cambios en las fechas
            dateTimePickerInicio.ValueChanged += (s, e) => RecalcularDiasYPrecio();
            dateTimePickerFin.ValueChanged += (s, e) => RecalcularDiasYPrecio();
        }

        // Mostrar los detalles de la reserva en los controles correspondientes
        public void MostrarDetalleReserva(Reserva reserva)
        {
            _reservaActual = reserva;  // Guardar la reserva actual para su uso en la actualización

            txtNroHabitacionDetalle.Text = reserva.NroHabitacion.ToString();
            dateTimePickerInicio.Value = reserva.FechaInicio;
            dateTimePickerFin.Value = reserva.FechaFin;
            txtTipoHabitacion.Text = reserva.TipoHabitacion.ToString();
            txtDiasEstadia.Text = reserva.DiasDeEstadia.ToString();
            txtPrecioFinal.Text = $"{reserva.MontoTotal:C}";
        }

        // Recalcular días de estadía y precio total cuando cambian las fechas
        private void RecalcularDiasYPrecio()
        {
            // Calcular días de estadía
            int diasDeEstadia = (int)(dateTimePickerFin.Value - dateTimePickerInicio.Value).TotalDays;

            // Actualizar campo de días de estadía
            txtDiasEstadia.Text = diasDeEstadia.ToString();

            // Calcular y actualizar el precio final (Precio por noche * días de estadía)
            decimal precioPorNoche = _reservaActual.PrecioPorNoche;
            decimal montoTotal = diasDeEstadia * precioPorNoche;
            txtPrecioFinal.Text = $"{montoTotal:C}";
        }

        // Métodos para manejar la vista
        public void ShowView()
        {
            this.Show(); // Mostrar la vista como modal
        }

        public void CloseView()
        {
            this.Close();
        }

        public void ShowMessage(string message, string title)
        {
            MaterialMessageBox.Show(this, title, message);
        }

        public void HideView()
        {
            this.Hide();
        }
    }
}