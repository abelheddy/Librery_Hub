using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNUBiblioteca
    {
        private readonly CDUBiblioteca cdBiblioteca = new CDUBiblioteca();
        

        // Método para registrar un nuevo usuario
        public string RegistrarUsuario(string nombre, string apellido, string correo, string telefono, string direccion)
        {
            try
            {
                cdBiblioteca.RegistrarUsuario(nombre, apellido, correo, telefono, direccion);
                return "Usuario registrado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al registrar el usuario: " + ex.Message;
            }
        }

        // Método para mostrar usuarios
        public DataTable MostrarUsuarios()
        {
            return cdBiblioteca.MostrarUsuarios();
        }
        //metodo para eliminar un usuario
        public void EliminarUsuario(string matricula)
        {
            try
            {
                // Llamamos a la capa de datos para realizar la eliminación
                cdBiblioteca.EliminarUsuario(matricula);
            }
            catch (Exception ex)
            {
                // Propagar la excepción hacia la capa de presentación
                throw new Exception("Error al eliminar el usuario desde la capa de negocio: " + ex.Message);
            }
        }
    }
}
