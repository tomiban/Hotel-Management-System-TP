using Domain.Entities;
using Infraestructure.DataAccess.Serialization;
using InfraestructureLayer.Helpers;
using Services.Services.ReservaServices;

namespace Infraestructure.DataAccess.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly string FILE_PATH;
        private readonly string FILE_NAME = "reservas";
        private readonly IBinarySerialization _persistenceService;
        private List<Reserva> _reservas;

        public ReservaRepository(IBinarySerialization persistenceService)
        {
            FILE_PATH = FileHelper.GetFilePath(FILE_NAME);
            _persistenceService = persistenceService;
            _reservas = GetAll();
        }

        public void Add(Reserva entity)
        {
            try
            {
                _reservas.Add(entity);
                _persistenceService.Save(FILE_PATH, _reservas);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al agregar reserva: {ex.Message}", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var reserva = _reservas.FirstOrDefault(r => r.Id == id);
                if (reserva != null)
                {
                    _reservas.Remove(reserva);
                    _persistenceService.Save(FILE_PATH, _reservas);
                }
                else
                {
                    throw new ArgumentException("La reserva no existe.");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al eliminar la reserva: {ex.Message}", ex);
            }
        }

        public List<Reserva> GetAll()
        {
            try
            {
                return _persistenceService.Load<List<Reserva>>(FILE_PATH) ?? new List<Reserva>();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al cargar reservas: {ex.Message}", ex);
            }
        }

        public List<Reserva> GetAllByUser(int userId)
        {
            try
            {
                return _reservas.Where(r => r.UserId == userId).ToList();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al obtener las reservas del usuario: {ex.Message}", ex);
            }
        }

        public Reserva GetById(int id)
        {
            try
            {
                return _reservas.FirstOrDefault(r => r.Id == id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al obtener la reserva: {ex.Message}", ex);
            }
        }

        public List<Reserva> GetReservasActivas()
        {
            try
            {
                return _reservas.Where(r => r.Estado == Reserva.EstadoReserva.Activa).ToList();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al obtener las reservas activas: {ex.Message}", ex);
            }
        }

        public void Update(Reserva entity)
        {
            try
            {
                var reservaExistente = _reservas.FirstOrDefault(r => r.Id == entity.Id);
                if (reservaExistente != null)
                {
                    reservaExistente.FechaInicio = entity.FechaInicio;
                    reservaExistente.FechaFin = entity.FechaFin;
                    reservaExistente.NroHabitacion = entity.NroHabitacion;
                    reservaExistente.Username = entity.Username;
                    reservaExistente.Estado = entity.Estado;  // Actualizar el estado de la reserva

                    _persistenceService.Save(FILE_PATH, _reservas);
                }
                else
                {
                    throw new ArgumentException("La reserva no existe.");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al actualizar la reserva: {ex.Message}", ex);
            }
        }

        public bool VerificarDisponibilidad(int nroHabitacion, DateTime fechaInicio, DateTime fechaFin)
        {
            return !_reservas
                .Any(r => r.NroHabitacion == nroHabitacion &&
                          fechaInicio < r.FechaFin &&
                          fechaFin > r.FechaInicio.AddDays(-1));
        }
    }
}
