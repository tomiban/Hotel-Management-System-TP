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
            panel2 = new Panel();
            panel1 = new Panel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btnBuscarHabitaciones = new MaterialSkin.Controls.MaterialButton();
            dtpFechaHasta = new DateTimePicker();
            dtpFechaDesde = new DateTimePicker();
            lblHabitaciones = new MaterialSkin.Controls.MaterialLabel();
            cmbFiltroHabitaciones = new MaterialSkin.Controls.MaterialComboBox();
            tpReservas = new TabPage();
            listReservas = new MaterialSkin.Controls.MaterialListView();
            lblReservas = new MaterialSkin.Controls.MaterialLabel();
            tpCuenta = new TabPage();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            txtDomicilio = new MaterialSkin.Controls.MaterialTextBox();
            txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            lblContraseña = new MaterialSkin.Controls.MaterialLabel();
            lblUsername = new MaterialSkin.Controls.MaterialLabel();
            linkCambiarContraseña = new LinkLabel();
            lblApellido = new MaterialSkin.Controls.MaterialLabel();
            lblDomicilio = new MaterialSkin.Controls.MaterialLabel();
            lblTelefono = new MaterialSkin.Controls.MaterialLabel();
            lblNombre = new MaterialSkin.Controls.MaterialLabel();
            lblCuenta = new MaterialSkin.Controls.MaterialLabel();
            lblRolCuenta = new MaterialSkin.Controls.MaterialLabel();
            tpLogout = new TabPage();
            imageListCliente = new ImageList(components);
            imageList1 = new ImageList(components);
            tcCliente.SuspendLayout();
            tpHabitaciones.SuspendLayout();
            panel1.SuspendLayout();
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
            tcCliente.ImageList = imageListCliente;
            tcCliente.Location = new Point(10, 64);
            tcCliente.MouseState = MaterialSkin.MouseState.HOVER;
            tcCliente.Multiline = true;
            tcCliente.Name = "tcCliente";
            tcCliente.SelectedIndex = 0;
            tcCliente.Size = new Size(1028, 733);
            tcCliente.TabIndex = 0;
            // 
            // tpHabitaciones
            // 
            tpHabitaciones.Controls.Add(panel2);
            tpHabitaciones.Controls.Add(panel1);
            tpHabitaciones.ImageKey = "apartment.png";
            tpHabitaciones.Location = new Point(4, 39);
            tpHabitaciones.Name = "tpHabitaciones";
            tpHabitaciones.Padding = new Padding(3);
            tpHabitaciones.Size = new Size(1020, 690);
            tpHabitaciones.TabIndex = 5;
            tpHabitaciones.Text = "Habitaciones";
            tpHabitaciones.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(1014, 538);
            panel2.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(btnBuscarHabitaciones);
            panel1.Controls.Add(dtpFechaHasta);
            panel1.Controls.Add(dtpFechaDesde);
            panel1.Controls.Add(lblHabitaciones);
            panel1.Controls.Add(cmbFiltroHabitaciones);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 146);
            panel1.TabIndex = 13;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(350, 101);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(47, 19);
            materialLabel2.TabIndex = 16;
            materialLabel2.Text = "Hasta:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(57, 101);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(49, 19);
            materialLabel1.TabIndex = 15;
            materialLabel1.Text = "Desde:";
            // 
            // btnBuscarHabitaciones
            // 
            btnBuscarHabitaciones.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscarHabitaciones.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBuscarHabitaciones.Depth = 0;
            btnBuscarHabitaciones.HighEmphasis = true;
            btnBuscarHabitaciones.Icon = null;
            btnBuscarHabitaciones.Location = new Point(625, 94);
            btnBuscarHabitaciones.Margin = new Padding(4, 6, 4, 6);
            btnBuscarHabitaciones.MaximumSize = new Size(0, 30);
            btnBuscarHabitaciones.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscarHabitaciones.Name = "btnBuscarHabitaciones";
            btnBuscarHabitaciones.NoAccentTextColor = Color.Empty;
            btnBuscarHabitaciones.Size = new Size(79, 30);
            btnBuscarHabitaciones.TabIndex = 14;
            btnBuscarHabitaciones.Text = "FILTRAR";
            btnBuscarHabitaciones.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBuscarHabitaciones.UseAccentColor = false;
            btnBuscarHabitaciones.UseVisualStyleBackColor = true;
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Format = DateTimePickerFormat.Short;
            dtpFechaHasta.Location = new Point(403, 97);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(200, 23);
            dtpFechaHasta.TabIndex = 13;
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Format = DateTimePickerFormat.Short;
            dtpFechaDesde.Location = new Point(112, 97);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(200, 23);
            dtpFechaDesde.TabIndex = 12;
            // 
            // lblHabitaciones
            // 
            lblHabitaciones.AutoSize = true;
            lblHabitaciones.Depth = 0;
            lblHabitaciones.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblHabitaciones.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblHabitaciones.Location = new Point(57, 25);
            lblHabitaciones.MouseState = MaterialSkin.MouseState.HOVER;
            lblHabitaciones.Name = "lblHabitaciones";
            lblHabitaciones.Size = new Size(201, 41);
            lblHabitaciones.TabIndex = 11;
            lblHabitaciones.Text = "Habitaciones";
            lblHabitaciones.UseAccent = true;
            // 
            // cmbFiltroHabitaciones
            // 
            cmbFiltroHabitaciones.AutoCompleteCustomSource.AddRange(new string[] { "Busqueda" });
            cmbFiltroHabitaciones.AutoResize = false;
            cmbFiltroHabitaciones.BackColor = Color.FromArgb(255, 255, 255);
            cmbFiltroHabitaciones.Cursor = Cursors.Hand;
            cmbFiltroHabitaciones.Depth = 0;
            cmbFiltroHabitaciones.DrawMode = DrawMode.OwnerDrawVariable;
            cmbFiltroHabitaciones.DropDownHeight = 174;
            cmbFiltroHabitaciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroHabitaciones.DropDownWidth = 121;
            cmbFiltroHabitaciones.FlatStyle = FlatStyle.Popup;
            cmbFiltroHabitaciones.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbFiltroHabitaciones.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbFiltroHabitaciones.FormattingEnabled = true;
            cmbFiltroHabitaciones.ImeMode = ImeMode.On;
            cmbFiltroHabitaciones.IntegralHeight = false;
            cmbFiltroHabitaciones.ItemHeight = 43;
            cmbFiltroHabitaciones.Items.AddRange(new object[] { "Filtrar por categoría", "Economica", "Estándard", "Presidencial" });
            cmbFiltroHabitaciones.Location = new Point(738, 80);
            cmbFiltroHabitaciones.MaxDropDownItems = 4;
            cmbFiltroHabitaciones.MouseState = MaterialSkin.MouseState.OUT;
            cmbFiltroHabitaciones.Name = "cmbFiltroHabitaciones";
            cmbFiltroHabitaciones.Size = new Size(242, 49);
            cmbFiltroHabitaciones.StartIndex = 0;
            cmbFiltroHabitaciones.TabIndex = 10;
            // 
            // tpReservas
            // 
            tpReservas.Controls.Add(listReservas);
            tpReservas.Controls.Add(lblReservas);
            tpReservas.ImageKey = "book.png";
            tpReservas.Location = new Point(4, 39);
            tpReservas.Name = "tpReservas";
            tpReservas.Size = new Size(1020, 690);
            tpReservas.TabIndex = 3;
            tpReservas.Text = "Reservas";
            tpReservas.UseVisualStyleBackColor = true;
            // 
            // listReservas
            // 
            listReservas.Alignment = ListViewAlignment.SnapToGrid;
            listReservas.Anchor = AnchorStyles.None;
            listReservas.AutoSizeTable = false;
            listReservas.BackColor = Color.FromArgb(255, 255, 255);
            listReservas.BorderStyle = BorderStyle.None;
            listReservas.Depth = 0;
            listReservas.Font = new Font("Garamond", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listReservas.FullRowSelect = true;
            listReservas.HoverSelection = true;
            listReservas.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listReservas.Location = new Point(68, 62);
            listReservas.MinimumSize = new Size(200, 100);
            listReservas.MouseLocation = new Point(-1, -1);
            listReservas.MouseState = MaterialSkin.MouseState.OUT;
            listReservas.Name = "listReservas";
            listReservas.OwnerDraw = true;
            listReservas.Size = new Size(894, 386);
            listReservas.TabIndex = 1;
            listReservas.TileSize = new Size(3, 3);
            listReservas.UseCompatibleStateImageBehavior = false;
            listReservas.View = View.Details;
            // 
            // lblReservas
            // 
            lblReservas.AutoSize = true;
            lblReservas.Depth = 0;
            lblReservas.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblReservas.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblReservas.Location = new Point(56, 18);
            lblReservas.MouseState = MaterialSkin.MouseState.HOVER;
            lblReservas.Name = "lblReservas";
            lblReservas.Size = new Size(205, 41);
            lblReservas.TabIndex = 0;
            lblReservas.Text = "Mis Reservas";
            // 
            // tpCuenta
            // 
            tpCuenta.Controls.Add(materialCard6);
            tpCuenta.Controls.Add(lblCuenta);
            tpCuenta.Controls.Add(lblRolCuenta);
            tpCuenta.ImageKey = "account_circle.png";
            tpCuenta.Location = new Point(4, 39);
            tpCuenta.Name = "tpCuenta";
            tpCuenta.Padding = new Padding(3);
            tpCuenta.Size = new Size(1020, 690);
            tpCuenta.TabIndex = 1;
            tpCuenta.Text = "Mi Cuenta";
            tpCuenta.UseVisualStyleBackColor = true;
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Controls.Add(txtPassword);
            materialCard6.Controls.Add(txtUsername);
            materialCard6.Controls.Add(txtDomicilio);
            materialCard6.Controls.Add(txtTelefono);
            materialCard6.Controls.Add(txtApellido);
            materialCard6.Controls.Add(txtNombre);
            materialCard6.Controls.Add(lblContraseña);
            materialCard6.Controls.Add(lblUsername);
            materialCard6.Controls.Add(linkCambiarContraseña);
            materialCard6.Controls.Add(lblApellido);
            materialCard6.Controls.Add(lblDomicilio);
            materialCard6.Controls.Add(lblTelefono);
            materialCard6.Controls.Add(lblNombre);
            materialCard6.Depth = 0;
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(220, 99);
            materialCard6.Margin = new Padding(14);
            materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(14);
            materialCard6.Size = new Size(640, 361);
            materialCard6.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 12F);
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(397, 276);
            txtPassword.MaxLength = 50;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Password = true;
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(208, 50);
            txtPassword.TabIndex = 13;
            txtPassword.Text = "tomasbanchio16";
            txtPassword.TrailingIcon = null;
            // 
            // txtUsername
            // 
            txtUsername.AnimateReadOnly = false;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Depth = 0;
            txtUsername.Font = new Font("Roboto", 12F);
            txtUsername.LeadingIcon = null;
            txtUsername.Location = new Point(52, 276);
            txtUsername.MaxLength = 50;
            txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(208, 50);
            txtUsername.TabIndex = 12;
            txtUsername.Text = "tomiban";
            txtUsername.TrailingIcon = null;
            // 
            // txtDomicilio
            // 
            txtDomicilio.AnimateReadOnly = false;
            txtDomicilio.BorderStyle = BorderStyle.None;
            txtDomicilio.Depth = 0;
            txtDomicilio.Font = new Font("Roboto", 12F);
            txtDomicilio.LeadingIcon = null;
            txtDomicilio.Location = new Point(395, 167);
            txtDomicilio.MaxLength = 50;
            txtDomicilio.MouseState = MaterialSkin.MouseState.OUT;
            txtDomicilio.Multiline = false;
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.ReadOnly = true;
            txtDomicilio.Size = new Size(208, 50);
            txtDomicilio.TabIndex = 11;
            txtDomicilio.Text = "Gabarret 1824";
            txtDomicilio.TrailingIcon = null;
            // 
            // txtTelefono
            // 
            txtTelefono.AnimateReadOnly = false;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Depth = 0;
            txtTelefono.Font = new Font("Roboto", 12F);
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(52, 167);
            txtTelefono.MaxLength = 50;
            txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefono.Multiline = false;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(208, 50);
            txtTelefono.TabIndex = 10;
            txtTelefono.Text = "3496547076";
            txtTelefono.TrailingIcon = null;
            // 
            // txtApellido
            // 
            txtApellido.AnimateReadOnly = false;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Depth = 0;
            txtApellido.Font = new Font("Roboto", 12F);
            txtApellido.LeadingIcon = null;
            txtApellido.Location = new Point(395, 65);
            txtApellido.MaxLength = 50;
            txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            txtApellido.Multiline = false;
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(208, 50);
            txtApellido.TabIndex = 9;
            txtApellido.Text = "Banchio";
            txtApellido.TrailingIcon = null;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Roboto", 12F);
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(52, 66);
            txtNombre.MaxLength = 50;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(208, 50);
            txtNombre.TabIndex = 8;
            txtNombre.Text = "Tomás";
            txtNombre.TrailingIcon = null;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Depth = 0;
            lblContraseña.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblContraseña.Location = new Point(397, 258);
            lblContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(71, 19);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Depth = 0;
            lblUsername.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUsername.Location = new Point(52, 253);
            lblUsername.MouseState = MaterialSkin.MouseState.HOVER;
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(72, 19);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // linkCambiarContraseña
            // 
            linkCambiarContraseña.AutoSize = true;
            linkCambiarContraseña.Location = new Point(544, 259);
            linkCambiarContraseña.Name = "linkCambiarContraseña";
            linkCambiarContraseña.Size = new Size(58, 15);
            linkCambiarContraseña.TabIndex = 7;
            linkCambiarContraseña.TabStop = true;
            linkCambiarContraseña.Text = "Modificar";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Depth = 0;
            lblApellido.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblApellido.Location = new Point(396, 44);
            lblApellido.MouseState = MaterialSkin.MouseState.HOVER;
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(58, 19);
            lblApellido.TabIndex = 0;
            lblApellido.Text = "Apellido";
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Depth = 0;
            lblDomicilio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDomicilio.Location = new Point(396, 145);
            lblDomicilio.MouseState = MaterialSkin.MouseState.HOVER;
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(68, 19);
            lblDomicilio.TabIndex = 5;
            lblDomicilio.Text = "Domicilio";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Depth = 0;
            lblTelefono.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTelefono.Location = new Point(52, 145);
            lblTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(64, 19);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Depth = 0;
            lblNombre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNombre.Location = new Point(52, 44);
            lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 19);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Depth = 0;
            lblCuenta.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCuenta.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblCuenta.Location = new Point(56, 18);
            lblCuenta.MouseState = MaterialSkin.MouseState.HOVER;
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(155, 41);
            lblCuenta.TabIndex = 8;
            lblCuenta.Text = "Mi Cuenta";
            // 
            // lblRolCuenta
            // 
            lblRolCuenta.AutoSize = true;
            lblRolCuenta.Depth = 0;
            lblRolCuenta.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblRolCuenta.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblRolCuenta.Location = new Point(503, 56);
            lblRolCuenta.MouseState = MaterialSkin.MouseState.HOVER;
            lblRolCuenta.Name = "lblRolCuenta";
            lblRolCuenta.Size = new Size(76, 29);
            lblRolCuenta.TabIndex = 6;
            lblRolCuenta.Text = "Cliente";
            // 
            // tpLogout
            // 
            tpLogout.ImageKey = "logout.png";
            tpLogout.Location = new Point(4, 39);
            tpLogout.Name = "tpLogout";
            tpLogout.Size = new Size(1020, 690);
            tpLogout.TabIndex = 4;
            tpLogout.Text = "Salir";
            tpLogout.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(1048, 800);
            Controls.Add(tcCliente);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tcCliente;
            Name = "GuestView";
            Padding = new Padding(10, 64, 10, 3);
            Text = "El Molino Hotel";
            tcCliente.ResumeLayout(false);
            tpHabitaciones.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private MaterialSkin.Controls.MaterialComboBox cmbFiltroHabitaciones;
        private MaterialSkin.Controls.MaterialLabel lblHabitaciones;
        private MaterialSkin.Controls.MaterialListView listReservas;
        private MaterialSkin.Controls.MaterialLabel lblReservas;
        private LinkLabel linkCambiarContraseña;
        private MaterialSkin.Controls.MaterialLabel lblRolCuenta;
        private MaterialSkin.Controls.MaterialLabel lblDomicilio;
        private MaterialSkin.Controls.MaterialLabel lblTelefono;
        private MaterialSkin.Controls.MaterialLabel lblUsername;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblContraseña;
        private MaterialSkin.Controls.MaterialLabel lblApellido;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialLabel lblCuenta;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialTextBox txtDomicilio;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox txtApellido;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private Panel panel1;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton btnBuscarHabitaciones;
        private DateTimePicker dtpFechaHasta;
        private DateTimePicker dtpFechaDesde;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Panel panel2;
    }
}