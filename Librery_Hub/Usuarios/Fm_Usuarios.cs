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

namespace Librery_Hub.Usuarios
{
    public partial class Fm_Usuarios : Form
    {
        public Fm_Usuarios()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            dgv_DatosUsuarios.DataBindingComplete += dgv_DatosUsuarios_DataBindingComplete;

        }

        private void txt_buscar_Enter(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "Usuario")
            {
                txt_buscar.Text = "";
                txt_buscar.ForeColor = Color.LightGray;
            }
        }

        private void txt_buscar_Leave(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "")
            {
                txt_buscar.Text = "Usuario";
                txt_buscar.ForeColor = Color.LightGray;
            }
        }

        //mostrar datos en el dataGrid
        private void CargarDatosUsuarios()
        {
            try
            {
                CNUsuarios objNegocio = new CNUsuarios();
                DataTable dtUsuarios = objNegocio.ObtenerUsuarios();

                // Asignar el DataTable al DataGridView
                dgv_DatosUsuarios.DataSource = dtUsuarios;
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre una excepción
                MessageBox.Show("Error al cargar los datos de los usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Fm_AUsuarios adUsuarios = new Fm_AUsuarios();
            adUsuarios.Show();
        }

        private void Fm_Usuarios_Load(object sender, EventArgs e)
        {
            // Llamar al método para cargar los datos al cargar el formulario
            CargarDatosUsuarios();
        }
        private void ConfigurarDataGridView()
        {
            dgv_DatosUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DatosUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv_DatosUsuarios.RowTemplate.MinimumHeight = 35;
            dgv_DatosUsuarios.AutoGenerateColumns = true;

            dgv_DatosUsuarios.AllowUserToAddRows = false; // Desactiva la fila extra de edición
            dgv_DatosUsuarios.ScrollBars = ScrollBars.Both;

            // Estilo visual
            dgv_DatosUsuarios.BackgroundColor = Color.White;
            dgv_DatosUsuarios.GridColor = Color.LightGray;
            dgv_DatosUsuarios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // Rellenar celdas vacías con un espacio en blanco
        private void dgv_DatosUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Si hay menos filas que el espacio disponible, agrega filas vacías
            //while (dgv_DatosUsuarios.Rows.Count < 10) // Cambia 10 según lo necesario
            //{
                //dgv_DatosUsuarios.Rows.Add();
            //}
        }

    }
}
