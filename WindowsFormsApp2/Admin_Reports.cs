using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Admin_Reports : Form
    {
        public Admin_Reports()
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 40, 40));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Home admin_Home = new Admin_Home();
            admin_Home.Show();
        }

        
        private void AdminReports_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Home admin_Home = new Admin_Home();
            admin_Home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminQueries adminQueries = new AdminQueries();
            adminQueries.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminPlanQuery adminPlanQuery = new AdminPlanQuery();
            adminPlanQuery.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminWorkOutQuery adminWorkOutQuery = new AdminWorkOutQuery();
            adminWorkOutQuery.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            auditQuery audit_query = new auditQuery();
            audit_query.Show();
        }
    }
}
