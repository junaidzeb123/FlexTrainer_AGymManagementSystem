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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp2
{
    public partial class auditQuery : Form
    {
        private string search_by;
        public auditQuery()
        {
            InitializeComponent();
        }
            private string create_query_filter()
            {
                string condition = "";

                if (!string.IsNullOrEmpty(textBox1.Text))
                    condition += (" AND timestamp >= DATEADD(MONTH, -" + textBox1.Text + ", GETDATE())");
                
                if (!string.IsNullOrEmpty(textBox2.Text))
                    condition += (" AND Gyms.Name = '" + textBox2.Text + "'");

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
                condition = "";

                return condition;
            }

        private string query;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
                MessageBox.Show("Click an option");
            else
            {
                if (radioButton1.Checked)
                    query = "Select audit_id, timestamp, OPERATION FROM Member Inner join MemberGym on Member.UserName = MemberGym.UserName Inner join Gyms on MemberGym.Name = Gyms.Name Inner join AUDIT_TRAIL on AUDIT_TRAIL.memberUserName = Member.UserName where OPERATION = 'Insert into Member'" + create_query_filter();
                else if (radioButton2.Checked)
                    query = "Select audit_id, timestamp, OPERATION FROM Trainer Inner join TrainerGym on Trainer.UserName = TrainerGym.UserName Inner join Gyms on TrainerGym.Name = Gyms.Name Inner join AUDIT_TRAIL on AUDIT_TRAIL.trainerUserName = Trainer.UserName WHERE OPERATION = 'Insert into Trainer'" + create_query_filter();
                else if (radioButton3.Checked)
                    query = "Select audit_id, timestamp, OPERATION FROM Gym_Owner Inner join Gyms on Gyms.UserName = Gym_Owner.UserName Inner join AUDIT_TRAIL on AUDIT_TRAIL.ownerUserName = Gym_Owner.UserName WHERE OPERATION = 'Insert into Gym_Owner'" + create_query_filter();


            MessageBox.Show(query);
            AdminQueryDisplay adminQueryDisplay = new AdminQueryDisplay(query, "audit");
            this.Hide();
            adminQueryDisplay.Show();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Reports admin_Reports = new Admin_Reports();
            admin_Reports.Show();
        } 
    }
}
