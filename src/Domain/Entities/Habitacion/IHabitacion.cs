using Domain.Entities;
namespace Domain.Interfaces
{
    public interface IHabitacion
    {
        int Id { get; set; }
        int NroHabitacion { get; set; }
        TipoHabitacion TipoHabitacion { get; set; }
        int CantidadPersonas { get; set; }
        double PrecioPorNoche { get; set; }
        bool Disponible { get; set; }
    }
}