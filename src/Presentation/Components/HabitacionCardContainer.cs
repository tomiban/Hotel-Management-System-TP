using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Components
{
    public class HabitacionCardContainer : FlowLayoutPanel
    {
        public HabitacionCardContainer()
        {
            this.Dock = DockStyle.Fill;
            this.AutoScroll = true;  // Para mostrar el scroll automáticamente si hay muchas tarjetas
            this.WrapContents = true;  // Las tarjetas se acomodarán automáticamente
            this.FlowDirection = FlowDirection.LeftToRight;
        }
    }
}
