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
    public partial class Delete : Form
    {
        WindowsFormsAppProiect.ServiceReference1.WebService1SoapClient service = new WindowsFormsAppProiect.ServiceReference1.WebService1SoapClient();
        static string facultate;
        static string curs;
        static string nume;
        public Delete()
        {
            InitializeComponent();
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public void getFaculty(string name)
        {
            facultate = name;
            nume = "faculty";
            label1.Text = "Are you sure you wanna delete the " + nume+"?";
        }

        public void getCourse(string name)
        {
            curs = name;
            nume = "course";
            label1.Text = "Are you sure you wanna delete the " + nume+"?";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (facultate.Length > 1)
                {
                    if (service.deleteFaculty(facultate))
                    {
                        MessageBox.Show("Faculty deleted!");
                    }
                }
                else
                {
                    if (service.deleteCourse(curs))
                    {
                        MessageBox.Show("Course deleted!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
}
