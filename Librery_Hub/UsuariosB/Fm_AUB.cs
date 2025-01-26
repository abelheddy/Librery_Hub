using System;
using CapaNegocio;
using System.Windows.Forms;
using System.Drawing;

namespace Librery_Hub.UsuariosB
{
    public partial class Fm_AUB : Form
    {
        public Fm_AUB()
        {
            InitializeComponent();
        }

        // Instancia de la clase CNUBiblioteca
        private readonly CNUBiblioteca negocioBiblioteca = new CNUBiblioteca();

        private void btn_AUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar campos obligatorios
                if (txt_Nombre.Text == "Nombre" || string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                    txt_Apellido.Text == "Apellido" || string.IsNullOrWhiteSpace(txt_Apellido.Text) ||
                    txt_Correo.Text == "Correo" || string.IsNullOrWhiteSpace(txt_Correo.Text))
                {
                    MessageBox.Show("Por favor, complete los campos obligatorios: Nombre, Apellido y Correo.",
                                    "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener valores de los campos
                string nombre = txt_Nombre.Text.Trim();
                string apellido = txt_Apellido.Text.Trim();
                string correo = txt_Correo.Text.Trim();
                string telefono = txt_Telefono.Text == "Telefono" ? null : txt_Telefono.Text.Trim();
                string direccion = txt_Direccion.Text == "Direccion" ? null : txt_Direccion.Text.Trim();

                // Registrar usuario
                string mensaje = negocioBiblioteca.RegistrarUsuario(nombre, apellido, correo, telefono, direccion);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos después de registrar
                ResetFields();

                // Actualizar DataGridView
                //CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpiar los campos del formulario
        private void ResetFields()
        {
            txt_Nombre.Text = "Nombre";
            txt_Nombre.ForeColor = Color.LightGray;

            txt_Apellido.Text = "Apellido";
            txt_Apellido.ForeColor = Color.LightGray;

            txt_Correo.Text = "Correo";
            txt_Correo.ForeColor = Color.LightGray;

            txt_Telefono.Text = "Telefono";
            txt_Telefono.ForeColor = Color.LightGray;

            txt_Direccion.Text = "Direccion";
            txt_Direccion.ForeColor = Color.LightGray;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txt_Apellido_Enter(object sender, EventArgs e)
        {
            if (txt_Apellido.Text == "Apellido")
            {
                txt_Apellido.Text = "";
                txt_Apellido.ForeColor = Color.LightGray;
            }
        }

        private void txt_Apellido_Leave(object sender, EventArgs e)
        {
            if (txt_Apellido.Text == "")
            {
                txt_Apellido.Text = "Apellido";
                txt_Apellido.ForeColor = Color.LightGray;
            }
        }

        private void txt_Correo_Enter(object sender, EventArgs e)
        {
            if (txt_Correo.Text == "Correo")
            {
                txt_Correo.Text = "";
                txt_Correo.ForeColor = Color.LightGray;
            }
        }

        private void txt_Correo_Leave(object sender, EventArgs e)
        {
            if (txt_Correo.Text == "")
            {
                txt_Correo.Text = "Correo";
                txt_Correo.ForeColor = Color.LightGray;
            }
        }

        private void txt_Telefono_Enter(object sender, EventArgs e)
        {
            if (txt_Telefono.Text == "Telefono")
            {
                txt_Telefono.Text = "";
                txt_Telefono.ForeColor = Color.LightGray;
            }
        }

        private void txt_Telefono_Leave(object sender, EventArgs e)
        {
            if (txt_Telefono.Text == "")
            {
                txt_Telefono.Text = "Telefono";
                txt_Telefono.ForeColor = Color.LightGray;
            }
        }

        private void txt_Direccion_Enter(object sender, EventArgs e)
        {
            if (txt_Direccion.Text == "Direccion")
            {
                txt_Direccion.Text = "";
                txt_Direccion.ForeColor = Color.LightGray;
            }
        }

        private void txt_Direccion_Leave(object sender, EventArgs e)
        {
            if (txt_Direccion.Text == "")
            {
                txt_Direccion.Text = "Direccion";
                txt_Direccion.ForeColor = Color.LightGray;
            }
        }
    }
}
