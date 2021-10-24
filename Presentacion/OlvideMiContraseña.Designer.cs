
namespace Presentacion
{
    partial class OlvideMiContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OlvideMiContraseña));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconclose = new System.Windows.Forms.PictureBox();
            this.Btn_IngresarRecuperarPass = new System.Windows.Forms.Button();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.TextBox_User = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 134);
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // iconclose
            // 
            this.iconclose.Image = ((System.Drawing.Image)(resources.GetObject("iconclose.Image")));
            this.iconclose.Location = new System.Drawing.Point(357, 12);
            this.iconclose.Name = "iconclose";
            this.iconclose.Size = new System.Drawing.Size(29, 24);
            this.iconclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconclose.TabIndex = 78;
            this.iconclose.TabStop = false;
            // 
            // Btn_IngresarRecuperarPass
            // 
            this.Btn_IngresarRecuperarPass.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_IngresarRecuperarPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_IngresarRecuperarPass.ForeColor = System.Drawing.Color.White;
            this.Btn_IngresarRecuperarPass.Location = new System.Drawing.Point(138, 249);
            this.Btn_IngresarRecuperarPass.Name = "Btn_IngresarRecuperarPass";
            this.Btn_IngresarRecuperarPass.Size = new System.Drawing.Size(129, 49);
            this.Btn_IngresarRecuperarPass.TabIndex = 76;
            this.Btn_IngresarRecuperarPass.Text = "Guardar";
            this.Btn_IngresarRecuperarPass.UseVisualStyleBackColor = false;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.White;
            this.lbl_pass.Location = new System.Drawing.Point(40, 193);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(149, 17);
            this.lbl_pass.TabIndex = 75;
            this.lbl_pass.Text = "Reingrese Contraseña";
            // 
            // lbl_user
            // 
            this.lbl_user.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.White;
            this.lbl_user.Location = new System.Drawing.Point(40, 158);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(131, 17);
            this.lbl_user.TabIndex = 74;
            this.lbl_user.Text = "Nueva Contraseña";
            this.lbl_user.Click += new System.EventHandler(this.lbl_user_Click);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(201, 193);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '*';
            this.TextBox_Password.Size = new System.Drawing.Size(129, 20);
            this.TextBox_Password.TabIndex = 73;
            // 
            // TextBox_User
            // 
            this.TextBox_User.Location = new System.Drawing.Point(201, 158);
            this.TextBox_User.Name = "TextBox_User";
            this.TextBox_User.Size = new System.Drawing.Size(129, 20);
            this.TextBox_User.TabIndex = 72;
            // 
            // OlvideMiContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(398, 367);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iconclose);
            this.Controls.Add(this.Btn_IngresarRecuperarPass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OlvideMiContraseña";
            this.Text = "OlvideMiContraseña";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iconclose;
        private System.Windows.Forms.Button Btn_IngresarRecuperarPass;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.TextBox TextBox_User;
    }
}