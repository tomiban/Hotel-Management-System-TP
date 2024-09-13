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

        public void CargarHabitaciones(List<Habitacion> habitaciones)
        {
            //Pasrle desde el presentador la lista de habitaciones
            flowLayoutPanel.Controls.Clear();
          
            foreach (var habitacion in habitaciones)
            {
                var cardHabitacion = new HabitacionCard(habitacion);
                flowLayoutPanel.Controls.Add(cardHabitacion);
                // Suscribirse al evento ReservarButtonClick de cada tarjeta
                cardHabitacion.OnReservarButtonClicked += (s, e) =>
                {
                    // También puedes invocar eventos personalizados si los tienes
                    EventHelper.RaiseEvent(cardHabitacion, OnRealizarReserva, EventArgs.Empty);
                };
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
