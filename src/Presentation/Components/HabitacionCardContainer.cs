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
            this.Dock = DockStyle.Fill;
            this.AutoScroll = true;  // Para mostrar el scroll automáticamente si hay muchas tarjetas
            this.WrapContents = true;  // Las tarjetas se acomodarán automáticamente
            this.FlowDirection = FlowDirection.LeftToRight;
            this.Padding = new Padding(40, 0, 0, 0);

            // Inicializamos el Label para mostrar mensajes
            lblMensaje = new MaterialLabel
            {
                Font = new Font("Roboto", 12, FontStyle.Italic),
                ForeColor = Color.Gray,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Visible = false,  // Oculto por defecto
                Dock = DockStyle.Fill,
                Margin = new Padding(220, 150, 0, 0),
                FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
            };

            this.Controls.Add(lblMensaje); // Añadimos el label al contenedor
        }

        // Método para mostrar un mensaje dinámico
        public void MostrarMensaje(string mensaje)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.Visible = true;
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

            // Mostrar el label por defecto
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
