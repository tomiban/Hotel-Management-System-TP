using GestionHotelWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Repositories
{
    public interface IUsuarioRepository: IRepository<Usuario>
    {
          Usuario GetByUsername(string username);
          public bool Authenticate(string username, string password);
    }
}
