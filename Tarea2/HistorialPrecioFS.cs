using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class HistorialPrecioFS
    {
        #region Propiedades
        public int HistorialID { get; set; }
        public int ProductoID { get; set; }
        public string FechaCambio { get; set; }
        public int PrecioAntiguo { get; set; }
        public int PrecioNuevo { get; set; }
        #endregion

        #region Constructor
        public HistorialPrecioFS()
        {
            HistorialID = 0;
            ProductoID = 0;
            FechaCambio = string.Empty;
            PrecioAntiguo = 0;
            PrecioNuevo = 0;
        }
        #endregion
    }

}
