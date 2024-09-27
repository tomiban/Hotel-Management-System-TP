using Domain.Entities;
using Domain.Interfaces;
using Domain.Validation.ModelDataAnnotationCheck;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

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

        public ICollection<ValidationResult> ValidateModel(IHabitacion habitacion)
        {
            return _modelDataAnnotationCheck.ValidateModel(habitacion);
        }

        public void Add(Habitacion habitacion)
        {
            var validationResults = ValidateModel(habitacion);
            if (validationResults.Any())
            {
                throw new ValidationException("Error en la validación de la habitación: " +
                    string.Join(", ", validationResults.Select(v => v.ErrorMessage)));
            }

            _habitacionRepository.Add(habitacion);
        }

        public void Update(Habitacion habitacion)
        {
            var validationResults = ValidateModel(habitacion);
            if (validationResults.Any())
            {
                throw new ValidationException("Error en la validación de la habitación: " +
                    string.Join(", ", validationResults.Select(v => v.ErrorMessage)));
            }

            _habitacionRepository.Update(habitacion);
        }

        public void Delete(int id)
        {
            _habitacionRepository.Delete(id);
        }

        public List<Habitacion> GetAll()
        {
            return _habitacionRepository.GetAll();
        }

        public Habitacion GetById(int id)
        {
            return _habitacionRepository.GetById(id);
        }

        public bool Exists(int id)
        {
            return _habitacionRepository.GetById(id) != null;
        }

    }
}
