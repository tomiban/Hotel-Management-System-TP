using GestionHotelWinForms.Models;
using GestionHotelWinForms.Services;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GestionHotelWinForms.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IPersistenceService _persistenceService;
        private readonly string _filePath;
        private List<Usuario> _usuarios;

        public UsuarioRepository(IPersistenceService persistenceService, string filePath)
        {
            _persistenceService = persistenceService;
            _filePath = filePath;
            _usuarios = GetAllAsync().Result; // Cargar usuarios al iniciar el repositorio
        }

        public async Task AddAsync(Usuario usuario)
        {
            try
            {
                _usuarios.Add(usuario);
                await _persistenceService.SaveAsync(_filePath, _usuarios);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al añadir el usuario: {ex.Message}");
                throw; // Relanza la excepción para que pueda ser manejada a nivel superior
            }
        }

        public async Task<List<Usuario>> GetAllAsync()
        {
            try
            {
                return await _persistenceService.LoadAsync<List<Usuario>>(_filePath) ?? new List<Usuario>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los usuarios: {ex.Message}");
                throw; // Relanza la excepción para que pueda ser manejada a nivel superior
            }
        }

        public async Task<Usuario> GetByIdAsync(int id)
        {
            try
            {
                var usuario = _usuarios.FirstOrDefault(u => u.Id == id);
                if (usuario == null)
                {
                    throw new NullReferenceException();
                }
                return await Task.FromResult(usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el usuario: {ex.Message}");
                throw; // Relanza la excepción para que pueda ser manejada a nivel superior
            }
        }

        public async Task UpdateAsync(Usuario usuario)
        {
            try
            {
                var item = _usuarios.FirstOrDefault(u => u.Id == usuario.Id);
                if (item == null)
                {
                    throw new NullReferenceException();
                }
                usuario.Nombre = item.Nombre;
                usuario.Username = item.Username;
                usuario.Contraseña = item.Contraseña;
                usuario.Role = item.Role;
                usuario.Telefono = item.Telefono;
                
                await _persistenceService.SaveAsync(_filePath, _usuarios);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el usuario: {ex.Message}");
                throw; // Relanza la excepción para que pueda ser manejada a nivel superior
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var usuario = _usuarios.FirstOrDefault(u => u.Id == id);
                if (usuario == null)
                {
                    throw new NullReferenceException();
                }

                _usuarios.Remove(usuario);
                await _persistenceService.SaveAsync(_filePath, _usuarios);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el usuario: {ex.Message}");
                throw; // Relanza la excepción para que pueda ser manejada a nivel superior
            }
        }

        // Método específico para buscar un usuario por username
        public async Task<Usuario?> GetByUsernameAsync(string username)
        {
            try
            {
                var usuario = _usuarios.FirstOrDefault(u => u.Username == username);
                return await Task.FromResult(usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el usuario por username: {ex.Message}");
                throw; // Relanza la excepción para que pueda ser manejada a nivel superior
            }
        }
    }
}
