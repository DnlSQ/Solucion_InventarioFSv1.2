using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class AuditoriaEmpleadosFS
    {
        #region Propiedades
        public int AuditoriaID { get; set; }
        public int EmpleadoID { get; set; }
        public string NombreCompleto { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string FechaAuditoria { get; set; }
        public string Accion { get; set; }
        #endregion

        #region Constructor
        public AuditoriaEmpleadosFS()
        {
            AuditoriaID = 0;
            EmpleadoID = 0;
            NombreCompleto = string.Empty;
            Cargo = string.Empty;
            Email = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
            FechaAuditoria = string.Empty;
            Accion = string.Empty;
        }
        #endregion
    }

}
