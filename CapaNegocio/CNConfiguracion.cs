using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    internal class CNConfiguracion
    {
        public static string ObtenerCadenaConexion()
        {
            // Carga la cadena de conexión desde el archivo app.config de Presentación
            return ConfigurationManager.ConnectionStrings["ConexionBiblioteca"].ConnectionString;
        }
        
    }
}
