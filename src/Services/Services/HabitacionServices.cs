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
            _habitacionRepository.Add(habitacion);
        }

        public void Update(Habitacion habitacion)
        {
            ValidateModel(habitacion);
            _habitacionRepository.Update(habitacion);
        }

        public void Delete(int id)
        {
            _habitacionRepository.Delete(id);
        }

        public  List<Habitacion> GetAll()
        {
            return  _habitacionRepository.GetAll();
        }

        public Habitacion GetById(int id)
        {
            return _habitacionRepository.GetById(id);
        }

        public bool CheckNroHabitacion(int id)
        {
            var habitacion = _habitacionRepository.GetById(id);

            if (habitacion == null)
            {
                return false;
            }
          
            return true;
            
          
        }
    }
}
