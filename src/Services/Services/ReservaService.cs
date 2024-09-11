using Domain.Entities;
using Domain.Validation.ModelDataAnnotationCheck;
using Services.Services.ReservaServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services
{
    public class ReservaService : IReservaService
    {
        IModelDataAnnotationCheck _modelDataAnnotationCheck;
        IReservaRepository _reservaRepository;

        public ReservaService(IModelDataAnnotationCheck modelDataAnnotationCheck, IReservaRepository reservaRepository)
        {
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
            _reservaRepository = reservaRepository;
        }

        public void ValidateModel(Reserva reserva)
        {
            _modelDataAnnotationCheck.ValidateModel(reserva);
        }

        public void AgregarReserva(Reserva reserva)
        {
            ValidateModel(reserva);
            _reservaRepository.Add(reserva);
        }
    }
}
