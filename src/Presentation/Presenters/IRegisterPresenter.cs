using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public interface IRegisterPresenter
    {
        
        void OnRegister(object? sender, EventArgs e);
        void OnLoginRedirect(object? sender, EventArgs e);
    }

}
