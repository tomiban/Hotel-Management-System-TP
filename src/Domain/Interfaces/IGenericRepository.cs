using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        void AddAsync(T entity);
        void DeleteAsync(int id);
        List<T> GetAllAsync();
        T GetByIdAsync(int id);
        void UpdateAsync(T entity);
    }
}