using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;

namespace Unit3Assignment
{
    public partial class Form1 : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();

        string gender;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            info.name = tbName.Text;
            if (rbMale.Checked == true)
            {
                gender = "Male";
            }
            if (rbFemale.Checked == true)
            {
                gender = "Female";
            }
            info.gender = gender;

            info.dob = Convert.ToDateTime(dtpDOB.Value.ToShortDateString());
            info.address = tbAddress.Text;
            info.education = tbEducation.Text;
            info.username = tbUsername.Text;
            info.password = tbPassword.Text;

             int rows=opr.insertReg(info);
            if (rows > 0)
            {
                MessageBox.Show("Data saved successfully");
            }
        }
    }
}
