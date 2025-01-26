using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librery_Hub.Libros
{
    public partial class Fm_Libros : Form
    {
        public Fm_Libros()
        {
            InitializeComponent();
            btn_Eliminiar_Msg.Visible = true;
            btn_EditAlert.Visible = true;
        }

        private void txt_Buscar_Enter(object sender, EventArgs e)
        {
            if (txt_Buscar.Text == "Libro")
            {
                txt_Buscar.Text = "";
                txt_Buscar.ForeColor = Color.LightGray;
            }
        }

        private void txt_Buscar_Leave(object sender, EventArgs e)
        {
            if (txt_Buscar.Text == "")
            {
                txt_Buscar.Text = "Libro";
                txt_Buscar.ForeColor = Color.LightGray;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Fm_ALibro addLi = new Fm_ALibro();
            addLi.Show();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Eliminiar_Msg_Click(object sender, EventArgs e)
        {
            Fm_ELibro El = new Fm_ELibro();
            El.Show();
            btn_Eliminiar_Msg.Visible = false;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {


        }

        private void btn_EditAlert_Click(object sender, EventArgs e)
        {
            Fm_EditAlert alert = new Fm_EditAlert();
            alert.Show();
            btn_EditAlert.Visible = false;
        }
    }
}
