namespace GestionHotelWinForms.Views
{
    partial class Register
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
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(110, 113);
            txtNombre.MaxLength = 32;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(267, 50);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "";
            txtNombre.TrailingIcon = null;
            txtNombre.TextChanged += materialTextBox1_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.AnimateReadOnly = false;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Depth = 0;
            txtContraseña.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtContraseña.LeadingIcon = null;
            txtContraseña.Location = new Point(510, 306);
            txtContraseña.MaxLength = 16;
            txtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            txtContraseña.Multiline = false;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Password = true;
            txtContraseña.Size = new Size(270, 50);
            txtContraseña.TabIndex = 1;
            txtContraseña.Text = "";
            txtContraseña.TrailingIcon = null;
            txtContraseña.TextChanged += materialTextBox2_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(110, 306);
            txtUsuario.MaxLength = 32;
            txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(267, 50);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "";
            txtUsuario.TrailingIcon = null;
            txtUsuario.TextChanged += materialTextBox3_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.AnimateReadOnly = false;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Depth = 0;
            txtTelefono.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(510, 209);
            txtTelefono.MaxLength = 15;
            txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefono.Multiline = false;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(270, 50);
            txtTelefono.TabIndex = 3;
            txtTelefono.Text = "";
            txtTelefono.TrailingIcon = null;
            txtTelefono.TextChanged += materialTextBox4_TextChanged;
            // 
            // txtEdad
            // 
            txtEdad.AnimateReadOnly = false;
            txtEdad.BorderStyle = BorderStyle.None;
            txtEdad.Depth = 0;
            txtEdad.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEdad.LeadingIcon = null;
            txtEdad.Location = new Point(110, 209);
            txtEdad.MaxLength = 3;
            txtEdad.MouseState = MaterialSkin.MouseState.OUT;
            txtEdad.Multiline = false;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(267, 50);
            txtEdad.TabIndex = 4;
            txtEdad.Text = "";
            txtEdad.TrailingIcon = null;
            txtEdad.TextChanged += materialTextBox5_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.AnimateReadOnly = false;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Depth = 0;
            txtApellido.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtApellido.LeadingIcon = null;
            txtApellido.Location = new Point(510, 113);
            txtApellido.MaxLength = 32;
            txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            txtApellido.Multiline = false;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(270, 50);
            txtApellido.TabIndex = 5;
            txtApellido.Text = "";
            txtApellido.TrailingIcon = null;
            txtApellido.TextChanged += materialTextBox6_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Depth = 0;
            lblNombre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNombre.Location = new Point(110, 91);
            lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 19);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Depth = 0;
            lblApellido.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblApellido.Location = new Point(510, 91);
            lblApellido.MouseState = MaterialSkin.MouseState.HOVER;
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(58, 19);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Depth = 0;
            lblEdad.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEdad.Location = new Point(110, 187);
            lblEdad.MouseState = MaterialSkin.MouseState.HOVER;
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(37, 19);
            lblEdad.TabIndex = 8;
            lblEdad.Text = "Edad";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Depth = 0;
            lblTelefono.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTelefono.Location = new Point(510, 187);
            lblTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(64, 19);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Teléfono";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Depth = 0;
            lblUsuario.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUsuario.Location = new Point(110, 284);
            lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(55, 19);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = "Usuario";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.AutoSize = false;
            btnRegistrarse.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegistrarse.Cursor = Cursors.Hand;
            btnRegistrarse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegistrarse.Depth = 0;
            btnRegistrarse.HighEmphasis = true;
            btnRegistrarse.Icon = null;
            btnRegistrarse.Location = new Point(340, 408);
            btnRegistrarse.Margin = new Padding(4, 6, 4, 6);
            btnRegistrarse.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.NoAccentTextColor = Color.Empty;
            btnRegistrarse.Size = new Size(213, 63);
            btnRegistrarse.TabIndex = 12;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegistrarse.UseAccentColor = false;
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Depth = 0;
            lblContraseña.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblContraseña.Location = new Point(510, 284);
            lblContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(82, 19);
            lblContraseña.TabIndex = 13;
            lblContraseña.Text = "Contraseña";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 487);
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
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
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
        
    }
}