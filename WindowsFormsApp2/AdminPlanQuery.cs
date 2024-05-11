using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AdminPlanQuery : Form
    {
        public AdminPlanQuery()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Reports admin = new Admin_Reports();
            admin.Show();
        }
        private string create_query_filter()
        {
            string condition = "WHERE ";

            if (!string.IsNullOrEmpty(textBox1.Text))
                condition += (" Calories = " + textBox1.Text);

            if (!string.IsNullOrEmpty(textBox2.Text))
                condition += (" AND Carbs = " + textBox2.Text);

            if (!string.IsNullOrEmpty(textBox3.Text))
                condition += (" AND Allergees = " + textBox3.Text);

            if (!string.IsNullOrEmpty(textBox4.Text))
                condition += (" AND Equipment = " + textBox4.Text);


            return condition;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Diet_Plan"; //TO BE CHANGED LATER
            AdminQueryDisplay display = new AdminQueryDisplay(query, "diet");

            this.Hide();
            display.Show();
        }
    }
}
