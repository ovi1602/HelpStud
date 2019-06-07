using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProiect
{
    public partial class Register : Form
    {
        WindowsFormsAppProiect.ServiceReference1.WebService1SoapClient service = new WindowsFormsAppProiect.ServiceReference1.WebService1SoapClient();

        public Register()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        bool okUsername=false;
        bool okPassword = false;
        bool okName = false;
        bool okEmail = false;



        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.Text.Length <= 5)
            {
                labelPassword.Text = "Password should be at least 6 characters.";
                this.okPassword = false;
            }
            else
            {
                this.okPassword = true;
                labelPassword.Text = "";
            }
        }


        private bool isEmail(String s)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(s);
                return addr.Address == s;
            }
            catch
            {
                return false;
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            if (!isEmail(email.Text))
            {
                labelEmail.Text = "Not a valid email.";
                this.okEmail = false;
            }
            else
            {
                this.okEmail = true;
                labelEmail.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (okUsername && okPassword && okEmail && okName)
            {
                MessageBox.Show(service.addUser(username.Text, Signin.MD5Hash(password.Text), email.Text,name.Text));
             
            }
            else
            {
                if (!okUsername)
                {
                    labelUsername.Text = "Username should be at least 4 characters.";
                }
                if (!okPassword)
                {
                    labelPassword.Text = "Password should be at least 6 characters.";
                }
                if(!okName)
                {
                    labelName.Text = "Name cannot be null.";
                }
                if(!okEmail)
                {
                    labelEmail.Text = "Not a valid email.";
                }
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (name.Text.Length <1)
            {
                labelName.Text = "Name cannot be null.";
                this.okName = false;
            }
            else
            {
                this.okName = true;
                labelName.Text = "";
            }
        }

        private void username_TextChanged_1(object sender, EventArgs e)
        {
            if (username.Text.Length <= 3)
            {
                labelUsername.Text = "Username should be at least 4 characters.";
                this.okUsername = false;
            }
            else
            {
                this.okUsername = true;
                labelUsername.Text = "";
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
