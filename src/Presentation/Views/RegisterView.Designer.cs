namespace Presentation.Views
{
    partial class RegisterView
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
            txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            txtContraseña = new MaterialSkin.Controls.MaterialTextBox();
            txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            txtEdad = new MaterialSkin.Controls.MaterialTextBox();
            txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            lblNombre = new MaterialSkin.Controls.MaterialLabel();
            lblApellido = new MaterialSkin.Controls.MaterialLabel();
            lblEdad = new MaterialSkin.Controls.MaterialLabel();
            lblTelefono = new MaterialSkin.Controls.MaterialLabel();
            lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            btnRegistrarse = new MaterialSkin.Controls.MaterialButton();
            lblContraseña = new MaterialSkin.Controls.MaterialLabel();
            btnRegresar = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
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
            txtNombre.Location = new Point(122, 129);
            txtNombre.MaxLength = 32;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(267, 50);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "";
            txtNombre.TrailingIcon = null;
            // 
            // txtContraseña
            // 
            txtContraseña.AnimateReadOnly = false;
            txtContraseña.BackColor = Color.FromArgb(50, 50, 50);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Depth = 0;
            txtContraseña.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtContraseña.ForeColor = Color.FromArgb(222, 255, 255, 255);
            txtContraseña.LeadingIcon = null;
            txtContraseña.Location = new Point(522, 322);
            txtContraseña.MaxLength = 16;
            txtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            txtContraseña.Multiline = false;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Password = true;
            txtContraseña.Size = new Size(270, 50);
            txtContraseña.TabIndex = 5;
            txtContraseña.Text = "";
            txtContraseña.TrailingIcon = null;
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.BackColor = Color.FromArgb(50, 50, 50);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsuario.ForeColor = Color.FromArgb(222, 255, 255, 255);
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(122, 322);
            txtUsuario.MaxLength = 32;
            txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(267, 50);
            txtUsuario.TabIndex = 4;
            txtUsuario.Text = "";
            txtUsuario.TrailingIcon = null;
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
            txtTelefono.Location = new Point(522, 225);
            txtTelefono.MaxLength = 15;
            txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefono.Multiline = false;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(270, 50);
            txtTelefono.TabIndex = 3;
            txtTelefono.Text = "";
            txtTelefono.TrailingIcon = null;
            // 
            // txtEdad
            // 
            txtEdad.AnimateReadOnly = false;
            txtEdad.BackColor = Color.FromArgb(50, 50, 50);
            txtEdad.BorderStyle = BorderStyle.None;
            txtEdad.Depth = 0;
            txtEdad.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEdad.ForeColor = Color.FromArgb(222, 255, 255, 255);
            txtEdad.LeadingIcon = null;
            txtEdad.Location = new Point(122, 225);
            txtEdad.MaxLength = 3;
            txtEdad.MouseState = MaterialSkin.MouseState.OUT;
            txtEdad.Multiline = false;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(267, 50);
            txtEdad.TabIndex = 2;
            txtEdad.Text = "";
            txtEdad.TrailingIcon = null;
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
            txtApellido.Location = new Point(522, 129);
            txtApellido.MaxLength = 32;
            txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            txtApellido.Multiline = false;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(270, 50);
            txtApellido.TabIndex = 1;
            txtApellido.Text = "";
            txtApellido.TrailingIcon = null;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(50, 50, 50);
            lblNombre.Depth = 0;
            lblNombre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNombre.ForeColor = Color.FromArgb(222, 255, 255, 255);
            lblNombre.Location = new Point(122, 107);
            lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 19);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.FromArgb(50, 50, 50);
            lblApellido.Depth = 0;
            lblApellido.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblApellido.ForeColor = Color.FromArgb(222, 255, 255, 255);
            lblApellido.Location = new Point(522, 107);
            lblApellido.MouseState = MaterialSkin.MouseState.HOVER;
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(58, 19);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.BackColor = Color.FromArgb(50, 50, 50);
            lblEdad.Depth = 0;
            lblEdad.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEdad.ForeColor = Color.FromArgb(222, 255, 255, 255);
            lblEdad.Location = new Point(122, 203);
            lblEdad.MouseState = MaterialSkin.MouseState.HOVER;
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(37, 19);
            lblEdad.TabIndex = 8;
            lblEdad.Text = "Edad";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.FromArgb(50, 50, 50);
            lblTelefono.Depth = 0;
            lblTelefono.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTelefono.ForeColor = Color.FromArgb(222, 255, 255, 255);
            lblTelefono.Location = new Point(522, 203);
            lblTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(64, 19);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Teléfono";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(50, 50, 50);
            lblUsuario.Depth = 0;
            lblUsuario.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUsuario.ForeColor = Color.FromArgb(222, 255, 255, 255);
            lblUsuario.Location = new Point(122, 300);
            lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(136, 19);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = "Nombre de Usuario";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.AutoSize = false;
            btnRegistrarse.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegistrarse.BackColor = Color.FromArgb(50, 50, 50);
            btnRegistrarse.Cursor = Cursors.Hand;
            btnRegistrarse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegistrarse.Depth = 0;
            btnRegistrarse.Enabled = false;
            btnRegistrarse.ForeColor = Color.FromArgb(222, 255, 255, 255);
            btnRegistrarse.HighEmphasis = true;
            btnRegistrarse.Icon = null;
            btnRegistrarse.Location = new Point(353, 415);
            btnRegistrarse.Margin = new Padding(4, 6, 4, 6);
            btnRegistrarse.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.NoAccentTextColor = Color.Empty;
            btnRegistrarse.Size = new Size(203, 40);
            btnRegistrarse.TabIndex = 12;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegistrarse.UseAccentColor = false;
            btnRegistrarse.UseVisualStyleBackColor = false;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = Color.FromArgb(50, 50, 50);
            lblContraseña.Depth = 0;
            lblContraseña.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblContraseña.ForeColor = Color.FromArgb(222, 255, 255, 255);
            lblContraseña.Location = new Point(522, 300);
            lblContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(82, 19);
            lblContraseña.TabIndex = 13;
            lblContraseña.Text = "Contraseña";
            // 
            // btnRegresar
            // 
            btnRegresar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegresar.BackColor = Color.FromArgb(50, 50, 50);
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegresar.Depth = 0;
            btnRegresar.FlatAppearance.BorderColor = Color.Gray;
            btnRegresar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnRegresar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnRegresar.ForeColor = Color.FromArgb(222, 255, 255, 255);
            btnRegresar.HighEmphasis = true;
            btnRegresar.Icon = null;
            btnRegresar.Location = new Point(407, 467);
            btnRegresar.Margin = new Padding(4, 6, 4, 6);
            btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegresar.Name = "btnRegresar";
            btnRegresar.NoAccentTextColor = Color.Empty;
            btnRegresar.Size = new Size(94, 36);
            btnRegresar.TabIndex = 14;
            btnRegresar.Text = "Regresar";
            btnRegresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnRegresar.UseAccentColor = false;
            btnRegresar.UseVisualStyleBackColor = false;
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 539);
            Controls.Add(btnRegresar);
            Controls.Add(lblContraseña);
            Controls.Add(btnRegistrarse);
            Controls.Add(lblUsuario);
            Controls.Add(lblTelefono);
            Controls.Add(lblEdad);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtEdad);
            Controls.Add(txtTelefono);
            Controls.Add(txtUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Name = "RegisterView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtContraseña;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox txtEdad;
        private MaterialSkin.Controls.MaterialTextBox txtApellido;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblApellido;
        private MaterialSkin.Controls.MaterialLabel lblEdad;
        private MaterialSkin.Controls.MaterialLabel lblTelefono;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialLabel lblContraseña;
        private MaterialSkin.Controls.MaterialButton btnRegistrarse;
        private MaterialSkin.Controls.MaterialButton btnRegresar;
    }
}