using Domain.Entities;


namespace Presentation.Views
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
