using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class Usuario
    {
        #region Propiedades 
        public int IDUsuario { get; set; }

        public string NUsuario { get; set; }

        public string Pass { get; set; }

        public string Fecha { get; set; }

        public bool Activo { get; set; }

        public bool Bloqueo { get; set; }

        public string U_Nombre { get; set; }

        public string U_Apellido { get; set; }

        public string U_Telefono { get; set; }

        public string U_Email { get; set; }

        public string TCedula { get; set; }

        public string Cedula { get; set; }

        #endregion

        #region Constructor
        public Usuario()
        {
            IDUsuario = 0;
            NUsuario = string.Empty;
            Pass = string.Empty;
            Fecha = string.Empty;
            Activo = true;
            Bloqueo = false;
            U_Nombre = string.Empty;
            U_Apellido = string.Empty;
            U_Telefono = string.Empty;
            U_Email = string.Empty;
            TCedula = string.Empty;
            Cedula = string.Empty;

        }
        #endregion
    }
}
