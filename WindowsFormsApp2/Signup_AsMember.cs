using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp2
{
    public partial class Signup_AsMember : Form
    {
        Member_class member;
        public Signup_AsMember(Member_class member)
        {
            InitializeComponent();
            this.member = member;
            SqlConnection sqlConnection = DatabaseManager.GetConnection();
            sqlConnection.Open();

            string checkQuery = "SELECT Gyms.Name FROM Gyms inner join Gym_Owner " +
                                "on Gyms.UserName = Gym_Owner.UserName where VarificationStatus = 1";
            SqlCommand command = new SqlCommand(checkQuery, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var value1 = reader["Name"];
                Gym.Items.Add(value1);
            }
            sqlConnection.Close();
        }

        private bool validateInput()
        {
            //if any one is null or white space it return true;
            return Gym.SelectedItem == null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterAsMember_Load(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!basic.Checked && !standard.Checked && !premium.Checked)
                MessageBox.Show("Please Complete you information");
            else if (validateInput())
            {
                MessageBox.Show("SOME THING IS WRONG");
            }
            else
            {

                try
                {
                    string membershiptype = "";
                    if (basic.Checked) membershiptype = "basic";
                    else if (standard.Checked) membershiptype = "basic";
                    else if (premium.Checked) membershiptype = "premium";


                    member.SetGymName(Gym.SelectedItem.ToString());
                    SqlConnection sqlConnection = DatabaseManager.GetConnection();
                    sqlConnection.Open();

                    string query = "INSERT INTO Member VALUES (@UserName, @FirstName, @Gmail,@cnic,@Date,@Address,@membershiptype, @Password)";
                    string query2 = "INSERT INTO MemberGym VALUES (@UserName,@Gymname)";

                    SqlCommand cmd1 = new SqlCommand(query, sqlConnection);
                    SqlCommand cmd2 = new SqlCommand(query2, sqlConnection);
                    cmd1.Parameters.AddWithValue("@UserName", member.GetUserName());
                    cmd1.Parameters.AddWithValue("@FirstName", member.GetFirstName());
                    cmd1.Parameters.AddWithValue("@Gmail", member.GetGmail());
                    cmd1.Parameters.AddWithValue("@cnic", member.GetCNIC());
                    cmd1.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd1.Parameters.AddWithValue("@Address", member.GetAddress());
                    cmd1.Parameters.AddWithValue("@membershiptype", membershiptype);
                    cmd1.Parameters.AddWithValue("@Password", member.GetPassword());


                    cmd2.Parameters.AddWithValue("@UserName", member.GetUserName());
                    cmd2.Parameters.AddWithValue("@Gymname", member.GetMemberGym());
                    MessageBox.Show(cmd1.ToString());
                    // ExecuteNonQuery for each command
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();



                    sqlConnection.Close();
                    this.Hide();
                    LoginPage loginPage = new LoginPage();
                    loginPage.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // width of ellipse
        int nHeightEllipse // height of ellipse
        );
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 40, 40));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupPage signupPage = new SignupPage();
            signupPage.Show();
        }
    }
}
