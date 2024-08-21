using System.ComponentModel.DataAnnotations;
using Application.Services;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Validation.ModelDataAnnotationCheck;
using Moq;
using Xunit;

namespace Services.Tests
{
    public class HabitacionServicesValidationTests
    {

        [Fact]
        public void ValidateModel_ShouldInvokeValidationCheck()
        {
            // Arrange
            var habitacionMock = new Mock<IHabitacion>(); // Creamos un mock de IHabitacion
            var validationMock = new Mock<IModelDataAnnotationCheck>(); // Creamos un mock de IModelDataAnnotationCheck
            var habitacionService = new HabitacionServices(null, validationMock.Object); // Inicializamos el servicio

            // Act
            habitacionService.ValidateModel(habitacionMock.Object);

            // Assert
            validationMock.Verify(v => v.ValidateModel(habitacionMock.Object), Times.Once);
        }

        [Fact]
        public void ValidateModel_ShouldNotThrowException_WhenModelIsValid()
        {
            // Arrange
            var habitacion = new Habitacion
            {
                Id = 1,
                NroHabitacion = 101,
                TipoHabitacion = TipoHabitacion.Premium,
                PrecioPorNoche = 200,
                CantidadPersonas = 2,
                Disponible = true,
            };
            var validator = new ModelDataAnnotationCheck();

            // Act & Assert
            validator.ValidateModel(habitacion); // No debería lanzar excepción
        }

        [Fact]
        public void ValidateModel_ShouldThrowValidationException_WhenModelIsInvalid()
        {
            // Arrange
            var habitacion = new Habitacion
            {
                NroHabitacion = -1,  // Inválido: número de habitación negativo
                TipoHabitacion = (TipoHabitacion)543, // Inválido: valor fuera del rango de la enumeración
                PrecioPorNoche = -100,  // Inválido: precio negativo
                CantidadPersonas = 0    // Inválido: cantidad de personas menor a 1
                
            };
            var validator = new ModelDataAnnotationCheck();

            // Act & Assert
            var exception = Assert.Throws<ValidationException>(() => validator.ValidateModel(habitacion));
            Assert.Contains("El número de habitación debe ser positivo.", exception.Message);
            Assert.Contains("El tipo de habitación no es válido.", exception.Message);
            Assert.Contains("El precio por noche debe ser positivo.", exception.Message);
            Assert.Contains("La cantidad de personas debe ser al menos 1.", exception.Message);
         
        }
    }
}
