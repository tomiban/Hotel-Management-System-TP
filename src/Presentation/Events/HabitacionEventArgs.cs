using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Events
{
    public class HabitacionEventArgs : EventArgs
    {
        public Habitacion Habitacion { get; private set; }

        public HabitacionEventArgs(Habitacion habitacion)
        {
            Habitacion = habitacion;
        }
    }

}
