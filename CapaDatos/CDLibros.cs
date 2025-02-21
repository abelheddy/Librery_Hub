using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDLibros
    {
        private CDConexion conexion = new CDConexion();
        // Método para verificar si el ISBN ya existe
        public int VerificarISBN(string isbn)
        {
            using (SqlConnection connection = conexion.AbrirConexion())
            {
                
                using (SqlCommand cmd = new SqlCommand("VerificarISBN", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ISBN", isbn);

                    SqlParameter existeLibroParam = new SqlParameter("@ExisteLibro", SqlDbType.Int);
                    existeLibroParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(existeLibroParam);

                    cmd.ExecuteNonQuery();
                    return (int)existeLibroParam.Value; // Retorna 1 si el libro NO existe, 2 si YA existe
                }
            }
        }

        // Método para registrar un nuevo libro
        // 📌 Registrar un libro y su primera copia
        public bool RegistrarLibro(string titulo, string autor, string isbn, string editorial, DateTime anoPublicacion, string genero)
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                SqlCommand cmd = new SqlCommand("RegistrarLibro", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del procedimiento almacenado
                cmd.Parameters.AddWithValue("@Titulo", titulo);
                cmd.Parameters.AddWithValue("@Autor", autor);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.Parameters.AddWithValue("@Editorial", editorial);
                cmd.Parameters.AddWithValue("@AnoPublicacion", anoPublicacion);
                cmd.Parameters.AddWithValue("@Genero", genero);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Método para agregar una nueva copia de un libro ya registrado
        public void AgregarCopiaLibro(int idLibro)
        {
            using (SqlConnection connection = conexion.AbrirConexion())
            {

                using (SqlCommand cmd = new SqlCommand("AgregarCopiaLibro", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDLibro", idLibro);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public int ObtenerIDLibroPorISBN(string isbn)
        {
            SqlConnection connection = null; // Declarar la conexión
            try
            {
                // Validar el formato del ISBN
                //if (!ValidarISBN(isbn))
                //{
                    //throw new Exception("El ISBN no tiene el formato correcto.");
                //}

                // Abrir la conexión usando tu clase CDConexion
                connection = conexion.AbrirConexion();

                SqlCommand cmd = new SqlCommand("ObtenerIDLibroPorISBN", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                // Asegurarse de que el ISBN sea pasado correctamente como parámetro
                cmd.Parameters.AddWithValue("@ISBN", isbn);

                // Ejecutar la consulta y obtener el resultado como un string
                object result = cmd.ExecuteScalar();

                // Verifica si el resultado es null y devuelve el ID del libro como string
                // Comprobar si el resultado no es null o DBNull
                if (result != null && result != DBNull.Value)
                {
                    return result.ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio: Error al obtener ID del libro por ISBN: " + ex.Message);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (connection != null)
                {
                    conexion.CerrarConexion(connection); // Cerrar la conexión
                }
            }
        }

        //mostrar libros y copas de los libros
        public DataTable MostrarLibrosYCopias()
        {
            using (SqlConnection connection = conexion.AbrirConexion()) 
            { 
                try
                {
                    // Crear el comando que ejecuta el procedimiento almacenado
                    SqlCommand cmd = new SqlCommand("MostrarLibrosYCopias", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Crear el DataAdapter para llenar el DataTable con los resultados
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los libros y copias: " + ex.Message);
                }
            }
        }
    }
}
