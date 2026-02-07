using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class Cita
    {
        #region Propiedades 
        public int IDCita { get; set; }

        public int ClienteId { get; set; }

        public string NombreCliente { get; set; }

        public int EmpleadoId { get; set; }

        public string NombreEmpleado { get; set; }

        public int ServicioId { get; set; }

        public string NombreServicio { get; set; }

        public string Fecha { get; set; }

        public string Hora { get; set; }

        public string Notas { get; set; }

        #endregion

        #region Constructor
        public Cita()
        {
            IDCita = 0;
            ClienteId = 0;
            NombreCliente = string.Empty;
            EmpleadoId = 0;
            NombreEmpleado = string.Empty;
            ServicioId = 0;
            NombreServicio = string.Empty;
            Fecha = string.Empty;
            Hora = string.Empty;
            Notas = string.Empty;





        }
        #endregion




    }
}
