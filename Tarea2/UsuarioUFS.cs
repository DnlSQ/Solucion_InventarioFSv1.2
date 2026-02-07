using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class UsuarioUFS
    {
        #region Propiedades 
        public int UsuarioID { get; set; }

        public string NombreUsuario { get; set; }

        public string Contrasena { get; set; }

        public int EmpleadoID { get; set; }




        #endregion

        #region Constructor
        public UsuarioUFS()
        {
            UsuarioID = 0;
            NombreUsuario = string.Empty;
            Contrasena = string.Empty;
            EmpleadoID = 0;
        }
        #endregion
    }
}
