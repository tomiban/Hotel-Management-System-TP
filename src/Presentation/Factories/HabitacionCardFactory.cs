using Domain.Entities;
using PresentationLayer.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Factories
{
    public class HabitacionCardFactory
    {
        // Método estático que crea una instancia de HabitacionCard
        public static HabitacionCard CreateHabitacionCard(Habitacion habitacion)
        {
            if (habitacion == null)
                throw new ArgumentNullException(nameof(habitacion));

            // Crear la tarjeta con base en la habitación recibida
            HabitacionCard card = new HabitacionCard(habitacion);

       

            return card;
        }
    }
}
