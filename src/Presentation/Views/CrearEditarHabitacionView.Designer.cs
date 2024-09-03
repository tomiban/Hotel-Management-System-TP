namespace Presentation.Views
{
    partial class CrearEditarHabitacionView
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            txtNroHabitacion = new MaterialSkin.Controls.MaterialTextBox2();
            cmbTipoHabitacion = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            switchDisponibilidad = new MaterialSkin.Controls.MaterialSwitch();
            txtPrecioHabitacion = new MaterialSkin.Controls.MaterialTextBox2();
            btnRegresarAdmin = new MaterialSkin.Controls.MaterialButton();
            panel1 = new Panel();
            btnGuardarHab = new MaterialSkin.Controls.MaterialButton();
            txtCantidadPersonas = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(99, 192);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(159, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Número de Habitación";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(528, 192);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(135, 19);
            materialLabel3.TabIndex = 2;
            materialLabel3.Text = "Tipo de Habitacion";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(99, 332);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(119, 19);
            materialLabel4.TabIndex = 3;
            materialLabel4.Text = "Precio por noche";
            // 
            // txtNroHabitacion
            // 
            txtNroHabitacion.AnimateReadOnly = false;
            txtNroHabitacion.BackgroundImageLayout = ImageLayout.None;
            txtNroHabitacion.CharacterCasing = CharacterCasing.Normal;
            txtNroHabitacion.Depth = 0;
            txtNroHabitacion.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNroHabitacion.HideSelection = true;
            txtNroHabitacion.LeadingIcon = null;
            txtNroHabitacion.Location = new Point(99, 228);
            txtNroHabitacion.MaxLength = 32767;
            txtNroHabitacion.MouseState = MaterialSkin.MouseState.OUT;
            txtNroHabitacion.Name = "txtNroHabitacion";
            txtNroHabitacion.PasswordChar = '\0';
            txtNroHabitacion.PrefixSuffixText = null;
            txtNroHabitacion.ReadOnly = false;
            txtNroHabitacion.RightToLeft = RightToLeft.No;
            txtNroHabitacion.SelectedText = "";
            txtNroHabitacion.SelectionLength = 0;
            txtNroHabitacion.SelectionStart = 0;
            txtNroHabitacion.ShortcutsEnabled = true;
            txtNroHabitacion.Size = new Size(250, 48);
            txtNroHabitacion.TabIndex = 4;
            txtNroHabitacion.TabStop = false;
            txtNroHabitacion.TextAlign = HorizontalAlignment.Left;
            txtNroHabitacion.TrailingIcon = null;
            txtNroHabitacion.UseSystemPasswordChar = false;
            // 
            // cmbTipoHabitacion
            // 
            cmbTipoHabitacion.AutoResize = false;
            cmbTipoHabitacion.BackColor = Color.FromArgb(255, 255, 255);
            cmbTipoHabitacion.Depth = 0;
            cmbTipoHabitacion.DrawMode = DrawMode.OwnerDrawVariable;
            cmbTipoHabitacion.DropDownHeight = 174;
            cmbTipoHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoHabitacion.DropDownWidth = 121;
            cmbTipoHabitacion.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbTipoHabitacion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbTipoHabitacion.FormattingEnabled = true;
            cmbTipoHabitacion.IntegralHeight = false;
            cmbTipoHabitacion.ItemHeight = 43;
            cmbTipoHabitacion.Items.AddRange(new object[] { "Premium", "Standard", "Economic" });
            cmbTipoHabitacion.Location = new Point(528, 228);
            cmbTipoHabitacion.MaxDropDownItems = 4;
            cmbTipoHabitacion.MouseState = MaterialSkin.MouseState.OUT;
            cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            cmbTipoHabitacion.Size = new Size(250, 49);
            cmbTipoHabitacion.StartIndex = 0;
            cmbTipoHabitacion.TabIndex = 7;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            materialLabel2.Location = new Point(320, 106);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(272, 41);
            materialLabel2.TabIndex = 9;
            materialLabel2.Text = "Añadir Habitación";
            materialLabel2.Click += materialLabel2_Click;
            // 
            // switchDisponibilidad
            // 
            switchDisponibilidad.AutoSize = true;
            switchDisponibilidad.Cursor = Cursors.Hand;
            switchDisponibilidad.Depth = 0;
            switchDisponibilidad.Location = new Point(718, 116);
            switchDisponibilidad.Margin = new Padding(0);
            switchDisponibilidad.MouseLocation = new Point(-1, -1);
            switchDisponibilidad.MouseState = MaterialSkin.MouseState.HOVER;
            switchDisponibilidad.Name = "switchDisponibilidad";
            switchDisponibilidad.Ripple = true;
            switchDisponibilidad.Size = new Size(118, 37);
            switchDisponibilidad.TabIndex = 10;
            switchDisponibilidad.Text = "Habilitar";
            switchDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // txtPrecioHabitacion
            // 
            txtPrecioHabitacion.AnimateReadOnly = false;
            txtPrecioHabitacion.BackgroundImageLayout = ImageLayout.None;
            txtPrecioHabitacion.CharacterCasing = CharacterCasing.Normal;
            txtPrecioHabitacion.Depth = 0;
            txtPrecioHabitacion.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecioHabitacion.HideSelection = true;
            txtPrecioHabitacion.LeadingIcon = null;
            txtPrecioHabitacion.Location = new Point(99, 364);
            txtPrecioHabitacion.MaxLength = 32767;
            txtPrecioHabitacion.MouseState = MaterialSkin.MouseState.OUT;
            txtPrecioHabitacion.Name = "txtPrecioHabitacion";
            txtPrecioHabitacion.PasswordChar = '\0';
            txtPrecioHabitacion.PrefixSuffixText = null;
            txtPrecioHabitacion.ReadOnly = false;
            txtPrecioHabitacion.RightToLeft = RightToLeft.No;
            txtPrecioHabitacion.SelectedText = "";
            txtPrecioHabitacion.SelectionLength = 0;
            txtPrecioHabitacion.SelectionStart = 0;
            txtPrecioHabitacion.ShortcutsEnabled = true;
            txtPrecioHabitacion.Size = new Size(250, 48);
            txtPrecioHabitacion.TabIndex = 11;
            txtPrecioHabitacion.TabStop = false;
            txtPrecioHabitacion.TextAlign = HorizontalAlignment.Left;
            txtPrecioHabitacion.TrailingIcon = null;
            txtPrecioHabitacion.UseSystemPasswordChar = false;
            // 
            // btnRegresarAdmin
            // 
            btnRegresarAdmin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegresarAdmin.BackColor = Color.FromArgb(64, 64, 64);
            btnRegresarAdmin.Cursor = Cursors.Hand;
            btnRegresarAdmin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegresarAdmin.Depth = 0;
            btnRegresarAdmin.FlatAppearance.BorderColor = Color.Gray;
            btnRegresarAdmin.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnRegresarAdmin.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnRegresarAdmin.ForeColor = SystemColors.ControlDarkDark;
            btnRegresarAdmin.HighEmphasis = true;
            btnRegresarAdmin.Icon = null;
            btnRegresarAdmin.Location = new Point(19, 87);
            btnRegresarAdmin.Margin = new Padding(4, 6, 4, 6);
            btnRegresarAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegresarAdmin.Name = "btnRegresarAdmin";
            btnRegresarAdmin.NoAccentTextColor = Color.Empty;
            btnRegresarAdmin.Size = new Size(94, 36);
            btnRegresarAdmin.TabIndex = 13;
            btnRegresarAdmin.Text = "Regresar";
            btnRegresarAdmin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnRegresarAdmin.UseAccentColor = false;
            btnRegresarAdmin.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGuardarHab);
            panel1.Location = new Point(320, 455);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 43);
            panel1.TabIndex = 15;
            // 
            // btnGuardarHab
            // 
            btnGuardarHab.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardarHab.Cursor = Cursors.Hand;
            btnGuardarHab.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardarHab.Depth = 0;
            btnGuardarHab.Dock = DockStyle.Fill;
            btnGuardarHab.HighEmphasis = true;
            btnGuardarHab.Icon = null;
            btnGuardarHab.Location = new Point(0, 0);
            btnGuardarHab.Margin = new Padding(4, 6, 4, 6);
            btnGuardarHab.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardarHab.Name = "btnGuardarHab";
            btnGuardarHab.NoAccentTextColor = Color.Empty;
            btnGuardarHab.Padding = new Padding(50, 0, 50, 0);
            btnGuardarHab.Size = new Size(250, 43);
            btnGuardarHab.TabIndex = 13;
            btnGuardarHab.Text = "Guardar";
            btnGuardarHab.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardarHab.UseAccentColor = false;
            btnGuardarHab.UseVisualStyleBackColor = true;
            // 
            // txtCantidadPersonas
            // 
            txtCantidadPersonas.AnimateReadOnly = false;
            txtCantidadPersonas.BackgroundImageLayout = ImageLayout.None;
            txtCantidadPersonas.CharacterCasing = CharacterCasing.Normal;
            txtCantidadPersonas.Depth = 0;
            txtCantidadPersonas.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCantidadPersonas.HideSelection = true;
            txtCantidadPersonas.LeadingIcon = null;
            txtCantidadPersonas.Location = new Point(528, 364);
            txtCantidadPersonas.MaxLength = 32767;
            txtCantidadPersonas.MouseState = MaterialSkin.MouseState.OUT;
            txtCantidadPersonas.Name = "txtCantidadPersonas";
            txtCantidadPersonas.PasswordChar = '\0';
            txtCantidadPersonas.PrefixSuffixText = null;
            txtCantidadPersonas.ReadOnly = false;
            txtCantidadPersonas.RightToLeft = RightToLeft.No;
            txtCantidadPersonas.SelectedText = "";
            txtCantidadPersonas.SelectionLength = 0;
            txtCantidadPersonas.SelectionStart = 0;
            txtCantidadPersonas.ShortcutsEnabled = true;
            txtCantidadPersonas.Size = new Size(250, 48);
            txtCantidadPersonas.TabIndex = 16;
            txtCantidadPersonas.TabStop = false;
            txtCantidadPersonas.TextAlign = HorizontalAlignment.Left;
            txtCantidadPersonas.TrailingIcon = null;
            txtCantidadPersonas.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(528, 332);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(217, 19);
            materialLabel5.TabIndex = 17;
            materialLabel5.Text = "Cantidad máxima de personas";
            // 
            // CrearEditarHabitacionView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 546);
            Controls.Add(materialLabel5);
            Controls.Add(txtCantidadPersonas);
            Controls.Add(panel1);
            Controls.Add(btnRegresarAdmin);
            Controls.Add(txtPrecioHabitacion);
            Controls.Add(switchDisponibilidad);
            Controls.Add(materialLabel2);
            Controls.Add(cmbTipoHabitacion);
            Controls.Add(txtNroHabitacion);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel1);
            Name = "CrearEditarHabitacionView";
            Text = "CrearEditarHabitacion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 txtNroHabitacion;
        private MaterialSkin.Controls.MaterialComboBox cmbTipoHabitacion;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSwitch switchDisponibilidad;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrecioHabitacion;
        private MaterialSkin.Controls.MaterialButton btnRegresarAdmin;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnGuardarHab;
        private MaterialSkin.Controls.MaterialTextBox2 txtCantidadPersonas;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}