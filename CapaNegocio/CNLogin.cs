using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNLogin
    {
        // Instancia la capa de datos para hacer uso de la clase CDLogin
        CDLogin objDato = new CDLogin();  // No es necesario pasar la cadena de conexión

        // Variables privadas para almacenar los valores ingresados por el usuario
        private string _usuario;
        private string _contraseña;

        // Propiedades para el manejo de las variables
        public string Usuario
        {
            set
            {
                _usuario = string.IsNullOrEmpty(value) ? "No ha ingresado un Usuario" : value;
            }
            get { return _usuario; }
        }

        public string Contraseña
        {
            set
            {
                _contraseña = string.IsNullOrEmpty(value) ? "No ha ingresado una Contraseña" : value;
            }
            get { return _contraseña; }
        }

        // Método que se encarga de autenticar al usuario usando los datos ingresados
        public bool IniciarSesion(string usuario, string contraseña, out string nivel, out string usuarioObtenido)
        {
            bool loginExitoso = false;

            // Inicializamos las variables out para que no cause el error
            nivel = string.Empty;
            usuarioObtenido = string.Empty;

            // Llamamos al método de la capa de datos para obtener el SqlDataReader con los datos de inicio de sesión
            SqlDataReader resultado = objDato.IniciarSesion(usuario, contraseña);

            // Verificamos si hay resultados (es decir, si existe el usuario)
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    // Obtener el rol del usuario desde la base de datos (suponiendo que el campo se llama 'nivel')
                    nivel = resultado["Rol"].ToString(); // Aquí 'nivel' es el nombre de tu campo en la base de datos
                    usuarioObtenido = resultado["usuario"].ToString(); // Obtener el nombre del usuario

                    // Si llegamos aquí, el login fue exitoso
                    loginExitoso = true;
                }
            }

            // Cerramos la conexión después de la validación
            objDato.CerrarConexion();

            return loginExitoso; // Retornamos si el login fue exitoso
        }
    }
}
