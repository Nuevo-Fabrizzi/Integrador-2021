namespace Presentacion
{
    public partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TextBox_User = new System.Windows.Forms.TextBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.linklbl_RestartPass = new System.Windows.Forms.LinkLabel();
            this.iconclose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_User
            // 
            this.TextBox_User.Location = new System.Drawing.Point(129, 124);
            this.TextBox_User.Name = "TextBox_User";
            this.TextBox_User.Size = new System.Drawing.Size(129, 20);
            this.TextBox_User.TabIndex = 0;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(129, 159);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '*';
            this.TextBox_Password.Size = new System.Drawing.Size(129, 20);
            this.TextBox_Password.TabIndex = 1;
            // 
            // lbl_user
            // 
            this.lbl_user.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.White;
            this.lbl_user.Location = new System.Drawing.Point(45, 124);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(52, 17);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "Legajo";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.White;
            this.lbl_pass.Location = new System.Drawing.Point(39, 159);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(84, 17);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Contraseña";
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Ingresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.ForeColor = System.Drawing.Color.White;
            this.Btn_Ingresar.Location = new System.Drawing.Point(129, 215);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(129, 49);
            this.Btn_Ingresar.TabIndex = 4;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.UseVisualStyleBackColor = false;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            // 
            // linklbl_RestartPass
            // 
            this.linklbl_RestartPass.AutoSize = true;
            this.linklbl_RestartPass.BackColor = System.Drawing.Color.Transparent;
            this.linklbl_RestartPass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_RestartPass.LinkColor = System.Drawing.Color.SeaGreen;
            this.linklbl_RestartPass.Location = new System.Drawing.Point(126, 287);
            this.linklbl_RestartPass.Name = "linklbl_RestartPass";
            this.linklbl_RestartPass.Size = new System.Drawing.Size(136, 17);
            this.linklbl_RestartPass.TabIndex = 5;
            this.linklbl_RestartPass.TabStop = true;
            this.linklbl_RestartPass.Text = "Olvide mi contraseña";
            // 
            // iconclose
            // 
            this.iconclose.Image = ((System.Drawing.Image)(resources.GetObject("iconclose.Image")));
            this.iconclose.Location = new System.Drawing.Point(314, 12);
            this.iconclose.Name = "iconclose";
            this.iconclose.Size = new System.Drawing.Size(29, 24);
            this.iconclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconclose.TabIndex = 70;
            this.iconclose.TabStop = false;
            this.iconclose.Click += new System.EventHandler(this.iconclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, -44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 134);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(355, 392);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iconclose);
            this.Controls.Add(this.linklbl_RestartPass);
            this.Controls.Add(this.Btn_Ingresar);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabrizzi - Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_User;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.LinkLabel linklbl_RestartPass;
        private System.Windows.Forms.PictureBox iconclose;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

