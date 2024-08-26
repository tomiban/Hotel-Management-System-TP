using Domain.Entities;
using Services.Services.ReservaServices;


namespace Infraestructure.DataAccess.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        public Task AddAsync(Reserva entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Reserva>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Reserva> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Reserva entity)
        {
            throw new NotImplementedException();
        }
    }
}
