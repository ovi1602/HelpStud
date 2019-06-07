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
    public partial class UpdateFacultyAdmin : Form
    {
        WindowsFormsAppProiect.ServiceReference1.WebService1SoapClient service = new WindowsFormsAppProiect.ServiceReference1.WebService1SoapClient();
        static string facultate;
        public UpdateFacultyAdmin()
        {
            InitializeComponent();
            
        }
  
        public void getFaculty(string name)
        {
            facultate = name;
            fillInfo();
        }
        public void fillInfo()
        {
            labelOldName.Text = facultate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (facultate != null)
            {
                if (service.updateFaculty(textBoxNewName.Text, facultate))
                {
                    MessageBox.Show("Faculty updated!");
                }
                else MessageBox.Show("Error!");
            }
            else
            {
                MessageBox.Show("Name cannot be null!");
            }

        }
    }
}
