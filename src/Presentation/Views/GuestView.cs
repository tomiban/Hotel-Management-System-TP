using Domain.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using PresentationLayer.Components;
using PresentationLayer.Helpers;
using PresentationLayer.Utils;
using PresentationLayer.Views;
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
    public partial class GuestView : MaterialForm, IGuestView
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        HabitacionCardContainer habitacionCardContainer;



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

            habitacionCardContainer = new HabitacionCardContainer();
            tpHabitaciones.Controls.Add(habitacionCardContainer);
            AttachAndRaiseViewEvents();

        }

        private void AttachAndRaiseViewEvents()
        {
            cmbFiltroHabitaciones.SelectedIndexChanged += (s, e) => EventHelper.RaiseEvent(this, OnFiltrarCategoria, EventArgs.Empty);
        }

        public event EventHandler OnRealizarReserva;
        public event EventHandler OnFiltrarCategoria;

        public void CargarTipoHabitaciones(List<Habitacion> habitaciones)
        {
            foreach (var item in habitaciones)
            {
                cmbFiltroHabitaciones.Items.Add(item);
            }
        }



        public void CargarHabitacionCards(List<HabitacionCard> habitacionCards)
        {
            habitacionCardContainer.Controls.Clear(); // Limpiar las tarjetas previas

            foreach (var card in habitacionCards)
            {
                habitacionCardContainer.Controls.Add(card); 
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

            listReservas.Columns.Add("Id");
            listReservas.Columns.Add("Habitacion");
            listReservas.Columns.Add("Categoria");
            listReservas.Columns.Add("Check In");
            listReservas.Columns.Add("Check Out");


            foreach (var reserva in reservas)
            {
                ListViewItem listItem = new ListViewItem(reserva.Id.ToString());
                listItem.SubItems.Add(reserva.NroHabitacion.ToString());
                listItem.SubItems.Add(reserva.Username);
                listItem.SubItems.Add(reserva.FechaInicio.ToString());
                listItem.SubItems.Add(reserva.FechaFin.ToString());
                listItem.SubItems.Add(reserva.MontoTotal.ToString());
            }
        }

    }
}
