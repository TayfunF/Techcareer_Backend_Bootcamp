using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmLogin : Form
    {
        private enum TLoginType { LtMail, LtUsername };
        private TLoginType LoginType = TLoginType.LtMail;

        private const string DbMailAddress = "mail";
        private const string DbPasswordOne = "password";

        private const string DbUserName = "admin";
        private const string DbPasswordTwo = "password";


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Username, Password, MailAddress;

            //-------------E-Posta Ile Giris-------------
            if (LoginType == TLoginType.LtMail)
            {
                if (TxtMail.Text.Trim() == "" || TxtPassword.Text.Trim() == "")
                    MessageBox.Show("Mail adresi veya şifre boş olamaz.");
                else
                {
                    MailAddress = TxtMail.Text.Trim();
                    Password = TxtPassword.Text.Trim();

                    if (DbMailAddress != MailAddress)
                        MessageBox.Show("Giriş bilgileri hatalı");
                    else
                    {
                        if (DbPasswordOne != Password)
                            MessageBox.Show("Giriş bilgileri hatalı");
                        else
                        {
                            if (DbMailAddress == MailAddress && DbPasswordOne == Password)
                                MessageBox.Show("Giriş başarılı");
                        }
                    }
                }
            }
            //-------------E-Posta Ile Giris-------------

            //-------------Kullanıcı Adi Ile Giris-------------
            if (LoginType == TLoginType.LtUsername)
            {
                if (TxtUserName.Text.Trim() == "" || TxtUserPassword.Text.Trim() == "")
                    MessageBox.Show("Kullanıcı Adı ya da Şifre Boş Bırakılamaz !!");
                else
                {
                    Username = TxtUserName.Text.Trim();
                    Password = TxtUserPassword.Text.Trim();

                    if (DbUserName != Username)
                    {
                        MessageBox.Show("Giriş Bilgileri Hatalı");
                    }
                    else
                    {
                        if (DbPasswordTwo != Password)
                            MessageBox.Show("Giriş Bilgileri Hatalı");
                        else
                        {
                            if (DbUserName == Username && DbPasswordTwo == Password)
                                MessageBox.Show("Giriş Başarılı");
                        }
                    }
                }
            }
            //-------------/Kullanıcı Adi Ile Giris-------------

        }

        private void TabLoginBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabLoginBox.SelectedIndex == 0)
                LoginType = TLoginType.LtMail;
            else if (TabLoginBox.SelectedIndex == 1)
                LoginType = TLoginType.LtUsername;
        }

       
    }
}
