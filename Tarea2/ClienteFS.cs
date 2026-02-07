using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class ClienteFS
    {
        #region Propiedades 
        public int ClienteID { get; set; }

        public string C_Nombre { get; set; }

        public string C_Apellidos { get; set; }

        public string Email { get; set; }

        public string C_Telefono { get; set; }

        #endregion

        #region Constructor
        public ClienteFS()
        {
            ClienteID = 0;
            C_Nombre = string.Empty;
            C_Apellidos = string.Empty;
            Email = string.Empty;
            C_Telefono = string.Empty;
           
        }
        #endregion
    }
}
