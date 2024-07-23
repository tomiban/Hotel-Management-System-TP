using GestionHotelWinForms.Models;
using GestionHotelWinForms.Repositories;
using GestionHotelWinForms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotelWinForms.Presenters
{
    public class RegisterPresenter
    {
        private readonly IRegisterView _view;
        private readonly IRepository<Usuario> _userRepository;

        public RegisterPresenter( IRegisterView view, IRepository<Usuario> userRepository)
        {
            this._view = view;
            this._userRepository = userRepository;
            this._view.RegisterEvent += OnRegister;
        }

        private void OnRegister(object? sender, EventArgs e)
        {
            var existingUser = _userRepository.GetAll().FirstOrDefault(u => u.Username == _view.Username);

            if (existingUser != null)
            {
                _view.ShowMessage("El nombre de usuario ya existe.", "Error");
                return;
            }

            var newUser = new Usuario
            {
                Nombre = _view.Nombre,
                Apellido = _view.Apellido,
                Username = _view.Username,
                Contraseña = _view.Contraseña,
                Role = _view.Role
            };

            _userRepository.Add(newUser);

            _view.ShowMessage("Usuario registrado correctamente.", "Exito");
        }
    }
}