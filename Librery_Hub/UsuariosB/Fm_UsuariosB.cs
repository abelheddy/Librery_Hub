using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librery_Hub.UsuariosB
{
    public partial class Fm_UsuariosB : Form
    {
        private readonly CNUBiblioteca negocioUsuarios = new CNUBiblioteca();
        public Fm_UsuariosB()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            dgv_DatosUsuariosB.DataBindingComplete += dgv_DatosUsuariosB_DataBindingComplete;
        }
        private void dgv_DatosUsuariosB_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Si hay menos filas que el espacio disponible, agrega filas vacías
            //while (dgv_DatosUsuarios.Rows.Count < 10) // Cambia 10 según lo necesario
            //{
            //dgv_DatosUsuarios.Rows.Add();
            //}
        }

        private void CargarUsuarios()
        {
            try
            {
                dgv_DatosUsuariosB.DataSource = negocioUsuarios.MostrarUsuarios();

                // Configuración opcional del DataGridView
                //dgv_DatosUsuariosB.Columns["IdUsuario"].Visible = false; // Ocultar columna de ID
                //dgv_DatosUsuariosB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajustar columnas

                // Personalización de encabezados (opcional)
                dgv_DatosUsuariosB.Columns["Matricula"].HeaderText = "Matrícula";
                dgv_DatosUsuariosB.Columns["Nombre"].HeaderText = "Nombre";
                dgv_DatosUsuariosB.Columns["Apellido"].HeaderText = "Apellido";
                dgv_DatosUsuariosB.Columns["Correo"].HeaderText = "Correo Electrónico";
                dgv_DatosUsuariosB.Columns["Telefono"].HeaderText = "Teléfono";
                dgv_DatosUsuariosB.Columns["Direccion"].HeaderText = "Dirección";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            dgv_DatosUsuariosB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DatosUsuariosB.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv_DatosUsuariosB.RowTemplate.MinimumHeight = 35;
            dgv_DatosUsuariosB.AutoGenerateColumns = true;

            dgv_DatosUsuariosB.AllowUserToAddRows = false; // Desactiva la fila extra de edición
            dgv_DatosUsuariosB.ScrollBars = ScrollBars.Both;

            // Estilo visual
            dgv_DatosUsuariosB.BackgroundColor = Color.White;
            dgv_DatosUsuariosB.GridColor = Color.LightGray;
            dgv_DatosUsuariosB.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
           Fm_AUB _AUB = new Fm_AUB();
            _AUB.Show();
        }

        private void Fm_UsuariosB_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
    }
}
