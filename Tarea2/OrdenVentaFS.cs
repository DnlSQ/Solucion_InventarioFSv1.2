using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class OrdenVentaFS
    {
        #region Propiedades 
        public int VentaID { get; set; }

        public string FechaVenta { get; set; }

        public int ClienteID { get; set; }

        public int Total { get; set; }

        public string Estado { get; set; }

        public int EmpleadoID { get; set; }


        #endregion

        #region Constructor
        public OrdenVentaFS()
        {
            VentaID = 0;
            FechaVenta = string.Empty;
            ClienteID = 0;
            Total =  0;
            Estado = string.Empty;
            EmpleadoID = 0;

        }
        #endregion
    }
}
