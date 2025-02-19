using System;
using System.Collections.Generic;
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
            return datosLibros.ObtenerIDLibroPorISBN(isbn);
        }
    }
}
