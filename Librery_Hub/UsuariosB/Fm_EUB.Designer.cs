namespace Librery_Hub.UsuariosB
{
    partial class Fm_EUB
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
            System.Windows.Forms.Label label1;
            this.Pl_movie = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Mini = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.Pl_movie.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pl_movie
            // 
            this.Pl_movie.Controls.Add(this.label2);
            this.Pl_movie.Controls.Add(this.btn_Close);
            this.Pl_movie.Controls.Add(this.btn_Mini);
            this.Pl_movie.Location = new System.Drawing.Point(-2, 0);
            this.Pl_movie.Name = "Pl_movie";
            this.Pl_movie.Size = new System.Drawing.Size(802, 30);
            this.Pl_movie.TabIndex = 8;
            this.Pl_movie.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pl_movie_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(182, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notificación";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Librery_Hub.Properties.Resources.fono_noti;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(label1);
            this.panel1.Location = new System.Drawing.Point(28, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 217);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Librery_Hub.Properties.Resources.adver;
            this.pictureBox1.Location = new System.Drawing.Point(178, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(121, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(22, 64);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(402, 68);
            label1.TabIndex = 9;
            label1.Text = "Para Eliminar un Lector porfavor busquelo en el cuadro de busqueda y seleccionelo" +
    " en la tabla y oprima el boton de eliminar";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::Librery_Hub.Properties.Resources.icons8_cerrar_ventana_50;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(461, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(27, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Mini
            // 
            this.btn_Mini.BackgroundImage = global::Librery_Hub.Properties.Resources.icons8_minimizar_50;
            this.btn_Mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Mini.FlatAppearance.BorderSize = 0;
            this.btn_Mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mini.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Mini.Location = new System.Drawing.Point(428, 3);
            this.btn_Mini.Name = "btn_Mini";
            this.btn_Mini.Size = new System.Drawing.Size(27, 23);
            this.btn_Mini.TabIndex = 1;
            this.btn_Mini.UseVisualStyleBackColor = false;
            this.btn_Mini.Click += new System.EventHandler(this.btn_Mini_Click);
            // 
            // Fm_EUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(488, 265);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pl_movie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fm_EUB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fm_EUB";
            this.Pl_movie.ResumeLayout(false);
            this.Pl_movie.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Pl_movie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Mini;
    }
}