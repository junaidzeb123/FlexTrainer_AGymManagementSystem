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
    public partial class GymOwner_MemberSearch : Form
    {
        public GymOwner_MemberSearch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GymOwner_Home home = new GymOwner_Home();
            home.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnColumn"].Index && e.RowIndex >= 0)
            {
                string username = dataGridView1.Rows[e.RowIndex].Cells["UserName"].Value.ToString();

                GymOwner_MemberReport member = new GymOwner_MemberReport(username);

                member.Show();
                this.Hide();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = "Report";
            
            buttonColumn.Name = "btnColumn";
           
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonColumn);
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;


            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                connection.Open();

                string query = "SELECT UserName, Name FROM Member WHERE Name = '" + name + "'";

                SqlCommand command = new SqlCommand(query, connection);
                

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
