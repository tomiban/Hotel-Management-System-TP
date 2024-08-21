using Domain.Entities;

namespace Domain.Interfaces
{ 
    public interface IUsuario
    {
        string Apellido { get; set; }
        string Contraseña { get; set; }
        int Edad { get; set; }
        int Id { get; set; }
        string Nombre { get; set; }
        Role Role { get; set; }
        int Telefono { get; set; }
        string Username { get; set; }
    }
}