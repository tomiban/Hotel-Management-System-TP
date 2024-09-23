namespace Domain.Entities.Factura
{
    public interface IFactura
    {
        int Id { get; set; }
        DateTime Fecha { get; set; }
        int IdReserva { get; set; }
        Reserva Reserva { get; set; }
    }
}