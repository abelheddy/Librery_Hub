namespace Librery_Hub.Libros.ISBN
{
    partial class Fm_ExistenteLibro
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
            this.label2 = new System.Windows.Forms.Label();
            this.Pl_movie = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Mini = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_BuscarISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pl_movie.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(311, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "BUSQUEDA DEL ISBN";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // Pl_movie
            // 
            this.Pl_movie.Controls.Add(this.label2);
            this.Pl_movie.Controls.Add(this.btn_Close);
            this.Pl_movie.Controls.Add(this.btn_Mini);
            this.Pl_movie.Location = new System.Drawing.Point(-4, 1);
            this.Pl_movie.Name = "Pl_movie";
            this.Pl_movie.Size = new System.Drawing.Size(807, 30);
            this.Pl_movie.TabIndex = 7;
            this.Pl_movie.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pl_movie_MouseDown);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::Librery_Hub.Properties.Resources.icons8_cerrar_ventana_50;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(773, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(27, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_Mini
            // 
            this.btn_Mini.BackgroundImage = global::Librery_Hub.Properties.Resources.icons8_minimizar_50;
            this.btn_Mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Mini.FlatAppearance.BorderSize = 0;
            this.btn_Mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mini.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Mini.Location = new System.Drawing.Point(740, 4);
            this.btn_Mini.Name = "btn_Mini";
            this.btn_Mini.Size = new System.Drawing.Size(27, 23);
            this.btn_Mini.TabIndex = 1;
            this.btn_Mini.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Librery_Hub.Properties.Resources.fondo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Btn_Buscar);
            this.panel1.Controls.Add(this.Txt_BuscarISBN);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 401);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Librery_Hub.Properties.Resources.EAN_13_ISBN_131;
            this.pictureBox1.Location = new System.Drawing.Point(298, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackgroundImage = global::Librery_Hub.Properties.Resources.Search_02;
            this.Btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Buscar.FlatAppearance.BorderSize = 0;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Buscar.Location = new System.Drawing.Point(564, 202);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(45, 41);
            this.Btn_Buscar.TabIndex = 1;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_BuscarISBN
            // 
            this.Txt_BuscarISBN.Location = new System.Drawing.Point(145, 213);
            this.Txt_BuscarISBN.Name = "Txt_BuscarISBN";
            this.Txt_BuscarISBN.Size = new System.Drawing.Size(353, 20);
            this.Txt_BuscarISBN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(142, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introdusca el ISBN del libro para buscar en la Base De Datos";
            // 
            // Fm_ExistenteLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pl_movie);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fm_ExistenteLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fm_ExistenteLibro";
            this.Pl_movie.ResumeLayout(false);
            this.Pl_movie.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Mini;
        private System.Windows.Forms.Panel Pl_movie;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_BuscarISBN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}