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
    public partial class AdminQueries : Form
    {
        public AdminQueries()
        {
            InitializeComponent();
        }
        private string create_query_filter()
        {
            string condition = "WHERE ";

            if (!string.IsNullOrEmpty(textBox1.Text)) 
                condition += (" Gym = " + textBox1.Text);

            if (!string.IsNullOrEmpty(textBox2.Text))
                condition += (" AND Trainer = " + textBox2.Text);

            if (!string.IsNullOrEmpty(textBox3.Text))
                condition += (" AND Plan = " + textBox3.Text);

            if (!string.IsNullOrEmpty(textBox4.Text))
                condition += (" AND Equipment = " + textBox4.Text);
            

            return condition;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Admin_Reports reports = new Admin_Reports();
            reports.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM MEMBER"; //TO BE CHANGED LATER
            AdminQueryDisplay display = new AdminQueryDisplay(query, "member");

            this.Hide();
            display.Show();
        }
    }
}
