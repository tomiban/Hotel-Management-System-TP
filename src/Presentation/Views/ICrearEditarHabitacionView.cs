using Domain.Entities;

namespace Presentation.Views
{
    public interface ICrearEditarHabitacionView
    {
        int NroHabitacion { get; }
        bool Disponible { get; }
        decimal  PrecioPorNoche { get; }
        TipoHabitacion TipoHabitacion { get; }
        string Descripcion { get; }
        int Capacidad{ get; }

        void ShowMessage(string title, string message);
    

        event EventHandler SaveEvent;
        event EventHandler NavigateToAdminView;

        void LimpiarCampos();
        void CloseView();
        void HideView();
        void ShowView();
    }
}