using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class Proveedor
    {
        #region Propiedades 
        public int IDProveedor { get; set; }

        public string P_Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Telefono { get; set; }


        #endregion

        #region Constructor
        public Proveedor()
        {
            IDProveedor = 0;
            P_Nombre = string.Empty;
            Descripcion = string.Empty;
            Telefono = string.Empty;

        }
        #endregion


    }
}
