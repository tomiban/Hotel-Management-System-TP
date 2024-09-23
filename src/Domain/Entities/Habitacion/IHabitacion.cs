using Domain.Entities;
namespace Domain.Interfaces
{
    public interface IHabitacion
    {
        
        bool Disponible { get; }
        int NroHabitacion { get; }
        decimal PrecioPorNoche { get; }
        TipoHabitacion TipoHabitacion { get; }
        string Descripcion { get; }
        int Capacidad { get; }
    }
}