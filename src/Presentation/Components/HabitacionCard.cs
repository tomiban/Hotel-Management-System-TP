using Domain.Entities;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PresentationLayer.Components
{
    public class HabitacionCard : MaterialCard
    {
        public Label NroHabitacionLabel { get; set; }
        public Label PrecioLabel { get; set; }
        public Label TipoHabitacionLabel { get; set; }
        public Label CapacidadLabel { get; set; }
        public PictureBox IconoCapacidad { get; set; }
        public MaterialButton ReservarButton { get; set; }
        public ImageList ImageList { get; set; }
        public MaterialLabel DescripcionTextBox { get; set; }
        public DateTimePicker FechaDesdePicker { get; set; }
        public DateTimePicker FechaHastaPicker { get; set; }
        public int HabitacionId { get; set; }

        public event EventHandler OnReservarButtonClicked;


        Dictionary<TipoHabitacion, Color> tipoHabitacionColors = new Dictionary<TipoHabitacion, Color>
        {
            { TipoHabitacion.Economic, Color.LightBlue },
            { TipoHabitacion.Standard, Color.LightGreen },
            { TipoHabitacion.Premium, Color.Gold },
        };

        public HabitacionCard(Habitacion habitacion)
        {
            // Inicializa el ImageList y agrega imágenes
            ImageList = new ImageList();
            ImageList.ImageSize = new Size(24, 24);

            // Ruta a la carpeta Assets relativa al directorio de salida
            string assetsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets");

            // Cargar imagen en el ImageList
            string imagePath = Path.Combine(assetsPath, "bed.png");
            if (File.Exists(imagePath))
            {
                ImageList.Images.Add("bed.png", Image.FromFile(imagePath));
            }
            else
            {
                throw new FileNotFoundException("No se encontró el archivo de imagen en la ruta especificada.", imagePath);
            }

            // Definir propiedades de la tarjeta
            this.Size = new Size(260, 350);
            this.BackColor = Color.FromArgb(55, 71, 79);
            this.Padding = new Padding(30, 10, 30, 10);
            this.Margin = new Padding(10);
            this.Depth = 4;



            // Etiqueta de número de habitación
            NroHabitacionLabel = new Label
            {
                Text = $"Habitación {habitacion.NroHabitacion}",
                Font = new Font("Roboto", 14, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(15, 13),
                AutoSize = true,
                BackColor = Color.Transparent
            };

            // Precio de la habitación
            PrecioLabel = new Label
            {
                Text = $"${habitacion.PrecioPorNoche:N0} ARS",
                ForeColor = Color.FromArgb(0, 188, 212),
                Location = new Point(15, 50),
                AutoSize = true,
                Font = new Font("Roboto", 12, FontStyle.Regular),
                BackColor = Color.Transparent
            };

            // Etiqueta de tipo de habitación como "pill"
            TipoHabitacionLabel = new Label
            {
                Text = habitacion.TipoHabitacion.ToString(),
                Font = new Font("Roboto", 10, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(15, 80),
                AutoSize = false,
                Size = new Size(120, 25),
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(5),
                BackColor = tipoHabitacionColors[habitacion.TipoHabitacion],
            };


            // Icono de capacidad de personas usando ImageList
            IconoCapacidad = new PictureBox
            {
                Image = ImageList.Images["bed.png"],
                Location = new Point(15, 115),
                Size = new Size(24, 24),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent
            };

            // Etiqueta de capacidad máxima de personas
            CapacidadLabel = new Label
            {
                Text = $"Capacidad: {habitacion.CantidadPersonas} personas",
                Font = new Font("Roboto", 10, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(50, IconoCapacidad.Top + 3),
                AutoSize = true,
                BackColor = Color.Transparent
            };

            // Campo de texto para la descripción de la habitación
            DescripcionTextBox = new MaterialLabel
            {
                Text = "Habitación cómoda y acogedora ideal para 3 personas. Equipado con camas individuales, aire acondicionado y conexión Wi-Fi gratuita. Perfecta para familias o grupos pequeños.", // Hardcodeada por ahora
                Font = new Font("Roboto", 10, FontStyle.Regular),
                ForeColor = Color.Black,
                Location = new Point(15, 150),
                TextAlign = ContentAlignment.TopLeft,
                Width = 230,
                Height = 90,
                Padding = new Padding(5, 0, 5, 0),
                FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
            };

            // DateTimePicker para la fecha de inicio de la reserva
            FechaDesdePicker = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Location = new Point(15, 240),
                Size = new Size(110, 30)
            };

            // DateTimePicker para la fecha de fin de la reserva
            FechaHastaPicker = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Location = new Point(135, 240),
                Size = new Size(110, 30)
            };

            // Botón de reserva
            ReservarButton = new MaterialButton
            {
                Name = "btnReservar",
                Text = habitacion.Disponible ? "RESERVA" : "NO DISPONIBLE",
                Size = new Size(160, 36),
                Location = new Point((this.Width - 160) / 2, 290),
                Enabled = habitacion.Disponible,
                HighEmphasis = true,
                Type = MaterialButton.MaterialButtonType.Contained,
                UseAccentColor = habitacion.Disponible,
                ForeColor = Color.White,
                AutoSize = false
            };

            // Enlazar el click del botón al evento público
            ReservarButton.Click += (sender, e) => OnReservarButtonClicked?.Invoke(this, e);

            // Añadir Tooltip para el botón de reserva
            var toolTip = new ToolTip();
            toolTip.SetToolTip(ReservarButton, habitacion.Disponible ? "Presiona para reservar esta habitación" : "Habitación no disponible actualmente");

            // Agregar controles a la tarjeta
            this.Controls.Add(NroHabitacionLabel);
            this.Controls.Add(PrecioLabel);
            this.Controls.Add(TipoHabitacionLabel);
            this.Controls.Add(IconoCapacidad);
            this.Controls.Add(CapacidadLabel);
            this.Controls.Add(DescripcionTextBox);
            this.Controls.Add(FechaDesdePicker);
            this.Controls.Add(FechaHastaPicker);
            this.Controls.Add(ReservarButton);
        }
    }
}
