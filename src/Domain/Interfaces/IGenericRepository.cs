using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
        void Update(T entity);
    }
}