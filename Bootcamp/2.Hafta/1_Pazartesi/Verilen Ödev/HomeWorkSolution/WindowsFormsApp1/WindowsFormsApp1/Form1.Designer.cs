namespace WindowsFormsApp1
{
    partial class FrmLogin
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
            this.TabLoginBox = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnMailExit = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnUserExit = new System.Windows.Forms.Button();
            this.BtnUserLogin = new System.Windows.Forms.Button();
            this.TxtUserPassword = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TabLoginBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabLoginBox
            // 
            this.TabLoginBox.Controls.Add(this.tabPage1);
            this.TabLoginBox.Controls.Add(this.tabPage2);
            this.TabLoginBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabLoginBox.HotTrack = true;
            this.TabLoginBox.Location = new System.Drawing.Point(0, 0);
            this.TabLoginBox.Margin = new System.Windows.Forms.Padding(2);
            this.TabLoginBox.Name = "TabLoginBox";
            this.TabLoginBox.SelectedIndex = 0;
            this.TabLoginBox.Size = new System.Drawing.Size(606, 331);
            this.TabLoginBox.TabIndex = 1;
            this.TabLoginBox.SelectedIndexChanged += new System.EventHandler(this.TabLoginBox_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.BtnMailExit);
            this.tabPage1.Controls.Add(this.TxtPassword);
            this.tabPage1.Controls.Add(this.BtnLogin);
            this.tabPage1.Controls.Add(this.TxtMail);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(598, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "E-Posta İle Giriş";
            // 
            // BtnMailExit
            // 
            this.BtnMailExit.BackColor = System.Drawing.Color.White;
            this.BtnMailExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnMailExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMailExit.Location = new System.Drawing.Point(248, 237);
            this.BtnMailExit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMailExit.Name = "BtnMailExit";
            this.BtnMailExit.Size = new System.Drawing.Size(102, 29);
            this.BtnMailExit.TabIndex = 1;
            this.BtnMailExit.Text = "Kayıt Ol";
            this.BtnMailExit.UseVisualStyleBackColor = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F);
            this.TxtPassword.Location = new System.Drawing.Point(198, 137);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(207, 26);
            this.TxtPassword.TabIndex = 3;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.White;
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnLogin.Location = new System.Drawing.Point(248, 184);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(102, 33);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Giriş";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F);
            this.TxtMail.Location = new System.Drawing.Point(198, 75);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(207, 26);
            this.TxtMail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(105, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(64, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Posta :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPage2.Controls.Add(this.BtnUserExit);
            this.tabPage2.Controls.Add(this.BtnUserLogin);
            this.tabPage2.Controls.Add(this.TxtUserPassword);
            this.tabPage2.Controls.Add(this.TxtUserName);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(598, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kullanıcı Adı ile Giriş";
            // 
            // BtnUserExit
            // 
            this.BtnUserExit.BackColor = System.Drawing.Color.White;
            this.BtnUserExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnUserExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnUserExit.Location = new System.Drawing.Point(257, 235);
            this.BtnUserExit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUserExit.Name = "BtnUserExit";
            this.BtnUserExit.Size = new System.Drawing.Size(107, 31);
            this.BtnUserExit.TabIndex = 9;
            this.BtnUserExit.Text = "Kayıt Ol";
            this.BtnUserExit.UseVisualStyleBackColor = false;
            // 
            // BtnUserLogin
            // 
            this.BtnUserLogin.BackColor = System.Drawing.Color.White;
            this.BtnUserLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnUserLogin.Location = new System.Drawing.Point(257, 188);
            this.BtnUserLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUserLogin.Name = "BtnUserLogin";
            this.BtnUserLogin.Size = new System.Drawing.Size(107, 34);
            this.BtnUserLogin.TabIndex = 8;
            this.BtnUserLogin.Text = "Giriş";
            this.BtnUserLogin.UseVisualStyleBackColor = false;
            this.BtnUserLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtUserPassword
            // 
            this.TxtUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F);
            this.TxtUserPassword.Location = new System.Drawing.Point(206, 137);
            this.TxtUserPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUserPassword.Name = "TxtUserPassword";
            this.TxtUserPassword.PasswordChar = '*';
            this.TxtUserPassword.Size = new System.Drawing.Size(223, 26);
            this.TxtUserPassword.TabIndex = 7;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.1F);
            this.TxtUserName.Location = new System.Drawing.Point(206, 80);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(223, 26);
            this.TxtUserName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(117, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(26, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kullanıcı Adı :";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 331);
            this.Controls.Add(this.TabLoginBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.TabLoginBox.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabLoginBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtUserPassword;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnMailExit;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnUserExit;
        private System.Windows.Forms.Button BtnUserLogin;
    }
}

