using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class UsuarioFS
    {
        #region Propiedades 
        public int EmpleadoID { get; set; }

        public string NombreCompleto { get; set; }

        public string Cargo { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }


        #endregion

        #region Constructor
        public UsuarioFS()
        {
            EmpleadoID = 0;
            NombreCompleto = string.Empty;
            Cargo = string.Empty;
            Email = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;

        }
        #endregion
    }
}
