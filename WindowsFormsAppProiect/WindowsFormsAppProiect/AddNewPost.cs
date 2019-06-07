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
    public partial class AddNewPost : Form
    {
        WindowsFormsAppProiect.ServiceReference1.WebService1SoapClient service = new WindowsFormsAppProiect.ServiceReference1.WebService1SoapClient();
        bool okTitle = false;
        string user;
        public AddNewPost()
        {
            InitializeComponent();
            comboBox1.Text = "Courses";
        }
        public void load()
        {
            DataSet dsCourses = new DataSet();
            //comboBox1.Items.Clear();
            try
            {
                dsCourses = service.getAllCourses();
                foreach (DataRow dr in dsCourses.Tables[0].Rows)
                {
                    String name = dr.ItemArray.GetValue(0).ToString();
                    comboBox1.Items.Add(name);
                }
            }
            catch
            {
                //do nothing i guess
            }

        }
        public void setUsername(string username)
        {
            user = username;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(okTitle && richTextBox1.Text.Length > 1)
            {
                MessageBox.Show(service.addPost(user, textBoxTitle.Text, richTextBox1.Text, comboBox1.Text, textBoxSourceLink.Text));
            }
            else
            {
                if (!okTitle)
                {
                    labelTitle.Text = "Title cannot be null.";
                }
                else
                {
                    MessageBox.Show("Content cannot be empty! Please write something useful!");
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTitle.Text.Length < 1)
            {
                labelTitle.Text = "Title cannot be null.";
                this.okTitle = false;
            }
            else
            {
                this.okTitle = true;
                labelTitle.Text = "";
            }
        }
    }
}
