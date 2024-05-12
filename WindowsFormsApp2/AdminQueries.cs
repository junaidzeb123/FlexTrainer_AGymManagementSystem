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
            string condition = "";

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text)) 
                condition = " Where ";
            if (!string.IsNullOrEmpty(textBox1.Text)) 
                condition += (" Gyms.Name = '" + textBox1.Text + "'");

            if (!string.IsNullOrEmpty(textBox2.Text))
                condition += (" AND Trainer.UserName = '" + textBox2.Text + "'");

            if (!string.IsNullOrEmpty(textBox3.Text))
                condition += (" AND Diet_Plan.DietPlanId = " + textBox3.Text);

            if (!string.IsNullOrEmpty(textBox4.Text))
                condition += (" AND Machine.Name = '" + textBox4.Text + "'");

            MessageBox.Show(condition);
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
            string query = "SELECT member.UserName, member.Name, member.Email, member.Cnic, member.Start_Date, member.Address, member.Membership_type FROM member inner join MemberGym on member.UserName = MemberGym.UserName inner join Gyms on MemberGym.Name = Gyms.Name inner join TrainerGym on TrainerGym.Name = Gyms.Name inner join Trainer on Trainer.UserName = TrainerGym.UserName inner join MemberDietPlan on member.UserName = MemberDietPlan.UserName inner join Diet_Plan on MemberDietPlan.DietPlanId = Diet_Plan.DietPlanId inner join Member_WorkoutPlan on member.UserName = Member_WorkoutPlan.UserName inner join Workout_Plan on Member_WorkoutPlan.WorkoutPlanId = Workout_Plan.WorkoutPlanId inner join Workout_Exercise on Workout_Exercise.WorkoutPlanId = Workout_Plan.WorkoutPlanId inner join Exercise on Workout_Exercise.ExerciseId = Exercise.ExerciseId inner join Machine on Exercise.MachineName = Machine.Name" + create_query_filter(); //TO BE CHANGED LATER
           
            string count = "SELECT Count(Distinct Member.UserName) FROM member inner join MemberGym on member.UserName = MemberGym.UserName inner join Gyms on MemberGym.Name = Gyms.Name inner join TrainerGym on TrainerGym.Name = Gyms.Name inner join Trainer on Trainer.UserName = TrainerGym.UserName inner join MemberDietPlan on member.UserName = MemberDietPlan.UserName inner join Diet_Plan on MemberDietPlan.DietPlanId = Diet_Plan.DietPlanId inner join Member_WorkoutPlan on member.UserName = Member_WorkoutPlan.UserName inner join Workout_Plan on Member_WorkoutPlan.WorkoutPlanId = Workout_Plan.WorkoutPlanId inner join Workout_Exercise on Workout_Exercise.WorkoutPlanId = Workout_Plan.WorkoutPlanId inner join Exercise on Workout_Exercise.ExerciseId = Exercise.ExerciseId inner join Machine on Exercise.MachineName = Machine.Name" + create_query_filter(); //TO BE CHANGED LATER

            SqlConnection connection = DatabaseManager.GetConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand(count, connection);

            AdminQueryDisplay display = new AdminQueryDisplay(query, "member", (int)cmd.ExecuteScalar());

            this.Hide();
            display.Show();
        }
    }
}
