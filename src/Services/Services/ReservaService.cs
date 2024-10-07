using Domain.Entities;
using Domain.Interfaces;
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

        public void ActualizarReserva(Reserva reserva)
        {
            var validationResults = ValidateModel(reserva);
            if (validationResults.Any())
                { throw new InvalidOperationException("Error en la validación de la reserva: " + string.Join(", ", validationResults.Select(v => v.ErrorMessage))); }
            _reservaRepository.Update(reserva);
        }

        public List<Reserva> GetAllReservasUser(int userId)
        {
            return _reservaRepository.GetAllByUser(userId);
        }

        public Reserva GetById(int id)
        {
            return _reservaRepository.GetById(id);
        }

        public void CancelarReserva(int id)
        {
            _reservaRepository.Delete(id);
        }

        public decimal RecalcularDiasYPrecio(Reserva reserva)
        {
            
            var diasDeEstadia = (reserva.FechaFin.Date - reserva.FechaInicio.Date).TotalDays;
            if (diasDeEstadia <= 0)
                throw new ArgumentException("La fecha de fin debe ser posterior a la fecha de inicio.");

            decimal precioTotal = (int)diasDeEstadia * reserva.PrecioPorNoche;
            return precioTotal;
        }

        public List<Reserva> GetAllReservasActivas()
        {
            return _reservaRepository.GetReservasActivas();
        }
    }
}
