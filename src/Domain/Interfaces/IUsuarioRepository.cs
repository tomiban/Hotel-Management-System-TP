


using Domain.Entities;


namespace Domain.Interfaces;

public interface IUsuarioRepository : IGenericRepository<Usuario>
{
    bool GetByUsername(string username);
    Usuario Authenticate(string username, string password);
}
