using Domain.Validation.ModelDataAnnotationCheck;
using Domain.Interfaces;
using Domain.Entities;

namespace ApplicationLayer.Services
{
    public class HabitacionServices : IHabitacionServices
    {
        private readonly IModelDataAnnotationCheck _modelDataAnnotationCheck;
        private readonly IHabitacionRepository _habitacionRepository;

        public HabitacionServices(IHabitacionRepository habitacionRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
            _habitacionRepository = habitacionRepository;
        }

        public void ValidateModel(IHabitacion habitacion)
        {
            _modelDataAnnotationCheck.ValidateModel(habitacion);
        }

    }
}
