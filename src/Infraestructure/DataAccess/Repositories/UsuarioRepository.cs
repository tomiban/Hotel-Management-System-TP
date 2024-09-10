using Domain.Entities;
using Domain.Interfaces;
using Infraestructure.DataAccess.Serialization;
using InfraestructureLayer.Helpers;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Infraestructure.DataAccess.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string FILE_PATH;
        private readonly string FILE_NAME = "usuarios";
        private readonly IBinarySerialization _persistenceService;
        private List<Usuario> _usuarios;

        public UsuarioRepository(IBinarySerialization persistenceService)
        {
            FILE_PATH = FileHelper.GetFilePath(FILE_NAME);
            _persistenceService = persistenceService;
            _usuarios = GetAll(); // Cargar usuarios al iniciar el repositorio
        }

        public void   Add(Usuario usuario)
        {
            try
            {
                _usuarios.Add(usuario);
                 _persistenceService.Save(FILE_PATH, _usuarios);

            }
            catch (IOException ex)
            {

                throw new ApplicationException($"Error al guardar los datos del usuario {ex.Message}: ", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al agregar usuario: {ex.Message}", ex);
            }
        }

        public List<Usuario> GetAll()
        {
            try
            {
                 return  _persistenceService.Load<List<Usuario>>(FILE_PATH) ?? new List<Usuario>();
            }

            catch (Exception ex)
            {
                throw new ApplicationException($"Error al obtener usuarios: {ex.Message}", ex);
            }
        }

        public Usuario GetById(int id)
        {
            try
            {
                var usuario = _usuarios.FirstOrDefault(u => u.Id == id);
                if (usuario == null)
                {
                    throw new NullReferenceException();
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al obtener usuario: {ex.Message}", ex);
            }
        }

        public void Update(Usuario usuario)
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

                 _persistenceService.Save(FILE_PATH, _usuarios);
            }
            catch (IOException ex)
            {

                throw new ApplicationException($"Error al guardar los datos del usuario {ex.Message}: ", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al actualizar usuario: {ex.Message}", ex);
            }
        }

        public  void  Delete(int id)
        {
            try
            {
                var usuario = _usuarios.FirstOrDefault(u => u.Id == id);
                if (usuario == null)
                {
                    throw new NullReferenceException();
                }

                _usuarios.Remove(usuario);
                 _persistenceService.Save(FILE_PATH, _usuarios);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al eliminar usuario: {ex.Message}", ex);
            }
        }

        // Método específico para buscar un usuario por username
        public bool GetByUsername(string username)
        {
            try
            {
                return _usuarios.Any(u => u.Username == username);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al obtener usuario: {ex.Message}", ex);
            }
        }

        public Usuario Authenticate(string username, string password)
        {
            try
            {
                return _usuarios.FirstOrDefault(u => u.Username == username && u.Contraseña == password);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al autenticar usuario: {ex.Message}", ex);
            }
        }

    }
}
