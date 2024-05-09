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
    public partial class GymOwner_Home : Form
    {
        public GymOwner_Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GymOwner_MemberSearch search = new GymOwner_MemberSearch();
            search.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gymowner_Search trainer = new Gymowner_Search();
            trainer.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Session.Logout();
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GymOwner_Profile ownerProfile = new GymOwner_Profile();
            ownerProfile.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            GymOwner_RegistrationRequests gymOwner_RegistrationRequests = new GymOwner_RegistrationRequests();  
            gymOwner_RegistrationRequests.Show();
        }
    }
}
