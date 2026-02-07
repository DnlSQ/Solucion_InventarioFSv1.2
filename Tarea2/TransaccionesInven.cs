using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class TransaccionesInven
    {
        #region Propiedades 
        public int TransaccionID { get; set; }

        public string FechaTransaccion { get; set; }

        public string TipoTransaccion { get; set; }

        public int ProductoID { get; set; }

        public int Cantidad { get; set; }

        public string Notas { get; set; }

        #endregion

        #region Constructor
        public TransaccionesInven()
        {
            TransaccionID = 0;
            FechaTransaccion = string.Empty;
            TipoTransaccion = string.Empty;
            ProductoID = 0;
            Cantidad = 0;
            Notas = string.Empty;

        }
        #endregion


    }
}
