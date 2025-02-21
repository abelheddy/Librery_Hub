namespace Librery_Hub.Libros
{
    partial class Fm_Libros
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
            this.dgvLibrosYCopias = new System.Windows.Forms.DataGridView();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.pl_Controls = new System.Windows.Forms.Panel();
            this.btn_EditAlert = new System.Windows.Forms.Button();
            this.btn_Eliminiar_Msg = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrosYCopias)).BeginInit();
            this.pl_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLibrosYCopias
            // 
            this.dgvLibrosYCopias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrosYCopias.Location = new System.Drawing.Point(35, 87);
            this.dgvLibrosYCopias.Name = "dgvLibrosYCopias";
            this.dgvLibrosYCopias.Size = new System.Drawing.Size(897, 352);
            this.dgvLibrosYCopias.TabIndex = 0;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BackColor = System.Drawing.Color.DimGray;
            this.txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Buscar.ForeColor = System.Drawing.Color.LightGray;
            this.txt_Buscar.Location = new System.Drawing.Point(212, 29);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(494, 20);
            this.txt_Buscar.TabIndex = 1;
            this.txt_Buscar.Text = "Libro";
            this.txt_Buscar.Enter += new System.EventHandler(this.txt_Buscar_Enter);
            this.txt_Buscar.Leave += new System.EventHandler(this.txt_Buscar_Leave);
            // 
            // pl_Controls
            // 
            this.pl_Controls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pl_Controls.Controls.Add(this.btn_EditAlert);
            this.pl_Controls.Controls.Add(this.btn_Eliminiar_Msg);
            this.pl_Controls.Controls.Add(this.btn_Editar);
            this.pl_Controls.Controls.Add(this.btn_Eliminar);
            this.pl_Controls.Controls.Add(this.btn_agregar);
            this.pl_Controls.Location = new System.Drawing.Point(129, 471);
            this.pl_Controls.Name = "pl_Controls";
            this.pl_Controls.Size = new System.Drawing.Size(718, 105);
            this.pl_Controls.TabIndex = 3;
            // 
            // btn_EditAlert
            // 
            this.btn_EditAlert.BackgroundImage = global::Librery_Hub.Properties.Resources.Editar_libro;
            this.btn_EditAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditAlert.FlatAppearance.BorderSize = 0;
            this.btn_EditAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditAlert.Location = new System.Drawing.Point(583, 27);
            this.btn_EditAlert.Name = "btn_EditAlert";
            this.btn_EditAlert.Size = new System.Drawing.Size(60, 50);
            this.btn_EditAlert.TabIndex = 4;
            this.btn_EditAlert.UseVisualStyleBackColor = true;
            this.btn_EditAlert.Click += new System.EventHandler(this.btn_EditAlert_Click);
            // 
            // btn_Eliminiar_Msg
            // 
            this.btn_Eliminiar_Msg.BackgroundImage = global::Librery_Hub.Properties.Resources.icons8_eliminar_libro_50;
            this.btn_Eliminiar_Msg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Eliminiar_Msg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminiar_Msg.FlatAppearance.BorderSize = 0;
            this.btn_Eliminiar_Msg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminiar_Msg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eliminiar_Msg.Location = new System.Drawing.Point(308, 27);
            this.btn_Eliminiar_Msg.Name = "btn_Eliminiar_Msg";
            this.btn_Eliminiar_Msg.Size = new System.Drawing.Size(60, 50);
            this.btn_Eliminiar_Msg.TabIndex = 3;
            this.btn_Eliminiar_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eliminiar_Msg.UseVisualStyleBackColor = true;
            this.btn_Eliminiar_Msg.Click += new System.EventHandler(this.btn_Eliminiar_Msg_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackgroundImage = global::Librery_Hub.Properties.Resources.Editar_libro;
            this.btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.FlatAppearance.BorderSize = 0;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Location = new System.Drawing.Point(583, 27);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(60, 50);
            this.btn_Editar.TabIndex = 2;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = global::Librery_Hub.Properties.Resources.icons8_eliminar_libro_50;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eliminar.Location = new System.Drawing.Point(308, 27);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(60, 50);
            this.btn_Eliminar.TabIndex = 1;
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = global::Librery_Hub.Properties.Resources.icons8_añadir_libro_50;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Location = new System.Drawing.Point(83, 27);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(60, 50);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackgroundImage = global::Librery_Hub.Properties.Resources.Search_02;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Location = new System.Drawing.Point(714, 27);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(32, 27);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Fm_Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(982, 588);
            this.Controls.Add(this.pl_Controls);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.dgvLibrosYCopias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fm_Libros";
            this.Text = "Fm_Libros";
            this.Load += new System.EventHandler(this.Fm_Libros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrosYCopias)).EndInit();
            this.pl_Controls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibrosYCopias;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Panel pl_Controls;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_Eliminiar_Msg;
        private System.Windows.Forms.Button btn_EditAlert;
    }
}