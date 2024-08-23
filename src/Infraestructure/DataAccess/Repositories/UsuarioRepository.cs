using Domain.Entities;
using Domain.Interfaces;
using Infraestructure.DataAccess.Serialization;
using System.Runtime.CompilerServices;


namespace Infraestructure.DataAccess.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        const string FOLDER = ".\\Data";
        const string FILE_NAME = "usuarios.bin";

        string FILE_PATH = Path.Combine("Data", "usuarios.bin");
        private readonly IBinarySerialization _persistenceService;
        
        private List<Usuario> _usuarios;

        public UsuarioRepository(IBinarySerialization persistenceService)
        {
            if (!Directory.Exists(FOLDER))
            {
                Directory.CreateDirectory(FOLDER);
            }
            _persistenceService = persistenceService;
            _usuarios = GetAllAsync().Result; // Cargar usuarios al iniciar el repositorio
        }

        public async Task AddAsync(Usuario usuario)
        {
            try
            {
                _usuarios.Add(usuario);
                await _persistenceService.SaveAsync(FILE_PATH, _usuarios);

            }
            catch (IOException ex)
            {

                throw new ApplicationException("Error al guardar los datos. Intente nuevamente.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding user: {ex.Message}");
                throw new ApplicationException($"Error adding user: {ex.Message}", ex);
            }
        }

        public async Task<List<Usuario>> GetAllAsync()
        {
            try
            {
                return await _persistenceService.LoadAsync<List<Usuario>>(FILE_PATH) ?? new List<Usuario>();
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error adding user: {ex.Message}");
                throw new ApplicationException($"Error adding user: {ex.Message}", ex);
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
                Console.WriteLine($"Error adding user: {ex.Message}");
                throw new ApplicationException($"Error adding user: {ex.Message}", ex);
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

                await _persistenceService.SaveAsync(FILE_PATH, _usuarios);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating user: {ex.Message}");
                throw new ApplicationException($"Error updating user: {ex.Message}", ex);
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
                await _persistenceService.SaveAsync(FILE_PATH, _usuarios);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting user: {ex.Message}");
                throw new ApplicationException($"Error deleting user: {ex.Message}", ex);
            }
        }

        // Método específico para buscar un usuario por username
        public Usuario GetByUsername(string username)
        {
            try
            {
                return _usuarios.FirstOrDefault(u => u.Username == username);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error user: {ex.Message}");
                throw new ApplicationException($"Error user: {ex.Message}", ex);
            }
        }

        public bool Authenticate(string username, string password)
        {
            try
            {
                return _usuarios.Any(u => u.Username == username && u.Contraseña == password);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error authenticate user: {ex.Message}");
                throw new ApplicationException($"Error authenticate user: {ex.Message}", ex);
            }
        }

    }
}
