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
    public partial class Login : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();

        DataTable dt = new DataTable();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            info.username = tbUname.Text;
            info.password = tbPassword.Text;

            dt = opr.login(info);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                MDI mde = new MDI();
                mde.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }
    }
}
