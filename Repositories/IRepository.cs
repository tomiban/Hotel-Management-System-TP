using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Update(T entity);
    }
}