using Domain.Entities;
using Domain.Validation.ModelDataAnnotationCheck;
using Services.Services.ReservaServices;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ApplicationLayer.Services
{
    public class ReservaService : IReservaService
    {
        private readonly IModelDataAnnotationCheck _modelDataAnnotationCheck;
        private readonly IReservaRepository _reservaRepository;



        public ReservaService(IModelDataAnnotationCheck modelDataAnnotationCheck, IReservaRepository reservaRepository)
        {
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
            _reservaRepository = reservaRepository;
        }

        public bool VerificarDisponibilidadHabitacion(int nroHabitacion, DateTime fechaInicio, DateTime fechaFin)
        {
            return _reservaRepository.VerificarDisponibilidad(nroHabitacion, fechaInicio, fechaFin);
        }


        public ICollection<ValidationResult> ValidateModel(Reserva reserva)
        {
            return _modelDataAnnotationCheck.ValidateModel(reserva);
        }

        public void AgregarReserva(Reserva reserva)
        {
            var validationResults = ValidateModel(reserva);
            if (validationResults.Any())
            {
                throw new ValidationException("Error en la validación de la reserva: " +
                    string.Join(", ", validationResults.Select(v => v.ErrorMessage)));
            }

            var disponible = VerificarDisponibilidadHabitacion(reserva.NroHabitacion, reserva.FechaInicio, reserva.FechaFin);

            if(!disponible)
                throw new InvalidOperationException("La habitación no está disponible para las fechas seleccionadas.");

            _reservaRepository.Add(reserva);
        }

        public List<Reserva> GetAll(int id)
        {
            return _reservaRepository.GetAllByUser(id);
        }

        public Reserva GetById(int id)
        {
            return _reservaRepository.GetById(id);
        }

        public void Delete(int id)
        {
            _reservaRepository.Delete(id);
        }
    }
}
