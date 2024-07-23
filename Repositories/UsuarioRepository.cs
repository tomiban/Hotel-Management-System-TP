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
    public class UsuarioRepository : IRepository<Usuario>
    {
        private readonly IPersistenceService _persistenceService;
        private readonly string filePath = "usuarios.bin";
        private List<Usuario> usuarios;

        public UsuarioRepository(IPersistenceService persistenceService)
        {
            this._persistenceService = persistenceService;
            usuarios = _persistenceService.LoadAsync<List<Usuario>>(filePath).Result ?? [];
        }

        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }

        public Usuario GetById(int id)
        {
            return usuarios.FirstOrDefault(u => u.Id == id);
        }

        public void Add(Usuario entity)
        {
            usuarios.Add(entity);
            _persistenceService.SaveAsync(filePath, usuarios);
        }


        public void Update(Usuario entity)
        {
           var item = usuarios.FirstOrDefault(u => u.Id == entity.Id);
            if (entity == null)
            {
                throw new NullReferenceException();
            }
            _persistenceService.SaveAsync(filePath, item);

        }

        public void Delete(Usuario entity)
        {
            usuarios.Remove(entity);
            _persistenceService.SaveAsync(filePath, usuarios);
        }
    }
}
