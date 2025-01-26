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
        // Declarar la conexión como privada y de solo lectura para mayor seguridad.
        private readonly SqlConnection conexion;

        // Constructor para inicializar la conexión. Permite flexibilidad si cambias la cadena de conexión.
        // Constructor que recibe la cadena de conexión
        public CDConexion(string connectionString)
        {
            conexion = new SqlConnection(connectionString);
        }

        // Método para abrir la conexión, con manejo de excepciones.
        public SqlConnection AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (SqlException ex)
            {
                // Loguear errores o lanzar excepciones según sea necesario
                throw new Exception("Error al abrir la conexión: " + ex.Message);
            }
            return conexion;
        }

        // Método para cerrar la conexión.
        public SqlConnection CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (SqlException ex)
            {
                // Loguear errores o lanzar excepciones según sea necesario
                throw new Exception("Error al cerrar la conexión: " + ex.Message);
            }
            return conexion;
        }
    }
}
