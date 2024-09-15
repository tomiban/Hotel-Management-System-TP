using Domain.Entities;
using Infraestructure.DataAccess.Serialization;
using InfraestructureLayer.Helpers;
using Services.Services.ReservaServices;

namespace Infraestructure.DataAccess.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        private string FILE_PATH;
        private readonly string FILE_NAME = "reservas";
        private readonly IBinarySerialization _persistenceService;
        private List<Reserva> _reservas;

        public ReservaRepository(IBinarySerialization persistenceService)
        {
            FILE_PATH = FileHelper.GetFilePath(FILE_NAME);
            _persistenceService = persistenceService;
            _reservas = GetAll(); // Cargar todas las reservas al inicializar el repositorio
        }

        // Agregar nueva reserva
        public void Add(Reserva entity)
        {
            try
            {
                _reservas.Add(entity); // Agregar reserva a la lista en memoria
                _persistenceService.Save(FILE_PATH, _reservas); // Guardar lista actualizada en archivo
            }
            catch (IOException ex)
            {
                throw new ApplicationException($"Error al guardar los datos de la reserva: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"{ex.Message}", ex);
            }
        }

        // Eliminar reserva por ID
        public void Delete(int id)
        {
            try
            {
                var reserva = _reservas.FirstOrDefault(r => r.Id == id);
                if (reserva != null)
                {
                    _reservas.Remove(reserva); // Remover la reserva de la lista
                    _persistenceService.Save(FILE_PATH, _reservas); // Guardar lista actualizada
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

        // Obtener todas las reservas
        public List<Reserva> GetAll()
        {
            try
            {
                return _persistenceService.Load<List<Reserva>>(FILE_PATH) ?? new List<Reserva>(); // Cargar desde archivo o retornar lista vacía
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al cargar las reservas: {ex.Message}", ex);
            }
        }

        // Obtener reserva por ID
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

        // Actualizar reserva existente
        public void Update(Reserva entity)
        {
            try
            {
                var reservaExistente = _reservas.FirstOrDefault(r => r.Id == entity.Id);
                if (reservaExistente != null)
                {
                    // Actualizar los valores de la reserva existente
                    reservaExistente.FechaInicio = entity.FechaInicio;
                    reservaExistente.FechaFin = entity.FechaFin;
                    reservaExistente.NroHabitacion = entity.NroHabitacion;
                    reservaExistente.Username = entity.Username;
                    reservaExistente.IdUsuario = entity.IdUsuario;

                    _persistenceService.Save(FILE_PATH, _reservas); // Guardar lista actualizada
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
            // Verificar si alguna reserva de la misma habitación se solapa con las fechas solicitadas
            return !_reservas.Any(r => r.NroHabitacion == nroHabitacion && (fechaInicio < r.FechaFin && fechaFin > r.FechaInicio));
        }
    }
}
