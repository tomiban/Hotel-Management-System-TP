using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Helpers
{
    public class FiltroFechaEventArgs : EventArgs
    {
        public DateTime FechaDesde { get; }
        public DateTime FechaHasta { get; }

        public FiltroFechaEventArgs(DateTime fechaDesde, DateTime fechaHasta)
        {
            FechaDesde = fechaDesde;
            FechaHasta = fechaHasta;
        }
    }
}
