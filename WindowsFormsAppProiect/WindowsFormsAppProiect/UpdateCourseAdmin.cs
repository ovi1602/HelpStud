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

    public partial class UpdateCourseAdmin : Form
    {
        WindowsFormsAppProiect.ServiceReference1.WebService1SoapClient service = new WindowsFormsAppProiect.ServiceReference1.WebService1SoapClient();
        static string course;
        static string facultate;
        static int an;
        static int semestru;

        public UpdateCourseAdmin()
        {
            InitializeComponent();
        }

        public void getData(string name,string faculty, int year, int semester)
        {
            course = name;
            facultate = faculty;
            an = year;
            semestru = semester;
            fillInfo();
        }
        public void fillInfo()
        {
            label5.Text = course;
            label8.Text = facultate;
            label6.Text = an.ToString();
            label7.Text = semestru.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str="";
            if(textBoxName.Text.Length > 0)
            {
                str += "Name " + service.editCourseName(textBoxName.Text, course)+ " ";
                    
            }
            if(textBoxYear.Text.Length > 0)
            {
                str += "Year " + service.editCourseYear(Convert.ToInt32(textBoxYear.Text), course) + " ";
               
            }
            if (textBoxSemester.Text.Length > 0)
            {
                str +="Semester " + service.editCourseSemester(Convert.ToInt32(textBoxSemester.Text), course)+ " ";
             
            }
            if (textBoxFaculty.Text.Length > 0)
            {
                str +="Faculty "+ service.editCourseFaculty(textBoxFaculty.Text, course)+ " ";
            }
            if (str.Length > 1)
                MessageBox.Show("Edited!");
            else
                MessageBox.Show("Error!");

        }
    }
}
