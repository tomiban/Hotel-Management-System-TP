using Domain.Entities;
using Domain.Interfaces;

namespace ApplicationLayer.Services
{
    public interface IHabitacionServices
    {
        void Add(Habitacion habitacion);
        void Delete(int id);
        List<Habitacion> GetAll();
        Habitacion GetById(int id);
        void Update(Habitacion habitacion);
       bool CheckNroHabitacion(int id);
        void ValidateModel(IHabitacion habitacion);
    }
}