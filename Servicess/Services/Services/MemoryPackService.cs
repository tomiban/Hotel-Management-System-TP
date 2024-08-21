using MemoryPack;
using System;
using System.IO;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Services
{
    public class MemoryPackService : IPersistenceService
    {
        public async Task<T?> LoadAsync<T>(string filePath) where T : class
        {
            if (!File.Exists(filePath))
            {
                return default; // Retorna null si el archivo no existe
            }

            try
            {
                byte[] bytes;
                using (FileStream sourceStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: 4096, useAsync: true))
                {
                    bytes = new byte[sourceStream.Length];
                    await sourceStream.ReadAsync(bytes, 0, (int)sourceStream.Length);
                }

                return MemoryPackSerializer.Deserialize<T>(bytes);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones específicas o generales
                Console.WriteLine($"Error al cargar el archivo: {ex.Message}");
                throw; // Relanza la excepción para que el llamado pueda manejarla si es necesario
            }
        }

        public async Task<bool> SaveAsync<T>(string filePath, T data) where T : class
        {
            try
            {
                byte[] bytes = MemoryPackSerializer.Serialize(data);
                using (FileStream destinationStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: 4096, useAsync: true))
                {
                    await destinationStream.WriteAsync(bytes, 0, bytes.Length);
                }
                return true;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones específicas o generales
                Console.WriteLine($"Error al guardar el archivo: {ex.Message}");
                throw; // Relanza la excepción para que el llamado pueda manejarla si es necesario
            }
        }
    }
}
