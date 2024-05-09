using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Member_SessionBook : Form
    {
        public Member_SessionBook()
        {
            InitializeComponent();
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

        private bool Validate()
        {


            if( trainer.SelectedItem == null ||
                    starttime.SelectedItem == null ||
                    endtime.SelectedItem == null)
                    return true;

            string startimeString = starttime.Text;
            string endtimeString = endtime.Text;
            int intstartime;
            int intendtime;
            startimeString = startimeString.Substring(0, startimeString.Length - 5);
            endtimeString = endtimeString.Substring(0, endtimeString.Length - 5);

            int.TryParse(startimeString, out intstartime);
            int.TryParse(endtimeString, out intendtime);

            if (intendtime <= intstartime)
            {
                MessageBox.Show("End time must be greater than start time");
                return true;
            }
            return false;

        }
        void Currbtn(ref Button btn, int round)
        {
            int bs = btn.FlatAppearance.BorderSize;
            Color btnColor = btn.FlatAppearance.BorderColor;
            FlatStyle fs = btn.FlatStyle;

            btn.FlatStyle = FlatStyle.Standard;
            btn.FlatAppearance.BorderSize = 0;
            btn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, round, round));
            btn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128, 128);
            Thread.Sleep(100);
            btn.FlatStyle = fs;
            btn.FlatAppearance.BorderSize = bs;
            btn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 0, 0));
            btn.FlatAppearance.BorderColor = btnColor;


        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            panel7.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Currbtn(ref button1, 40);
        }

        private void home_Click(object sender, EventArgs e)
        {
            Currbtn(ref home, 40);
            Thread.Sleep(50);
            Member_Home form = new Member_Home();
            Hide();
            form.ShowDialog();
        }

        

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 20, 20));

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {
            panel7.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
            panel4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 20, 20));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Member_SessionBook_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                starttime.Items.Add("0" + (i).ToString() + " : 00");
                endtime.Items.Add( "0" + (i).ToString() + " : 00");
            } 
            for (int i = 10; i < 23; i++)
            {
                starttime.Items.Add( (i+1).ToString() + " : 00");
                endtime.Items.Add( (i+1).ToString() + " : 00");
            }

            SqlConnection sqlConnection = DatabaseManager.GetConnection();
            sqlConnection.Open();

            string query = "SELECT UserName from trainer where trainer.VarificationStatus = 1";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                var value = (string)sqlDataReader.GetValue(0);
                trainer.Items.Add(value);
            }
            sqlConnection.Close();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            if (Validate())
            {
                MessageBox.Show("PLese Enter Complete info");
            }
            else
            {
                try
                {
                    SqlConnection sqlConnection = DatabaseManager.GetConnection();
                    sqlConnection.Open();

                    string query = "INSERT INTO Booking_Session " +
                                    "(SessionDate, startTime, endTime, MemberUserName, TrainerUserName, Status)" +
                                    " VALUES (@date, @starttime, @endtime, @memberName, @trainerName,@status);";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@date", date.Value);
                    sqlCommand.Parameters.AddWithValue("@starttime", starttime.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@endtime", endtime.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@memberName", Session.Username);
                    sqlCommand.Parameters.AddWithValue("@trainerName", trainer.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@status", " Pending");

                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                    notification.Text = "Request have been Send to Trainer.";
                    await Task.Delay(1500);
                    this.Hide();
                    Member_Home member_Home = new Member_Home();
                    member_Home.Show();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Member_SessionBooking_display member_SessionBooking_Display = new Member_SessionBooking_display();  
            member_SessionBooking_Display.Show();
        }
    }
}
