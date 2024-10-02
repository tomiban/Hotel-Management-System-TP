namespace PresentationLayer.Views
{
    partial class CambiarContraseñaView
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
            txtContraseñaActual = new MaterialSkin.Controls.MaterialTextBox();
            txtNuevaContraseña = new MaterialSkin.Controls.MaterialTextBox();
            lblContraseñaActual = new MaterialSkin.Controls.MaterialLabel();
            lblNuevaContraseña = new MaterialSkin.Controls.MaterialLabel();
            btnCambiarContraseña = new MaterialSkin.Controls.MaterialButton();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // txtContraseñaActual
            // 
            txtContraseñaActual.AnimateReadOnly = false;
            txtContraseñaActual.BorderStyle = BorderStyle.None;
            txtContraseñaActual.Depth = 0;
            txtContraseñaActual.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtContraseñaActual.LeadingIcon = null;
            txtContraseñaActual.Location = new Point(56, 124);
            txtContraseñaActual.MaxLength = 50;
            txtContraseñaActual.MouseState = MaterialSkin.MouseState.OUT;
            txtContraseñaActual.Multiline = false;
            txtContraseñaActual.Name = "txtContraseñaActual";
            txtContraseñaActual.Password = true;
            txtContraseñaActual.ScrollBars = RichTextBoxScrollBars.None;
            txtContraseñaActual.Size = new Size(208, 50);
            txtContraseñaActual.TabIndex = 11;
            txtContraseñaActual.Text = "";
            txtContraseñaActual.TrailingIcon = null;
            // 
            // txtNuevaContraseña
            // 
            txtNuevaContraseña.AnimateReadOnly = false;
            txtNuevaContraseña.BorderStyle = BorderStyle.None;
            txtNuevaContraseña.Depth = 0;
            txtNuevaContraseña.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNuevaContraseña.LeadingIcon = null;
            txtNuevaContraseña.Location = new Point(56, 241);
            txtNuevaContraseña.MaxLength = 50;
            txtNuevaContraseña.MouseState = MaterialSkin.MouseState.OUT;
            txtNuevaContraseña.Multiline = false;
            txtNuevaContraseña.Name = "txtNuevaContraseña";
            txtNuevaContraseña.Size = new Size(208, 50);
            txtNuevaContraseña.TabIndex = 12;
            txtNuevaContraseña.Text = "";
            txtNuevaContraseña.TrailingIcon = null;
            // 
            // lblContraseñaActual
            // 
            lblContraseñaActual.AutoSize = true;
            lblContraseñaActual.Depth = 0;
            lblContraseñaActual.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblContraseñaActual.Location = new Point(56, 102);
            lblContraseñaActual.MouseState = MaterialSkin.MouseState.HOVER;
            lblContraseñaActual.Name = "lblContraseñaActual";
            lblContraseñaActual.Size = new Size(131, 19);
            lblContraseñaActual.TabIndex = 13;
            lblContraseñaActual.Text = "Contraseña Actual";
            // 
            // lblNuevaContraseña
            // 
            lblNuevaContraseña.AutoSize = true;
            lblNuevaContraseña.Depth = 0;
            lblNuevaContraseña.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNuevaContraseña.Location = new Point(56, 219);
            lblNuevaContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            lblNuevaContraseña.Name = "lblNuevaContraseña";
            lblNuevaContraseña.Size = new Size(131, 19);
            lblNuevaContraseña.TabIndex = 14;
            lblNuevaContraseña.Text = "Nueva Contraseña";
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCambiarContraseña.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCambiarContraseña.Depth = 0;
            btnCambiarContraseña.HighEmphasis = true;
            btnCambiarContraseña.Icon = null;
            btnCambiarContraseña.Location = new Point(65, 332);
            btnCambiarContraseña.Margin = new Padding(4, 6, 4, 6);
            btnCambiarContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.NoAccentTextColor = Color.Empty;
            btnCambiarContraseña.Size = new Size(185, 36);
            btnCambiarContraseña.TabIndex = 15;
            btnCambiarContraseña.Text = "Cambiar Contraseña";
            btnCambiarContraseña.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCambiarContraseña.UseAccentColor = false;
            btnCambiarContraseña.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(110, 380);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CambiarContraseñaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnCambiarContraseña);
            Controls.Add(lblNuevaContraseña);
            Controls.Add(lblContraseñaActual);
            Controls.Add(txtNuevaContraseña);
            Controls.Add(txtContraseñaActual);
            Name = "CambiarContraseñaView";
            Text = "CambiarContraseñaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtContraseñaActual;
        private MaterialSkin.Controls.MaterialTextBox txtNuevaContraseña;
        private MaterialSkin.Controls.MaterialLabel lblContraseñaActual;
        private MaterialSkin.Controls.MaterialLabel lblNuevaContraseña;
        private MaterialSkin.Controls.MaterialButton btnCambiarContraseña;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
    }
}