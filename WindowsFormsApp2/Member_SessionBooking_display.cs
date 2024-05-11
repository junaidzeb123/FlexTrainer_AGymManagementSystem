using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Member_SessionBooking_display : Form
    {
        public Member_SessionBooking_display()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Member_Home member_Home = new Member_Home();
            member_Home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Member_SessionBook member_SessionBook = new Member_SessionBook();   
            member_SessionBook.Show();
        }

        private void Member_SessionBooking_display_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = DatabaseManager.GetConnection();
            sqlConnection.Open();


            string query = "Select * from Booking_Session " +
                            "where " + Session.Role + "UserName = @username";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@username", Session.Username);


            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Gridview.DataSource = dataTable;


        }
    }
}
