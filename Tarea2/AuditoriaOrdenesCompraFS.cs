using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class AuditoriaOrdenesCompraFS
    {
        #region Propiedades
        public int AuditoriaID { get; set; }
        public int OrdenID { get; set; }
        public string FechaOrden { get; set; }
        public int ProveedorID { get; set; }
        public string Total { get; set; }
        public string Estado { get; set; }
        public int EmpleadoID { get; set; }
        public string FechaAuditoria { get; set; }
        public string Accion { get; set; }
        #endregion

        #region Constructor
        public AuditoriaOrdenesCompraFS()
        {
            AuditoriaID = 0;
            OrdenID = 0;
            FechaOrden = string.Empty;
            ProveedorID = 0;
            Total = string.Empty;
            Estado = string.Empty;
            EmpleadoID = 0;
            FechaAuditoria = string.Empty;
            Accion = string.Empty;
        }
        #endregion
    }

}
