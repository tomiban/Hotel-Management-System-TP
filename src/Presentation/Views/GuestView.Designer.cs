namespace Presentation.Views
{
    partial class GuestView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            ListViewItem listViewItem3 = new ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestView));
            tcCliente = new MaterialSkin.Controls.MaterialTabControl();
            tpHabitaciones = new TabPage();
            tableLayoutPanel = new TableLayoutPanel();
            btnBuscarHabitaciones = new MaterialSkin.Controls.MaterialButton();
            panel3 = new Panel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            dtpFechaHasta = new DateTimePicker();
            panel4 = new Panel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            dtpFechaDesde = new DateTimePicker();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            cmbFiltroHabitaciones = new MaterialSkin.Controls.MaterialComboBox();
            panelContenedor = new Panel();
            tpReservas = new TabPage();
            btnModificarReserva = new MaterialSkin.Controls.MaterialButton();
            listReservas = new MaterialSkin.Controls.MaterialListView();
            lblReservas = new MaterialSkin.Controls.MaterialLabel();
            tpCuenta = new TabPage();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            lblContraseña = new MaterialSkin.Controls.MaterialLabel();
            lblUsername = new MaterialSkin.Controls.MaterialLabel();
            linkCambiarContraseña = new LinkLabel();
            lblApellido = new MaterialSkin.Controls.MaterialLabel();
            lblTelefono = new MaterialSkin.Controls.MaterialLabel();
            lblNombre = new MaterialSkin.Controls.MaterialLabel();
            lblCuenta = new MaterialSkin.Controls.MaterialLabel();
            tpLogout = new TabPage();
            imageListCliente = new ImageList(components);
            imageList1 = new ImageList(components);
            colorDialog1 = new ColorDialog();
            tcCliente.SuspendLayout();
            tpHabitaciones.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tpReservas.SuspendLayout();
            tpCuenta.SuspendLayout();
            materialCard6.SuspendLayout();
            SuspendLayout();
            // 
            // tcCliente
            // 
            tcCliente.Controls.Add(tpHabitaciones);
            tcCliente.Controls.Add(tpReservas);
            tcCliente.Controls.Add(tpCuenta);
            tcCliente.Controls.Add(tpLogout);
            tcCliente.Depth = 0;
            tcCliente.Dock = DockStyle.Fill;
            tcCliente.ForeColor = Color.FromArgb(222, 255, 255, 255);
            tcCliente.ImageList = imageListCliente;
            tcCliente.Location = new Point(10, 64);
            tcCliente.MouseState = MaterialSkin.MouseState.HOVER;
            tcCliente.Multiline = true;
            tcCliente.Name = "tcCliente";
            tcCliente.SelectedIndex = 0;
            tcCliente.Size = new Size(1028, 653);
            tcCliente.TabIndex = 0;
            // 
            // tpHabitaciones
            // 
            tpHabitaciones.BackColor = Color.FromArgb(50, 50, 50);
            tpHabitaciones.Controls.Add(tableLayoutPanel);
            tpHabitaciones.Controls.Add(panelContenedor);
            tpHabitaciones.ImageKey = "apartment.png";
            tpHabitaciones.Location = new Point(4, 39);
            tpHabitaciones.Name = "tpHabitaciones";
            tpHabitaciones.Padding = new Padding(3);
            tpHabitaciones.Size = new Size(1020, 610);
            tpHabitaciones.TabIndex = 5;
            tpHabitaciones.Text = "Habitaciones";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.FromArgb(50, 50, 50);
            tableLayoutPanel.ColumnCount = 5;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.2F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.8F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 344F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 237F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel.Controls.Add(btnBuscarHabitaciones, 3, 1);
            tableLayoutPanel.Controls.Add(panel3, 2, 1);
            tableLayoutPanel.Controls.Add(panel4, 1, 1);
            tableLayoutPanel.Controls.Add(materialLabel5, 1, 0);
            tableLayoutPanel.Controls.Add(cmbFiltroHabitaciones, 3, 0);
            tableLayoutPanel.Dock = DockStyle.Top;
            tableLayoutPanel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            tableLayoutPanel.ForeColor = Color.FromArgb(222, 255, 255, 255);
            tableLayoutPanel.Location = new Point(3, 3);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 64.44444F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 35.5555573F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(1014, 135);
            tableLayoutPanel.TabIndex = 33;
            // 
            // btnBuscarHabitaciones
            // 
            btnBuscarHabitaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnBuscarHabitaciones.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscarHabitaciones.BackColor = Color.FromArgb(50, 50, 50);
            btnBuscarHabitaciones.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBuscarHabitaciones.Depth = 0;
            btnBuscarHabitaciones.ForeColor = Color.FromArgb(222, 255, 255, 255);
            btnBuscarHabitaciones.HighEmphasis = true;
            btnBuscarHabitaciones.Icon = null;
            btnBuscarHabitaciones.Location = new Point(776, 93);
            btnBuscarHabitaciones.Margin = new Padding(4, 6, 4, 6);
            btnBuscarHabitaciones.MaximumSize = new Size(0, 30);
            btnBuscarHabitaciones.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscarHabitaciones.Name = "btnBuscarHabitaciones";
            btnBuscarHabitaciones.NoAccentTextColor = Color.Empty;
            btnBuscarHabitaciones.Size = new Size(185, 30);
            btnBuscarHabitaciones.TabIndex = 21;
            btnBuscarHabitaciones.Text = "BUSCAR HABITACIONES";
            btnBuscarHabitaciones.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBuscarHabitaciones.UseAccentColor = false;
            btnBuscarHabitaciones.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(50, 50, 50);
            panel3.Controls.Add(materialLabel3);
            panel3.Controls.Add(dtpFechaHasta);
            panel3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel3.ForeColor = Color.FromArgb(222, 255, 255, 255);
            panel3.Location = new Point(420, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(315, 42);
            panel3.TabIndex = 24;
            // 
            // materialLabel3
            // 
            materialLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            materialLabel3.AutoSize = true;
            materialLabel3.BackColor = Color.FromArgb(50, 50, 50);
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.ForeColor = Color.FromArgb(222, 255, 255, 255);
            materialLabel3.Location = new Point(3, 9);
            materialLabel3.Margin = new Padding(3);
            materialLabel3.MinimumSize = new Size(0, 23);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(121, 23);
            materialLabel3.TabIndex = 23;
            materialLabel3.Text = "Fecha de Egreso:";
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtpFechaHasta.BackColor = Color.FromArgb(50, 50, 50);
            dtpFechaHasta.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpFechaHasta.ForeColor = Color.FromArgb(222, 255, 255, 255);
            dtpFechaHasta.Format = DateTimePickerFormat.Short;
            dtpFechaHasta.Location = new Point(130, 10);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(174, 23);
            dtpFechaHasta.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left;
            panel4.BackColor = Color.FromArgb(50, 50, 50);
            panel4.Controls.Add(materialLabel4);
            panel4.Controls.Add(dtpFechaDesde);
            panel4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel4.ForeColor = Color.FromArgb(222, 255, 255, 255);
            panel4.Location = new Point(64, 90);
            panel4.Name = "panel4";
            panel4.Size = new Size(329, 42);
            panel4.TabIndex = 27;
            // 
            // materialLabel4
            // 
            materialLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            materialLabel4.AutoSize = true;
            materialLabel4.BackColor = Color.FromArgb(50, 50, 50);
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.ForeColor = Color.FromArgb(222, 255, 255, 255);
            materialLabel4.Location = new Point(3, 8);
            materialLabel4.MinimumSize = new Size(0, 23);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(125, 23);
            materialLabel4.TabIndex = 26;
            materialLabel4.Text = "Fecha de Ingreso:";
            materialLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtpFechaDesde.BackColor = Color.FromArgb(50, 50, 50);
            dtpFechaDesde.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpFechaDesde.ForeColor = Color.FromArgb(222, 255, 255, 255);
            dtpFechaDesde.Format = DateTimePickerFormat.Short;
            dtpFechaDesde.Location = new Point(134, 8);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(173, 23);
            dtpFechaDesde.TabIndex = 19;
            // 
            // materialLabel5
            // 
            materialLabel5.Anchor = AnchorStyles.Left;
            materialLabel5.AutoSize = true;
            materialLabel5.BackColor = Color.FromArgb(50, 50, 50);
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            materialLabel5.ForeColor = Color.FromArgb(222, 255, 255, 255);
            materialLabel5.Location = new Point(64, 23);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(201, 41);
            materialLabel5.TabIndex = 28;
            materialLabel5.Text = "Habitaciones";
            materialLabel5.UseAccent = true;
            // 
            // cmbFiltroHabitaciones
            // 
            cmbFiltroHabitaciones.Anchor = AnchorStyles.None;
            cmbFiltroHabitaciones.AutoCompleteCustomSource.AddRange(new string[] { "Busqueda" });
            cmbFiltroHabitaciones.AutoResize = false;
            cmbFiltroHabitaciones.BackColor = Color.FromArgb(50, 50, 50);
            cmbFiltroHabitaciones.Cursor = Cursors.Hand;
            cmbFiltroHabitaciones.Depth = 0;
            cmbFiltroHabitaciones.DrawMode = DrawMode.OwnerDrawVariable;
            cmbFiltroHabitaciones.DropDownHeight = 174;
            cmbFiltroHabitaciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroHabitaciones.DropDownWidth = 121;
            cmbFiltroHabitaciones.FlatStyle = FlatStyle.Popup;
            cmbFiltroHabitaciones.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbFiltroHabitaciones.ForeColor = Color.FromArgb(222, 255, 255, 255);
            cmbFiltroHabitaciones.FormattingEnabled = true;
            cmbFiltroHabitaciones.ImeMode = ImeMode.On;
            cmbFiltroHabitaciones.IntegralHeight = false;
            cmbFiltroHabitaciones.ItemHeight = 43;
            cmbFiltroHabitaciones.Items.AddRange(new object[] { "Filtrar por categoría", "Economica", "Estándard", "Presidencial" });
            cmbFiltroHabitaciones.Location = new Point(753, 19);
            cmbFiltroHabitaciones.MaxDropDownItems = 4;
            cmbFiltroHabitaciones.MouseState = MaterialSkin.MouseState.OUT;
            cmbFiltroHabitaciones.Name = "cmbFiltroHabitaciones";
            cmbFiltroHabitaciones.Size = new Size(231, 49);
            cmbFiltroHabitaciones.StartIndex = 0;
            cmbFiltroHabitaciones.TabIndex = 17;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(50, 50, 50);
            panelContenedor.Dock = DockStyle.Bottom;
            panelContenedor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panelContenedor.ForeColor = Color.FromArgb(222, 255, 255, 255);
            panelContenedor.Location = new Point(3, 133);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1014, 474);
            panelContenedor.TabIndex = 14;
            // 
            // tpReservas
            // 
            tpReservas.BackColor = Color.FromArgb(50, 50, 50);
            tpReservas.Controls.Add(btnModificarReserva);
            tpReservas.Controls.Add(listReservas);
            tpReservas.Controls.Add(lblReservas);
            tpReservas.ImageKey = "book.png";
            tpReservas.Location = new Point(4, 39);
            tpReservas.Name = "tpReservas";
            tpReservas.Size = new Size(1020, 610);
            tpReservas.TabIndex = 3;
            tpReservas.Text = "Reservas";
            // 
            // btnModificarReserva
            // 
            btnModificarReserva.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificarReserva.BackColor = Color.FromArgb(50, 50, 50);
            btnModificarReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnModificarReserva.Depth = 0;
            btnModificarReserva.ForeColor = Color.FromArgb(222, 255, 255, 255);
            btnModificarReserva.HighEmphasis = true;
            btnModificarReserva.Icon = null;
            btnModificarReserva.Location = new Point(56, 85);
            btnModificarReserva.Margin = new Padding(4, 6, 4, 6);
            btnModificarReserva.MouseState = MaterialSkin.MouseState.HOVER;
            btnModificarReserva.Name = "btnModificarReserva";
            btnModificarReserva.NoAccentTextColor = Color.Empty;
            btnModificarReserva.Size = new Size(122, 36);
            btnModificarReserva.TabIndex = 2;
            btnModificarReserva.Text = "VER DETALLES";
            btnModificarReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnModificarReserva.UseAccentColor = false;
            btnModificarReserva.UseVisualStyleBackColor = false;
            // 
            // listReservas
            // 
            listReservas.Anchor = AnchorStyles.None;
            listReservas.AutoSizeTable = false;
            listReservas.BackColor = Color.FromArgb(255, 255, 255);
            listReservas.BorderStyle = BorderStyle.None;
            listReservas.Depth = 0;
            listReservas.Font = new Font("Garamond", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listReservas.ForeColor = Color.FromArgb(222, 255, 255, 255);
            listReservas.FullRowSelect = true;
            listReservas.HoverSelection = true;
            listReservas.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listReservas.Location = new Point(75, 130);
            listReservas.MinimumSize = new Size(200, 100);
            listReservas.MouseLocation = new Point(-1, -1);
            listReservas.MouseState = MaterialSkin.MouseState.OUT;
            listReservas.Name = "listReservas";
            listReservas.OwnerDraw = true;
            listReservas.Size = new Size(891, 436);
            listReservas.TabIndex = 1;
            listReservas.TileSize = new Size(3, 3);
            listReservas.UseCompatibleStateImageBehavior = false;
            listReservas.View = View.Details;
            // 
            // lblReservas
            // 
            lblReservas.AutoSize = true;
            lblReservas.BackColor = Color.FromArgb(50, 50, 50);
            lblReservas.Depth = 0;
            lblReservas.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblReservas.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblReservas.ForeColor = Color.FromArgb(222, 255, 255, 255);
            lblReservas.Location = new Point(56, 18);
            lblReservas.MouseState = MaterialSkin.MouseState.HOVER;
            lblReservas.Name = "lblReservas";
            lblReservas.Size = new Size(205, 41);
            lblReservas.TabIndex = 0;
            lblReservas.Text = "Mis Reservas";
            // 
            // tpCuenta
            // 
            tpCuenta.BackColor = Color.FromArgb(50, 50, 50);
            tpCuenta.Controls.Add(materialCard6);
            tpCuenta.Controls.Add(lblCuenta);
            tpCuenta.ImageKey = "account_circle.png";
            tpCuenta.Location = new Point(4, 39);
            tpCuenta.Name = "tpCuenta";
            tpCuenta.Padding = new Padding(3);
            tpCuenta.Size = new Size(1020, 610);
            tpCuenta.TabIndex = 1;
            tpCuenta.Text = "Mi Cuenta";
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Controls.Add(txtPassword);
            materialCard6.Controls.Add(txtUsername);
            materialCard6.Controls.Add(txtTelefono);
            materialCard6.Controls.Add(txtApellido);
            materialCard6.Controls.Add(txtNombre);
            materialCard6.Controls.Add(lblContraseña);
            materialCard6.Controls.Add(lblUsername);
            materialCard6.Controls.Add(linkCambiarContraseña);
            materialCard6.Controls.Add(lblApellido);
            materialCard6.Controls.Add(lblTelefono);
            materialCard6.Controls.Add(lblNombre);
            materialCard6.Depth = 0;
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(134, 99);
            materialCard6.Margin = new Padding(14);
            materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(14);
            materialCard6.Size = new Size(726, 361);
            materialCard6.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BackColor = Color.FromArgb(50, 50, 50);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.ForeColor = Color.FromArgb(222, 255, 255, 255);
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(434, 163);
            txtPassword.MaxLength = 50;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Password = true;
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(208, 50);
            txtPassword.TabIndex = 13;
            txtPassword.Text = "";
            txtPassword.TrailingIcon = null;
            // 
            // txtUsername
            // 
            txtUsername.AnimateReadOnly = false;
            txtUsername.BackColor = Color.FromArgb(50, 50, 50);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Depth = 0;
            txtUsername.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsername.ForeColor = Color.FromArgb(222, 255, 255, 255);
            txtUsername.LeadingIcon = null;
            txtUsername.Location = new Point(434, 72);
            txtUsername.MaxLength = 50;
            txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(208, 50);
            txtUsername.TabIndex = 12;
            txtUsername.Text = "";
            txtUsername.TrailingIcon = null;
            // 
            // txtTelefono
            // 
            txtTelefono.AnimateReadOnly = false;
            txtTelefono.BackColor = Color.FromArgb(50, 50, 50);
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Depth = 0;
            txtTelefono.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefono.ForeColor = Color.FromArgb(222, 255, 255, 255);
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(101, 260);
            txtTelefono.MaxLength = 50;
            txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefono.Multiline = false;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(208, 50);
            txtTelefono.TabIndex = 10;
            txtTelefono.Text = "";
            txtTelefono.TrailingIcon = null;
            // 
            // txtApellido
            // 
            txtApellido.AnimateReadOnly = false;
            txtApellido.BackColor = Color.FromArgb(50, 50, 50);
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Depth = 0;
            txtApellido.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtApellido.ForeColor = Color.FromArgb(222, 255, 255, 255);
            txtApellido.LeadingIcon = null;
            txtApellido.Location = new Point(101, 163);
            txtApellido.MaxLength = 50;
            txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            txtApellido.Multiline = false;
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(208, 50);
            txtApellido.TabIndex = 9;
            txtApellido.Text = "";
            txtApellido.TrailingIcon = null;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.BackColor = Color.FromArgb(50, 50, 50);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.ForeColor = Color.FromArgb(222, 255, 255, 255);
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(101, 72);
            txtNombre.MaxLength = 50;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(208, 50);
            txtNombre.TabIndex = 8;
            txtNombre.Text = "";
            txtNombre.TrailingIcon = null;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = Color.FromArgb(50, 50, 50);
            lblContraseña.Depth = 0;
            lblContraseña.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblContraseña.ForeColor = Color.FromArgb(222, 255, 255, 255);
            lblContraseña.Location = new Point(434, 145);
            lblContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(71, 19);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.FromArgb(50, 50, 50);
            lblUsername.Depth = 0;
            lblUsername.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUsername.ForeColor = Color.FromArgb(222, 255, 255, 255);
            lblUsername.Location = new Point(434, 49);
            lblUsername.MouseState = MaterialSkin.MouseState.HOVER;
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(72, 19);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // linkCambiarContraseña
            // 
            linkCambiarContraseña.AutoSize = true;
            linkCambiarContraseña.BackColor = Color.FromArgb(80, 80, 80);
            linkCambiarContraseña.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            linkCambiarContraseña.ForeColor = Color.FromArgb(222, 255, 255, 255);
            linkCambiarContraseña.Location = new Point(581, 146);
            linkCambiarContraseña.Name = "linkCambiarContraseña";
            linkCambiarContraseña.Size = new Size(65, 17);
            linkCambiarContraseña.TabIndex = 7;
            linkCambiarContraseña.TabStop = true;
            linkCambiarContraseña.Text = "Modificar";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.FromArgb(50, 50, 50);
            lblApellido.Depth = 0;
            lblApellido.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblApellido.ForeColor = Color.FromArgb(222, 255, 255, 255);
            lblApellido.Location = new Point(102, 142);
            lblApellido.MouseState = MaterialSkin.MouseState.HOVER;
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(58, 19);
            lblApellido.TabIndex = 0;
            lblApellido.Text = "Apellido";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.FromArgb(50, 50, 50);
            lblTelefono.Depth = 0;
            lblTelefono.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTelefono.ForeColor = Color.FromArgb(222, 255, 255, 255);
            lblTelefono.Location = new Point(101, 238);
            lblTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(64, 19);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(50, 50, 50);
            lblNombre.Depth = 0;
            lblNombre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNombre.ForeColor = Color.FromArgb(222, 255, 255, 255);
            lblNombre.Location = new Point(101, 50);
            lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 19);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.BackColor = Color.FromArgb(50, 50, 50);
            lblCuenta.Depth = 0;
            lblCuenta.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCuenta.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblCuenta.ForeColor = Color.FromArgb(222, 255, 255, 255);
            lblCuenta.Location = new Point(56, 18);
            lblCuenta.MouseState = MaterialSkin.MouseState.HOVER;
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(155, 41);
            lblCuenta.TabIndex = 8;
            lblCuenta.Text = "Mi Cuenta";
            // 
            // tpLogout
            // 
            tpLogout.BackColor = Color.FromArgb(50, 50, 50);
            tpLogout.ImageKey = "logout.png";
            tpLogout.Location = new Point(4, 39);
            tpLogout.Name = "tpLogout";
            tpLogout.Size = new Size(1020, 610);
            tpLogout.TabIndex = 4;
            tpLogout.Text = "Salir";
            // 
            // imageListCliente
            // 
            imageListCliente.ColorDepth = ColorDepth.Depth32Bit;
            imageListCliente.ImageStream = (ImageListStreamer)resources.GetObject("imageListCliente.ImageStream");
            imageListCliente.TransparentColor = Color.Transparent;
            imageListCliente.Images.SetKeyName(0, "bed.png");
            imageListCliente.Images.SetKeyName(1, "logout.png");
            imageListCliente.Images.SetKeyName(2, "person_search.png");
            imageListCliente.Images.SetKeyName(3, "bookmark_check.png");
            imageListCliente.Images.SetKeyName(4, "account_circle.png");
            imageListCliente.Images.SetKeyName(5, "apartment.png");
            imageListCliente.Images.SetKeyName(6, "book.png");
            imageListCliente.Images.SetKeyName(7, "add.png");
            imageListCliente.Images.SetKeyName(8, "bookmark_check.png");
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // GuestView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1048, 720);
            Controls.Add(tcCliente);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tcCliente;
            Name = "GuestView";
            Padding = new Padding(10, 64, 10, 3);
            Text = "El Molino Hotel";
            tcCliente.ResumeLayout(false);
            tpHabitaciones.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tpReservas.ResumeLayout(false);
            tpReservas.PerformLayout();
            tpCuenta.ResumeLayout(false);
            tpCuenta.PerformLayout();
            materialCard6.ResumeLayout(false);
            materialCard6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcCliente;
        private TabPage tpCuenta;
        private ImageList imageListCliente;
        private TabPage tpReservas;
        private TabPage tpLogout;
        private TabPage tpHabitaciones;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private MaterialSkin.Controls.MaterialListView listReservas;
        private MaterialSkin.Controls.MaterialLabel lblReservas;
        private LinkLabel linkCambiarContraseña;
        private MaterialSkin.Controls.MaterialLabel lblTelefono;
        private MaterialSkin.Controls.MaterialLabel lblUsername;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblContraseña;
        private MaterialSkin.Controls.MaterialLabel lblApellido;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialLabel lblCuenta;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox txtApellido;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private ImageList imageList1;
        private Panel panelContenedor;
        private MaterialSkin.Controls.MaterialButton btnModificarReserva;
        private ColorDialog colorDialog1;
        private TableLayoutPanel tableLayoutPanel;
        private MaterialSkin.Controls.MaterialButton btnBuscarHabitaciones;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private DateTimePicker dtpFechaHasta;
        private Panel panel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private DateTimePicker dtpFechaDesde;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox cmbFiltroHabitaciones;
    }
}