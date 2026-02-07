using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class ProductoFS
    {
        #region Propiedades 
        public int ProductoID { get; set; }

        public string P_Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Precio { get; set; }

        public int Stock { get; set; }

        public string Categoria { get; set; }

        #endregion

        #region Constructor
        public ProductoFS()
        {
            ProductoID = 0;
            P_Nombre = string.Empty;
            Descripcion = string.Empty;
            Precio = string.Empty;
            Stock =0;
            Categoria = string.Empty;

        }
        #endregion
    }
}
