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
    public partial class InsertCourseAdmin : Form
    {
        bool okName = false;
        bool okYear = false;
        bool okSemester = false;
        bool okFaculty = false;
        WindowsFormsAppProiect.ServiceReference1.WebService1SoapClient service = new WindowsFormsAppProiect.ServiceReference1.WebService1SoapClient();
        public InsertCourseAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (okName && okYear && okSemester && okFaculty)
            {
                MessageBox.Show(service.addCourse(Convert.ToInt16(textBoxYear.Text), Convert.ToInt16(textBoxSemester.Text), textBoxFaculty.Text, textBoxName.Text));

            }
            else
            {
                if (!okName)
                {
                    labelName.Text = "Name cannot be null.";
                }
                if (!okYear)
                {
                    labelYear.Text = "Year cannot be null and must be a number.";
                }
                if (!okSemester)
                {
                    labelSemester.Text = "Semester cannot be null and must be a number.";
                }
                if (!okFaculty)
                {
                    labelFaculty.Text = "Faculty cannot be null.";
                }
            }
            
         
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length < 1)
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

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (textBoxYear.Text.Length < 1 || !(int.TryParse(textBoxYear.Text, out value)))
            {
                if (textBoxYear.Text.Length < 1)
                {
                    labelYear.Text = "Year cannot be null.";
                    this.okYear = false;
                }
                else
                {
                    labelYear.Text = "Year must be a number.";
                    this.okYear = false;
                }
            }
            else
            {
                this.okYear = true;
                labelYear.Text = "";
            }
        }

        private void textBoxSemester_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (textBoxSemester.Text.Length < 1 || !(int.TryParse(textBoxSemester.Text, out value)))
            {
                if (textBoxSemester.Text.Length < 1)
                {
                    labelSemester.Text = "Semester cannot be null.";
                    this.okSemester = false;
                }
                else
                {
                    labelSemester.Text = "Semester must be a number.";
                    this.okSemester = false;
                }
            }
            else
            {
                this.okSemester = true;
                labelSemester.Text = "";
            }
        }

        private void textBoxFaculty_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFaculty.Text.Length < 1)
            {
                labelFaculty.Text = "Faculty cannot be null.";
                this.okFaculty = false;
            }
            else
            {
                this.okFaculty = true;
                labelFaculty.Text = "";
            }
        }
    }
}
