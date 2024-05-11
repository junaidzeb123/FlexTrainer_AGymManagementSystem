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
    public partial class Admin_ReigistraionRequests : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (int nLeftRect, int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse);
        public Admin_ReigistraionRequests()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Home admin_Home = new Admin_Home();
            admin_Home.Show();
        }


       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 40, 40));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Home admin_Home = new Admin_Home();
            admin_Home.Show();
        }

        private void label1_Click(object sender, EventArgs e)
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
                        string id = (string)value;
                        SqlConnection sqlConnection = DatabaseManager.GetConnection();
                        sqlConnection.Open();


                        string query = "SELECT Gym_Owner.UserName FROM " +
                                        "Gym_Owner INNER JOIN Gyms " +
                                        "ON Gym_Owner.UserName = Gyms.UserName" +
                                        " WHERE Gyms.Name = @id;";

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@id", id);
                        string userName = (string)sqlCommand.ExecuteScalar();

                       
                        string query2 = "Update Gym_Owner set VarificationStatus = @value " +
                                        "where  Gym_Owner.UserName = @userName";

                        SqlCommand sqlCommand2 = new SqlCommand(query2, sqlConnection);
                        sqlCommand2.Parameters.AddWithValue("@userName", userName);
                        sqlCommand2.Parameters.AddWithValue("@value", 1);
                        sqlCommand2.ExecuteNonQuery();

                        LoadDatatoGrid();
                        sqlConnection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        void LoadDatatoGrid()
        {
            SqlConnection sqlConnection = DatabaseManager.GetConnection();
            sqlConnection.Open();

            string query = "SELECT  GYMS.* , Gym_Owner.Name as OwnerName " +
                            "FROM Gyms inner join Gym_Owner on " +
                            "Gyms.UserName = Gym_Owner.UserName " +
                            "where Gym_Owner.VarificationStatus = 0;";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Gridview.DataSource = dataTable;
        }

        private void Admin_ReigistraionRequests_Load(object sender, EventArgs e)
        {
         
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = "Approve";
            buttonColumn.Name = "btnColumn";
            buttonColumn.UseColumnTextForButtonValue = true;
            Gridview.Columns.Add(buttonColumn);
            LoadDatatoGrid();
        }
    }
}
