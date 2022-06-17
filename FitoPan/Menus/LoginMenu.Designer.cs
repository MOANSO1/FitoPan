namespace FitoPan
{
    partial class LoginMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMenu));
            this.ImageExit = new System.Windows.Forms.PictureBox();
            this.ImageProfileLogin = new System.Windows.Forms.PictureBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rpta_username = new System.Windows.Forms.TextBox();
            this.rpta_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProfileLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageExit
            // 
            this.ImageExit.Image = global::FitoPan.Properties.Resources.ExitImage;
            this.ImageExit.Location = new System.Drawing.Point(8, 460);
            this.ImageExit.Name = "ImageExit";
            this.ImageExit.Size = new System.Drawing.Size(66, 89);
            this.ImageExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageExit.TabIndex = 1;
            this.ImageExit.TabStop = false;
            this.ImageExit.Click += new System.EventHandler(this.ImageExit_Click);
            // 
            // ImageProfileLogin
            // 
            this.ImageProfileLogin.Image = global::FitoPan.Properties.Resources.LoginProfile;
            this.ImageProfileLogin.Location = new System.Drawing.Point(150, 20);
            this.ImageProfileLogin.Name = "ImageProfileLogin";
            this.ImageProfileLogin.Size = new System.Drawing.Size(146, 125);
            this.ImageProfileLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageProfileLogin.TabIndex = 0;
            this.ImageProfileLogin.TabStop = false;
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.Location = new System.Drawing.Point(120, 160);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(228, 47);
            this.label_Login.TabIndex = 2;
            this.label_Login.Text = "Iniciar Sesión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // rpta_username
            // 
            this.rpta_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpta_username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpta_username.Location = new System.Drawing.Point(16, 255);
            this.rpta_username.Name = "rpta_username";
            this.rpta_username.Size = new System.Drawing.Size(422, 26);
            this.rpta_username.TabIndex = 4;
            // 
            // rpta_password
            // 
            this.rpta_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpta_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpta_password.Location = new System.Drawing.Point(16, 322);
            this.rpta_password.Name = "rpta_password";
            this.rpta_password.PasswordChar = '*';
            this.rpta_password.Size = new System.Drawing.Size(422, 26);
            this.rpta_password.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(119, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Iniciar Sesión";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rpta_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rpta_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.ImageExit);
            this.Controls.Add(this.ImageProfileLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ImageExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProfileLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageProfileLogin;
        private System.Windows.Forms.PictureBox ImageExit;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rpta_username;
        private System.Windows.Forms.TextBox rpta_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

