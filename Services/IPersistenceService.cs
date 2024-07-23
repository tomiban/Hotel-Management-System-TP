using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Services
{
    public interface IPersistenceService
    {
        Task<bool> SaveAsync<T>(string filePath, T data);
        Task<T> LoadAsync<T>(string filePath);
    }
}