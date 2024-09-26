using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Utils
{
    public static class EventHelper
    {
        public static void RaiseEvent(object sender, EventHandler eventHandler, EventArgs e)
        {
            eventHandler?.Invoke(sender, e);
        }

        public static void RaiseEvent<TEventArgs>(object sender, EventHandler<TEventArgs> eventHandler, TEventArgs e) where TEventArgs : EventArgs
        {
            eventHandler?.Invoke(sender, e);
        }

        // Sobrecarga para eventos que manejan un tipo de dato simple como int
        public static void RaiseEvent(object sender, EventHandler<int> eventHandler, int e)
        {
            eventHandler?.Invoke(sender, e);
        }
    }
}
