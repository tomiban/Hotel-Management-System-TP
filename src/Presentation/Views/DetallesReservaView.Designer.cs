namespace PresentationLayer.Views
{
    partial class DetallesReservaView
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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            txtTipoHabitacion = new MaterialSkin.Controls.MaterialTextBox2();
            btnActualizarReserva = new MaterialSkin.Controls.MaterialButton();
            btnCancelarReserva = new MaterialSkin.Controls.MaterialButton();
            dateTimePickerFin = new DateTimePicker();
            dateTimePickerInicio = new DateTimePicker();
            lblPrecioFInal = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            lblDiasEstadia = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            lblFechaFin = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtPrecioFinal = new MaterialSkin.Controls.MaterialTextBox2();
            txtDiasEstadia = new MaterialSkin.Controls.MaterialTextBox2();
            txtNroHabitacionDetalle = new MaterialSkin.Controls.MaterialTextBox2();
            btnRegresarCliente = new MaterialSkin.Controls.MaterialButton();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(txtTipoHabitacion);
            materialCard1.Controls.Add(btnActualizarReserva);
            materialCard1.Controls.Add(btnCancelarReserva);
            materialCard1.Controls.Add(dateTimePickerFin);
            materialCard1.Controls.Add(dateTimePickerInicio);
            materialCard1.Controls.Add(lblPrecioFInal);
            materialCard1.Controls.Add(materialLabel5);
            materialCard1.Controls.Add(lblDiasEstadia);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Controls.Add(lblFechaFin);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Controls.Add(txtPrecioFinal);
            materialCard1.Controls.Add(txtDiasEstadia);
            materialCard1.Controls.Add(txtNroHabitacionDetalle);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(115, 104);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(813, 409);
            materialCard1.TabIndex = 0;
            // 
            // txtTipoHabitacion
            // 
            txtTipoHabitacion.AnimateReadOnly = false;
            txtTipoHabitacion.BackgroundImageLayout = ImageLayout.None;
            txtTipoHabitacion.CharacterCasing = CharacterCasing.Normal;
            txtTipoHabitacion.Depth = 0;
            txtTipoHabitacion.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTipoHabitacion.HideSelection = true;
            txtTipoHabitacion.LeadingIcon = null;
            txtTipoHabitacion.Location = new Point(450, 145);
            txtTipoHabitacion.MaxLength = 32767;
            txtTipoHabitacion.MouseState = MaterialSkin.MouseState.OUT;
            txtTipoHabitacion.Name = "txtTipoHabitacion";
            txtTipoHabitacion.PasswordChar = '\0';
            txtTipoHabitacion.PrefixSuffixText = null;
            txtTipoHabitacion.ReadOnly = true;
            txtTipoHabitacion.RightToLeft = RightToLeft.No;
            txtTipoHabitacion.SelectedText = "";
            txtTipoHabitacion.SelectionLength = 0;
            txtTipoHabitacion.SelectionStart = 0;
            txtTipoHabitacion.ShortcutsEnabled = true;
            txtTipoHabitacion.Size = new Size(301, 48);
            txtTipoHabitacion.TabIndex = 63;
            txtTipoHabitacion.TabStop = false;
            txtTipoHabitacion.TextAlign = HorizontalAlignment.Left;
            txtTipoHabitacion.TrailingIcon = null;
            txtTipoHabitacion.UseSystemPasswordChar = false;
            // 
            // btnActualizarReserva
            // 
            btnActualizarReserva.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnActualizarReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnActualizarReserva.Depth = 0;
            btnActualizarReserva.FlatStyle = FlatStyle.Flat;
            btnActualizarReserva.ForeColor = Color.Black;
            btnActualizarReserva.HighEmphasis = true;
            btnActualizarReserva.Icon = null;
            btnActualizarReserva.Location = new Point(62, 334);
            btnActualizarReserva.Margin = new Padding(4, 6, 4, 6);
            btnActualizarReserva.MinimumSize = new Size(301, 48);
            btnActualizarReserva.MouseState = MaterialSkin.MouseState.HOVER;
            btnActualizarReserva.Name = "btnActualizarReserva";
            btnActualizarReserva.NoAccentTextColor = Color.Empty;
            btnActualizarReserva.Size = new Size(301, 48);
            btnActualizarReserva.TabIndex = 62;
            btnActualizarReserva.Text = "Modificar";
            btnActualizarReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnActualizarReserva.UseAccentColor = true;
            btnActualizarReserva.UseVisualStyleBackColor = true;
            // 
            // btnCancelarReserva
            // 
            btnCancelarReserva.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelarReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelarReserva.Depth = 0;
            btnCancelarReserva.HighEmphasis = true;
            btnCancelarReserva.Icon = null;
            btnCancelarReserva.Location = new Point(450, 334);
            btnCancelarReserva.Margin = new Padding(4, 6, 4, 6);
            btnCancelarReserva.MinimumSize = new Size(301, 48);
            btnCancelarReserva.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelarReserva.Name = "btnCancelarReserva";
            btnCancelarReserva.NoAccentTextColor = Color.Empty;
            btnCancelarReserva.Size = new Size(301, 48);
            btnCancelarReserva.TabIndex = 61;
            btnCancelarReserva.Text = "Cancelar Reserva";
            btnCancelarReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelarReserva.UseAccentColor = false;
            btnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.CalendarMonthBackground = SystemColors.WindowFrame;
            dateTimePickerFin.Location = new Point(450, 49);
            dateTimePickerFin.MinimumSize = new Size(300, 45);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(301, 45);
            dateTimePickerFin.TabIndex = 60;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(62, 48);
            dateTimePickerInicio.MinimumSize = new Size(0, 45);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(301, 45);
            dateTimePickerInicio.TabIndex = 59;
            // 
            // lblPrecioFInal
            // 
            lblPrecioFInal.AutoSize = true;
            lblPrecioFInal.Depth = 0;
            lblPrecioFInal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPrecioFInal.Location = new Point(450, 238);
            lblPrecioFInal.MouseState = MaterialSkin.MouseState.HOVER;
            lblPrecioFInal.Name = "lblPrecioFInal";
            lblPrecioFInal.Size = new Size(84, 19);
            lblPrecioFInal.TabIndex = 58;
            lblPrecioFInal.Text = "Precio Final";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(450, 123);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(135, 19);
            materialLabel5.TabIndex = 57;
            materialLabel5.Text = "Tipo de Habitación";
            // 
            // lblDiasEstadia
            // 
            lblDiasEstadia.AutoSize = true;
            lblDiasEstadia.Depth = 0;
            lblDiasEstadia.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDiasEstadia.Location = new Point(62, 229);
            lblDiasEstadia.MouseState = MaterialSkin.MouseState.HOVER;
            lblDiasEstadia.Name = "lblDiasEstadia";
            lblDiasEstadia.Size = new Size(111, 19);
            lblDiasEstadia.TabIndex = 56;
            lblDiasEstadia.Text = "Dias de Estadía";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(62, 122);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(159, 19);
            materialLabel3.TabIndex = 55;
            materialLabel3.Text = "Número de Habitación";
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Depth = 0;
            lblFechaFin.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFechaFin.Location = new Point(450, 27);
            lblFechaFin.MouseState = MaterialSkin.MouseState.HOVER;
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(70, 19);
            lblFechaFin.TabIndex = 54;
            lblFechaFin.Text = "Fecha Fin";
            // 
            // materialLabel1
            // 
            materialLabel1.AccessibleName = "lblFechaInicio";
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(62, 26);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(86, 19);
            materialLabel1.TabIndex = 53;
            materialLabel1.Text = "Fecha Inicio";
            // 
            // txtPrecioFinal
            // 
            txtPrecioFinal.AnimateReadOnly = false;
            txtPrecioFinal.BackgroundImageLayout = ImageLayout.None;
            txtPrecioFinal.CharacterCasing = CharacterCasing.Normal;
            txtPrecioFinal.Depth = 0;
            txtPrecioFinal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecioFinal.HideSelection = true;
            txtPrecioFinal.LeadingIcon = null;
            txtPrecioFinal.Location = new Point(450, 260);
            txtPrecioFinal.MaxLength = 32767;
            txtPrecioFinal.MouseState = MaterialSkin.MouseState.OUT;
            txtPrecioFinal.Name = "txtPrecioFinal";
            txtPrecioFinal.PasswordChar = '\0';
            txtPrecioFinal.PrefixSuffixText = null;
            txtPrecioFinal.ReadOnly = true;
            txtPrecioFinal.RightToLeft = RightToLeft.No;
            txtPrecioFinal.SelectedText = "";
            txtPrecioFinal.SelectionLength = 0;
            txtPrecioFinal.SelectionStart = 0;
            txtPrecioFinal.ShortcutsEnabled = true;
            txtPrecioFinal.Size = new Size(301, 48);
            txtPrecioFinal.TabIndex = 52;
            txtPrecioFinal.TabStop = false;
            txtPrecioFinal.TextAlign = HorizontalAlignment.Left;
            txtPrecioFinal.TrailingIcon = null;
            txtPrecioFinal.UseSystemPasswordChar = false;
            // 
            // txtDiasEstadia
            // 
            txtDiasEstadia.AnimateReadOnly = false;
            txtDiasEstadia.BackgroundImageLayout = ImageLayout.None;
            txtDiasEstadia.CharacterCasing = CharacterCasing.Normal;
            txtDiasEstadia.Depth = 0;
            txtDiasEstadia.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDiasEstadia.HideSelection = true;
            txtDiasEstadia.LeadingIcon = null;
            txtDiasEstadia.Location = new Point(62, 251);
            txtDiasEstadia.MaxLength = 32767;
            txtDiasEstadia.MouseState = MaterialSkin.MouseState.OUT;
            txtDiasEstadia.Name = "txtDiasEstadia";
            txtDiasEstadia.PasswordChar = '\0';
            txtDiasEstadia.PrefixSuffixText = null;
            txtDiasEstadia.ReadOnly = true;
            txtDiasEstadia.RightToLeft = RightToLeft.No;
            txtDiasEstadia.SelectedText = "";
            txtDiasEstadia.SelectionLength = 0;
            txtDiasEstadia.SelectionStart = 0;
            txtDiasEstadia.ShortcutsEnabled = true;
            txtDiasEstadia.Size = new Size(301, 48);
            txtDiasEstadia.TabIndex = 51;
            txtDiasEstadia.TabStop = false;
            txtDiasEstadia.TextAlign = HorizontalAlignment.Left;
            txtDiasEstadia.TrailingIcon = null;
            txtDiasEstadia.UseSystemPasswordChar = false;
            // 
            // txtNroHabitacionDetalle
            // 
            txtNroHabitacionDetalle.AnimateReadOnly = false;
            txtNroHabitacionDetalle.BackgroundImageLayout = ImageLayout.None;
            txtNroHabitacionDetalle.CharacterCasing = CharacterCasing.Normal;
            txtNroHabitacionDetalle.Depth = 0;
            txtNroHabitacionDetalle.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNroHabitacionDetalle.HideSelection = true;
            txtNroHabitacionDetalle.LeadingIcon = null;
            txtNroHabitacionDetalle.Location = new Point(62, 144);
            txtNroHabitacionDetalle.MaxLength = 32767;
            txtNroHabitacionDetalle.MouseState = MaterialSkin.MouseState.OUT;
            txtNroHabitacionDetalle.Name = "txtNroHabitacionDetalle";
            txtNroHabitacionDetalle.PasswordChar = '\0';
            txtNroHabitacionDetalle.PrefixSuffixText = null;
            txtNroHabitacionDetalle.ReadOnly = true;
            txtNroHabitacionDetalle.RightToLeft = RightToLeft.No;
            txtNroHabitacionDetalle.SelectedText = "";
            txtNroHabitacionDetalle.SelectionLength = 0;
            txtNroHabitacionDetalle.SelectionStart = 0;
            txtNroHabitacionDetalle.ShortcutsEnabled = true;
            txtNroHabitacionDetalle.Size = new Size(301, 48);
            txtNroHabitacionDetalle.TabIndex = 50;
            txtNroHabitacionDetalle.TabStop = false;
            txtNroHabitacionDetalle.TextAlign = HorizontalAlignment.Left;
            txtNroHabitacionDetalle.TrailingIcon = null;
            txtNroHabitacionDetalle.UseSystemPasswordChar = false;
            // 
            // btnRegresarCliente
            // 
            btnRegresarCliente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegresarCliente.BackColor = Color.FromArgb(64, 64, 64);
            btnRegresarCliente.Cursor = Cursors.Hand;
            btnRegresarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegresarCliente.Depth = 0;
            btnRegresarCliente.FlatAppearance.BorderColor = Color.Gray;
            btnRegresarCliente.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnRegresarCliente.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnRegresarCliente.ForeColor = SystemColors.ControlDarkDark;
            btnRegresarCliente.HighEmphasis = true;
            btnRegresarCliente.Icon = null;
            btnRegresarCliente.Location = new Point(7, 79);
            btnRegresarCliente.Margin = new Padding(4, 6, 4, 6);
            btnRegresarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegresarCliente.Name = "btnRegresarCliente";
            btnRegresarCliente.NoAccentTextColor = Color.Empty;
            btnRegresarCliente.Size = new Size(94, 36);
            btnRegresarCliente.TabIndex = 14;
            btnRegresarCliente.Text = "Regresar";
            btnRegresarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnRegresarCliente.UseAccentColor = false;
            btnRegresarCliente.UseVisualStyleBackColor = false;
            // 
            // DetallesReservaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 553);
            Controls.Add(btnRegresarCliente);
            Controls.Add(materialCard1);
            Name = "DetallesReservaView";
            Text = "Reserva";
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 txtTipoHabitacion;
        private MaterialSkin.Controls.MaterialButton btnActualizarReserva;
        private MaterialSkin.Controls.MaterialButton btnCancelarReserva;
        private DateTimePicker dateTimePickerFin;
        private DateTimePicker dateTimePickerInicio;
        private MaterialSkin.Controls.MaterialLabel lblPrecioFInal;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lblDiasEstadia;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblFechaFin;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrecioFinal;
        private MaterialSkin.Controls.MaterialTextBox2 txtDiasEstadia;
        private MaterialSkin.Controls.MaterialTextBox2 txtNroHabitacionDetalle;
        private MaterialSkin.Controls.MaterialButton btnRegresarCliente;
    }
}