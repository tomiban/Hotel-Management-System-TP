using GestionHotelWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Repositories
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
