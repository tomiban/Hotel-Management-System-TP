using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Utils
{
    public interface IPresenter
    {
        void ShowView();  // Mostrar la vista asociada con el presentador
        void HideView();  // Ocultar la vista asociada con el presentador

    }

}
