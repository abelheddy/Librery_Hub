using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNUBiblioteca
    {
        private readonly CDUBiblioteca cdBiblioteca = new CDUBiblioteca();
        private readonly CDUBiblioteca datosUsuarios = new CDUBiblioteca();

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
    }
}
