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
    public partial class GuestView : MaterialForm, IGuestView
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        HabitacionCardContainer HabitacionCardContainer;

        public DateTime ReservaFechaDesde => dtpFechaDesde.Value;
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
            panel2.Controls.Add(HabitacionCardContainer);
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today.AddDays(7);
            AttachAndRaiseViewEvents();
            MostrarMensaje("Debe aplicar un filtro para ver las habitaciones disponibles...");
        }


        private void AttachAndRaiseViewEvents()
        {
            cmbFiltroHabitaciones.SelectedIndexChanged += (s, e) => EventHelper.RaiseEvent(this, OnFiltrarCategoria, EventArgs.Empty);

            // Usamos el MouseClick para detectar la selección
            listReservas.MouseClick += (s, e) =>
            {
                var reservaId = (int)listReservas.SelectedItems[0].Tag;
                EventHelper.RaiseEvent(this, ReservaSeleccionada, reservaId);
            };

            btnBuscarHabitaciones.Click += (s, e) =>
            {
            
                if (dtpFechaDesde.Value == null || dtpFechaHasta.Value == null)
                {
                    MessageBox.Show("Por favor, ingrese una fecha de inicio y una fecha de fin.");
                    return;
                }
                if (dtpFechaHasta.Value < dtpFechaDesde.Value)
                {
                    MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.");
                    return;
                }
                if (DateTime.Today > dtpFechaDesde.Value)
                {
                    MessageBox.Show("La fecha de inicio no puede ser anterior a la fecha actual.");
                    return;
                }
             
                EventHelper.RaiseEvent(this, OnFiltrarHabitacionesRangoFechas, new FiltroFechaEventArgs(dtpFechaDesde.Value, dtpFechaHasta.Value));
            };



        }


        public event EventHandler OnFiltrarCategoria;
        public event EventHandler<int> ReservaSeleccionada; // Cambiar a EventHandler<int> para pasar el ID de la reserva
        public event EventHandler<FiltroFechaEventArgs> OnFiltrarHabitacionesRangoFechas;
        public event EventHandler<HabitacionEventArgs> OnRealizarReserva;

        public void CargarTipoHabitaciones(List<Habitacion> habitaciones)
        {
            foreach (var item in habitaciones)
            {
                cmbFiltroHabitaciones.Items.Add(item);
            }
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
                    habitacionCardContainer.Add(card); // Añadir las tarjetas de las habitaciones
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
            listReservas.Columns.Add("Habitacion", 150);
            listReservas.Columns.Add("Categoria", 154);
            listReservas.Columns.Add("Check In", 170);
            listReservas.Columns.Add("Check Out", 170);
            listReservas.Columns.Add("Precio Final", 150);

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

                // Guardar el ID de la reserva en el Tag del ListViewItem
                listItem.Tag = reserva.Id;

                listReservas.Items.Add(listItem);
                contador++;
            }

        }

        // Implementación del método para mostrar el mensaje inicial
        // Método único para mostrar diferentes mensajes
        public void MostrarMensaje(string mensaje)
        {
            habitacionCardContainer.Clear();  // Limpiar cualquier contenido previo
            habitacionCardContainer.MostrarMensaje(mensaje); // Mostrar el mensaje en el contenedor
        }

    }
}
