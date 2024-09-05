using Infraestructure.DataAccess.Serialization;
using MemoryPack;
using System;
using System.IO;

namespace Infraestructure.DataAccess.Serialization
{
    public class BinarySerialization : IBinarySerialization
    {
        public T? Load<T>(string filePath) where T : class
        {
            if (!File.Exists(filePath))
            {
                return default(T);
            }
            try
            {
                byte[] bytes;
                using (FileStream sourceStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    bytes = new byte[sourceStream.Length];
                    sourceStream.Read(bytes, 0, (int)sourceStream.Length);
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

        public bool Save<T>(string filePath, T data) where T : class
        {
            try
            {
                byte[] bytes = MemoryPackSerializer.Serialize(data);
                using (FileStream destinationStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    destinationStream.Write(bytes, 0, bytes.Length);
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
