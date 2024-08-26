using System;
using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;
using MemoryPack;

namespace Domain.Entities
{
    [MemoryPackable]
    public partial class Usuario : IUsuario
    {
        private static int _contadorId = 0;

        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre es requerido")]
        //No puede contener numeros
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "El nombre solo puede contener letras")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder 50 caracteres")]
        public string Nombre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El apellido es requerido")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "El apellido solo puede contener letras")]
        [StringLength(50, ErrorMessage = "El apellido no puede exceder 50 caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La edad es requerida")]
        [Range(18, 100, ErrorMessage = "La edad debe estar entre 18 y 100 años")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El teléfono es requerido")]
        [StringLength(20, ErrorMessage = "El teléfono no puede exceder 20 caracteres")]
        public string Telefono { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre de usuario es requerido")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "El nombre de usuario debe tener entre 5 y 20 caracteres")]
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "La contraseña es requerida")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres")]
        public string Contraseña { get; set; }

        [Required(ErrorMessage = "El rol es requerido")]
        [EnumDataType(typeof(Role), ErrorMessage = "El rol seleccionado no es válido")]
        public Role Role { get; set; }

        public Usuario()
        {
            _contadorId++;
            Id = _contadorId;
        }
    }

    public enum Role
    {
        Admin,
        Guest
    }
}
