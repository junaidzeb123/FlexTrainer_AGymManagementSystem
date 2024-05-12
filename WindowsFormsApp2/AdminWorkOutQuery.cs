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
            string condition = " WHERE ";

            if (!string.IsNullOrEmpty(textBox4.Text))
                condition += (" Exercise.MachineName != " + textBox4.Text);
            else condition = "";

            return condition;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select Workout_Plan.WorkoutPlanId, Workout_Plan.Experience_required, Workout_Plan.nofoexercise, Workout_Plan.sets, Workout_Plan.reps from Workout_Plan inner join Workout_Exercise on Workout_Plan.WorkoutPlanId = Workout_Exercise.WorkoutPlanId inner join Exercise on Workout_Exercise.ExerciseId = Exercise.ExerciseId" + create_query_filter(); //TO BE CHANGED LATER
            string count = "select Count(Distinct WorkoutPlanId) from Workout_Plan inner join Workout_Exercise on Workout_Plan.WorkoutPlanId = Workout_Exercise.WorkoutPlanId inner join Exercise on Workout_Exercise.ExerciseId = Exercise.ExerciseId" + create_query_filter();

            SqlConnection connection = DatabaseManager.GetConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand(count, connection);
            
            AdminQueryDisplay display = new AdminQueryDisplay(query, "workout", (int)cmd.ExecuteScalar());

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
