using Domain.Validation.ModelDataAnnotationCheck;
using Domain.Interfaces;
using Domain.Entities;

namespace ApplicationLayer.Services
{
    public class HabitacionServices : IHabitacionServices
    {
        IModelDataAnnotationCheck _modelDataAnnotationCheck;
        IHabitacionRepository _habitacionRepository;

        public HabitacionServices(IHabitacionRepository habitacionRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
            _habitacionRepository = habitacionRepository;
        }

        public void ValidateModel(IHabitacion habitacion)
        {
            _modelDataAnnotationCheck.ValidateModel(habitacion);
        }

        public void Add(Habitacion habitacion)
        {
            ValidateModel(habitacion);
            _habitacionRepository.AddAsync(habitacion);
        }

        public void Update(Habitacion habitacion)
        {
            ValidateModel(habitacion);
            _habitacionRepository.UpdateAsync(habitacion);
        }

        public void Delete(int id)
        {
            _habitacionRepository.DeleteAsync(id);
        }

        public Task<List<Habitacion>> GetAll()
        {
            return _habitacionRepository.GetAllAsync();
        }

        public Task<Habitacion> GetById(int id)
        {
            return _habitacionRepository.GetByIdAsync(id);
        }

        public Task<bool> CheckNroHabitacion(int id)
        {
            var habitacion = _habitacionRepository.GetByIdAsync(id);

            if (habitacion.Result == null)
            {
                return Task.FromResult(false);
            }
          
            return Task.FromResult(true);
            
          
        }
    }
}
