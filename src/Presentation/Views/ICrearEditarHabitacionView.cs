using Domain.Entities;

namespace Presentation.Views
{
    public interface ICrearEditarHabitacionView
    {
        int Id { get; }
        bool Disponible { get; }
        int NroHabitacion { get; }
        double PrecioPorNoche { get; }
        TipoHabitacion TipoHabitacion { get; }
         int CantidadPersonas
        {
            get;
          
        }

        void ShowMessage(string title, string message);
    

        event EventHandler SaveEvent;
        event EventHandler NavigateToAdminView;


        void CloseView();
        void HideView();
        void ShowView();
    }
}