using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Configuration;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDLogin
    {
        private SqlConnection conexion;

        public CDLogin()
        {
            // Aquí se lee la cadena de conexión desde app.config
            string connectionString = ConfigurationManager.ConnectionStrings["ConexionBiblioteca"].ConnectionString;
            conexion = new SqlConnection(connectionString);
        }

        // Método para iniciar sesión
        public SqlDataReader IniciarSesion(string usuario, string pass)
        {
            SqlDataReader leer;
            SqlCommand comando = new SqlCommand("loginn", conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            // Parámetros para el procedimiento almacenado
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@pass", pass);

            // Abrir la conexión antes de ejecutar
            conexion.Open();
            leer = comando.ExecuteReader();

            return leer;
        }

        // Método para cerrar la conexión
        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }
    }
}
