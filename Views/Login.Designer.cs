namespace GestionHotelWinForms.Views
{
    partial class Login
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
            txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            txtContraseña = new MaterialSkin.Controls.MaterialTextBox();
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            lblContraseña = new MaterialSkin.Controls.MaterialLabel();
            btnSinCuenta = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(161, 136);
            txtUsuario.MaxLength = 32;
            txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(270, 50);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "";
            txtUsuario.TrailingIcon = null;
            // 
            // txtContraseña
            // 
            txtContraseña.AnimateReadOnly = false;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Depth = 0;
            txtContraseña.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtContraseña.LeadingIcon = null;
            txtContraseña.Location = new Point(161, 233);
            txtContraseña.MaxLength = 16;
            txtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            txtContraseña.Multiline = false;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Password = true;
            txtContraseña.Size = new Size(270, 50);
            txtContraseña.TabIndex = 1;
            txtContraseña.Text = "";
            txtContraseña.TrailingIcon = null;
            // 
            // btnLogin
            // 
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.Location = new Point(228, 335);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(128, 36);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Iniciar sesión";
            btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Depth = 0;
            lblUsuario.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUsuario.Location = new Point(161, 114);
            lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(55, 19);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Depth = 0;
            lblContraseña.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblContraseña.Location = new Point(161, 211);
            lblContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(82, 19);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña";
            // 
            // btnSinCuenta
            // 
            btnSinCuenta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSinCuenta.BackColor = Color.FromArgb(64, 64, 64);
            btnSinCuenta.Cursor = Cursors.Hand;
            btnSinCuenta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSinCuenta.Depth = 0;
            btnSinCuenta.FlatAppearance.BorderColor = Color.Gray;
            btnSinCuenta.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnSinCuenta.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnSinCuenta.ForeColor = SystemColors.ControlDarkDark;
            btnSinCuenta.HighEmphasis = true;
            btnSinCuenta.Icon = null;
            btnSinCuenta.Location = new Point(195, 403);
            btnSinCuenta.Margin = new Padding(4, 6, 4, 6);
            btnSinCuenta.MouseState = MaterialSkin.MouseState.HOVER;
            btnSinCuenta.Name = "btnSinCuenta";
            btnSinCuenta.NoAccentTextColor = Color.Empty;
            btnSinCuenta.Size = new Size(188, 36);
            btnSinCuenta.TabIndex = 5;
            btnSinCuenta.Text = "No tengo una cuenta";
            btnSinCuenta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            btnSinCuenta.UseAccentColor = false;
            btnSinCuenta.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(600, 500);
            Controls.Add(btnSinCuenta);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(btnLogin);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialTextBox txtContraseña;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialLabel lblContraseña;
        private MaterialSkin.Controls.MaterialButton btnSinCuenta;
    }
}