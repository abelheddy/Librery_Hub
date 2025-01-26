using System;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;

namespace Librery_Hub.Usuarios
{
    public partial class Fm_AUsuarios : Form
    {
        public Fm_AUsuarios()
        {
            InitializeComponent();
        }

        private void btn_AUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txt_Nombre.Text;
                string usuario = txt_Usuario.Text;
                string password = txt_Password.Text;
                string correo = txt_Correo.Text;
                string rol = cbo_Rol.SelectedItem.ToString(); // Asumiendo que tienes un ComboBox para el rol

                // Verificar que no haya campos vacíos
                // Verificar que no haya campos vacíos, comparando con el texto por defecto
                if (txt_Nombre.Text == "Nombre" || txt_Usuario.Text == "Usuario" ||
                    txt_Password.Text == "Password" || txt_Correo.Text == "Correo Electronico" ||
                    cbo_Rol.SelectedItem == null)
                {
                    // Alerta personalizada en caso de campos vacíos
                    MostrarAlerta("Por favor, completa todos los campos.", "Error");
                    return;
                }

                // Crear una instancia de la capa de negocio y llamar al método InsertarUsuario
                CNUsuarios objNegocio = new CNUsuarios();
                objNegocio.InsertarUsuario(nombre, usuario, password, correo, rol);

                // Alerta personalizada en caso de éxito
                MostrarAlerta("Usuario registrado correctamente.", "Éxito");
            }
            catch (Exception ex)
            {
                // Si ocurre un error, mostramos un mensaje de alerta personalizado
                MostrarAlerta($"Ocurrió un error: {ex.Message}", "Error");
            }
        }

        private void MostrarAlerta(string mensaje, string tipo)
        {
            // Crear una alerta personalizada dependiendo del tipo (Error o Éxito)
            if (tipo == "Error")
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tipo == "Éxito")
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txt_Nombre_Enter(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "Nombre")
            {
                txt_Nombre.Text = "";
                txt_Nombre.ForeColor = Color.LightGray;
            }
        }

        private void txt_Nombre_Leave(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "")
            {
                txt_Nombre.Text = "Nombre";
                txt_Nombre.ForeColor = Color.LightGray;
            }
        }

        private void txt_Usuario_Enter(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "Usuario")
            {
                txt_Usuario.Text = "";
                txt_Usuario.ForeColor = Color.LightGray;
            }
        }

        private void txt_Usuario_Leave(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "")
            {
                txt_Usuario.Text = "Usuario";
                txt_Usuario.ForeColor = Color.LightGray;
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Password")
            {
                txt_Password.Text = "";
                txt_Password.ForeColor = Color.LightGray;
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
            {
                txt_Password.Text = "Password";
                txt_Password.ForeColor = Color.LightGray;
            }
        }

        private void txt_Correo_Enter(object sender, EventArgs e)
        {
            if (txt_Correo.Text == "Correo Electronico")
            {
                txt_Correo.Text = "";
                txt_Correo.ForeColor = Color.LightGray;
            }
        }

        private void txt_Correo_Leave(object sender, EventArgs e)
        {
            if (txt_Correo.Text == "")
            {
                txt_Correo.Text = "Correo Electronico";
                txt_Correo.ForeColor = Color.LightGray;
            }
        }
    }
}
