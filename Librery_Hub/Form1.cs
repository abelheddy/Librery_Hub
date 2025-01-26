using System;
using System.Collections.Generic;
using System.ComponentModel;
using CapaNegocio;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Librery_Hub.Menu;

namespace Librery_Hub
{
    public partial class Fm_Login : Form
    {
        public Fm_Login()
        {
            InitializeComponent();
            laErrorlogeo.Visible = false;
        }
        // codigo para mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);
        private void btn_Login_Click(object sender, EventArgs e)
        {
            CNLogin objLogin = new CNLogin();
            objLogin.Usuario = txtUser.Text;
            objLogin.Contraseña = txtPass.Text;

            if (string.IsNullOrEmpty(objLogin.Usuario) || objLogin.Usuario == "Usuario" ||
                string.IsNullOrEmpty(objLogin.Contraseña) || objLogin.Contraseña == "Password")
            {
                laErrorlogeo.Text = "Por favor, ingrese usuario y contraseña";
                laErrorlogeo.Visible = true;
                return;
            }

            // Intentar iniciar sesión y obtener el nivel y usuario
            string nivel = string.Empty;
            string usuario = string.Empty;

            // Aquí es donde llamas al método correctamente
            bool loginExitoso = objLogin.IniciarSesion(objLogin.Usuario, objLogin.Contraseña, out nivel, out usuario);

            if (loginExitoso)
            {
                // Asignamos el nivel y el usuario a la variable Program
                Program.usuario = usuario;
                Program.nivel = nivel;

                this.Hide(); // Ocultar el formulario de login
                Fm_Menu pri = new Fm_Menu();
                pri.Show();
            }
            else
            {
                laErrorlogeo.Text = "Usuario o Contraseña incorrectos";
                laErrorlogeo.Visible = true;

                txtUser.Focus();
            }
        }

        private void btn_Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pl_movie_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.LightGray;
            }
        }
    }
}
