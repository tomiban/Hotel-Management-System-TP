using Domain.Entities;
using MaterialSkin.Controls;
using System.Drawing;

namespace PresentationLayer.Components
{
    public class HabitacionCard : MaterialCard
    {
        public MaterialLabel NroHabitacionLabel { get; set; }
        public MaterialLabel PrecioLabel { get; set; }
        public MaterialLabel TipoHabitacionPill { get; set; }
        public MaterialButton ReservarButton { get; set; }

        public HabitacionCard(int nroHabitacion, double precio, TipoHabitacion tipoHabitacion, bool disponible)
        {
            // Definir propiedades de la tarjeta
            this.Size = new Size(240, 170);  // Tamaño compacto
            this.BackColor = Color.FromArgb(55, 71, 79);
            this.Padding = new Padding(10); // Padding interno para mejor espaciamiento
            this.Margin = new Padding(20);  // Margen entre tarjetas
            this.Depth = 3; // Sombra más prominente para un look más profesional

            // Etiqueta de número de habitación
            NroHabitacionLabel = new MaterialLabel
            {
                Text = $"Habitación {nroHabitacion}",
                Font = new Font("Roboto", 14, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(10, 10),
                AutoSize = true
            };

            // Precio con formato destacado
            PrecioLabel = new MaterialLabel
            {
                Text = $"${precio:N0} ARS", // Con separadores de miles
                Font = new Font("Roboto", 16, FontStyle.Bold), // Formato destacado
                ForeColor = Color.FromArgb(255, 215, 64), // Color dorado para destacar
                Location = new Point(10, 50),
                AutoSize = true
            };

            // Pill simulado con MaterialLabel (borde redondeado y estilo de etiqueta)
            TipoHabitacionPill = new MaterialLabel
            {
                Text = tipoHabitacion.ToString(),
                Font = new Font("Roboto", 10, FontStyle.Bold), // Estilo más pequeño y en negrita
                BackColor = Color.LightBlue,  // Color de fondo para el pill
                ForeColor = Color.Black, // Texto oscuro para el pill
                Size = new Size(70, 24),  // Tamaño adecuado para el pill
                Location = new Point(PrecioLabel.Right + 10, PrecioLabel.Top),  // Ubicar al lado del precio
                TextAlign = ContentAlignment.MiddleCenter,  // Centrar el texto
                BorderStyle = BorderStyle.FixedSingle,  // Agregar un borde
                FlatStyle = FlatStyle.Popup,
                UseAccent = false,
            };

            // Crear bordes redondeados para el "pill"
            TipoHabitacionPill.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, TipoHabitacionPill.ClientRectangle, Color.LightBlue, ButtonBorderStyle.Solid);
                Rectangle rect = new Rectangle(0, 0, TipoHabitacionPill.Width, TipoHabitacionPill.Height);
                e.Graphics.FillRectangle(new SolidBrush(Color.LightBlue), rect);
                e.Graphics.DrawString(TipoHabitacionPill.Text, TipoHabitacionPill.Font, new SolidBrush(Color.Black), rect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            };

            // Botón de reserva
            ReservarButton = new MaterialButton
            {
                Text = disponible ? "RESERVA" : "NO DISPONIBLE",
                Size = new Size(120, 36),
                Location = new Point(10, 120),
                Enabled = disponible,
                HighEmphasis = true,  // Estilo de énfasis alto
                BackColor = disponible ? Color.Purple : Color.Gray,
                ForeColor = Color.White
            };

            // Agregar controles a la tarjeta
            this.Controls.Add(NroHabitacionLabel);
            this.Controls.Add(PrecioLabel);
            this.Controls.Add(TipoHabitacionPill); // Añadir el "pill" simulado
            this.Controls.Add(ReservarButton);
        }
    }
}