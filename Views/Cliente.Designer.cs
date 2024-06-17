namespace GestionHotelWinForms.Views
{
    partial class clienteDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clienteDashboard));
            tabControlCliente = new MaterialSkin.Controls.MaterialTabControl();
            tpDashboard = new TabPage();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialButton5 = new MaterialSkin.Controls.MaterialButton();
            materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            lblHabitaciones = new MaterialSkin.Controls.MaterialLabel();
            cmbFiltroHabitaciones = new MaterialSkin.Controls.MaterialComboBox();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            cardHabitacion = new MaterialSkin.Controls.MaterialCard();
            btnReserva = new MaterialSkin.Controls.MaterialButton();
            lblPrecioHabitacion = new MaterialSkin.Controls.MaterialLabel();
            lblHabitacion = new MaterialSkin.Controls.MaterialLabel();
            tpReservas = new TabPage();
            listReservas = new MaterialSkin.Controls.MaterialListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
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
            imageList = new ImageList(components);
            tabControlCliente.SuspendLayout();
            tpDashboard.SuspendLayout();
            materialCard1.SuspendLayout();
            materialCard5.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard2.SuspendLayout();
            cardHabitacion.SuspendLayout();
            tpReservas.SuspendLayout();
            tpCuenta.SuspendLayout();
            materialCard6.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCliente
            // 
            tabControlCliente.Controls.Add(tpDashboard);
            tabControlCliente.Controls.Add(tpReservas);
            tabControlCliente.Controls.Add(tpCuenta);
            tabControlCliente.Controls.Add(tpLogout);
            tabControlCliente.Depth = 0;
            tabControlCliente.Dock = DockStyle.Fill;
            tabControlCliente.ImageList = imageList;
            tabControlCliente.Location = new Point(10, 64);
            tabControlCliente.MouseState = MaterialSkin.MouseState.HOVER;
            tabControlCliente.Multiline = true;
            tabControlCliente.Name = "tabControlCliente";
            tabControlCliente.SelectedIndex = 0;
            tabControlCliente.Size = new Size(1028, 486);
            tabControlCliente.TabIndex = 0;
            // 
            // tpDashboard
            // 
            tpDashboard.Controls.Add(materialCard1);
            tpDashboard.Controls.Add(lblHabitaciones);
            tpDashboard.Controls.Add(cmbFiltroHabitaciones);
            tpDashboard.Controls.Add(materialCard5);
            tpDashboard.Controls.Add(materialCard3);
            tpDashboard.Controls.Add(materialCard2);
            tpDashboard.Controls.Add(cardHabitacion);
            tpDashboard.ImageKey = "apartment.png";
            tpDashboard.Location = new Point(4, 39);
            tpDashboard.Name = "tpDashboard";
            tpDashboard.Padding = new Padding(3);
            tpDashboard.Size = new Size(1020, 443);
            tpDashboard.TabIndex = 5;
            tpDashboard.Text = "Habitaciones";
            tpDashboard.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialButton5);
            materialCard1.Controls.Add(materialLabel18);
            materialCard1.Controls.Add(materialLabel19);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(800, 96);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(158, 110);
            materialCard1.TabIndex = 12;
            // 
            // materialButton5
            // 
            materialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton5.Cursor = Cursors.Hand;
            materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton5.Depth = 0;
            materialButton5.HighEmphasis = true;
            materialButton5.Icon = null;
            materialButton5.Location = new Point(35, 77);
            materialButton5.Margin = new Padding(4, 6, 4, 6);
            materialButton5.MaximumSize = new Size(80, 20);
            materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton5.Name = "materialButton5";
            materialButton5.NoAccentTextColor = Color.Empty;
            materialButton5.Size = new Size(80, 20);
            materialButton5.TabIndex = 7;
            materialButton5.Text = "Reserva";
            materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton5.UseAccentColor = false;
            materialButton5.UseVisualStyleBackColor = true;
            // 
            // materialLabel18
            // 
            materialLabel18.AutoSize = true;
            materialLabel18.Depth = 0;
            materialLabel18.Enabled = false;
            materialLabel18.FlatStyle = FlatStyle.Popup;
            materialLabel18.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel18.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel18.Location = new Point(14, 45);
            materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel18.Name = "materialLabel18";
            materialLabel18.Size = new Size(90, 17);
            materialLabel18.TabIndex = 1;
            materialLabel18.Text = "$150.000 ARS";
            materialLabel18.UseAccent = true;
            materialLabel18.UseCompatibleTextRendering = true;
            // 
            // materialLabel19
            // 
            materialLabel19.AutoSize = true;
            materialLabel19.Depth = 0;
            materialLabel19.Dock = DockStyle.Fill;
            materialLabel19.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel19.Location = new Point(14, 14);
            materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel19.Name = "materialLabel19";
            materialLabel19.Size = new Size(91, 19);
            materialLabel19.TabIndex = 0;
            materialLabel19.Text = "Habitación 4";
            // 
            // lblHabitaciones
            // 
            lblHabitaciones.AutoSize = true;
            lblHabitaciones.Depth = 0;
            lblHabitaciones.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblHabitaciones.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblHabitaciones.Location = new Point(56, 18);
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
            cmbFiltroHabitaciones.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbFiltroHabitaciones.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbFiltroHabitaciones.FormattingEnabled = true;
            cmbFiltroHabitaciones.IntegralHeight = false;
            cmbFiltroHabitaciones.ItemHeight = 43;
            cmbFiltroHabitaciones.Items.AddRange(new object[] { "Filtrar por categoría", "Economica", "Estándard", "Presidencial" });
            cmbFiltroHabitaciones.Location = new Point(614, 18);
            cmbFiltroHabitaciones.MaxDropDownItems = 4;
            cmbFiltroHabitaciones.MouseState = MaterialSkin.MouseState.OUT;
            cmbFiltroHabitaciones.Name = "cmbFiltroHabitaciones";
            cmbFiltroHabitaciones.Size = new Size(344, 49);
            cmbFiltroHabitaciones.StartIndex = 0;
            cmbFiltroHabitaciones.TabIndex = 10;
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(materialButton4);
            materialCard5.Controls.Add(materialLabel6);
            materialCard5.Controls.Add(materialLabel7);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(614, 96);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(158, 110);
            materialCard5.TabIndex = 9;
            // 
            // materialButton4
            // 
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Cursor = Cursors.Hand;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(35, 77);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MaximumSize = new Size(80, 20);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(80, 20);
            materialButton4.TabIndex = 7;
            materialButton4.Text = "Reserva";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Enabled = false;
            materialLabel6.FlatStyle = FlatStyle.Popup;
            materialLabel6.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel6.Location = new Point(14, 45);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(90, 17);
            materialLabel6.TabIndex = 1;
            materialLabel6.Text = "$150.000 ARS";
            materialLabel6.UseAccent = true;
            materialLabel6.UseCompatibleTextRendering = true;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Dock = DockStyle.Fill;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(14, 14);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(91, 19);
            materialLabel7.TabIndex = 0;
            materialLabel7.Text = "Habitación 4";
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(materialButton3);
            materialCard3.Controls.Add(materialLabel4);
            materialCard3.Controls.Add(materialLabel5);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(428, 96);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(158, 110);
            materialCard3.TabIndex = 8;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Cursor = Cursors.Hand;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(35, 77);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MaximumSize = new Size(80, 20);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(80, 20);
            materialButton3.TabIndex = 7;
            materialButton3.Text = "Reserva";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Enabled = false;
            materialLabel4.FlatStyle = FlatStyle.Popup;
            materialLabel4.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel4.Location = new Point(14, 45);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(90, 17);
            materialLabel4.TabIndex = 1;
            materialLabel4.Text = "$150.000 ARS";
            materialLabel4.UseAccent = true;
            materialLabel4.UseCompatibleTextRendering = true;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Dock = DockStyle.Fill;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(14, 14);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(91, 19);
            materialLabel5.TabIndex = 0;
            materialLabel5.Text = "Habitación 3";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(materialButton2);
            materialCard2.Controls.Add(materialLabel2);
            materialCard2.Controls.Add(materialLabel3);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(242, 96);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(158, 110);
            materialCard2.TabIndex = 6;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Cursor = Cursors.Hand;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(35, 77);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MaximumSize = new Size(80, 20);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(80, 20);
            materialButton2.TabIndex = 7;
            materialButton2.Text = "Reserva";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Enabled = false;
            materialLabel2.FlatStyle = FlatStyle.Popup;
            materialLabel2.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel2.Location = new Point(14, 45);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(90, 17);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "$150.000 ARS";
            materialLabel2.UseAccent = true;
            materialLabel2.UseCompatibleTextRendering = true;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Dock = DockStyle.Fill;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(14, 14);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(91, 19);
            materialLabel3.TabIndex = 0;
            materialLabel3.Text = "Habitación 2";
            // 
            // cardHabitacion
            // 
            cardHabitacion.BackColor = Color.FromArgb(255, 255, 255);
            cardHabitacion.Controls.Add(btnReserva);
            cardHabitacion.Controls.Add(lblPrecioHabitacion);
            cardHabitacion.Controls.Add(lblHabitacion);
            cardHabitacion.Depth = 0;
            cardHabitacion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardHabitacion.Location = new Point(56, 96);
            cardHabitacion.Margin = new Padding(14);
            cardHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            cardHabitacion.Name = "cardHabitacion";
            cardHabitacion.Padding = new Padding(14);
            cardHabitacion.Size = new Size(158, 110);
            cardHabitacion.TabIndex = 5;
            // 
            // btnReserva
            // 
            btnReserva.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReserva.Cursor = Cursors.Hand;
            btnReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReserva.Depth = 0;
            btnReserva.HighEmphasis = true;
            btnReserva.Icon = null;
            btnReserva.Location = new Point(35, 77);
            btnReserva.Margin = new Padding(4, 6, 4, 6);
            btnReserva.MaximumSize = new Size(80, 20);
            btnReserva.MouseState = MaterialSkin.MouseState.HOVER;
            btnReserva.Name = "btnReserva";
            btnReserva.NoAccentTextColor = Color.Empty;
            btnReserva.Size = new Size(80, 20);
            btnReserva.TabIndex = 7;
            btnReserva.Text = "Reserva";
            btnReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReserva.UseAccentColor = false;
            btnReserva.UseVisualStyleBackColor = true;
            // 
            // lblPrecioHabitacion
            // 
            lblPrecioHabitacion.AutoSize = true;
            lblPrecioHabitacion.Depth = 0;
            lblPrecioHabitacion.Enabled = false;
            lblPrecioHabitacion.FlatStyle = FlatStyle.Popup;
            lblPrecioHabitacion.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblPrecioHabitacion.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            lblPrecioHabitacion.Location = new Point(14, 45);
            lblPrecioHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            lblPrecioHabitacion.Name = "lblPrecioHabitacion";
            lblPrecioHabitacion.Size = new Size(90, 17);
            lblPrecioHabitacion.TabIndex = 1;
            lblPrecioHabitacion.Text = "$150.000 ARS";
            lblPrecioHabitacion.UseAccent = true;
            lblPrecioHabitacion.UseCompatibleTextRendering = true;
            // 
            // lblHabitacion
            // 
            lblHabitacion.AutoSize = true;
            lblHabitacion.Depth = 0;
            lblHabitacion.Dock = DockStyle.Fill;
            lblHabitacion.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblHabitacion.Location = new Point(14, 14);
            lblHabitacion.MouseState = MaterialSkin.MouseState.HOVER;
            lblHabitacion.Name = "lblHabitacion";
            lblHabitacion.Size = new Size(91, 19);
            lblHabitacion.TabIndex = 0;
            lblHabitacion.Text = "Habitación 1";
            // 
            // tpReservas
            // 
            tpReservas.Controls.Add(listReservas);
            tpReservas.Controls.Add(lblReservas);
            tpReservas.ImageKey = "book.png";
            tpReservas.Location = new Point(4, 39);
            tpReservas.Name = "tpReservas";
            tpReservas.Size = new Size(1020, 443);
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
            listReservas.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader5, columnHeader3, columnHeader4 });
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
            // columnHeader1
            // 
            columnHeader1.Text = "       Id";
            columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "              Habitacion";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "              Categoría";
            columnHeader5.TextAlign = HorizontalAlignment.Right;
            columnHeader5.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "                  Check in";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "                Check out";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 200;
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
            tpCuenta.Size = new Size(1020, 443);
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
            materialCard6.Paint += materialCard6_Paint;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F);
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
            txtUsername.Font = new Font("Microsoft Sans Serif", 12F);
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
            txtDomicilio.Font = new Font("Microsoft Sans Serif", 12F);
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
            txtTelefono.Font = new Font("Microsoft Sans Serif", 12F);
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
            txtApellido.Font = new Font("Microsoft Sans Serif", 12F);
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
            txtNombre.Font = new Font("Microsoft Sans Serif", 12F);
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
            tpLogout.Size = new Size(1020, 443);
            tpLogout.TabIndex = 4;
            tpLogout.Text = "Salir";
            tpLogout.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "bed.png");
            imageList.Images.SetKeyName(1, "logout.png");
            imageList.Images.SetKeyName(2, "person_search.png");
            imageList.Images.SetKeyName(3, "bookmark_check.png");
            imageList.Images.SetKeyName(4, "account_circle.png");
            imageList.Images.SetKeyName(5, "apartment.png");
            imageList.Images.SetKeyName(6, "book.png");
            imageList.Images.SetKeyName(7, "add.png");
            imageList.Images.SetKeyName(8, "bookmark_check.png");
            // 
            // clienteDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 553);
            Controls.Add(tabControlCliente);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tabControlCliente;
            Name = "clienteDashboard";
            Padding = new Padding(10, 64, 10, 3);
            Text = "El Molino Hotel";
            tabControlCliente.ResumeLayout(false);
            tpDashboard.ResumeLayout(false);
            tpDashboard.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            cardHabitacion.ResumeLayout(false);
            cardHabitacion.PerformLayout();
            tpReservas.ResumeLayout(false);
            tpReservas.PerformLayout();
            tpCuenta.ResumeLayout(false);
            tpCuenta.PerformLayout();
            materialCard6.ResumeLayout(false);
            materialCard6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControlCliente;
        private TabPage tpCuenta;
        private ImageList imageList;
        private TabPage tpReservas;
        private TabPage tpLogout;
        private TabPage tpDashboard;
        private MaterialSkin.Controls.MaterialCard cardHabitacion;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel lblHabitacion;
        private MaterialSkin.Controls.MaterialLabel lblPrecioHabitacion;
        private MaterialSkin.Controls.MaterialButton btnReserva;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
        private MaterialSkin.Controls.MaterialComboBox cmbFiltroHabitaciones;
        private MaterialSkin.Controls.MaterialLabel lblHabitaciones;
        private MaterialSkin.Controls.MaterialListView listReservas;
        private MaterialSkin.Controls.MaterialLabel lblReservas;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
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
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
    }
}