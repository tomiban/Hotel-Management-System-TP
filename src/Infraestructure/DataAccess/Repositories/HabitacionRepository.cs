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
            _habitaciones = GetAll();
        }

        public void Add(Habitacion entity)
        {
            try
            {
                _habitaciones.Add(entity);
                _persistenceService.Save(FILE_PATH, _habitaciones);

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

        public void Delete(int id)
        {
            try
            {
                var habitacion = _habitaciones.FirstOrDefault(h => h.Id == id);
                if (habitacion == null)
                {
                    throw new NullReferenceException();
                }
                _habitaciones.Remove(habitacion);
                _persistenceService.Save(FILE_PATH, _habitaciones);

            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"Error al eliminar la habitacion: {ex.Message}", ex);
            }
        }

        public List<Habitacion> GetAll()
        {
            try
            {
                return _persistenceService.Load<List<Habitacion>>(FILE_PATH) ?? [];
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"Error al obtener las habitaciones: {ex.Message}", ex);
            }
        }

        public Habitacion GetById(int id)
        {
            try
            {
                return _habitaciones.FirstOrDefault(h => h.Id == id);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException($"Error al obtener la habitacion: {ex.Message}", ex);
            }
        }

        public void Update(Habitacion entity)
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

                 _persistenceService.Save(FILE_PATH, habitacion);
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
