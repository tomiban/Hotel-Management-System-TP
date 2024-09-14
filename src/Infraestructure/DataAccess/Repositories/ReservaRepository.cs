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
                throw new ApplicationException($"{ex.Message}", ex);
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

        public void Update(Reserva entity)
        {
            throw new NotImplementedException();
        }
    }
}
