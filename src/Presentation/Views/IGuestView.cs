using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Views
{
    public interface IGuestView
    {
        void ShowMessage(string title, string message);

        void ShowView();
        void CloseView();
        void HideView();
    }
}
