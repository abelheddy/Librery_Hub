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
        public void RegistrarLibro(string titulo, string autor, string isbn, string editorial, DateTime anioPublicacion, string genero)
        {
            using (SqlConnection connection = conexion.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand("RegistrarLibro", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Titulo", titulo);
                    cmd.Parameters.AddWithValue("@Autor", autor);
                    cmd.Parameters.AddWithValue("@ISBN", isbn);
                    cmd.Parameters.AddWithValue("@Editorial", editorial);
                    cmd.Parameters.AddWithValue("@AnoPublicacion", anioPublicacion);
                    cmd.Parameters.AddWithValue("@Genero", genero);

                    cmd.ExecuteNonQuery();
                }
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
    }
}
