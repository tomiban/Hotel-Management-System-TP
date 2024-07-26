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
          Task<bool> GetByUsernameAsync(string username);
    }
}
