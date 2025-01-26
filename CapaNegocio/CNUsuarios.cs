using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNUsuarios
    {
        private CDUsuarios objDato = new CDUsuarios(); // Instancia de la capa de datos

        // Método para insertar un usuario en el sistema
        public void InsertarUsuario(string nombre, string usuario, string password, string correo, string rol)
        {
            // Llamar al método de la capa de datos para insertar el usuario
            objDato.InsertarUsuarioSistema(nombre, usuario, password, correo, rol);
        }
        public DataTable ObtenerUsuarios()
        {
            try
            {
                // Llamamos al método de la capa de datos para obtener los usuarios
                return objDato.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio: " + ex.Message);
            }
        }
    }
}
