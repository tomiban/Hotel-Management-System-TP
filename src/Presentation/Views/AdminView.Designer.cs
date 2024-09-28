namespace Presentation.Views
{
    partial class AdminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminView));
            tcAdmin = new MaterialSkin.Controls.MaterialTabControl();
            tpDashboard = new TabPage();
            lblReservas = new MaterialSkin.Controls.MaterialLabel();
            cardFactura = new MaterialSkin.Controls.MaterialCard();
            captionLblFactura = new MaterialSkin.Controls.MaterialLabel();
            lblTotalFacturado = new MaterialSkin.Controls.MaterialLabel();
            lblFactura = new MaterialSkin.Controls.MaterialLabel();
            cardUsuarios = new MaterialSkin.Controls.MaterialCard();
            imgUsuarios = new PictureBox();
            captionLblUsuarios = new MaterialSkin.Controls.MaterialLabel();
            lblTotalUsuarios = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            listReservasActivas = new MaterialSkin.Controls.MaterialListView();
            columnId = new ColumnHeader();
            columnHabitacion = new ColumnHeader();
            columnCategoria = new ColumnHeader();
            columnCapacidad = new ColumnHeader();
            columnCliente = new ColumnHeader();
            columnCheckin = new ColumnHeader();
            columnCheckout = new ColumnHeader();
            cardReservas = new MaterialSkin.Controls.MaterialCard();
            captionLblOcupacion = new Label();
            imgReservas = new PictureBox();
            lblTotalReservas = new MaterialSkin.Controls.MaterialLabel();
            progressBarOcupacion = new MaterialSkin.Controls.MaterialProgressBar();
            lblHabitacionesActivas = new MaterialSkin.Controls.MaterialLabel();
            lblDashboard = new MaterialSkin.Controls.MaterialLabel();
            tpHabitaciones = new TabPage();
            btnEditarHab = new MaterialSkin.Controls.MaterialButton();
            btnBorrarHab = new MaterialSkin.Controls.MaterialButton();
            btnAgregarHab = new MaterialSkin.Controls.MaterialButton();
            listHabitaciones = new MaterialSkin.Controls.MaterialListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            lblHabitaciones = new MaterialSkin.Controls.MaterialLabel();
            tpUsuarios = new TabPage();
            btnEditarUsu = new MaterialSkin.Controls.MaterialButton();
            btnBorrarUsu = new MaterialSkin.Controls.MaterialButton();
            btnAgregarUsu = new MaterialSkin.Controls.MaterialButton();
            listUsuarios = new MaterialSkin.Controls.MaterialListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            lblUsuarios = new MaterialSkin.Controls.MaterialLabel();
            tpFacturacion = new TabPage();
            listFacturas = new MaterialSkin.Controls.MaterialListView();
            lblFacturacion = new MaterialSkin.Controls.MaterialLabel();
            tpLogout = new TabPage();
            imageListAdmin = new ImageList(components);
            imageListDash = new ImageList(components);
            tcAdmin.SuspendLayout();
            tpDashboard.SuspendLayout();
            cardFactura.SuspendLayout();
            cardUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUsuarios).BeginInit();
            cardReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgReservas).BeginInit();
            tpHabitaciones.SuspendLayout();
            tpUsuarios.SuspendLayout();
            tpFacturacion.SuspendLayout();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpDashboard);
            tcAdmin.Controls.Add(tpHabitaciones);
            tcAdmin.Controls.Add(tpUsuarios);
            tcAdmin.Controls.Add(tpFacturacion);
            tcAdmin.Controls.Add(tpLogout);
            tcAdmin.Depth = 0;
            tcAdmin.Dock = DockStyle.Fill;
            tcAdmin.ImageList = imageListAdmin;
            tcAdmin.ItemSize = new Size(119, 35);
            tcAdmin.Location = new Point(10, 64);
            tcAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            tcAdmin.Multiline = true;
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(1028, 486);
            tcAdmin.TabIndex = 0;
            // 
            // tpDashboard
            // 
            tpDashboard.Controls.Add(lblReservas);
            tpDashboard.Controls.Add(cardFactura);
            tpDashboard.Controls.Add(cardUsuarios);
            tpDashboard.Controls.Add(listReservasActivas);
            tpDashboard.Controls.Add(cardReservas);
            tpDashboard.Controls.Add(lblDashboard);
            tpDashboard.ImageKey = "dashboard.png";
            tpDashboard.Location = new Point(4, 39);
            tpDashboard.Name = "tpDashboard";
            tpDashboard.Padding = new Padding(3);
            tpDashboard.Size = new Size(1020, 443);
            tpDashboard.TabIndex = 0;
            tpDashboard.Text = "Dashboard";
            tpDashboard.UseVisualStyleBackColor = true;
            // 
            // lblReservas
            // 
            lblReservas.AutoSize = true;
            lblReservas.Depth = 0;
            lblReservas.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblReservas.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblReservas.Location = new Point(56, 224);
            lblReservas.MouseState = MaterialSkin.MouseState.HOVER;
            lblReservas.Name = "lblReservas";
            lblReservas.Size = new Size(154, 24);
            lblReservas.TabIndex = 22;
            lblReservas.Text = "Reservas Activas";
            // 
            // cardFactura
            // 
            cardFactura.BackColor = Color.FromArgb(255, 255, 255);
            cardFactura.Controls.Add(captionLblFactura);
            cardFactura.Controls.Add(lblTotalFacturado);
            cardFactura.Controls.Add(lblFactura);
            cardFactura.Depth = 0;
            cardFactura.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardFactura.Location = new Point(632, 73);
            cardFactura.Margin = new Padding(14);
            cardFactura.MouseState = MaterialSkin.MouseState.HOVER;
            cardFactura.Name = "cardFactura";
            cardFactura.Padding = new Padding(14);
            cardFactura.Size = new Size(285, 125);
            cardFactura.TabIndex = 21;
            // 
            // captionLblFactura
            // 
            captionLblFactura.AutoSize = true;
            captionLblFactura.Depth = 0;
            captionLblFactura.Dock = DockStyle.Bottom;
            captionLblFactura.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            captionLblFactura.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            captionLblFactura.Location = new Point(14, 97);
            captionLblFactura.MouseState = MaterialSkin.MouseState.HOVER;
            captionLblFactura.Name = "captionLblFactura";
            captionLblFactura.Size = new Size(51, 14);
            captionLblFactura.TabIndex = 2;
            captionLblFactura.Text = "En el año";
            // 
            // lblTotalFacturado
            // 
            lblTotalFacturado.AutoSize = true;
            lblTotalFacturado.Depth = 0;
            lblTotalFacturado.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTotalFacturado.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            lblTotalFacturado.Location = new Point(27, 33);
            lblTotalFacturado.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotalFacturado.Name = "lblTotalFacturado";
            lblTotalFacturado.Size = new Size(176, 58);
            lblTotalFacturado.TabIndex = 1;
            lblTotalFacturado.Text = "312.420";
            // 
            // lblFactura
            // 
            lblFactura.AutoSize = true;
            lblFactura.Depth = 0;
            lblFactura.Dock = DockStyle.Top;
            lblFactura.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblFactura.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            lblFactura.Location = new Point(14, 14);
            lblFactura.MouseState = MaterialSkin.MouseState.HOVER;
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(96, 17);
            lblFactura.TabIndex = 0;
            lblFactura.Text = "FACTURACIÓN";
            // 
            // cardUsuarios
            // 
            cardUsuarios.BackColor = Color.FromArgb(255, 255, 255);
            cardUsuarios.Controls.Add(imgUsuarios);
            cardUsuarios.Controls.Add(captionLblUsuarios);
            cardUsuarios.Controls.Add(lblTotalUsuarios);
            cardUsuarios.Controls.Add(materialLabel5);
            cardUsuarios.Depth = 0;
            cardUsuarios.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardUsuarios.Location = new Point(346, 73);
            cardUsuarios.Margin = new Padding(14);
            cardUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            cardUsuarios.Name = "cardUsuarios";
            cardUsuarios.Padding = new Padding(14);
            cardUsuarios.Size = new Size(258, 125);
            cardUsuarios.TabIndex = 20;
            // 
            // imgUsuarios
            // 
            imgUsuarios.Image = (Image)resources.GetObject("imgUsuarios.Image");
            imgUsuarios.Location = new Point(142, 14);
            imgUsuarios.Name = "imgUsuarios";
            imgUsuarios.Size = new Size(84, 94);
            imgUsuarios.SizeMode = PictureBoxSizeMode.StretchImage;
            imgUsuarios.TabIndex = 3;
            imgUsuarios.TabStop = false;
            // 
            // captionLblUsuarios
            // 
            captionLblUsuarios.AutoSize = true;
            captionLblUsuarios.Depth = 0;
            captionLblUsuarios.Dock = DockStyle.Bottom;
            captionLblUsuarios.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            captionLblUsuarios.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            captionLblUsuarios.Location = new Point(14, 97);
            captionLblUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            captionLblUsuarios.Name = "captionLblUsuarios";
            captionLblUsuarios.Size = new Size(103, 14);
            captionLblUsuarios.TabIndex = 2;
            captionLblUsuarios.Text = "3 Nuevos Usuarios";
            // 
            // lblTotalUsuarios
            // 
            lblTotalUsuarios.AutoSize = true;
            lblTotalUsuarios.Depth = 0;
            lblTotalUsuarios.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTotalUsuarios.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            lblTotalUsuarios.Location = new Point(31, 33);
            lblTotalUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotalUsuarios.Name = "lblTotalUsuarios";
            lblTotalUsuarios.Size = new Size(55, 58);
            lblTotalUsuarios.TabIndex = 1;
            lblTotalUsuarios.Text = "14";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Dock = DockStyle.Top;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel5.Location = new Point(14, 14);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(131, 17);
            materialLabel5.TabIndex = 0;
            materialLabel5.Text = "USUARIOS TOTALES";
            // 
            // listReservasActivas
            // 
            listReservasActivas.AutoSizeTable = false;
            listReservasActivas.BackColor = Color.FromArgb(255, 255, 255);
            listReservasActivas.BorderStyle = BorderStyle.None;
            listReservasActivas.Columns.AddRange(new ColumnHeader[] { columnId, columnHabitacion, columnCategoria, columnCapacidad, columnCliente, columnCheckin, columnCheckout });
            listReservasActivas.Depth = 0;
            listReservasActivas.FullRowSelect = true;
            listReservasActivas.Location = new Point(56, 266);
            listReservasActivas.MinimumSize = new Size(200, 100);
            listReservasActivas.MouseLocation = new Point(-1, -1);
            listReservasActivas.MouseState = MaterialSkin.MouseState.OUT;
            listReservasActivas.Name = "listReservasActivas";
            listReservasActivas.OwnerDraw = true;
            listReservasActivas.Size = new Size(861, 197);
            listReservasActivas.TabIndex = 18;
            listReservasActivas.UseCompatibleStateImageBehavior = false;
            listReservasActivas.View = View.Details;
            // 
            // columnId
            // 
            columnId.Text = "Id";
            columnId.Width = 62;
            // 
            // columnHabitacion
            // 
            columnHabitacion.Text = "Habitación";
            columnHabitacion.Width = 130;
            // 
            // columnCategoria
            // 
            columnCategoria.Text = "Categoría";
            columnCategoria.Width = 140;
            // 
            // columnCapacidad
            // 
            columnCapacidad.Text = "Capacidad";
            columnCapacidad.Width = 130;
            // 
            // columnCliente
            // 
            columnCliente.Text = "Cliente";
            columnCliente.Width = 140;
            // 
            // columnCheckin
            // 
            columnCheckin.Text = "Check In";
            columnCheckin.Width = 130;
            // 
            // columnCheckout
            // 
            columnCheckout.Text = "Check Out";
            columnCheckout.Width = 130;
            // 
            // cardReservas
            // 
            cardReservas.BackColor = Color.FromArgb(255, 255, 255);
            cardReservas.Controls.Add(captionLblOcupacion);
            cardReservas.Controls.Add(imgReservas);
            cardReservas.Controls.Add(lblTotalReservas);
            cardReservas.Controls.Add(progressBarOcupacion);
            cardReservas.Controls.Add(lblHabitacionesActivas);
            cardReservas.Depth = 0;
            cardReservas.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardReservas.Location = new Point(56, 73);
            cardReservas.Margin = new Padding(14);
            cardReservas.MouseState = MaterialSkin.MouseState.HOVER;
            cardReservas.Name = "cardReservas";
            cardReservas.Padding = new Padding(14);
            cardReservas.Size = new Size(262, 125);
            cardReservas.TabIndex = 15;
            // 
            // captionLblOcupacion
            // 
            captionLblOcupacion.AutoSize = true;
            captionLblOcupacion.Dock = DockStyle.Bottom;
            captionLblOcupacion.Location = new Point(14, 91);
            captionLblOcupacion.Name = "captionLblOcupacion";
            captionLblOcupacion.Size = new Size(90, 15);
            captionLblOcupacion.TabIndex = 20;
            captionLblOcupacion.Text = "50% Ocupación";
            // 
            // imgReservas
            // 
            imgReservas.Image = (Image)resources.GetObject("imgReservas.Image");
            imgReservas.Location = new Point(148, 17);
            imgReservas.Name = "imgReservas";
            imgReservas.Size = new Size(82, 83);
            imgReservas.SizeMode = PictureBoxSizeMode.StretchImage;
            imgReservas.TabIndex = 3;
            imgReservas.TabStop = false;
            // 
            // lblTotalReservas
            // 
            lblTotalReservas.AutoSize = true;
            lblTotalReservas.Depth = 0;
            lblTotalReservas.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTotalReservas.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            lblTotalReservas.Location = new Point(31, 33);
            lblTotalReservas.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotalReservas.Name = "lblTotalReservas";
            lblTotalReservas.Size = new Size(55, 58);
            lblTotalReservas.TabIndex = 1;
            lblTotalReservas.Text = "10";
            // 
            // progressBarOcupacion
            // 
            progressBarOcupacion.Depth = 0;
            progressBarOcupacion.Dock = DockStyle.Bottom;
            progressBarOcupacion.Location = new Point(14, 106);
            progressBarOcupacion.MouseState = MaterialSkin.MouseState.HOVER;
            progressBarOcupacion.Name = "progressBarOcupacion";
            progressBarOcupacion.Size = new Size(234, 5);
            progressBarOcupacion.Step = 1;
            progressBarOcupacion.TabIndex = 19;
            progressBarOcupacion.Value = 50;
            // 
            // lblHabitacionesActivas
            // 
            lblHabitacionesActivas.AutoSize = true;
            lblHabitacionesActivas.Depth = 0;
            lblHabitacionesActivas.Dock = DockStyle.Top;
            lblHabitacionesActivas.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblHabitacionesActivas.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            lblHabitacionesActivas.Location = new Point(14, 14);
            lblHabitacionesActivas.MouseState = MaterialSkin.MouseState.HOVER;
            lblHabitacionesActivas.Name = "lblHabitacionesActivas";
            lblHabitacionesActivas.Size = new Size(69, 17);
            lblHabitacionesActivas.TabIndex = 0;
            lblHabitacionesActivas.Text = "RESERVAS";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Depth = 0;
            lblDashboard.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblDashboard.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblDashboard.Location = new Point(56, 18);
            lblDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(167, 41);
            lblDashboard.TabIndex = 14;
            lblDashboard.Text = "Dashboard";
            lblDashboard.UseAccent = true;
            // 
            // tpHabitaciones
            // 
            tpHabitaciones.Controls.Add(btnEditarHab);
            tpHabitaciones.Controls.Add(btnBorrarHab);
            tpHabitaciones.Controls.Add(btnAgregarHab);
            tpHabitaciones.Controls.Add(listHabitaciones);
            tpHabitaciones.Controls.Add(lblHabitaciones);
            tpHabitaciones.ImageKey = "bed.png";
            tpHabitaciones.Location = new Point(4, 39);
            tpHabitaciones.Name = "tpHabitaciones";
            tpHabitaciones.Padding = new Padding(3);
            tpHabitaciones.Size = new Size(1020, 443);
            tpHabitaciones.TabIndex = 1;
            tpHabitaciones.Text = "Habitaciones";
            tpHabitaciones.UseVisualStyleBackColor = true;
            // 
            // btnEditarHab
            // 
            btnEditarHab.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarHab.Cursor = Cursors.Hand;
            btnEditarHab.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarHab.Depth = 0;
            btnEditarHab.HighEmphasis = true;
            btnEditarHab.Icon = null;
            btnEditarHab.Location = new Point(154, 82);
            btnEditarHab.Margin = new Padding(4, 6, 4, 6);
            btnEditarHab.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditarHab.Name = "btnEditarHab";
            btnEditarHab.NoAccentTextColor = Color.Empty;
            btnEditarHab.Size = new Size(71, 36);
            btnEditarHab.TabIndex = 23;
            btnEditarHab.Text = "EDITAR";
            btnEditarHab.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnEditarHab.UseAccentColor = true;
            btnEditarHab.UseVisualStyleBackColor = true;
            // 
            // btnBorrarHab
            // 
            btnBorrarHab.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBorrarHab.Cursor = Cursors.Hand;
            btnBorrarHab.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBorrarHab.Depth = 0;
            btnBorrarHab.HighEmphasis = true;
            btnBorrarHab.Icon = null;
            btnBorrarHab.Location = new Point(873, 82);
            btnBorrarHab.Margin = new Padding(4, 6, 4, 6);
            btnBorrarHab.MouseState = MaterialSkin.MouseState.HOVER;
            btnBorrarHab.Name = "btnBorrarHab";
            btnBorrarHab.NoAccentTextColor = Color.Empty;
            btnBorrarHab.Size = new Size(88, 36);
            btnBorrarHab.TabIndex = 22;
            btnBorrarHab.Text = "Eliminar";
            btnBorrarHab.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnBorrarHab.UseAccentColor = false;
            btnBorrarHab.UseVisualStyleBackColor = true;
            // 
            // btnAgregarHab
            // 
            btnAgregarHab.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarHab.BackColor = Color.Black;
            btnAgregarHab.Cursor = Cursors.Hand;
            btnAgregarHab.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarHab.Depth = 0;
            btnAgregarHab.HighEmphasis = true;
            btnAgregarHab.Icon = null;
            btnAgregarHab.Location = new Point(56, 82);
            btnAgregarHab.Margin = new Padding(4, 6, 4, 6);
            btnAgregarHab.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarHab.Name = "btnAgregarHab";
            btnAgregarHab.NoAccentTextColor = Color.Empty;
            btnAgregarHab.Size = new Size(74, 36);
            btnAgregarHab.TabIndex = 21;
            btnAgregarHab.Text = "AÑADIR";
            btnAgregarHab.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnAgregarHab.UseAccentColor = true;
            btnAgregarHab.UseMnemonic = false;
            btnAgregarHab.UseVisualStyleBackColor = false;
            // 
            // listHabitaciones
            // 
            listHabitaciones.AutoSizeTable = false;
            listHabitaciones.BackColor = Color.FromArgb(255, 255, 255);
            listHabitaciones.BorderStyle = BorderStyle.None;
            listHabitaciones.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listHabitaciones.Cursor = Cursors.Hand;
            listHabitaciones.Depth = 0;
            listHabitaciones.FullRowSelect = true;
            listHabitaciones.Location = new Point(56, 127);
            listHabitaciones.MinimumSize = new Size(200, 100);
            listHabitaciones.MouseLocation = new Point(-1, -1);
            listHabitaciones.MouseState = MaterialSkin.MouseState.OUT;
            listHabitaciones.Name = "listHabitaciones";
            listHabitaciones.OwnerDraw = true;
            listHabitaciones.Size = new Size(905, 320);
            listHabitaciones.TabIndex = 17;
            listHabitaciones.UseCompatibleStateImageBehavior = false;
            listHabitaciones.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nro Habitacion";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 181;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tipo";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 216;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Disponibilidad";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 216;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Precio";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 200;
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
            lblHabitaciones.TabIndex = 16;
            lblHabitaciones.Text = "Habitaciones";
            lblHabitaciones.UseAccent = true;
            // 
            // tpUsuarios
            // 
            tpUsuarios.Controls.Add(btnEditarUsu);
            tpUsuarios.Controls.Add(btnBorrarUsu);
            tpUsuarios.Controls.Add(btnAgregarUsu);
            tpUsuarios.Controls.Add(listUsuarios);
            tpUsuarios.Controls.Add(lblUsuarios);
            tpUsuarios.ImageKey = "person_search.png";
            tpUsuarios.Location = new Point(4, 39);
            tpUsuarios.Name = "tpUsuarios";
            tpUsuarios.Padding = new Padding(3);
            tpUsuarios.Size = new Size(1020, 443);
            tpUsuarios.TabIndex = 2;
            tpUsuarios.Text = "Usuarios";
            tpUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnEditarUsu
            // 
            btnEditarUsu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarUsu.Cursor = Cursors.Hand;
            btnEditarUsu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarUsu.Depth = 0;
            btnEditarUsu.HighEmphasis = true;
            btnEditarUsu.Icon = null;
            btnEditarUsu.Location = new Point(154, 82);
            btnEditarUsu.Margin = new Padding(4, 6, 4, 6);
            btnEditarUsu.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditarUsu.Name = "btnEditarUsu";
            btnEditarUsu.NoAccentTextColor = Color.Empty;
            btnEditarUsu.Size = new Size(71, 36);
            btnEditarUsu.TabIndex = 26;
            btnEditarUsu.Text = "EDITAR";
            btnEditarUsu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnEditarUsu.UseAccentColor = true;
            btnEditarUsu.UseVisualStyleBackColor = true;
            // 
            // btnBorrarUsu
            // 
            btnBorrarUsu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBorrarUsu.Cursor = Cursors.Hand;
            btnBorrarUsu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBorrarUsu.Depth = 0;
            btnBorrarUsu.HighEmphasis = true;
            btnBorrarUsu.Icon = null;
            btnBorrarUsu.Location = new Point(873, 82);
            btnBorrarUsu.Margin = new Padding(4, 6, 4, 6);
            btnBorrarUsu.MouseState = MaterialSkin.MouseState.HOVER;
            btnBorrarUsu.Name = "btnBorrarUsu";
            btnBorrarUsu.NoAccentTextColor = Color.Empty;
            btnBorrarUsu.Size = new Size(88, 36);
            btnBorrarUsu.TabIndex = 25;
            btnBorrarUsu.Text = "Eliminar";
            btnBorrarUsu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnBorrarUsu.UseAccentColor = false;
            btnBorrarUsu.UseVisualStyleBackColor = true;
            // 
            // btnAgregarUsu
            // 
            btnAgregarUsu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarUsu.BackColor = Color.Black;
            btnAgregarUsu.Cursor = Cursors.Hand;
            btnAgregarUsu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarUsu.Depth = 0;
            btnAgregarUsu.HighEmphasis = true;
            btnAgregarUsu.Icon = null;
            btnAgregarUsu.Location = new Point(56, 82);
            btnAgregarUsu.Margin = new Padding(4, 6, 4, 6);
            btnAgregarUsu.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarUsu.Name = "btnAgregarUsu";
            btnAgregarUsu.NoAccentTextColor = Color.Empty;
            btnAgregarUsu.Size = new Size(74, 36);
            btnAgregarUsu.TabIndex = 24;
            btnAgregarUsu.Text = "AÑADIR";
            btnAgregarUsu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnAgregarUsu.UseAccentColor = true;
            btnAgregarUsu.UseMnemonic = false;
            btnAgregarUsu.UseVisualStyleBackColor = false;
            // 
            // listUsuarios
            // 
            listUsuarios.AutoSizeTable = false;
            listUsuarios.BackColor = Color.FromArgb(255, 255, 255);
            listUsuarios.BorderStyle = BorderStyle.None;
            listUsuarios.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listUsuarios.Cursor = Cursors.Hand;
            listUsuarios.Depth = 0;
            listUsuarios.FullRowSelect = true;
            listUsuarios.Location = new Point(56, 127);
            listUsuarios.MinimumSize = new Size(200, 100);
            listUsuarios.MouseLocation = new Point(-1, -1);
            listUsuarios.MouseState = MaterialSkin.MouseState.OUT;
            listUsuarios.Name = "listUsuarios";
            listUsuarios.OwnerDraw = true;
            listUsuarios.Size = new Size(905, 320);
            listUsuarios.TabIndex = 21;
            listUsuarios.UseCompatibleStateImageBehavior = false;
            listUsuarios.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Id";
            columnHeader6.Width = 92;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Nombre";
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Apellido";
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Edad";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Telefono";
            columnHeader10.Width = 210;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Role";
            columnHeader11.Width = 100;
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Depth = 0;
            lblUsuarios.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblUsuarios.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblUsuarios.Location = new Point(56, 18);
            lblUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(136, 41);
            lblUsuarios.TabIndex = 16;
            lblUsuarios.Text = "Usuarios";
            lblUsuarios.UseAccent = true;
            // 
            // tpFacturacion
            // 
            tpFacturacion.Controls.Add(listFacturas);
            tpFacturacion.Controls.Add(lblFacturacion);
            tpFacturacion.ImageKey = "facturacion.png";
            tpFacturacion.Location = new Point(4, 39);
            tpFacturacion.Name = "tpFacturacion";
            tpFacturacion.Padding = new Padding(3);
            tpFacturacion.Size = new Size(1020, 443);
            tpFacturacion.TabIndex = 3;
            tpFacturacion.Text = "Facturación";
            tpFacturacion.UseVisualStyleBackColor = true;
            // 
            // listFacturas
            // 
            listFacturas.AutoSizeTable = false;
            listFacturas.BackColor = Color.FromArgb(255, 255, 255);
            listFacturas.BorderStyle = BorderStyle.None;
            listFacturas.Depth = 0;
            listFacturas.FullRowSelect = true;
            listFacturas.Location = new Point(56, 74);
            listFacturas.MinimumSize = new Size(200, 100);
            listFacturas.MouseLocation = new Point(-1, -1);
            listFacturas.MouseState = MaterialSkin.MouseState.OUT;
            listFacturas.Name = "listFacturas";
            listFacturas.OwnerDraw = true;
            listFacturas.Size = new Size(905, 366);
            listFacturas.TabIndex = 16;
            listFacturas.UseCompatibleStateImageBehavior = false;
            listFacturas.View = View.Details;
            // 
            // lblFacturacion
            // 
            lblFacturacion.AutoSize = true;
            lblFacturacion.Depth = 0;
            lblFacturacion.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblFacturacion.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblFacturacion.Location = new Point(56, 18);
            lblFacturacion.MouseState = MaterialSkin.MouseState.HOVER;
            lblFacturacion.Name = "lblFacturacion";
            lblFacturacion.Size = new Size(182, 41);
            lblFacturacion.TabIndex = 15;
            lblFacturacion.Text = "Facturación";
            lblFacturacion.UseAccent = true;
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
            // imageListAdmin
            // 
            imageListAdmin.ColorDepth = ColorDepth.Depth32Bit;
            imageListAdmin.ImageStream = (ImageListStreamer)resources.GetObject("imageListAdmin.ImageStream");
            imageListAdmin.TransparentColor = Color.Transparent;
            imageListAdmin.Images.SetKeyName(0, "admin_panel.png");
            imageListAdmin.Images.SetKeyName(1, "bed.png");
            imageListAdmin.Images.SetKeyName(2, "bedroom_parent.png");
            imageListAdmin.Images.SetKeyName(3, "facturacion.png");
            imageListAdmin.Images.SetKeyName(4, "logout.png");
            imageListAdmin.Images.SetKeyName(5, "person_search.png");
            imageListAdmin.Images.SetKeyName(6, "dashboard.png");
            // 
            // imageListDash
            // 
            imageListDash.ColorDepth = ColorDepth.Depth32Bit;
            imageListDash.ImageStream = (ImageListStreamer)resources.GetObject("imageListDash.ImageStream");
            imageListDash.TransparentColor = Color.Transparent;
            imageListDash.Images.SetKeyName(0, "door.png");
            imageListDash.Images.SetKeyName(1, "group.png");
            imageListDash.Images.SetKeyName(2, "money.png");
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 553);
            Controls.Add(tcAdmin);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tcAdmin;
            Name = "AdminView";
            Padding = new Padding(10, 64, 10, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "El Molino Hotel";
            tcAdmin.ResumeLayout(false);
            tpDashboard.ResumeLayout(false);
            tpDashboard.PerformLayout();
            cardFactura.ResumeLayout(false);
            cardFactura.PerformLayout();
            cardUsuarios.ResumeLayout(false);
            cardUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgUsuarios).EndInit();
            cardReservas.ResumeLayout(false);
            cardReservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgReservas).EndInit();
            tpHabitaciones.ResumeLayout(false);
            tpHabitaciones.PerformLayout();
            tpUsuarios.ResumeLayout(false);
            tpUsuarios.PerformLayout();
            tpFacturacion.ResumeLayout(false);
            tpFacturacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcAdmin;
        private TabPage tpDashboard;
        private TabPage tpHabitaciones;
        private TabPage tpUsuarios;
        private TabPage tpFacturacion;
        private TabPage tpLogout;
        private ImageList imageListAdmin;
        private MaterialSkin.Controls.MaterialLabel lblDashboard;
        private MaterialSkin.Controls.MaterialLabel lblFacturacion;
        private MaterialSkin.Controls.MaterialLabel lblHabitaciones;
        private MaterialSkin.Controls.MaterialLabel lblUsuarios;
        private MaterialSkin.Controls.MaterialCard cardReservas;
        private MaterialSkin.Controls.MaterialCard cardFactura;
        private MaterialSkin.Controls.MaterialCard cardUsuarios;
        private MaterialSkin.Controls.MaterialListView listReservasActivas;
        private MaterialSkin.Controls.MaterialProgressBar progressBarOcupacion;
        private MaterialSkin.Controls.MaterialLabel lblTotalReservas;
        private MaterialSkin.Controls.MaterialLabel lblHabitacionesActivas;
        private ImageList imageListDash;
        private PictureBox imgReservas;
        private MaterialSkin.Controls.MaterialLabel captionLblFactura;
        private MaterialSkin.Controls.MaterialLabel lblTotalFacturado;
        private MaterialSkin.Controls.MaterialLabel lblFactura;
        private PictureBox imgUsuarios;
        private MaterialSkin.Controls.MaterialLabel captionLblUsuarios;
        private MaterialSkin.Controls.MaterialLabel lblTotalUsuarios;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private Label captionLblOcupacion;
        private MaterialSkin.Controls.MaterialLabel lblReservas;
        private ColumnHeader columnId;
        private ColumnHeader columnHabitacion;
        private ColumnHeader columnCategoria;
        private ColumnHeader columnCapacidad;
        private ColumnHeader columnCliente;
        private ColumnHeader columnCheckin;
        private ColumnHeader columnCheckout;
        private MaterialSkin.Controls.MaterialListView listHabitaciones;
        private MaterialSkin.Controls.MaterialListView listFacturas;
        private MaterialSkin.Controls.MaterialListView listUsuarios;
        private MaterialSkin.Controls.MaterialButton btnAgregarHab;
        private MaterialSkin.Controls.MaterialButton btnBorrarHab;
        private MaterialSkin.Controls.MaterialButton btnEditarHab;
        private MaterialSkin.Controls.MaterialButton btnEditarUsu;
        private MaterialSkin.Controls.MaterialButton btnBorrarUsu;
        private MaterialSkin.Controls.MaterialButton btnAgregarUsu;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
    }
}