using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Librery_Hub.Libros;
using Librery_Hub.Usuarios;
using Librery_Hub.Prestamos;
using Librery_Hub.Historial;
using Librery_Hub.UsuariosB;

namespace Librery_Hub.Menu
{
    public partial class Fm_Menu : Form
    {
        public Fm_Menu()
        {
            InitializeComponent();
            nivel();
        }

        //funcion de muestreo de botones segun el nivel 
        private void nivel()
        {
            if(Program.nivel == "Administrador")
            {
                
            }
            else
            {
                btn_GLibros.Visible = false;
                btn_GUsuarios.Visible = false;
                btn_GUL.Visible = false;
            }
        }

        //codigo para abrir en un panel una nueva ventana
        private void AbrirFromHijo(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = FormHijo as Form;
            //se declara que no es un formulario de primer nivel 
            fh.TopLevel = false;
            //le decimos que se acople al todo el dock
            fh.Dock = DockStyle.Fill;
            //ahora lo agremamos al contenedor que es un objeto panel 
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            //por ultimo se muestra
            fh.Show();
        }
        // codigo para mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void mostrarusuarioactivo()
        {
            lbl_Nivel.Text = Program.nivel;
            lbl_User.Text = Program.usuario;
            lbl_Nivel.Visible = true;
            lbl_User.Visible = true;
        }
        private void btn_CloseCesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fm_Login fm_Login = new Fm_Login();
            fm_Login.Show();
        }

        //codigo para poder mover la ventana
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //codigo para poder mover la ventana
        private void lbl_SistemaLibros_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //codigo de minizacion de ventana
        private void btn_Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //codigo de cierre de ventana
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //codigo para ir a Gestion de libros
        private void btn_GLibros_Click(object sender, EventArgs e)
        {
            AbrirFromHijo(new Fm_Libros());
        }

        private void btn_GUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFromHijo(new Fm_Usuarios());
        }

        private void btn_GPDevolucion_Click(object sender, EventArgs e)
        {
            AbrirFromHijo(new Fm_Prestamos());
        }

        private void btn_HPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFromHijo(new Fm_HPrestamos());
        }

        private void Fm_Menu_Load(object sender, EventArgs e)
        {
            mostrarusuarioactivo();
        }

        private void btn_GUL_Click(object sender, EventArgs e)
        {
            AbrirFromHijo(new Fm_UsuariosB());
        }
    }
}
