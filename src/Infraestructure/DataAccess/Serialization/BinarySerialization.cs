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
                Console.WriteLine("El archivo no existe.");
                return default(T);
            }

            try
            {
                byte[] bytes;
                using (FileStream sourceStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    // Leer todos los bytes relevantes del archivo
                    bytes = new byte[sourceStream.Length];
                    sourceStream.Read(bytes, 0, (int)sourceStream.Length);
                }

                Console.WriteLine($"Cargando datos de tamaño: {bytes.Length} bytes desde el archivo {filePath}");

                // Deserializar los datos desde el byte array
                return MemoryPackSerializer.Deserialize<T>(bytes);
            }
            

            catch (MemoryPackSerializationException ex)
            {
                throw new Exception($"Error de serialización de MemoryPack: {ex.Message}");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar los datos: {ex.Message}");
                throw;
            }
        }

        public bool Save<T>(string filePath, T data) where T : class
        {
            try
            {
                // Serializar los datos
                byte[] bytes = MemoryPackSerializer.Serialize(data);

                // Imprimir el tamaño de los datos serializados
                Console.WriteLine($"Guardando datos de tamaño: {bytes.Length} bytes en el archivo {filePath}");

                // Guardar los datos en el archivo
                using (FileStream destinationStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    destinationStream.Write(bytes, 0, bytes.Length);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar los datos: {ex.Message}");
                throw;
            }
        }
    }
}
