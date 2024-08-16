using GestionHotelWinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHotelWinForms.Views
{
    public interface ICrearEditarHabitacion
    {

        int Id { get;  }
        int NroHabitacion { get; }
        TipoHabitacion TipoHabitacion { get;  }
        bool Disponible { get;  }
        int PrecioPorNoche { get;  }

        event EventHandler SaveEvent;
        event EventHandler BackEvent;
    }
}
