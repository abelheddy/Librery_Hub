namespace Librery_Hub.UsuariosB
{
    partial class Fm_UsuariosB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pl_Controls = new System.Windows.Forms.Panel();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dgv_DatosUsuariosB = new System.Windows.Forms.DataGridView();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_AlertE = new System.Windows.Forms.Button();
            this.pl_Controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DatosUsuariosB)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_Controls
            // 
            this.pl_Controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pl_Controls.Controls.Add(this.btn_AlertE);
            this.pl_Controls.Controls.Add(this.btn_Editar);
            this.pl_Controls.Controls.Add(this.btn_Eliminar);
            this.pl_Controls.Controls.Add(this.btn_agregar);
            this.pl_Controls.Location = new System.Drawing.Point(137, 464);
            this.pl_Controls.Name = "pl_Controls";
            this.pl_Controls.Size = new System.Drawing.Size(718, 105);
            this.pl_Controls.TabIndex = 11;
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.DimGray;
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.ForeColor = System.Drawing.Color.LightGray;
            this.txt_buscar.Location = new System.Drawing.Point(220, 23);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(494, 21);
            this.txt_buscar.TabIndex = 9;
            this.txt_buscar.Text = "Matricula";
            this.txt_buscar.Enter += new System.EventHandler(this.txt_buscar_Enter);
            this.txt_buscar.Leave += new System.EventHandler(this.txt_buscar_Leave);
            // 
            // dgv_DatosUsuariosB
            // 
            this.dgv_DatosUsuariosB.AllowUserToAddRows = false;
            this.dgv_DatosUsuariosB.AllowUserToDeleteRows = false;
            this.dgv_DatosUsuariosB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DatosUsuariosB.Location = new System.Drawing.Point(43, 80);
            this.dgv_DatosUsuariosB.Name = "dgv_DatosUsuariosB";
            this.dgv_DatosUsuariosB.ReadOnly = true;
            this.dgv_DatosUsuariosB.Size = new System.Drawing.Size(897, 352);
            this.dgv_DatosUsuariosB.TabIndex = 8;
            this.dgv_DatosUsuariosB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DatosUsuariosB_CellClick);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Editar.BackgroundImage = global::Librery_Hub.Properties.Resources.Edit;
            this.btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.FlatAppearance.BorderSize = 0;
            this.btn_Editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Location = new System.Drawing.Point(552, 15);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 74);
            this.btn_Editar.TabIndex = 2;
            this.btn_Editar.UseVisualStyleBackColor = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.BackgroundImage = global::Librery_Hub.Properties.Resources.Delete;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Location = new System.Drawing.Point(321, 15);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 74);
            this.btn_Eliminar.TabIndex = 1;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar.BackgroundImage = global::Librery_Hub.Properties.Resources.Add;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Location = new System.Drawing.Point(83, 15);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 74);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Buscar.BackgroundImage = global::Librery_Hub.Properties.Resources.Search_02;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Location = new System.Drawing.Point(720, 20);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(44, 31);
            this.btn_Buscar.TabIndex = 10;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // btn_AlertE
            // 
            this.btn_AlertE.BackColor = System.Drawing.Color.Transparent;
            this.btn_AlertE.BackgroundImage = global::Librery_Hub.Properties.Resources.Delete;
            this.btn_AlertE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AlertE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AlertE.FlatAppearance.BorderSize = 0;
            this.btn_AlertE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_AlertE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btn_AlertE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AlertE.Location = new System.Drawing.Point(321, 15);
            this.btn_AlertE.Name = "btn_AlertE";
            this.btn_AlertE.Size = new System.Drawing.Size(75, 74);
            this.btn_AlertE.TabIndex = 3;
            this.btn_AlertE.UseVisualStyleBackColor = false;
            this.btn_AlertE.Click += new System.EventHandler(this.btn_AlertE_Click);
            // 
            // Fm_UsuariosB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(982, 588);
            this.Controls.Add(this.pl_Controls);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.dgv_DatosUsuariosB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fm_UsuariosB";
            this.Text = "Fm_UsuariosB";
            this.Load += new System.EventHandler(this.Fm_UsuariosB_Load);
            this.pl_Controls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DatosUsuariosB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pl_Controls;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView dgv_DatosUsuariosB;
        private System.Windows.Forms.Button btn_AlertE;
    }
}