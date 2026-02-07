using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class ProveedorFS
    {
        #region Propiedades 
        public int ProveedorID { get; set; }

        public string NombreEmpresa { get; set; }

        public string Contacto { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        #endregion

        #region Constructor
        public ProveedorFS()
        {
            ProveedorID = 0;
            NombreEmpresa = string.Empty;
            Contacto = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;

        }
        #endregion
    }
}
