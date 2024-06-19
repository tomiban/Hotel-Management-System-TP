namespace GestionHotelWinForms.Views
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            tcAdmin = new MaterialSkin.Controls.MaterialTabControl();
            tpDashboard = new TabPage();
            lblReservas = new MaterialSkin.Controls.MaterialLabel();
            cardFactura = new MaterialSkin.Controls.MaterialCard();
            imgPesos = new PictureBox();
            captionLblFactura = new MaterialSkin.Controls.MaterialLabel();
            lblTotalFacturado = new MaterialSkin.Controls.MaterialLabel();
            lblFactura = new MaterialSkin.Controls.MaterialLabel();
            cardUsuarios = new MaterialSkin.Controls.MaterialCard();
            imgUsuarios = new PictureBox();
            captionLblUsuarios = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            listReservas = new MaterialSkin.Controls.MaterialListView();
            columnId = new ColumnHeader();
            columnHabitacion = new ColumnHeader();
            columnCategoria = new ColumnHeader();
            columnCapacidad = new ColumnHeader();
            columnCliente = new ColumnHeader();
            columnCheckin = new ColumnHeader();
            columnCheckout = new ColumnHeader();
            cardReservas = new MaterialSkin.Controls.MaterialCard();
            captionLblReservas = new Label();
            imgReservas = new PictureBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            progressBarOcupacion = new MaterialSkin.Controls.MaterialProgressBar();
            lblHabitacionesActivas = new MaterialSkin.Controls.MaterialLabel();
            lblDashboard = new MaterialSkin.Controls.MaterialLabel();
            tpHabitaciones = new TabPage();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            listHabitaciones = new MaterialSkin.Controls.MaterialListView();
            lblHabitaciones = new MaterialSkin.Controls.MaterialLabel();
            tpUsuarios = new TabPage();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            listUsuarios = new MaterialSkin.Controls.MaterialListView();
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
            ((System.ComponentModel.ISupportInitialize)imgPesos).BeginInit();
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
            tpDashboard.Controls.Add(listReservas);
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
            lblReservas.Size = new Size(212, 24);
            lblReservas.TabIndex = 22;
            lblReservas.Text = "Habitaciones Ocupadas";
            // 
            // cardFactura
            // 
            cardFactura.BackColor = Color.FromArgb(255, 255, 255);
            cardFactura.Controls.Add(imgPesos);
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
            // imgPesos
            // 
            imgPesos.Image = (Image)resources.GetObject("imgPesos.Image");
            imgPesos.Location = new Point(206, 28);
            imgPesos.Margin = new Padding(0);
            imgPesos.Name = "imgPesos";
            imgPesos.Size = new Size(65, 68);
            imgPesos.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPesos.TabIndex = 3;
            imgPesos.TabStop = false;
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
            cardUsuarios.Controls.Add(materialLabel4);
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
            captionLblUsuarios.Click += materialLabel3_Click;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            materialLabel4.Location = new Point(31, 33);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(55, 58);
            materialLabel4.TabIndex = 1;
            materialLabel4.Text = "14";
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
            // listReservas
            // 
            listReservas.AutoSizeTable = false;
            listReservas.BackColor = Color.FromArgb(255, 255, 255);
            listReservas.BorderStyle = BorderStyle.None;
            listReservas.Columns.AddRange(new ColumnHeader[] { columnId, columnHabitacion, columnCategoria, columnCapacidad, columnCliente, columnCheckin, columnCheckout });
            listReservas.Depth = 0;
            listReservas.FullRowSelect = true;
            listReservas.Location = new Point(56, 266);
            listReservas.MinimumSize = new Size(200, 100);
            listReservas.MouseLocation = new Point(-1, -1);
            listReservas.MouseState = MaterialSkin.MouseState.OUT;
            listReservas.Name = "listReservas";
            listReservas.OwnerDraw = true;
            listReservas.Size = new Size(861, 197);
            listReservas.TabIndex = 18;
            listReservas.UseCompatibleStateImageBehavior = false;
            listReservas.View = View.Details;
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
            cardReservas.Controls.Add(captionLblReservas);
            cardReservas.Controls.Add(imgReservas);
            cardReservas.Controls.Add(materialLabel1);
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
            // captionLblReservas
            // 
            captionLblReservas.AutoSize = true;
            captionLblReservas.Dock = DockStyle.Bottom;
            captionLblReservas.Location = new Point(14, 91);
            captionLblReservas.Name = "captionLblReservas";
            captionLblReservas.Size = new Size(90, 15);
            captionLblReservas.TabIndex = 20;
            captionLblReservas.Text = "50% Ocupación";
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
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            materialLabel1.Location = new Point(31, 33);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(55, 58);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "10";
            // 
            // progressBarOcupacion
            // 
            progressBarOcupacion.Depth = 0;
            progressBarOcupacion.Dock = DockStyle.Bottom;
            progressBarOcupacion.Location = new Point(14, 106);
            progressBarOcupacion.Maximum = 10;
            progressBarOcupacion.MouseState = MaterialSkin.MouseState.HOVER;
            progressBarOcupacion.Name = "progressBarOcupacion";
            progressBarOcupacion.Size = new Size(234, 5);
            progressBarOcupacion.Step = 1;
            progressBarOcupacion.TabIndex = 19;
            progressBarOcupacion.Value = 5;
            progressBarOcupacion.Click += materialProgressBar1_Click;
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
            tpHabitaciones.Controls.Add(materialButton2);
            tpHabitaciones.Controls.Add(materialButton1);
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
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(150, 82);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(88, 36);
            materialButton2.TabIndex = 22;
            materialButton2.Text = "Eliminar";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(56, 82);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(74, 36);
            materialButton1.TabIndex = 21;
            materialButton1.Text = "AÑADIR";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButton1.UseAccentColor = true;
            materialButton1.UseMnemonic = false;
            materialButton1.UseVisualStyleBackColor = false;
            // 
            // listHabitaciones
            // 
            listHabitaciones.AutoSizeTable = false;
            listHabitaciones.BackColor = Color.FromArgb(255, 255, 255);
            listHabitaciones.BorderStyle = BorderStyle.None;
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
            tpUsuarios.Controls.Add(materialButton4);
            tpUsuarios.Controls.Add(materialButton3);
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
            // materialButton4
            // 
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(56, 82);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(74, 36);
            materialButton4.TabIndex = 23;
            materialButton4.Text = "AÑADIR";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButton4.UseAccentColor = true;
            materialButton4.UseMnemonic = false;
            materialButton4.UseVisualStyleBackColor = false;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(150, 82);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(88, 36);
            materialButton3.TabIndex = 24;
            materialButton3.Text = "Eliminar";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // listUsuarios
            // 
            listUsuarios.AutoSizeTable = false;
            listUsuarios.BackColor = Color.FromArgb(255, 255, 255);
            listUsuarios.BorderStyle = BorderStyle.None;
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
            listFacturas.SelectedIndexChanged += listFacturas_SelectedIndexChanged;
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
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 553);
            Controls.Add(tcAdmin);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tcAdmin;
            Name = "Admin";
            Padding = new Padding(10, 64, 10, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "El Molino Hotel";
            Load += Form1_Load;
            tcAdmin.ResumeLayout(false);
            tpDashboard.ResumeLayout(false);
            tpDashboard.PerformLayout();
            cardFactura.ResumeLayout(false);
            cardFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgPesos).EndInit();
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
        private MaterialSkin.Controls.MaterialListView listReservas;
        private MaterialSkin.Controls.MaterialProgressBar progressBarOcupacion;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblHabitacionesActivas;
        private ImageList imageListDash;
        private PictureBox imgReservas;
        private PictureBox imgPesos;
        private MaterialSkin.Controls.MaterialLabel captionLblFactura;
        private MaterialSkin.Controls.MaterialLabel lblTotalFacturado;
        private MaterialSkin.Controls.MaterialLabel lblFactura;
        private PictureBox imgUsuarios;
        private MaterialSkin.Controls.MaterialLabel captionLblUsuarios;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private Label captionLblReservas;
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
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton3;
    }
}