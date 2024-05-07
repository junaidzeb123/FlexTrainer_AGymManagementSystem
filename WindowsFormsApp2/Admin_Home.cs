using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Admin_ReigistraionRequests admin_ReigistraionRequests = new Admin_ReigistraionRequests();   
            admin_ReigistraionRequests.Show();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminGymPerfomance adminGymPerfomance = new AdminGymPerfomance();
            adminGymPerfomance.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMemberControl adminMemberControl  =    new AdminMemberControl();
            adminMemberControl.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Reports adminReports = new Admin_Reports();
            adminReports.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Session.Logout();
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }
    }
}
