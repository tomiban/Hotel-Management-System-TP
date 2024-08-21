using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;
using MemoryPack;

namespace Domain.Entities
{
    [MemoryPackable]
    public partial class Habitacion : IHabitacion
    {
        private static int _contadorId = 0;
        public int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "El número de habitación debe ser positivo.")]
        public int NroHabitacion { get; set; }

        [Required(ErrorMessage = "El tipo de habitación es requerido.")]
        [EnumDataType(typeof(TipoHabitacion), ErrorMessage = "El tipo de habitación no es válido.")]
        public TipoHabitacion TipoHabitacion { get; set; }


        public bool Disponible { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "El precio por noche debe ser positivo.")]
        public int PrecioPorNoche { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La cantidad de personas debe ser al menos 1.")]
        public int CantidadPersonas { get; set; }
      

        public Habitacion()
        {
            _contadorId++;
            Id = _contadorId;
        }
    }

    public enum TipoHabitacion
    {
        Default = 0,
        Economic = 1,
        Standard = 2,
        Premium = 3
    }
}
