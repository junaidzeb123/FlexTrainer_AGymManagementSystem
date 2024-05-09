using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Trainer_Profile : Form
    {
        private string userName;
        public Trainer_Profile()
        {
            InitializeComponent();
            query_basic_info();
        }
        void query_basic_info()
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                userName = Session.Username;
                string query = "SELECT * FROM Trainer WHERE UserName = '" + userName + "'";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        try
                        {
                            var Name = reader["Name"].ToString();
                            var qualification = reader["Qualifications"].ToString();
                            var email = reader["Email"].ToString();
                            var Specialty_areas = reader["Specialty_areas"].ToString();
                            var Address = reader["Address"].ToString();
                            var Start_Date = reader["Start_Date"].ToString().Substring(0, 8);

                            label2.Text += (" " + Name);
                            label6.Text += (" " + Start_Date);
                            label3.Text += (" " + Specialty_areas);
                            label8.Text += (" " + Address);
                            label1.Text += (" " + qualification);
                            label7.Text += (" " + email);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error fetching data: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void Trainer_Profile_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrainenHome trainenHome = new TrainenHome();    
            trainenHome.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrainenHome trainenHome = new TrainenHome();
            trainenHome.Show();
        }
    }
}
