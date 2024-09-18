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


        // Método para cargar las tarjetas de habitaciones
        public void CargarHabitacionCards(List<HabitacionCard> habitacionCards)
        {
            habitacionCardContainer.Controls.Clear(); // Limpiar las tarjetas previas

            foreach (var card in habitacionCards)
            {
                habitacionCardContainer.Controls.Add(card); // Añadir cada tarjeta al panel
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
    }
}
