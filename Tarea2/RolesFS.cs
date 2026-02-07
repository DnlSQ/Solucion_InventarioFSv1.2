using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class RolesFS
    {

        #region Propiedades 
        public int RolID { get; set; }

        public string NombreRol { get; set; }




        #endregion

        #region Constructor
        public RolesFS()
        {
            RolID = 0;
            NombreRol = string.Empty;

        }
        #endregion
    }
}
