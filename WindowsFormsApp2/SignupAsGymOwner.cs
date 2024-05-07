using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class SignupAsGymOwner : Form
    {
        Owner_class owner;
        public SignupAsGymOwner(Owner_class owner)
        {
            InitializeComponent();
            this.owner = owner;
        }


        private bool validateInput()
        {
            return string.IsNullOrWhiteSpace(gymname.Text) ||
                    string.IsNullOrWhiteSpace(licenceno.Text) ||
                    string.IsNullOrWhiteSpace(location.Text) ||
                    string.IsNullOrWhiteSpace(timing.Text);

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(validateInput())
            {
                MessageBox.Show("invalid inputs");
            }
            else
            {
                if (validateInput())
                {
                    MessageBox.Show("something is  wrong");
                }
                else
                {
                    owner.SetGymName(gymname.Text.Trim());
                    owner.SetLicenseNO(licenceno.Text.Trim());
                    owner.SetLocation(location.Text.Trim());
                    owner.SetTiming(timing.Text.Trim());
                    owner.Setvarificatiostatus(0);
                    
               

                    SqlConnection sqlConnection = DatabaseManager.GetConnection();
                    sqlConnection.Open();


                    string query = "INSERT INTO Gym_Owner VALUES (@UserName, @FirstName, @Gmail, @Address, @Date, @Password, @VarificationStatus)";
                    string query2 = "INSERT INTO GYMS VALUES (@gymnmae, @location, @timing, @gymowner,@licencno)";

                    SqlCommand cmd1 = new SqlCommand(query, sqlConnection);
                    cmd1.Parameters.AddWithValue("@UserName", owner.GetUserName());
                    cmd1.Parameters.AddWithValue("@FirstName", owner.GetFirstName());
                    cmd1.Parameters.AddWithValue("@Gmail", owner.GetGmail());
                    cmd1.Parameters.AddWithValue("@Address", owner.GetAddress());
                    cmd1.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd1.Parameters.AddWithValue("@Password", owner.GetPassword());
                    cmd1.Parameters.AddWithValue("@VarificationStatus", owner.Getvarificatiostatus()); // Corrected parameter name
                    cmd1.ExecuteNonQuery();


                    SqlCommand cmd2 = new SqlCommand(query2, sqlConnection);
                    cmd2.Parameters.AddWithValue("@gymnmae", owner.Getgymname());
                    cmd2.Parameters.AddWithValue("@location", owner.GetLocation());
                    cmd2.Parameters.AddWithValue("@timing", owner.GetLocation());
                    cmd2.Parameters.AddWithValue("@gymowner", owner.GetUserName());
                    cmd2.Parameters.AddWithValue("@licencno", owner.GetLicenseNO());


                    // ExecuteNonQuery for each command
                    cmd2.ExecuteNonQuery();


                    sqlConnection.Close();
                    this.Hide();
                    LoginPage loginPage = new LoginPage();
                    loginPage.Show();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            SignupPage signupPage = new SignupPage();
            signupPage.Show();
        }
    }
}
