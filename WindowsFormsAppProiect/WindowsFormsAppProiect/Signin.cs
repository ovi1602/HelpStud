using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProiect
{
    public partial class Signin : Form
    {
        WindowsFormsAppProiect.ServiceReference1.WebService1SoapClient service = new WindowsFormsAppProiect.ServiceReference1.WebService1SoapClient();
        public static int idUser = 0;
        private int isAdmin = 0;
        public Signin()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }


        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.Show();
        }

        private void buttonSignin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            if (service.logIn(textBoxUsername.Text, MD5Hash(textBoxPassword.Text), ref idUser, ref isAdmin) != 0)
             {
                 if(isAdmin == 1)
                 {
                    
                     Form1 f = new Form1(idUser);
                     f.setUsername(username);
                     
                     f.Show();
             
                 }else
                 {
                    AppUser au = new AppUser(idUser);
                    au.setUsername(username);
                    au.Show();
                 }

             }
             else
             {
                 MessageBox.Show("Wrong username/password");
             }
        }
    }
}
