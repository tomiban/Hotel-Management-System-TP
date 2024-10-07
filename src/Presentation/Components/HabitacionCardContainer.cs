using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.Components
{
    public class HabitacionCardContainer : FlowLayoutPanel
    {
        private MaterialLabel lblMensaje;

        public HabitacionCardContainer()
        {
            // Habilitar scroll automático
            this.AutoScroll = true;  // Mostrar barra de desplazamiento automáticamente si es necesario
            this.WrapContents = true; // Configurar para que el contenido no se ajuste automáticamente
            this.FlowDirection = FlowDirection.LeftToRight; // Cambiar la dirección si prefieres de arriba a abajo

            // Ajustes visuales
            this.Dock = DockStyle.Fill; // Asegura que ocupe todo el espacio disponible
            this.Padding = new Padding(30, 0, 0, 10); // Espacio de relleno
            lblMensaje = new MaterialLabel
            {
                Font = new Font("Roboto", 12, FontStyle.Italic),
                ForeColor = Color.Gray,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Visible = false,  // Oculto por defecto
                Dock = DockStyle.None,
                FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1,
                Margin = new Padding(200, 100, 0, 0)
            };

            this.Controls.Add(lblMensaje); // Añadimos el label al contenedor
        }

        // Método para mostrar un mensaje dinámico
        public void MostrarMensaje(string mensaje)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.Visible = true;

            // Centrar el mensaje
            lblMensaje.Location = new Point((this.Width - lblMensaje.Width) / 2, (this.Height - lblMensaje.Height) / 2);
        }

        // Método para ocultar el mensaje
        public void OcultarMensaje()
        {
            lblMensaje.Visible = false;
        }

        // Sobreescribir el método Clear y añadir lógica para mostrar el mensaje
        public new void Clear()
        {
            base.Controls.Clear();  // Limpiar las tarjetas
            this.Controls.Add(lblMensaje); // Reagregar el label después de limpiar
        }

        // Sobreescribir el método Add para añadir lógica de ocultar el mensaje
        public new void Add(Control control)
        {
            // Si vamos a añadir tarjetas, ocultamos el mensaje
            if (lblMensaje.Visible)
                OcultarMensaje();

            base.Controls.Add(control);  // Añadir la tarjeta
        }
    }
}
