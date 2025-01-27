using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; // Necesario para leer el app.config

namespace CapaDatos
{
    class CDConexion
    {
        // Cadena de conexión recuperada del archivo app.config
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["ConexionBiblioteca"].ConnectionString;

        public SqlConnection AbrirConexion()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al abrir la conexión: " + ex.Message);
            }
        }

        public void CerrarConexion(SqlConnection conn)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}
