using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class ObtenerClientesOrdenesVentaFS
    {
        #region Propiedades 
        public int ClienteID { get; set; }

        public string C_Nombre { get; set; }

        public string C_Apellidos { get; set; }

        public string C_Telefono { get; set; }

        public int VentaID { get; set; }

        public string FechaVenta { get; set; }

        public int VentaTotal { get; set; }

        #endregion

        #region Constructor
        public ObtenerClientesOrdenesVentaFS()
        {
            ClienteID = 0;
            C_Nombre = string.Empty;
            C_Apellidos = string.Empty;
            C_Telefono = string.Empty;
            VentaID = 0;
            FechaVenta = string.Empty;
            VentaTotal = 0;

        }
        #endregion

    }
}
