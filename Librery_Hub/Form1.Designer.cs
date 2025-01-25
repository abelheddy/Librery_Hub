namespace Librery_Hub
{
    partial class Fm_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.P_BaseLogin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Titlle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Mini = new System.Windows.Forms.Button();
            this.Pl_movie = new System.Windows.Forms.Panel();
            this.P_BaseLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // P_BaseLogin
            // 
            this.P_BaseLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.P_BaseLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_BaseLogin.Controls.Add(this.label1);
            this.P_BaseLogin.Controls.Add(this.lbl_Titlle);
            this.P_BaseLogin.Controls.Add(this.pictureBox1);
            this.P_BaseLogin.Controls.Add(this.txtPass);
            this.P_BaseLogin.Controls.Add(this.txtUser);
            this.P_BaseLogin.Controls.Add(this.btn_Login);
            this.P_BaseLogin.Location = new System.Drawing.Point(135, 32);
            this.P_BaseLogin.Name = "P_BaseLogin";
            this.P_BaseLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.P_BaseLogin.Size = new System.Drawing.Size(509, 534);
            this.P_BaseLogin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 160);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(325, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Un libro es el puente hacia un mundo de posibilidades, y nuestra biblioteca es la" +
    " llave que te invita a cruzarlo.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            this.label1.UseWaitCursor = true;
            // 
            // lbl_Titlle
            // 
            this.lbl_Titlle.AutoSize = true;
            this.lbl_Titlle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titlle.ForeColor = System.Drawing.Color.White;
            this.lbl_Titlle.Location = new System.Drawing.Point(181, 19);
            this.lbl_Titlle.Name = "lbl_Titlle";
            this.lbl_Titlle.Size = new System.Drawing.Size(155, 16);
            this.lbl_Titlle.TabIndex = 4;
            this.lbl_Titlle.Text = "Sistema Bibliotecario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Librery_Hub.Properties.Resources.icons8_usuario_100;
            this.pictureBox1.Location = new System.Drawing.Point(205, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPass.Location = new System.Drawing.Point(108, 306);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(305, 13);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "Password";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUser.Location = new System.Drawing.Point(108, 235);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(305, 13);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Usuario";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(151, 399);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(209, 32);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::Librery_Hub.Properties.Resources.icons8_cerrar_ventana_50;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(758, 12);
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
            this.btn_Mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mini.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Mini.Location = new System.Drawing.Point(725, 12);
            this.btn_Mini.Name = "btn_Mini";
            this.btn_Mini.Size = new System.Drawing.Size(27, 23);
            this.btn_Mini.TabIndex = 1;
            this.btn_Mini.UseVisualStyleBackColor = false;
            this.btn_Mini.Click += new System.EventHandler(this.btn_Mini_Click);
            // 
            // Pl_movie
            // 
            this.Pl_movie.Location = new System.Drawing.Point(-1, 0);
            this.Pl_movie.Name = "Pl_movie";
            this.Pl_movie.Size = new System.Drawing.Size(720, 26);
            this.Pl_movie.TabIndex = 3;
            this.Pl_movie.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pl_movie_MouseDown);
            // 
            // Fm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.Pl_movie);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Mini);
            this.Controls.Add(this.P_BaseLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fm_Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.P_BaseLogin.ResumeLayout(false);
            this.P_BaseLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_BaseLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Titlle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Mini;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel Pl_movie;
    }
}

