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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp2
{
    public partial class GymOwner_RegistrationRequests : Form
    {
        public GymOwner_RegistrationRequests()
        {
            InitializeComponent();
        }


        private void Gridview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

                        string query2 = "Update Trainer set VarificationStatus = @status " +
                                        " where UserName = @userName";

                        SqlCommand sqlCommand2 = new SqlCommand(query2, sqlConnection);
                        sqlCommand2.Parameters.AddWithValue("@userName", value);
                        sqlCommand2.Parameters.AddWithValue("@status", 1);
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

            string query = "select Gyms.Name from " +
                "Gyms where Gyms.UserName = @userName";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@userName", Session.Username);

            string GymName = (string)sqlCommand.ExecuteScalar();

            string query2 = "SELECT Trainer.UserName ,Trainer.Name ,Email ," +
                            "  Qualifications ,Specialty_areas , Address " +
                            " FROM Trainer  INNER JOIN  TRAINERGYM on" +
                            " Trainer.UserName = TRAINERGYM.UserName " +
                            "where varificationStatus = 0 and  TRAINERGYM.Name = @gymName;";

            SqlCommand sqlCommand1 = new SqlCommand(query2, sqlConnection);
            sqlCommand1.Parameters.AddWithValue("@gymName", GymName);

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand1);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Gridview.DataSource = dataTable;
        }

        private void GymOwner_RegistrationRequests_Load(object sender, EventArgs e)
        {

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = "Approve";
            buttonColumn.Name = "btnColumn";
            buttonColumn.UseColumnTextForButtonValue = true;
            Gridview.Columns.Add(buttonColumn);
            LoadDatatoGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GymOwner_Home gymOwner_Home = new GymOwner_Home();
            gymOwner_Home.Show();
        }

      

        
    }
}
