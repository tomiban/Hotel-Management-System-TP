namespace Presentation.Views
{
    partial class CrearEditarHabitacion
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
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            disponibilidadSwitch = new MaterialSkin.Controls.MaterialSwitch();
            materialTextBox22 = new MaterialSkin.Controls.MaterialTextBox2();
            btnRegresarAdmin = new MaterialSkin.Controls.MaterialButton();
            panel1 = new Panel();
            btnGuardarHab = new MaterialSkin.Controls.MaterialButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(198, 207);
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
            materialLabel3.Location = new Point(198, 308);
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
            materialLabel4.Location = new Point(198, 405);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(119, 19);
            materialLabel4.TabIndex = 3;
            materialLabel4.Text = "Precio por noche";
            // 
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(381, 193);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(250, 48);
            materialTextBox21.TabIndex = 4;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Items.AddRange(new object[] { "Premium", "Standard", "Economic" });
            materialComboBox1.Location = new Point(381, 292);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(250, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 7;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            materialLabel2.Location = new Point(198, 106);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(272, 41);
            materialLabel2.TabIndex = 9;
            materialLabel2.Text = "Añadir Habitación";
            // 
            // disponibilidadSwitch
            // 
            disponibilidadSwitch.AutoSize = true;
            disponibilidadSwitch.Cursor = Cursors.Hand;
            disponibilidadSwitch.Depth = 0;
            disponibilidadSwitch.Location = new Point(709, 116);
            disponibilidadSwitch.Margin = new Padding(0);
            disponibilidadSwitch.MouseLocation = new Point(-1, -1);
            disponibilidadSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            disponibilidadSwitch.Name = "disponibilidadSwitch";
            disponibilidadSwitch.Ripple = true;
            disponibilidadSwitch.Size = new Size(118, 37);
            disponibilidadSwitch.TabIndex = 10;
            disponibilidadSwitch.Text = "Habilitar";
            disponibilidadSwitch.UseVisualStyleBackColor = true;
            // 
            // materialTextBox22
            // 
            materialTextBox22.AnimateReadOnly = false;
            materialTextBox22.BackgroundImageLayout = ImageLayout.None;
            materialTextBox22.CharacterCasing = CharacterCasing.Normal;
            materialTextBox22.Depth = 0;
            materialTextBox22.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox22.HideSelection = true;
            materialTextBox22.LeadingIcon = null;
            materialTextBox22.Location = new Point(381, 386);
            materialTextBox22.MaxLength = 32767;
            materialTextBox22.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox22.Name = "materialTextBox22";
            materialTextBox22.PasswordChar = '\0';
            materialTextBox22.PrefixSuffixText = null;
            materialTextBox22.ReadOnly = false;
            materialTextBox22.RightToLeft = RightToLeft.No;
            materialTextBox22.SelectedText = "";
            materialTextBox22.SelectionLength = 0;
            materialTextBox22.SelectionStart = 0;
            materialTextBox22.ShortcutsEnabled = true;
            materialTextBox22.Size = new Size(250, 48);
            materialTextBox22.TabIndex = 11;
            materialTextBox22.TabStop = false;
            materialTextBox22.TextAlign = HorizontalAlignment.Left;
            materialTextBox22.TrailingIcon = null;
            materialTextBox22.UseSystemPasswordChar = false;
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
            panel1.Location = new Point(381, 477);
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
            // CrearEditarHabitacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 546);
            Controls.Add(panel1);
            Controls.Add(btnRegresarAdmin);
            Controls.Add(materialTextBox22);
            Controls.Add(disponibilidadSwitch);
            Controls.Add(materialLabel2);
            Controls.Add(materialComboBox1);
            Controls.Add(materialTextBox21);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel1);
            Name = "CrearEditarHabitacion";
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
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSwitch disponibilidadSwitch;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialButton btnRegresarAdmin;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnGuardarHab;
    }
}