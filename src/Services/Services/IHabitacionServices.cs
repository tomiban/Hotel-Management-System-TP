using Domain.Entities;
using Domain.Interfaces;

namespace ApplicationLayer.Services
{
    public interface IHabitacionServices
    {
        void Add(Habitacion habitacion);
        void Delete(int id);
        Task<List<Habitacion>> GetAll();
        Task<Habitacion> GetById(int id);
        void Update(Habitacion habitacion);
        void ValidateModel(IHabitacion habitacion);
    }
}