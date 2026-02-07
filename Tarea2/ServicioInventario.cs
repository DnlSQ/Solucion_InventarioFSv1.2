using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class ServicioInventario
    {
        #region Propiedades 
        public int IDServicioInventario { get; set; }

        public int IDServicio { get; set; }

        public int IDInventario { get; set; }

        public int CantidadUsada { get; set; }


        #endregion

        #region Constructor
        public ServicioInventario()
        {
            IDServicioInventario = 0;
            IDServicio = 0;
            IDInventario = 0;
            CantidadUsada = 0;

        }
        #endregion
    }
}
