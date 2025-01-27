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
    public class CDUBiblioteca
    {
        // Obtener la cadena de conexión desde app.config
        //private static string connectionString = ConfigurationManager.ConnectionStrings["ConexionBiblioteca"].ConnectionString;
        private CDConexion conexion = new CDConexion();
        // Instancia de la conexión con la cadena configurada
       // private readonly CDConexion conexion = new CDConexion(connectionString);

        // Método para registrar un usuario
        public void RegistrarUsuario(
            string nombre,
            string apellido,
            string correo,
            string telefono,
            string direccion)
        {
            try
            {
                using (SqlConnection connection = conexion.AbrirConexion())
                {
                    using (SqlCommand command = new SqlCommand("RegistrarUsuario", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetros del procedimiento almacenado
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellido", apellido);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@Telefono", string.IsNullOrEmpty(telefono) ? (object)DBNull.Value : telefono);
                        command.Parameters.AddWithValue("@Direccion", string.IsNullOrEmpty(direccion) ? (object)DBNull.Value : direccion);
                        // Ejecutar el procedimiento
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el usuario: " + ex.Message);
            }
        }

        // Método para generar matrícula
        public string GenerarMatricula()
        {
            try
            {
                using (SqlConnection connection = conexion.AbrirConexion())
                {
                    using (SqlCommand command = new SqlCommand("GenerarMatricula", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetro de salida
                        SqlParameter outputParam = new SqlParameter("@NuevaMatricula", SqlDbType.NVarChar, 20)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputParam);

                        // Ejecutar el procedimiento
                        command.ExecuteNonQuery();

                        // Retornar la matrícula generada
                        return outputParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar la matrícula: " + ex.Message);
            }
        }

        // Método para obtener los usuarios
        public DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand command = new SqlCommand("MostrarUsuarios", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar usuarios: " +  ex.Message);
            }
            return tabla;
        }
        //metodo para eliminar un usuario 
        public void EliminarUsuario(string matricula)
        {
            SqlConnection conn = conexion.AbrirConexion(); // Usamos el método de CDConexion para abrir la conexión
            try
            {
                // Creamos el comando para ejecutar el procedimiento almacenado de eliminación
                using (SqlCommand cmd = new SqlCommand("EliminarUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Matricula", matricula);

                    cmd.ExecuteNonQuery(); // Ejecutar el procedimiento almacenado
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el usuario: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(conn); // Aseguramos de cerrar la conexión después de realizar la operación
            }
        }
    }
}
