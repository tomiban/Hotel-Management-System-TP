using MemoryPack;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Factura
{
    [MemoryPackable]
    public partial class Factura : IFactura
    {
        private int _contadorId;
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha es requerida.")]
        [DataType(DataType.Date, ErrorMessage = "La fecha debe ser una fecha válida.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El ID de la reserva es requerido.")]
        public int IdReserva { get; set; }

        [Required(ErrorMessage = "La reserva es requerida.")]
        public Reserva Reserva { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "El monto total debe ser positivo.")]
        public double MontoTotal
        {
            get
            {
                //return Reserva.Habitacion.PrecioPorNoche * Reserva.CantidadNoches;
                return 0;
            }
        }

        public Factura()
        {
            _contadorId++;
            Id = _contadorId;
        }
    }
}
