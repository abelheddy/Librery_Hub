using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDUsuarios
    {
        private SqlConnection conexion;

        // Constructor para abrir la conexión
        public CDUsuarios()
        {
            // Aquí se lee la cadena de conexión desde app.config
            string connectionString = ConfigurationManager.ConnectionStrings["ConexionBiblioteca"].ConnectionString;
            conexion = new SqlConnection(connectionString);
        }
        // Método para insertar un usuario en la base de datos
        public void InsertarUsuarioSistema(string nombre, string usuario, string password, string correo, string rol)
        {
            try
            {
                // Crear el comando que ejecutará el procedimiento almacenado
                SqlCommand cmd = new SqlCommand("InsertarUsuarioSistema", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros al comando
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Rol", rol);

                // Abrir la conexión, ejecutar el comando y cerrarla
                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        // Método para cerrar la conexión
        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        //metodo para mostrar los datos en un DataGrid
        public DataTable ObtenerUsuarios()
        {
            DataTable dtUsuarios = new DataTable();

            try
            {
                // Abrir conexión
                conexion.Open();

                // Crear el comando para ejecutar el procedimiento almacenado
                SqlCommand cmd = new SqlCommand("ObtenerUsuariosSistema", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                // Ejecutar el comando y llenar el DataTable con los resultados
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtUsuarios);

                return dtUsuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los usuarios: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                conexion.Close();
            }
        }
    }
}
