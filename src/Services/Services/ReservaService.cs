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

        public ICollection<ValidationResult> ValidateModel(Reserva reserva)
        {
            return _modelDataAnnotationCheck.ValidateModel(reserva);
        }

        public void AgregarReserva(Reserva reserva)
        {
            var validationResults = ValidateModel(reserva);
            if (validationResults.Any())
            {
                throw new ValidationException("Error en la validación de la reserva: " + string.Join(", ", validationResults.Select(v => v.ErrorMessage)));
            }
            _reservaRepository.Add(reserva);
        }
    }
}
