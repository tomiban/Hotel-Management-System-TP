using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Presenters
{
    public interface ILoginPresenter
    {
        ILoginView GetLoginView();
        void OnLogin(object? sender, EventArgs e);
        void OnRegisterRedirect(object? sender, EventArgs e);
        void ShowLoginView();
    }

}
