
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

        public AdminView()
        {
            InitializeComponent();

            var colorScheme = new ColorScheme(
            Primary.DeepPurple600,   // Deep Purple más oscuro para un mejor contraste
            Primary.DeepPurple700,   // Deep Purple oscuro para el contraste principal
            Primary.Cyan700,   // Deep Purple base para fondos principales
            Accent.Cyan700,         // Acento verde 400 para destacar
            TextShade.WHITE          // Color de texto blanco para el contraste
        );

            SkinHelper.ApplyTheme(this, MaterialSkinManager.Themes.DARK, colorScheme);

            AttachAndRaiseViewEvents();

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
            listHabitaciones.Columns.Add("Capacidad máxima", 200, HorizontalAlignment.Left);
            listHabitaciones.Columns.Add("Disponibilidad", 150, HorizontalAlignment.Left);
            listHabitaciones.Columns.Add("Precio por noche", 200, HorizontalAlignment.Left);


            foreach (var hab in habitaciones)
            {
                 ListViewItem item = new ListViewItem(hab.NroHabitacion.ToString());
                item.SubItems.Add(hab.TipoHabitacion.ToString());
                item.SubItems.Add(string.Concat(hab.CantidadPersonas.ToString(), " personas"));
                item.SubItems.Add(hab.Disponible ? "Disponible" : "Ocupada");
                item.SubItems.Add(hab.PrecioPorNoche.ToString("C"));
                listHabitaciones.Items.Add(item);
            }
        }


        public void ShowMessage(string title, string message)
        {

            MaterialMessageBox.Show(this, title, message);
        }



        public void ObtenerDatos()
        {
            throw new NotImplementedException();
        }

        public int ObtenerIdSeleccionado()
        {
            throw new NotImplementedException();
        }

        public void LimpiarFormulario()
        {
            throw new NotImplementedException();
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
