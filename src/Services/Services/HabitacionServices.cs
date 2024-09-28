using Domain.Entities;
using Domain.Interfaces;
using Domain.Validation.ModelDataAnnotationCheck;
using Services.Services.ReservaServices;
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
        private readonly IReservaRepository _reservaRepository;

        public HabitacionServices(IHabitacionRepository habitacionRepository, IReservaRepository reservaRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
            _habitacionRepository = habitacionRepository;
            _reservaRepository = reservaRepository;
        }

        // Método optimizado para filtrar habitaciones disponibles
        public List<Habitacion> FiltrarHabitacionesDisponibles(DateTime fechaDesde, DateTime fechaHasta)
        {
          
            var reservasActivas = _reservaRepository.GetReservasActivas();

            // Obtener las habitaciones que NO tienen reservas activas en el rango de fechas especificado
            return _habitacionRepository.GetAll()
                .Where(h => !reservasActivas.Any(r =>
                        r.NroHabitacion == h.NroHabitacion &&
                        (fechaDesde < r.FechaFin && fechaHasta > r.FechaInicio)
                    )
                ).ToList();
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
