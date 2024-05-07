using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Trainer_AddingExercise : Form
    {

        WorkoutPlan Plan;
        int nofoexeccise;
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
        public Trainer_AddingExercise()
        {
            InitializeComponent();

        }
          public Trainer_AddingExercise(WorkoutPlan plan)
        {
            this.Plan = plan;
            InitializeComponent();
            nofoexeccise = 0;
        }


        private bool Validate()
        {
            // Check if any of the fields are empty or contain non-integer values
            return string.IsNullOrWhiteSpace(MachinName.Text) ||
                   string.IsNullOrWhiteSpace(TagerMuscle.Text) ||
                   string.IsNullOrWhiteSpace(exerciseName.Text);
               
        }
        private void AddingExercise_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trainer_Workout workout = new Trainer_Workout();
            workout.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 40, 40));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                string exercisenamestring = exerciseName.Text.Trim();
                string musclestring = TagerMuscle.Text.Trim();
                string machinenamestrng = MachinName.Text.Trim();

                SqlConnection connection = DatabaseManager.GetConnection();
                connection.Open();

                // Insert into Workout_Plan table
                //SELECT SCOPE_IDENTITY(); is for gettig the workoutplanid which is autoincrmented
                string query3 = "INSERT INTO Workout_Plan ( Experience_required, nofoexercise, sets, reps) VALUES ( @Experincrequired, @noofExercise, @sets, @reps); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd3 = new SqlCommand(query3, connection);
                cmd3.Parameters.AddWithValue("@Experincrequired", Plan.experience);
                cmd3.Parameters.AddWithValue("@noofExercise", Plan.noofexercise);
                cmd3.Parameters.AddWithValue("@sets", Plan.set);
                cmd3.Parameters.AddWithValue("@reps", Plan.reps);

                int insertedWorkoutPlanId = Convert.ToInt32(cmd3.ExecuteScalar());

                // Insert into corresponding tables based on the role
                if (Session.IsAuthenticated)
                {
                    if (Session.Role == "Trainer")
                    {
                        string query4 = "INSERT INTO Trainer_WorkoutPlan (UserName, WorkoutPlanId) VALUES (@UserName, @WorkoutPlanId);";
                        SqlCommand cmd4 = new SqlCommand(query4, connection);
                        cmd4.Parameters.AddWithValue("@UserName", Session.Username);
                        cmd4.Parameters.AddWithValue("@WorkoutPlanId", insertedWorkoutPlanId);
                        cmd4.ExecuteNonQuery();
                    }
                    else if (Session.Role == "Member")
                    {
                        // Insert into Member_WorkoutPlan
                        string query5 = "INSERT INTO Member_WorkoutPlan (UserName, WorkoutPlanId) VALUES (@UserName, @WorkoutPlanId);";
                        SqlCommand cmd5 = new SqlCommand(query5, connection);
                        cmd5.Parameters.AddWithValue("@UserName", Session.Username);
                        cmd5.Parameters.AddWithValue("@WorkoutPlanId", insertedWorkoutPlanId);
                        cmd5.ExecuteNonQuery();
                    }

                    string query6 = "INSERT INTO Workout_Plan_Purposes_ (Purposes_, WorkoutPlanId) VALUES (@Purposes, @WorkoutPlanId);";
                    SqlCommand cmd6 = new SqlCommand(query6, connection);
                    cmd6.Parameters.AddWithValue("@Purposes", Plan.purpose);
                    cmd6.Parameters.AddWithValue("@WorkoutPlanId", insertedWorkoutPlanId);
                    cmd6.ExecuteNonQuery();

                    // Insert into Machine table
                    string query7 = "INSERT INTO Machine (Name) VALUES (@MachineName);";
                    SqlCommand cmd7 = new SqlCommand(query7, connection);
                    cmd7.Parameters.AddWithValue("@MachineName", machinenamestrng);
                    cmd7.ExecuteNonQuery();

                    // Insert into Exercise table
                    string query8 = "INSERT INTO Exercise (Target_Muscle, Name, MachineName) VALUES (@TargetMuscle, @ExerciseName, @MachineName);";
                    SqlCommand cmd8 = new SqlCommand(query8, connection);
                    cmd8.Parameters.AddWithValue("@TargetMuscle", musclestring);
                    cmd8.Parameters.AddWithValue("@ExerciseName", exercisenamestring);
                    cmd8.Parameters.AddWithValue("@MachineName", machinenamestrng);
                    cmd8.ExecuteNonQuery();

                    // Insert into Workout_Exercise table
                    string query9 = "INSERT INTO Workout_Exercise (WorkoutPlanId, Name) VALUES (@WorkoutPlanId, @ExerciseName);";
                    SqlCommand cmd9 = new SqlCommand(query9, connection);
                    cmd9.Parameters.AddWithValue("@WorkoutPlanId", insertedWorkoutPlanId);
                    cmd9.Parameters.AddWithValue("@ExerciseName", exercisenamestring);
                    cmd9.ExecuteNonQuery();
                }
                exerciseName.Text = "";
                TagerMuscle.Text  = "";
                MachinName.Text   = "";
                instruction.Text  = "Enter new Exercise";
                nofoexeccise++;

                if(nofoexeccise == Plan.noofexercise)
                {
                    instruction.Text = "Exercise completed";
                }
            
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Trainer_WorkoutAdd workoutAdd = new Trainer_WorkoutAdd();
            workoutAdd.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trainer_WorkoutAdd workoutAdd = new Trainer_WorkoutAdd();
            workoutAdd.Show();
        }
    }
}
