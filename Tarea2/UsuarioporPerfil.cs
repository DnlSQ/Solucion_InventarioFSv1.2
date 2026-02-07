using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class UsuarioporPerfil
    {

        #region Propiedades
        public int UsuarioId { get; set; }

        public string Usuario { get; set; }

        public int CodPerfil { get; set; }

        public string FechaAsociacion { get; set; }

        #endregion

        #region Constructor
        public UsuarioporPerfil()
        {
            UsuarioId = 0;
            Usuario = string.Empty;
            CodPerfil = 0;
            FechaAsociacion = string.Empty;

        }
        #endregion

    }
}
