using Presentation.Views;
using PresentationLayer.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public interface IRegisterPresenter: IPresenter
    {
        IRegisterView GetRegisterView();
        void OnLoginRedirect(object? sender, EventArgs e);
        void OnRegister(object? sender, EventArgs e);
    }

}
