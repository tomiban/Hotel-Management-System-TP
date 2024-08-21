


using Domain.Entities;


namespace Domain.Interfaces;

public interface IUsuarioRepository : IGenericRepository<Usuario>
{
    Usuario GetByUsername(string username);
    public bool Authenticate(string username, string password);
}
