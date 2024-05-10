using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class GymOwner_MemberReport : Form
    {
        private string userName;
        public GymOwner_MemberReport(string userName)
        {
            this.userName = userName;
            InitializeComponent();
            query_basic_info();
        }
        void query_basic_info()
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                string query = "SELECT Name, Email, Cnic, Start_Date, Address, Membership_type FROM Member WHERE UserName = '" + userName + "'";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        try
                        {
                            var Name = reader["Name"].ToString();
                            var cnic = reader["Cnic"].ToString();
                            var email = reader["Email"].ToString();
                            var start_date = reader["Start_Date"].ToString();
                            var Address = reader["Address"];
                            var MemberShip_Type = reader["MemberShip_type"].ToString();
                            label2.Text += (" " + Name);
                            label6.Text += (" " + start_date);
                            label8.Text += (" " + MemberShip_Type);
                            label5.Text += (" " + cnic);
                            label1.Text += (" " + Address);
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



    }
}
