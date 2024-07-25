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
        private readonly IUsuarioRepository _userRepository;

        public RegisterPresenter( IRegisterView view, IUsuarioRepository userRepository)
        {
            this._view = view;
            this._userRepository = userRepository;
            this._view.RegisterEvent += OnRegister;
        }

        private async void OnRegister(object? sender, EventArgs e)
        {
            var existingUser = await _userRepository.GetByUsernameAsync(_view.Username);

            if (existingUser == true)
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

            _userRepository.AddAsync(newUser);

            _view.ShowMessage("Usuario registrado correctamente.", "Exito");
        }
    }
}