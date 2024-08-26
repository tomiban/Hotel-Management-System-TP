
using Domain.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using Presentation.Views;

namespace Presentation.Views
{
    public partial class AdminView : MaterialForm, IAdminView
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public AdminView()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
         Primary.DeepPurple600,   // Deep Purple más oscuro para un mejor contraste
         Primary.DeepPurple700,   // Deep Purple oscuro para el contraste principal
         Primary.Cyan700,   // Deep Purple base para fondos principales
         Accent.Cyan700,         // Acento verde 400 para destacar
         TextShade.WHITE          // Color de texto blanco para el contraste
     );

        }

        public event EventHandler AñadirEvent;
        public event EventHandler EditarEvent;
        public event EventHandler EliminarEvent;
        public event EventHandler SearchEvent;


        private void AssocciateAndRaiseViewEvents()
        {
            btnAgregarHab.Click += delegate { AñadirEvent?.Invoke(this, EventArgs.Empty); };
            btnEditarHab.Click += delegate { EditarEvent?.Invoke(this, EventArgs.Empty); };
            btnBorrarHab.Click += delegate { EliminarEvent?.Invoke(this, EventArgs.Empty); };
        }

        public void ActualizarListaUsuarios(List<Usuario> items)
        {
            listUsuarios.Items.Clear();
            var usuarios = new List<Usuario>()
               {
                   new Usuario
                   {
                       Id = 1,
                       Nombre = "John",
                       Apellido = "Doe",
                       Edad = 30,
                       Telefono = "123456789",
                       Role = Role.Admin
                   },
                   new Usuario
                   {
                       Id = 2,
                       Nombre = "Jane",
                       Apellido = "Doe",
                       Edad = 25,
                       Telefono = "987654321",
                       Role = Role.Guest
                   }
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

        public void ActualizarListaHabitaciones(List<Habitacion> itemss)
        {
            listHabitaciones.Items.Clear();
            List<Habitacion> items = new List<Habitacion>
                {
                    new Habitacion
                    {
                        Id = 1,
                        NroHabitacion = 1,
                        TipoHabitacion = TipoHabitacion.Standard,
                        Disponible = true,
                        PrecioPorNoche = 100
                    },
                    new Habitacion
                    {
                        Id = 2,
                        NroHabitacion = 2,
                        TipoHabitacion = TipoHabitacion.Premium,
                        Disponible = false,
                        PrecioPorNoche = 200
                    }
            };
            foreach (var hab in items)
            {
                ListViewItem item = new ListViewItem(hab.Id.ToString());
                item.SubItems.Add(hab.NroHabitacion.ToString());
                item.SubItems.Add(hab.TipoHabitacion.ToString());
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
