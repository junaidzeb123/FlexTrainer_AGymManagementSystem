using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Security.Cryptography;

namespace WindowsFormsApp2
{
    public partial class LoginPage : Form
    {


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignupPage signupPage = new SignupPage();   
            signupPage.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 40, 40));
        }


        private void memberLogin()
        {


            SqlConnection sqlConnection = DatabaseManager.GetConnection();
            sqlConnection.Open();

            string checkQuery = "SELECT COUNT(*) FROM Member WHERE UserName = @username and Password = @password";

            string passwordstring = password.Text.Trim();
            string UserNamestring = username.Text.Trim();

            SqlCommand cmd5 = new SqlCommand(checkQuery, sqlConnection);
            cmd5.Parameters.AddWithValue("@username", UserNamestring);
            cmd5.Parameters.AddWithValue("@password", passwordstring);
            int count = (int)cmd5.ExecuteScalar();

            if (count == 0)
            {
                MessageBox.Show("InvalidCredencils");
                return;
            }

            sqlConnection.Close();
            /*Creating login session for member*/
            Session.Login(UserNamestring,"Member");
            this.Hide();
            Member_Home registerAsMember = new Member_Home();
            registerAsMember.Show();
        }

        private void TrainerLogin()
        {

            SqlConnection sqlConnection = DatabaseManager.GetConnection();
            sqlConnection.Open();

            string checkQuery = "SELECT COUNT(*) FROM Trainer WHERE UserName = @username and Password = @password";

            string passwordstring = password.Text.Trim();
            string UserNamestring = username.Text.Trim();

            SqlCommand cmd5 = new SqlCommand(checkQuery, sqlConnection);
            cmd5.Parameters.AddWithValue("@username", UserNamestring);
            cmd5.Parameters.AddWithValue("@password", passwordstring);
            int count = (int)cmd5.ExecuteScalar();

            if (count == 0)
            {
                MessageBox.Show("InvalidCredencils");
                return;
            }



            string checkQuery2 = "SELECT VarificationStatus FROM Trainer WHERE UserName = @username and Password = @password";
            SqlCommand cmd6 = new SqlCommand(checkQuery2, sqlConnection);
            cmd6.Parameters.AddWithValue("@username", UserNamestring);
            cmd6.Parameters.AddWithValue("@password", passwordstring);
            int status = (int)cmd6.ExecuteScalar();

            if (status == 0)
            {
                MessageBox.Show("Gym Owner did't Approve you");
                return;

            }

            sqlConnection.Close();
            /*Creating login session for Trainer*/
            Session.Login(UserNamestring, "Trainer");
            this.Hide();
            TrainenHome registerTrainer = new TrainenHome();
            registerTrainer.Show();
            

        }
        private void GymOwnerLogin()
        {

            SqlConnection sqlConnection = DatabaseManager.GetConnection();
            sqlConnection.Open();

            string checkQuery = "SELECT COUNT(*) FROM Gym_Owner WHERE UserName = @username and Password = @password";

            string passwordstring = password.Text.Trim();
            string UserNamestring = username.Text.Trim();

            SqlCommand cmd5 = new SqlCommand(checkQuery, sqlConnection);
            cmd5.Parameters.AddWithValue("@username", UserNamestring);
            cmd5.Parameters.AddWithValue("@password", passwordstring);
            int count = (int)cmd5.ExecuteScalar();

            if (count == 0)
            {
                MessageBox.Show("InvalidCredencils");
                return;
            }


            string checkQuery2 = "SELECT VarificationStatus FROM Gym_Owner WHERE UserName = @username and Password = @password";
            SqlCommand cmd6 = new SqlCommand(checkQuery2, sqlConnection);
            cmd6.Parameters.AddWithValue("@username", UserNamestring);
            cmd6.Parameters.AddWithValue("@password", passwordstring);
            int status = (int)cmd6.ExecuteScalar();

            if (status == 0)
            {
                MessageBox.Show("Admin Have did't approve you.");
                return;

            }


            sqlConnection.Close();
            /*Creating login session for Gym_Owner*/
            Session.Login(UserNamestring, "Gym_Owner");
            this.Hide();
            GymOwner_Home signupAsGymOwner = new GymOwner_Home();
            signupAsGymOwner.Show();

        }

        private void adminLogin()
        {

            if (username.Text.Trim() == "admin" && password.Text.Trim() == "admin")
            {
                /*Creating login session for adming*/
                Session.Login("admin", "Admin");
                this.Hide();
                Admin_Home signupAsGymOwner = new Admin_Home();
                signupAsGymOwner.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                MessageBox.Show("Please Complete you information");
            else if (radioButton1.Checked)
            {

                TrainerLogin();
            }
            else if (radioButton2.Checked)
            {
                GymOwnerLogin();        
            }
            else if (radioButton3.Checked)
            {
                memberLogin();
            }
            else
            {
                adminLogin();
            }

        
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
