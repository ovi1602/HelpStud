using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProiect
{
    public partial class AppUser : Form
    {
        WindowsFormsAppProiect.ServiceReference1.WebService1SoapClient service = new WindowsFormsAppProiect.ServiceReference1.WebService1SoapClient();
        static string fac;
        static int an;
        static int sem;
        protected int idUser;
        static string user;
        public AppUser(int idUser)
        {
            this.idUser = idUser;
            InitializeComponent();
            LoadYearSemester();
            LoadTitles();
            comboBox1.Text = "Faculty";
            textBoxNewPassword.PasswordChar = '*';
            textBoxoldPassword.PasswordChar = '*';

            DataSet dsFaculties = new DataSet();

            dsFaculties = service.getAllFaculties();

            try
            {

                foreach (DataRow dr in dsFaculties.Tables[0].Rows)

                {
                    String name = dr.ItemArray.GetValue(1).ToString();
                    comboBox1.Items.Add(name);
                }
            }

            catch (Exception xe)
            {
                MessageBox.Show("No faculties");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void setUsername(string usern)
        {
            user = usern;
            fillInfo();
        }
        public void fillInfo()
        {

            string str = service.getUserData(user);
            if (str.Length > 1)
            {
                string[] str1 = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                labelName.Text = str1[0].ToString();
                labelEmail.Text = str1[1].ToString();
            }
            labelUsername.Text = user;
            labelUser.Text = user;
            try
            {
                if (service.getImage(user) != null)
                {
                    byte[] img = service.getImage(user);
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch
            {

            }
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fac = comboBox1.Text;
            comboBox4.Items.Clear();
            comboBox4.Text = "Course";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            an = Convert.ToInt16(comboBox2.Text);
            comboBox4.Items.Clear();
            comboBox4.Text = "Course";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            sem = Convert.ToInt16(comboBox3.Text);
            DataSet dsCourses = new DataSet();

            try
            {
                dsCourses = service.getCourse(fac, an, sem);
                foreach (DataRow dr in dsCourses.Tables[0].Rows)
                {
                    String name = dr.ItemArray.GetValue(0).ToString();
                    comboBox4.Items.Add(name);
                }
            }
            catch
            {
                //do nothing i guess
            }
        }
        private void LoadYearSemester()
        {
            comboBox2.Text = "Year";
            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");
            comboBox3.Text = "Semester";
            comboBox3.Items.Add("1");
            comboBox3.Items.Add("2");
            comboBox4.Text = "Course";
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTitles();
        }

        private void listboxTitluriPostari_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsContent = new DataSet();
            DataSet dsLink = new DataSet();
            try
            {
                dsContent = service.getPostByTitle(listboxTitluriPostari.GetItemText(listboxTitluriPostari.SelectedItem));
                dsLink = service.getLinkByTitle(listboxTitluriPostari.GetItemText(listboxTitluriPostari.SelectedItem));
                foreach (DataRow dr in dsContent.Tables[0].Rows)
                {
                    String name = dr.ItemArray.GetValue(0).ToString();
                    contentTextbox.Text = name;
                }
                foreach (DataRow dr in dsLink.Tables[0].Rows)
                {
                    String link = dr.ItemArray.GetValue(0).ToString();
                    linkSources.Text = link;
                }
            }
            catch
            {
                //do nothing
            }
        }
        DataSet dsTitles = new DataSet();


        public void LoadTitles()
        {
            listboxTitluriPostari.Items.Clear();

            if (!comboBox4.Text.Equals("Course"))
            {
                try
                {
                    this.dsTitles = service.getTitleByCourse(comboBox4.Text);
                    foreach (DataRow dr in dsTitles.Tables[0].Rows)
                    {
                        String name = dr.ItemArray.GetValue(0).ToString();
                        listboxTitluriPostari.Items.Add(name);
                    }
                }
                catch
                {
                    //do nothing i guess
                }
            }
            else
            {
                try
                {
                    this.dsTitles = service.getAllPosts();
                    foreach (DataRow dr in dsTitles.Tables[0].Rows)
                    {
                        String name = dr.ItemArray.GetValue(0).ToString();
                        listboxTitluriPostari.Items.Add(name);
                    }
                }
                catch
                {
                    //do nothing i guess
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string user = labelUser.Text;
            AddNewPost anp = new AddNewPost();
            anp.setUsername(user);
            anp.load();
            anp.Show();
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            try
            {
                string oldName = labelName.Text;
                string newName = textBoxName.Text;
                if (service.editName(newName, user))
                {
                    MessageBox.Show("Name changed!");
                    labelName.Text = newName;
                    textBoxName.Text = "";
                }
            }catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string newUsername = textBoxUsername.Text;
            string str = service.editUsername(newUsername, user);
            MessageBox.Show(str);
            if (str == "Username Edited!")
            {
                labelUsername.Text = newUsername;
                labelUser.Text = newUsername;
                textBoxUsername.Text = "";
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (!isEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Not a valid email.");

            }
            else
            {
                string newEmail = textBoxEmail.Text;
                MessageBox.Show(service.editEmail(newEmail, user));
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text.Length <= 5)
            {
                MessageBox.Show("Password should be at least 6 characters.");

            }
            else
            {
                MessageBox.Show(service.editPassword(MD5Hash(textBoxNewPassword.Text), MD5Hash(textBoxoldPassword.Text), labelUser.Text));
            }
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file(*.jpg)|*.jpg|(*.png)|*.png";
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    //pictureBox1.ImageLocation = ofd.FileName;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    Image img = pictureBox1.Image;
                    byte[] arr = ImageToByteArray(img);
                    /*
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                    */
                    //MessageBox.Show("Alo");
                    MessageBox.Show(service.insertImage(arr, user));
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkSources_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkSources.Text);
        }

        private void contentTextbox_TextChanged(object sender, EventArgs e)
        {
            LoadComments();
        }
        private void LoadComments()
        {
            DataSet dsComments = new DataSet();
            richTextBox1.Text = "";
            try
            {
                dsComments = service.getComments(listboxTitluriPostari.GetItemText(listboxTitluriPostari.SelectedItem));
                foreach (DataRow dr in dsComments.Tables[0].Rows)
                {
                    String name = dr.ItemArray.GetValue(0).ToString();
                    int name2 = (int)dr.ItemArray.GetValue(1);
                    richTextBox1.Text += service.getUsernameById(name2) + ": " + name + "\n";

                }
            }
            catch
            {
                //do nothing i guess
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            service.postComment(listboxTitluriPostari.GetItemText(listboxTitluriPostari.SelectedItem), idUser, textBoxComment.Text);
            LoadComments();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            DataSet dsFaculties = new DataSet();

            dsFaculties = service.getAllFaculties();

            try
            {

                foreach (DataRow dr in dsFaculties.Tables[0].Rows)

                {
                    String name = dr.ItemArray.GetValue(1).ToString();
                    comboBox1.Items.Add(name);
                }
            }

            catch (Exception xe)
            {
                MessageBox.Show("No faculties");
            }

            DataSet dsCourses = new DataSet();
            comboBox4.Items.Clear();
            try
            {
                dsCourses = service.getCourse(fac, an, sem);
                foreach (DataRow dr in dsCourses.Tables[0].Rows)
                {
                    String name = dr.ItemArray.GetValue(0).ToString();
                    comboBox4.Items.Add(name);
                }
            }
            catch
            {
                //do nothing i guess
            }

            LoadTitles();

        }
    }
}
