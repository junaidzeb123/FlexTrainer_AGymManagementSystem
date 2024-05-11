using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Owner_Trainer_Report : Form
    {
        private string userName;
        public Owner_Trainer_Report(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            query_basic_info();
        }
        void query_basic_info()
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "SELECT Name, Email, Qualifications, Specialty_areas, VarificationStatus, Address, Start_Date FROM Trainer WHERE UserName = '" + userName + "'";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        try
                        {
                            var Name = reader["Name"].ToString();
                            var email = reader["Email"].ToString();
                            var start_date = reader["Start_Date"].ToString();
                            var Address = reader["Address"];
                            var Specialty_areas = reader["Specialty_areas"].ToString();
                            var Qualifications = reader["Qualifications"].ToString();
                            label2.Text += (" " + Name);
                            label6.Text += (" " + start_date);
                            label8.Text += (" " + Address);
                            label1.Text += (" " + Qualifications);
                            label7.Text += (" " + email);
                            label3.Text += (" " + Specialty_areas);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error fetching data: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = DatabaseManager.GetConnection();
            string query = "DELETE FROM TRAINER WHERE UserName = '" + userName + "'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            Gymowner_Search search = new Gymowner_Search();
            search.Show();  
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Gymowner_Search search = new Gymowner_Search();
            search.Show();
            this.Hide();
        }
    }
}
