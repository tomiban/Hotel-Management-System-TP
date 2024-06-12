using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MemoryPack;

namespace GestionHotelWinForms.Models
{
    [MemoryPackable]
    public partial class Usuario
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es requerido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El nombre de usuario es requerido")]
        public string Username { get; set; }
        [Required(ErrorMessage = "La contraseña es requerida")]
        public string Contraseña { get; set; }
        [EnumDataType(typeof(Role), ErrorMessage = "El rol es requerido")]
        public Role Role { get; set; }
    }

    public enum Role
    {
        Admin,
        User
    }
}
