using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Events
{
    public class FiltroFechaEventArgs : EventArgs
    {
        public DateTime FechaDesde { get; }
        public DateTime FechaHasta { get; }
        public string CategoriaSeleccionada { get; }

        public FiltroFechaEventArgs(DateTime fechaDesde, DateTime fechaHasta, string categoriaSeleccionada)
        {
            FechaDesde = fechaDesde;
            FechaHasta = fechaHasta;
            CategoriaSeleccionada = categoriaSeleccionada;
        }
    }

}
