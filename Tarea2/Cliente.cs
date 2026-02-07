using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class Cliente
    {

        #region Propiedades 
        public int IDCliente { get; set; }

        public string C_Nombre { get; set; }

        public string C_Apellidos { get; set; }

        public string C_Telefono { get; set; }

        public string Email { get; set; }

        public string TipoCedula { get; set; }

        public string NumeroCedula { get; set; }

        #endregion

        #region Constructor
        public Cliente()
        {
            IDCliente = 0;
            C_Nombre = string.Empty;
            C_Apellidos = string.Empty;
            C_Telefono = string.Empty;
            Email = string.Empty;
            TipoCedula = string.Empty;
            NumeroCedula = string.Empty;


        }
        #endregion

    }
}
