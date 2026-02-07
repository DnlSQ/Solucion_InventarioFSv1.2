using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class DetalleOrdenVentaFS
    {
        #region Propiedades
        public int DetalleID { get; set; }
        public int VentaID { get; set; }
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
        public int PrecioUnitario { get; set; }
        public int TotalLinea { get; set; }
        #endregion

        #region Constructor
        public DetalleOrdenVentaFS()
        {
            DetalleID = 0;
            VentaID = 0;
            ProductoID = 0;
            Cantidad = 0;
            PrecioUnitario = 0;
            TotalLinea = 0;
        }
        #endregion
    }

}
