using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class AdminWorkOutQuery : Form
    {
        public AdminWorkOutQuery()
        {
            InitializeComponent();
        }
        private string create_query_filter()
        {
            string condition = "WHERE ";

            if (!string.IsNullOrEmpty(textBox4.Text))
                condition += (" Equipment = " + textBox4.Text);


            return condition;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Workout_Plan"; //TO BE CHANGED LATER
            AdminQueryDisplay display = new AdminQueryDisplay(query, "workout");

            this.Hide();
            display.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Reports reports = new Admin_Reports();
            reports.Show();
        }
    }
}
