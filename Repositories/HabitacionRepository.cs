using GestionHotelWinForms.Models;
using GestionHotelWinForms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Repositories
{
    public class HabitacionRepository : IRepository<Habitacion>
    {
        private readonly IPersistenceService _persistenceService;
        private readonly string _filePath;
        private List<Habitacion> _habitaciones;

        public HabitacionRepository(IPersistenceService persistenceService, string filePath)
        {
            _persistenceService = persistenceService;
            _filePath = filePath;
            _habitaciones = GetAllAsync().Result; // Cargar habitaciones al iniciar el repositorio
        }

        public Task AddAsync(Habitacion entity)
        {
            try
            {
                _habitaciones.Add(entity);
                _persistenceService.SaveAsync(_filePath, _habitaciones);
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al añadir la habitacion: {ex.Message}");
                throw ex;
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
                _persistenceService.SaveAsync(_filePath, _habitaciones);
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la habitacion: {ex.Message}");
                throw ex;
            }
        }

        public Task<List<Habitacion>> GetAllAsync()
        {
            try
            {
                return Task.FromResult(_habitaciones);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las habitaciones: {ex.Message}");
                throw ex;
            }
        }

        public Task<Habitacion> GetByIdAsync(int id)
        {
            try
            {
                var habitacion = _habitaciones.FirstOrDefault(h => h.Id == id);
                if (habitacion == null)
                {
                    throw new NullReferenceException();
                }
                return Task.FromResult(habitacion);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener la habitacion: {ex.Message}");
                throw ex;
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


                _persistenceService.SaveAsync(_filePath, habitacion);
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar la habitacion: {ex.Message}");
                throw ex;
            }
        }
    }
}
