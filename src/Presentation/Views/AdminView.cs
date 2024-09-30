
using ApplicationLayer.Services;
using Domain.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using Presentation.Views;
using PresentationLayer.Helpers;
using PresentationLayer.Utils;
using System.Net.Sockets;

namespace Presentation.Views
{
    public partial class AdminView : MaterialForm, IAdminView
    {

        public event EventHandler RedirectToCrearEditarHabitacion;
        public event EventHandler RedirectToCrearEditarUsuario;
        public event EventHandler EliminarHabitacion;
        public event EventHandler SearchHabitacion;
        public event EventHandler SearchUsuario;
        public event EventHandler EditarHabitacion;
        public event Action<int, Role> RolUsuarioCambiado;
        public event Action<int> EliminarUsuario;
        public event EventHandler ActualizarRol;
        private bool isEditMode = false;

        public AdminView()
        {
            InitializeComponent();
            btnBorrarHab.Enabled = false;
            btnEditarHab.Enabled = false;


            var colorScheme = new ColorScheme(
            Primary.DeepPurple600,
            Primary.DeepPurple700,
            Primary.Cyan700,
            Accent.Cyan700,
            TextShade.WHITE
        );

            SkinHelper.ApplyTheme(this, MaterialSkinManager.Themes.DARK, colorScheme);

            AttachAndRaiseViewEvents();
            AttachDeleteEvents();
            AttachEditEvents();

            //listHabitaciones.SelectedIndexChanged += OnHabitacionSeleccionada;
            listHabitaciones.SelectedIndexChanged += OnHabitacionSelectionChanged;
            dataGridViewUsuarios.CurrentCellDirtyStateChanged += DataGridViewUsuarios_CurrentCellDirtyStateChanged;
            tcAdmin.SelectedIndexChanged += TabControl_SelectedIndexChanged;
        }

        private void DataGridViewUsuarios_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.IsCurrentCellDirty)
            {
                dataGridViewUsuarios.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void OnHabitacionSelectionChanged(object sender, EventArgs e)
        {
            btnBorrarHab.Enabled = listHabitaciones.SelectedItems.Count > 0;
            btnEditarHab.Enabled = listHabitaciones.SelectedItems.Count > 0;
        }

        private void AttachDeleteEvents()
        {
            btnBorrarHab.Click += (s, e) => EventHelper.RaiseEvent(this, EliminarHabitacion, EventArgs.Empty);
            btnBorrarUsu.Click += (s, e) =>
            {
                if (dataGridViewUsuarios.SelectedRows.Count > 0)
                {
                    int userId = int.Parse(dataGridViewUsuarios.SelectedRows[0].Cells["ID"].Value.ToString());
                    EliminarUsuario?.Invoke(userId);  // Invocar directamente el Action<int>
                }
            };
        }

        private void AttachEditEvents()
        {
            btnEditarHab.Click += (s, e) =>
            {
                EventHelper.RaiseEvent(this, EditarHabitacion, EventArgs.Empty);
            };
            // Editar Usuarios
            btnActualizarRol.Click += (s, e) =>
            {
                EventHelper.RaiseEvent(this, ActualizarRol, EventArgs.Empty);
            };
        }

        public Role GetSelectedUserRole()
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el valor de la columna "Rol" de la fila seleccionada
                var roleValue = dataGridViewUsuarios.SelectedRows[0].Cells["Rol"].Value;

                // Asegurarse de que el valor no es nulo y convertirlo a Role
                if (roleValue != null && Enum.TryParse(roleValue.ToString(), out Role selectedRole))
                {
                    return selectedRole;
                }
                else
                {
                    throw new Exception("No se pudo obtener el rol seleccionado.");
                }
            }
            else
            {
                throw new Exception("No hay usuario seleccionado.");
            }
        }

        public int GetSelectedUserId()
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                return int.Parse(dataGridViewUsuarios.SelectedRows[0].Cells["ID"].Value.ToString());
            }
            return -1;  // No hay usuario seleccionado
        }

        public void SetEliminarHabitacionButtonState(bool enabled)
        {
            btnBorrarHab.Enabled = enabled;
        }
        public void SetEditarHabitacionButtonState(bool enabled)
        {
            btnEditarHab.Enabled = enabled;
        }

        private void AttachAndRaiseViewEvents()
        {
            btnAgregarHab.Click += (s, e) =>
            {
                EventHelper.RaiseEvent(this, RedirectToCrearEditarHabitacion, EventArgs.Empty);
            };
        }

        public void ActualizarListaUsuarios(List<Usuario> usuarios)
        {
            // Limpiar las columnas y filas actuales del DataGridView
            dataGridViewUsuarios.Columns.Clear();
            dataGridViewUsuarios.Rows.Clear();

            // Configurar las columnas del DataGridView
            dataGridViewUsuarios.Columns.Add("ID", "ID");
            dataGridViewUsuarios.Columns.Add("Nombre", "Nombre");
            dataGridViewUsuarios.Columns.Add("Apellido", "Apellido");
            dataGridViewUsuarios.Columns.Add("Edad", "Edad");
            dataGridViewUsuarios.Columns.Add("Telefono", "Teléfono");

            // Hacer las columnas solo lectura excepto la de "Rol"
            dataGridViewUsuarios.Columns["ID"].ReadOnly = true;
            dataGridViewUsuarios.Columns["Nombre"].ReadOnly = true;
            dataGridViewUsuarios.Columns["Apellido"].ReadOnly = true;
            dataGridViewUsuarios.Columns["Edad"].ReadOnly = true;
            dataGridViewUsuarios.Columns["Telefono"].ReadOnly = true;

            // Columna Rol (editable) - Configurar correctamente el ComboBox con los valores del enum
            var colRol = new DataGridViewComboBoxColumn
            {
                HeaderText = "Rol",
                DataPropertyName = "Role",  // Asegúrate de que coincida con la propiedad del objeto Usuario
                DataSource = Enum.GetValues(typeof(Role)),  // Usar los valores del enum Role como opciones
                ValueType = typeof(Role),  // El tipo del valor debe ser Role
                Name = "Rol",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox,  // Mostrar siempre el ComboBox para editarlo
                FlatStyle = FlatStyle.Flat  // Para un estilo plano sin bordes gruesos
            };

            dataGridViewUsuarios.Columns.Add(colRol);

            // Añadir filas al DataGridView
            foreach (var usuario in usuarios)
            {
                dataGridViewUsuarios.Rows.Add(
                    usuario.Id.ToString(),
                    usuario.Nombre,
                    usuario.Apellido,
                    usuario.Edad.ToString(),
                    usuario.Telefono,
                    usuario.Role  // Asegúrate de que estás asignando el valor del enum directamente
                );
            }

            // Suscribirse al evento CellEnter para entrar en modo de edición automáticamente en la columna de Rol
            dataGridViewUsuarios.CellEnter += DataGridViewUsuarios_CellEnter;

            // Refrescar el DataGridView para que se actualice correctamente
            dataGridViewUsuarios.Refresh();
        }

        // Este evento activará el modo de edición en la columna del ComboBox automáticamente
        private void DataGridViewUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUsuarios.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                dataGridViewUsuarios.BeginEdit(true);  // Activar la edición automáticamente
            }
        }


        public void ActualizarListaHabitaciones(List<Habitacion> habitaciones)
        {
            listHabitaciones.Columns.Clear();
            listHabitaciones.Items.Clear();
            listHabitaciones.Columns.Add("Número de Habitación", 200, HorizontalAlignment.Left);
            listHabitaciones.Columns.Add("Tipo", 155, HorizontalAlignment.Left);
            listHabitaciones.Columns.Add("Capacidad", 200, HorizontalAlignment.Left);
            listHabitaciones.Columns.Add("Disponibilidad", 150, HorizontalAlignment.Left);
            listHabitaciones.Columns.Add("Precio por noche", 200, HorizontalAlignment.Left);


            foreach (var hab in habitaciones)
            {
                ListViewItem listItem = new ListViewItem(hab.NroHabitacion.ToString());
                listItem.SubItems.Add(hab.TipoHabitacion.ToString());
                listItem.SubItems.Add(string.Concat(hab.Capacidad.ToString(), " personas"));
                listItem.SubItems.Add(hab.Disponible ? "Disponible" : "Ocupada");
                listItem.SubItems.Add(hab.PrecioPorNoche.ToString("C"));
                listHabitaciones.Items.Add(listItem);
            }
        }
        public void ActualizarDashboard(int reservasActivas, double porcentajeOcupacion, int totalUsuarios, int nuevosUsuarios, decimal facturacionAnual)
        {
            // Actualizar el texto y la barra de progreso para "Reservas"
            lblTotalReservas.Text = reservasActivas.ToString();
            captionLblOcupacion.Text = $"{porcentajeOcupacion}% Ocupación";
            progressBarOcupacion.Value = (int)porcentajeOcupacion;

            // Actualizar los valores para "Usuarios Totales"
            lblTotalUsuarios.Text = totalUsuarios.ToString();
            captionLblUsuarios.Text = $"{nuevosUsuarios} Nuevos Usuarios";

            // Actualizar la facturación
            lblTotalFacturado.Text = $"{facturacionAnual:C}"; // Mostrar el monto formateado con símbolo de moneda
        }

        public void CargarListaReservasActivas(List<Reserva> reservas)
        {
            listReservasActivas.Columns.Clear();
            listReservasActivas.Items.Clear();

            // Definir columnas de la lista
            listReservasActivas.Columns.Add("Número de Habitación", 200, HorizontalAlignment.Left);
            listReservasActivas.Columns.Add("Nombre de Usuario", 155, HorizontalAlignment.Left);
            listReservasActivas.Columns.Add("Fecha de Inicio", 200, HorizontalAlignment.Left);
            listReservasActivas.Columns.Add("Fecha de Fin", 200, HorizontalAlignment.Left);


            // Cargar las reservas activas en el ListView
            foreach (var reserva in reservas)
            {
                ListViewItem listItem = new ListViewItem(reserva.NroHabitacion.ToString());
                listItem.SubItems.Add(reserva.Username);
                listItem.SubItems.Add(reserva.FechaInicio.ToShortDateString());
                listItem.SubItems.Add(reserva.FechaFin.ToShortDateString());


                listReservasActivas.Items.Add(listItem);
            }
        }


        public void ShowMessage(string title, string message)
        {

            MaterialMessageBox.Show(this, title, message);
        }


        public int ObtenerNroHabitacionSeleccionado()
        {
            if (listHabitaciones.SelectedItems.Count == 0)
            {
                throw new ApplicationException("No hay ninguna habitación seleccionada.");
            }

            // Obtenemos el primer ítem seleccionado
            var selectedItem = listHabitaciones.SelectedItems[0];
            int id = int.Parse(selectedItem.Text); // El Nro de la habitación está en la primera columna
            return id;
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

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificamos si la pestaña seleccionada es "tpLogout"
            if (tcAdmin.SelectedTab == tpLogout)
            {
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
                    tcAdmin.SelectedIndex = 0;
                }
            }
        }

    }
}
