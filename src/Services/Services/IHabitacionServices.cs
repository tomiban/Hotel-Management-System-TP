using Domain.Entities;
using Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

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
        ICollection<ValidationResult> ValidateModel(IHabitacion habitacion);
    }
}