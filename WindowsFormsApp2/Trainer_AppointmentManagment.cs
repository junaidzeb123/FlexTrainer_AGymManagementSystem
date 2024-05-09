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

namespace WindowsFormsApp2
{
    public partial class Trainer_AppointmentManagment : Form
    {
        public Trainer_AppointmentManagment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrainenHome trainenHome = new TrainenHome();
            this.Hide();
            trainenHome.Show();
        }

        void LoadDataToGrid()
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
        private void TrainerAppointmentManagment_Load(object sender, EventArgs e)
        {
          

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = "Toggle";
            buttonColumn.Name = "btnColumn";
            buttonColumn.UseColumnTextForButtonValue = true;
            Gridview.Columns.Add(buttonColumn);
            LoadDataToGrid();
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
            TrainenHome trainenHome = new TrainenHome();
            this.Hide();
            trainenHome.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private void Gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Gridview.Columns["btnColumn"].Index && e.RowIndex >= 0)
            {
                try
                {
                    object value = Gridview.Rows[e.RowIndex].Cells[1].Value;
                    if (value != null)
                    {
                        int id = (int)value;
                        SqlConnection sqlConnection = DatabaseManager.GetConnection();
                        sqlConnection.Open();


                        string query = "SELECT Status from Booking_Session where BookingSessionId = @id";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@id", id);

                        string status = (string)sqlCommand.ExecuteScalar();
                        if (status == "Pending")
                        {
                            string query2 = "Update Booking_Session set Status = @value " +
                                        "where  BookingSessionId = @id";
                            SqlCommand sqlCommand2 = new SqlCommand(query2, sqlConnection);
                            sqlCommand2.Parameters.AddWithValue("@id", id);
                            sqlCommand2.Parameters.AddWithValue("@value", "Approved");
                            sqlCommand2.ExecuteNonQuery();
                        }
                        else
                        {

                            string query2 = "Update Booking_Session set Status = @value " +
                                        "where  BookingSessionId = @id";
                            SqlCommand sqlCommand2 = new SqlCommand(query2, sqlConnection);
                            sqlCommand2.Parameters.AddWithValue("@id", id);
                            sqlCommand2.Parameters.AddWithValue("@value", "Pending");
                            sqlCommand2.ExecuteNonQuery();
                        }
                            LoadDataToGrid();

                        sqlConnection.Close();
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        
    }
}
