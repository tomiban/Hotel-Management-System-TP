using Domain.Entities;
using Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ApplicationLayer.Services
{
    public interface IUsuarioService
    {
        /// <summary>
        /// Elimina un usuario según su ID.
        /// </summary>
        /// <param name="id">ID del usuario a eliminar.</param>
        void DeleteUsuario(int id);

        /// <summary>
        /// Obtiene todos los usuarios registrados en el sistema.
        /// </summary>
        /// <returns>Lista de todos los usuarios.</returns>
        List<Usuario> GetAllUsuarios();

        /// <summary>
        /// Obtiene un usuario por su ID.
        /// </summary>
        /// <param name="id">ID del usuario a obtener.</param>
        /// <returns>Usuario con el ID correspondiente.</returns>
        Usuario GetUsuarioById(int id);

        /// <summary>
        /// Actualiza la información de un usuario.
        /// </summary>
        /// <param name="usuario">Usuario a actualizar.</param>
        void UpdateUsuario(Usuario usuario);


    }
}