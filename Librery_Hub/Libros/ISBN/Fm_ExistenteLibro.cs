using CapaNegocio;
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

namespace Librery_Hub.Libros.ISBN
{
    public partial class Fm_ExistenteLibro: Form
    {
        public Fm_ExistenteLibro()
        {
            InitializeComponent();
        }
        // codigo para mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        // linea para conectarse con la capa de negocio 
        private CNLibros negocioLibros = new CNLibros();
        private void Pl_movie_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string isbnIngresado = Txt_BuscarISBN.Text.Trim();// Obtener el ISBN como cadena

            if (string.IsNullOrEmpty(isbnIngresado))
            {
                MessageBox.Show("Por favor, ingrese un ISBN.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int resultado = negocioLibros.VerificarISBN(isbnIngresado);

            if (resultado == 1) // 📕 NO existe, registrar nuevo libro
            {
                Fm_ALibro Fm_new = new Fm_ALibro(isbnIngresado);
                Fm_new.Show();
            }
            else if (resultado == 2) // 📚 YA existe, agregar nueva copia
            {
                string idLibro = negocioLibros.ObtenerIDLibroPorISBN(isbnIngresado);
                if (idLibro != -1)
                {
                    negocioLibros.AgregarCopiaLibro(idLibro);
                    MessageBox.Show("Se ha agregado una nueva copia del libro.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error: No se encontró el ID del libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error al verificar el ISBN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
