using System;
using CapaNegocio;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Librery_Hub.Libros
{
    public partial class Fm_ALibro : Form
    {
        // 📌 Instancia de la capa de negocio
        private CNLibros cnLibros = new CNLibros();
        private string isbnRecibido;
        public Fm_ALibro(string isbn)
        {
            InitializeComponent();
            isbnRecibido = isbn;
            TxtISBN.Text = isbnRecibido; // Asignar el ISBN al TextBox
            TxtISBN.ReadOnly = true; // Para evitar que el usuario lo edite
        }

        // codigo para mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Pl_movie_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txt_Titulo.Text == "Titulo")
            {
                txt_Titulo.Text = "";
                txt_Titulo.ForeColor = Color.LightGray;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txt_Titulo.Text == "")
            {
                txt_Titulo.Text = "Titulo";
                txt_Titulo.ForeColor = Color.LightGray;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Autor_Enter(object sender, EventArgs e)
        {
            if (txt_Autor.Text == "Autor")
            {
                txt_Autor.Text = "";
                txt_Autor.ForeColor = Color.LightGray;
            }
        }

        private void txt_Autor_Leave(object sender, EventArgs e)
        {
            if (txt_Autor.Text == "")
            {
                txt_Autor.Text = "Autor";
                txt_Autor.ForeColor = Color.LightGray;
            }
        }

        private void txt_genero_Enter(object sender, EventArgs e)
        {     
            if (txt_Genero.Text == "Género")
            {
                txt_Genero.Text = "";
                txt_Genero.ForeColor = Color.LightGray;
            }
        }

        private void txt_genero_Leave(object sender, EventArgs e)
        {
            if (txt_Genero.Text == "")
            {
                txt_Genero.Text = "Género";
                txt_Genero.ForeColor = Color.LightGray;
            }
        }

        private void txt_APublicacion_Enter(object sender, EventArgs e)
        {
            if (txt_APublicacion.Text == "Año de publicación")
            {
                txt_APublicacion.Text = "";
                txt_APublicacion.ForeColor = Color.LightGray;
            }
        }

        private void txt_APublicacion_Leave(object sender, EventArgs e)
        {
            if (txt_APublicacion.Text == "")
            {
                txt_APublicacion.Text = "Año de publicación";
                txt_APublicacion.ForeColor = Color.LightGray;
            }
        }

        private void txt_Editorial_Leave(object sender, EventArgs e)
        {
            if (txt_Editorial.Text == "")
            {
                txt_Editorial.Text = "Editorial";
                txt_Editorial.ForeColor = Color.LightGray;
            }
        }

        private void txt_Editorial_Enter(object sender, EventArgs e)
        {
            if (txt_Editorial.Text == "Editorial")
            {
                txt_Editorial.Text = "";
                txt_Editorial.ForeColor = Color.LightGray;
            }
        }

        private void txtISBN_Enter(object sender, EventArgs e)
        {
            if (txt_Editorial.Text == "ISBN")
            {
                txt_Editorial.Text = "";
                txt_Editorial.ForeColor = Color.LightGray;
            }
        }

        private void txtISBN_Leave(object sender, EventArgs e)
        {
            if (txt_Editorial.Text == "")
            {
                txt_Editorial.Text = "ISBN";
                txt_Editorial.ForeColor = Color.LightGray;
            }
        }

        private void btn_ALibro_Click(object sender, EventArgs e)
        {
            // 📌 Validación de datos
            if (TxtISBN.Text == "ISBN" || string.IsNullOrWhiteSpace(TxtISBN.Text) ||
                txt_Titulo.Text == "Título" || string.IsNullOrWhiteSpace(txt_Titulo.Text) ||
                txt_Titulo.Text == "Autor" || string.IsNullOrWhiteSpace(txt_Titulo.Text) ||
                txt_Editorial.Text == "Editorial" || string.IsNullOrWhiteSpace(txt_Editorial.Text) ||
                txt_Genero.Text == "Género" || string.IsNullOrWhiteSpace(txt_Genero.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 📌 Capturar datos
            string titulo = txt_Titulo.Text.Trim();
            string autor = txt_Titulo.Text.Trim();
            string isbn = TxtISBN.Text.Trim();
            string editorial = txt_Editorial.Text.Trim();
            string genero = txt_Genero.Text.Trim();
            DateTime anoPublicacion = Dtp_Apublicacion.Value;
            // 📌 Registrar el libro
            bool libroRegistrado = cnLibros.RegistrarLibro(titulo, autor, isbn, editorial, anoPublicacion, genero);

            if (libroRegistrado)
                MessageBox.Show("Libro registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error al registrar el libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
