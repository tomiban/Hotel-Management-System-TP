using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Services
{
    public interface IPersistenceService
    {
        /// <summary>
        /// Carga los datos desde un archivo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo de datos a cargar.</typeparam>
        /// <param name="filePath">Ruta del archivo desde el cual se cargará la información.</param>
        /// <returns>Los datos deserializados del archivo, o null si el archivo no existe o hay un error.</returns>
        Task<T?> LoadAsync<T>(string filePath) where T : class;

        /// <summary>
        /// Guarda los datos en un archivo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo de datos a guardar.</typeparam>
        /// <param name="filePath">Ruta del archivo en el cual se guardarán los datos.</param>
        /// <param name="data">Datos a serializar y guardar.</param>
        /// <returns>True si los datos se guardaron correctamente, de lo contrario, false.</returns>
        Task<bool> SaveAsync<T>(string filePath, T data) where T : class;
    }

}