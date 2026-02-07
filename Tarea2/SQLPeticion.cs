using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tarea2
{
    public class SQLPeticion
    {
        #region Propiedades

        public string Peticion { get; set; }

        public List<SqlParameter> ListaParametros { get; set; }

        #endregion

        #region Constructor
        public SQLPeticion() {
            Peticion = string.Empty;
            ListaParametros = new List<SqlParameter>();
        
        }
        #endregion
    }
}
