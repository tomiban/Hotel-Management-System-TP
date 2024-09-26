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
            if (eventHandler != null)
            {
                eventHandler?.Invoke(sender, e);
            }
        }

        public static void RaiseEvent<T>(object sender, EventHandler<T> eventHandler, T e)
        {
            if (eventHandler != null)
            {
                eventHandler?.Invoke(sender, e);
            }
        }
    }

}
