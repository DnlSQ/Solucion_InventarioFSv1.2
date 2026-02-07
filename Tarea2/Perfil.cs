using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class Perfil
    {
        #region Propiedades

        public int ID_Codigo { get; set; }

        public string Descripcion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public bool Estado { get; set; }


        #endregion

        #region Constructor

        public Perfil(){

            ID_Codigo = 0;
            Descripcion = string.Empty;
            FechaCreacion = DateTime.MinValue;
            Estado = true;
            
        }

        #endregion




    }
}
