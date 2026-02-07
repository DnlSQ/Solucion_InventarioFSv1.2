using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class Inventario
    {

        #region Propiedades 
        public int IDInventario { get; set; }

        public string I_Nombre { get; set; }

        public int Cantidad { get; set; }

        public string UnidadMedida { get; set; }

        public string Descripcion { get; set; }

        public int ProveedorId { get; set; }

        

        #endregion

        #region Constructor
        public Inventario()
        {
            IDInventario = 0;
            I_Nombre = string.Empty;
            Cantidad = 0;
            UnidadMedida = string.Empty;
            Descripcion = string.Empty;
            ProveedorId = 0;

        }
        #endregion

    }
}
