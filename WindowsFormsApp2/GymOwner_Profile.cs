using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class GymOwner_Profile : Form
    {
        private string regNo;
        public GymOwner_Profile()
        {
            InitializeComponent();
            query_basic_info();
        }
        void query_basic_info()
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                regNo = Session.Username;
                string query = "SELECT * FROM Gym_Owner WHERE UserName = '" + regNo + "'";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        try {
                            var Name = reader["UserName"].ToString();
                            var email = reader["Email"].ToString();
                        
                            label2.Text += (" " + regNo);
                            label3.Text += (" " + Name);
                            label4.Text += (" " + email);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error fetching data: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GymOwner_Home home = new GymOwner_Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GymOwner_ProfileEdit edit = new GymOwner_ProfileEdit();
            edit.Show();
            this.Hide();
        }

        private void OwnerProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
