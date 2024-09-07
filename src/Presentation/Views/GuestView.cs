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
                 Primary.DeepPurple600,   // Deep Purple más oscuro para un mejor contraste
                 Primary.DeepPurple700,   // Deep Purple oscuro para el contraste principal
                 Primary.Cyan300,   // Deep Purple base para fondos principales
                 Accent.Cyan700,         // Acento verde 400 para destacar
                 TextShade.WHITE          // Color de texto blanco para el contraste
             );

            SkinHelper.ApplyTheme(this, MaterialSkinManager.Themes.DARK, ColorScheme);




            AttachAndRaiseViewEvents();


        }

        private void AttachAndRaiseViewEvents()
        {
            // btnReserva.Click += (s, e) => EventHelper.RaiseEvent(this, OnReservaClicked, EventArgs.Empty);
            cmbFiltroHabitaciones.SelectedIndexChanged += (s, e) => EventHelper.RaiseEvent(this, OnCategoriaFiltrada, EventArgs.Empty);
        }

        public event EventHandler OnReservaClicked;
        public event EventHandler OnCategoriaFiltrada;

        //public void CargarHabitaciones(List<Habitacion> habitaciones)
        //{
        //    foreach (var item in habitaciones)
        //    {
        //        cmbFiltroHabitaciones.Items.Add(item);
        //    }
        //}

        public void CargarHabitaciones(List<Habitacion> habitaciones)
        {
            flowLayoutPanel.Controls.Clear();
            habitaciones.Add(
                new Habitacion() { NroHabitacion = 1, PrecioPorNoche = 500, Disponible = true, CantidadPersonas = 3, TipoHabitacion = TipoHabitacion.Premium }
                );

            habitaciones.Add(
               new Habitacion() { NroHabitacion = 2, PrecioPorNoche = 123, Disponible = true, CantidadPersonas = 5, TipoHabitacion = TipoHabitacion.Economic }
               );

            habitaciones.Add(
               new Habitacion() { NroHabitacion = 3, PrecioPorNoche = 80, Disponible = false, CantidadPersonas = 3, TipoHabitacion = TipoHabitacion.Economic }
               );
            foreach (var habitacion in habitaciones)
            {
                var cardHabitacion = new HabitacionCard(habitacion.NroHabitacion, habitacion.PrecioPorNoche, habitacion.TipoHabitacion, habitacion.Disponible);
                flowLayoutPanel.Controls.Add(cardHabitacion);
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

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
