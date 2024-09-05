using Domain.Entities;
using Domain.Interfaces;
using Infraestructure.DataAccess.Serialization;
using InfraestructureLayer.Helpers;

namespace Infraestructure.DataAccess.Repositories
{
    public class HabitacionRepository : IHabitacionRepository
    {
        private string FILE_PATH;
        private readonly string FILE_NAME = "habitaciones";
        private readonly IBinarySerialization _persistenceService;
        private List<Habitacion> _habitaciones;

        public HabitacionRepository(IBinarySerialization persistenceService)
        {
            FILE_PATH = FileHelper.GetFilePath(FILE_NAME);
            _persistenceService = persistenceService;
            _habitaciones = GetAllAsync().Result ?? []; 
        }

        public Task AddAsync(Habitacion entity)
        {
            try
            {
                _habitaciones.Add(entity);
                _persistenceService.SaveAsync(FILE_PATH, _habitaciones);
                return Task.CompletedTask;
            }
            catch (IOException ex)
            {
                throw new IOException($"Error al guardar los datos de la habitacion: {ex.Message}: ", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al añadir la habitacion: {ex.Message}");
                throw new ApplicationException($"Error al añadir la habitacion: {ex.Message}", ex);
            }

        }

        public Task DeleteAsync(int id)
        {
            try
            {
                var habitacion = _habitaciones.FirstOrDefault(h => h.Id == id);
                if (habitacion == null)
                {
                    throw new NullReferenceException();
                }
                _habitaciones.Remove(habitacion);
                _persistenceService.SaveAsync(FILE_PATH, _habitaciones);
                return Task.CompletedTask;
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"Error al eliminar la habitacion: {ex.Message}", ex);
            }
        }

        public async Task<List<Habitacion>> GetAllAsync()
        {
            try
            {
                return await _persistenceService.LoadAsync<List<Habitacion>>(FILE_PATH) ?? new List<Habitacion>();

             
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"Error al obtener las habitaciones: {ex.Message}", ex);
            }
        }

        public Task<Habitacion> GetByIdAsync(int id)
        {
            try
            {
                var habitacion = _habitaciones.FirstOrDefault(h => h.Id == id);
                return Task.FromResult(habitacion);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"Error al obtener la habitacion: {ex.Message}", ex);
            }
        }

        public Task UpdateAsync(Habitacion entity)
        {
            try
            {
                var habitacion = _habitaciones.FirstOrDefault(h => h.Id == entity.Id);
                if (habitacion == null)
                {
                    throw new NullReferenceException();
                }

                habitacion.NroHabitacion = entity.NroHabitacion;
                habitacion.PrecioPorNoche = entity.PrecioPorNoche;
                habitacion.TipoHabitacion = entity.TipoHabitacion;
                habitacion.Disponible = entity.Disponible;


                _persistenceService.SaveAsync(FILE_PATH, habitacion);
                return Task.CompletedTask;
            }
            catch (IOException ex)
            {
                throw new IOException($"Error al guardar los datos de la habitacion: {ex.Message}: ", ex);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"Error al actualizar la habitacion: {ex.Message}", ex);
            }
        }
    }
}
