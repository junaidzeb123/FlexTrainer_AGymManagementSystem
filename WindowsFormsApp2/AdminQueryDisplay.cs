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
    public partial class AdminQueryDisplay : Form
    {
        private string query, type, count;
        public AdminQueryDisplay(string query, string type, int count)
        {
            this.query = query;
            this.type = type;
            this.count = count.ToString();
            label1.Text += (" " + this.count);
            InitializeComponent();
            addquery();
        }
        private void addquery()
        {
            using (SqlConnection connection = DatabaseManager.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminQueryDisplay_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (type == "member") { 
                AdminQueries member = new AdminQueries();
                member.Show();
            }
            else if (type == "diet")
            {
                AdminPlanQuery diet = new AdminPlanQuery();
                diet.Show();
            }
            else if (type == "workout")
            {
                AdminWorkOutQuery workout = new AdminWorkOutQuery();
                workout.Show();
            }
            else if (type == "audit")
            {
                auditQuery audit = new auditQuery();
                audit.Show();
            }
            MessageBox.Show(type);
            
            
            this.Hide();
        }
    }
}
