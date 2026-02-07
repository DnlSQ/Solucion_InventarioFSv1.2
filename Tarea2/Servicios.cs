using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class Servicios
    {
        #region Propiedades 
        public int IDServicio { get; set; }

        public string S_Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Duracion { get; set; }


        #endregion

        #region Constructor
        public Servicios()
        {
            IDServicio = 0;
            S_Nombre = string.Empty;
            Descripcion = string.Empty;
            Duracion = string.Empty;

        }
        #endregion


    }
}
