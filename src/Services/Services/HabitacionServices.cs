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
                throw new ValidationException("Error en la validación de la habitación: " + string.Join(", ", validationResults.Select(v => v.ErrorMessage)));
            }
            try
            {
                _habitacionRepository.Add(habitacion);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado al agregar la habitación.", ex);
            }
        }

        public void Update(Habitacion habitacion)
        {
            var validationResults = ValidateModel(habitacion);
            if (validationResults.Any())
            {
                throw new ValidationException("Error en la validación de la habitación: " + string.Join(", ", validationResults.Select(v => v.ErrorMessage)));
            }
            try
            {
                _habitacionRepository.Update(habitacion);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado al actualizar la habitación.", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _habitacionRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado al eliminar la habitación.", ex);
            }
        }

        public List<Habitacion> GetAll()
        {
            try
            {
                return _habitacionRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al obtener las habitaciones.", ex);
            }
        }

        public Habitacion GetById(int id)
        {
            try
            {
                return _habitacionRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Ocurrió un error al obtener la habitación con id {id}.", ex);
            }
        }

        public bool CheckNroHabitacion(int id)
        {
            try
            {
                var habitacion = _habitacionRepository.GetById(id);
                return habitacion != null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al verificar el número de la habitación.", ex);
            }
        }
    }
}
