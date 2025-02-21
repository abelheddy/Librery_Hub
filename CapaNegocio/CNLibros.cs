using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CNLibros
    {
        private CDLibros datosLibros = new CDLibros();

        public int VerificarISBN(string isbn)
        {
            return datosLibros.VerificarISBN(isbn);
        }

        public bool RegistrarLibro(string titulo, string autor, string isbn, string editorial, DateTime anoPublicacion, string genero)
        {
            return datosLibros.RegistrarLibro(titulo, autor, isbn, editorial, anoPublicacion, genero);
        }

        public void AgregarCopiaLibro(int idLibro)
        {
            datosLibros.AgregarCopiaLibro(idLibro);
        }
        public int ObtenerIDLibroPorISBN(string isbn)
        {
            try
            {
                // Llamar al método de la capa de datos para obtener el ID del libro por ISBN
                return datosLibros.ObtenerIDLibroPorISBN(isbn);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio: " + ex.Message);
            }
        }

        public DataTable MostrarLibrosYCopias()
        {
            try
            {
                // Llamamos al método de la capa de datos para obtener el DataTable
                return datosLibros.MostrarLibrosYCopias();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio: " + ex.Message);
            }
        }
    }
}
