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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp2
{
    public partial class SginupAsTrainer : Form
    {
        public Trainer_class trainer;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
              int nLeftRect,    
              int nTopRect,      
              int nRightRect,    
              int nBottomRect,   
              int nWidthEllipse, 
              int nHeightEllipse 
      );
        public SginupAsTrainer(Trainer_class trainer)
        {
            this.trainer = trainer;
            InitializeComponent();

            SqlConnection sqlConnection = DatabaseManager.GetConnection();
            sqlConnection.Open();


            string checkQuery = "SELECT Gyms.Name FROM Gyms inner join Gym_Owner " +
                                "on Gyms.UserName = Gym_Owner.UserName where VarificationStatus = 1";
            SqlCommand command = new SqlCommand(checkQuery, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var value1 = reader["Name"];
                gym.Items.Add(value1);
            }
            sqlConnection.Close();
        }

        private bool validateInput()
        {
            return  string.IsNullOrWhiteSpace(experience1.Text)  ||
                    string.IsNullOrWhiteSpace(experience2.Text)  ||
                    string.IsNullOrWhiteSpace(experience3.Text)  ||
                    string.IsNullOrWhiteSpace(speciltyarea.Text) ||
                    string.IsNullOrWhiteSpace(qualification.Text);
                 
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (validateInput())
            {
                MessageBox.Show("something is  wrong");
            }
            else
            {
                trainer.SetExperience1(experience1.Text.Trim());
                trainer.SetExperience2(experience2.Text.Trim());
                trainer.SetExperience3(experience3.Text.Trim());
                trainer.SetSpecilifyArea(speciltyarea.Text.Trim());
                trainer.SetQualification(qualification.Text.Trim());
                trainer.SetGymName(gym.SelectedItem.ToString());
                trainer.SetVarificationStatus(0);

                SqlConnection sqlConnection = DatabaseManager.GetConnection();
                sqlConnection.Open();

                string query = "INSERT INTO Trainer VALUES (@UserName, @FirstName, @Gmail, @Qualification, @SpecializeArea,@VarificationStatus, @Address, @Date, @Password)";
                string query2 = "INSERT INTO Trainer_Experience VALUES (@Experience, @UserName)";
                string query3 = "INSERT INTO Trainer_Experience VALUES (@Experience, @UserName)";
                string query4 = "INSERT INTO Trainer_Experience VALUES (@Experience, @UserName)";
                string query5 = "INSERT INTO TrainerGym VALUES (@UserName,@TrainerGym)";

                SqlCommand cmd1 = new SqlCommand(query, sqlConnection);
                cmd1.Parameters.AddWithValue("@UserName", trainer.GetUserName());
                cmd1.Parameters.AddWithValue("@FirstName", trainer.GetFirstName());
                cmd1.Parameters.AddWithValue("@Gmail", trainer.GetGmail());
                cmd1.Parameters.AddWithValue("@Qualification", trainer.GetQualification());
                cmd1.Parameters.AddWithValue("@SpecializeArea", trainer.GetSpecilifyArea());
                cmd1.Parameters.AddWithValue("@Address", trainer.GetAddress());
                cmd1.Parameters.AddWithValue("@Date", DateTime.Now);
                cmd1.Parameters.AddWithValue("@Password", trainer.GetPassword());
                cmd1.Parameters.AddWithValue("@VarificationStatus", 0);

                SqlCommand cmd2 = new SqlCommand(query2, sqlConnection);
                cmd2.Parameters.AddWithValue("@Experience", trainer.GetExperience1());
                cmd2.Parameters.AddWithValue("@UserName", trainer.GetUserName());

                SqlCommand cmd3 = new SqlCommand(query3, sqlConnection);
                cmd3.Parameters.AddWithValue("@Experience", trainer.GetExperience2());
                cmd3.Parameters.AddWithValue("@UserName", trainer.GetUserName());

                SqlCommand cmd4 = new SqlCommand(query4, sqlConnection);
                cmd4.Parameters.AddWithValue("@Experience", trainer.GetExperience3());
                cmd4.Parameters.AddWithValue("@UserName", trainer.GetUserName());

                SqlCommand cmd5 = new SqlCommand(query5, sqlConnection);
                cmd5.Parameters.AddWithValue("@TrainerGym", trainer.GetTrainerGym());
                cmd5.Parameters.AddWithValue("@UserName", trainer.GetUserName());

                // ExecuteNonQuery for each command
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();


                sqlConnection.Close();
                this.Hide();
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
            }
        }
        private void SginupAsTrainer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      
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

        private void gym_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
