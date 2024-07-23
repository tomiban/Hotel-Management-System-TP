using MemoryPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Services
{
    public class MemoryPackService : IPersistenceService
    {
        public async Task<T> LoadAsync<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return default;
            }

            byte[] bytes;
            using (FileStream sourceStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: 4096, useAsync: true))
            {
                bytes = new byte[sourceStream.Length];
                await sourceStream.ReadAsync(bytes, 0, (int)sourceStream.Length);
            }

            return MemoryPackSerializer.Deserialize<T>(bytes);
        }

        public async Task<bool> SaveAsync<T>(string filePath, T data)
        {
            try
            {
                byte[] bytes = MemoryPackSerializer.Serialize(data);
                using (FileStream destinationStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: 4096, useAsync: true))
                {
                    await destinationStream.WriteAsync(bytes, 0, bytes.Length);
                }
                return true; // Return true if the operation was successful
            }
            catch (Exception ex)
            {
                // Handle the exception here if needed
                Console.WriteLine($"An error occurred while saving the file: {ex.Message}");
                return false; // Return false if an exception occurred
            }
        }
    }
}
