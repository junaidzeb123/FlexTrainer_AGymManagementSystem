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
    public partial class Trainer_Feebacks : Form
    {
        public Trainer_Feebacks()
        {
            InitializeComponent();
        }

        private void Gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Trainer_Feebacks_Load(object sender, EventArgs e)
        {
            try
            {

                SqlConnection sqlConnection = DatabaseManager.GetConnection();
                sqlConnection.Open();


                string query = "SELECT Description," +
                                " Rating,MemberUserName " +
                                "FROM Feedback " +
                                "WHERE TrainerUserName = @userName;";


                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@userName", Session.Username);

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Gridview.DataSource = dataTable;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrainenHome trainenHome =  new TrainenHome();
            trainenHome.Show(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
