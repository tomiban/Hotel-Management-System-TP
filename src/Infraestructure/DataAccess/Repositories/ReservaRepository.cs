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
            _reservas = GetAll(); 
        }

        public void Add(Reserva entity)
        {
            try
            {
                _reservas.Add(entity);
                _persistenceService.Save(FILE_PATH, _reservas);
            }
            catch (IOException ex)
            {

                throw new ApplicationException($"Error al guardar los datos de la reserva {ex.Message}: ", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al agregar reserva: {ex.Message}", ex);
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reserva> GetAll()
        {
           try
            {
                return _persistenceService.Load<List<Reserva>>(FILE_PATH) ?? new List<Reserva>();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al agregar usuario: {ex.Message}", ex);
            }
        }

        public Reserva GetById(int id)
        {
            throw new NotImplementedException();
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

        // Queremos asegurarnos de que una nueva reserva no solape con una reserva existente.Esto se traduce en dos casos de solapamiento:
        //La nueva reserva empieza antes de que termine la reserva existente.
        //La nueva reserva termina después de que empiece la reserva existente.
        public bool VerificarDisponibilidad(int nroHabitacion, DateTime fechaInicio, DateTime fechaFin)
        {
            return !_reservas
                .Any(r => r.NroHabitacion == nroHabitacion &&
                                             fechaInicio < r.FechaFin &&   // Verifica si la nueva reserva empieza antes de que termine una reserva existente.
                                             fechaFin > r.FechaInicio.AddDays(-1)); //Verifica si la nueva reserva termina después del día anterior al que comienza una reserva existente. se resta un dia a la existente para permitir que la nueva reserva termine el día antes de que comience una reserva existente
        }
    }
}
