using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Workout_AddExercise : Form
    {

        WorkoutPlan Plan;
        int nofoexeccise;
        int insertedWorkoutPlanId;
        bool isWorkoutDone;
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
        public Workout_AddExercise()
        {
            InitializeComponent();
            isWorkoutDone = false;

        }
          public Workout_AddExercise(WorkoutPlan plan)
        {
            this.Plan = plan;
            InitializeComponent();
            nofoexeccise = 0;
            isWorkoutDone = false;
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
            Workout_Display workout = new Workout_Display();
            workout.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 40, 40));
        }

        private void InsertingWorkout()
        {
            // Insert into Workout_Plan table
            //SELECT SCOPE_IDENTITY(); is for gettig the workoutplanid which is autoincrmented
            if (isWorkoutDone == false)
            {
                try 
                {
                    using (SqlConnection connection = DatabaseManager.GetConnection())
                    {


                        connection.Open();
                        string query3 = "INSERT INTO Workout_Plan ( Experience_required, nofoexercise, sets, reps)" +
                                         " VALUES ( @Experincrequired, @noofExercise, @sets, @reps); SELECT SCOPE_IDENTITY();";
                        SqlCommand cmd3 = new SqlCommand(query3, connection);
                        cmd3.Parameters.AddWithValue("@Experincrequired", Plan.experience);
                        cmd3.Parameters.AddWithValue("@noofExercise", Plan.noofexercise);
                        cmd3.Parameters.AddWithValue("@sets", Plan.set);
                        cmd3.Parameters.AddWithValue("@reps", Plan.reps);
                        this.insertedWorkoutPlanId = Convert.ToInt32(cmd3.ExecuteScalar());


                        string query6 = "INSERT INTO Workout_Plan_Purposes_ (Purposes_, WorkoutPlanId) VALUES (@Purposes, @WorkoutPlanId);";
                        SqlCommand cmd6 = new SqlCommand(query6, connection);
                        cmd6.Parameters.AddWithValue("@Purposes", Plan.purpose);
                        cmd6.Parameters.AddWithValue("@WorkoutPlanId", insertedWorkoutPlanId);
                        cmd6.ExecuteNonQuery();
                        isWorkoutDone = true;

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
                    }

                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void insertMachineData(string machinenamestrng)
        {

            try
            {
                SqlConnection connection = DatabaseManager.GetConnection();
                connection.Open();
                string validate = "SELECT COUNT(*) FROM Machine WHERE Name = @MachineName;";
                SqlCommand cmd1 = new SqlCommand(validate, connection);
                cmd1.Parameters.AddWithValue("@MachineName", machinenamestrng);

                int count = (int)cmd1.ExecuteScalar();

                if (count <= 0) {
                    string query7 = "INSERT INTO Machine (Name) VALUES (@MachineName);";
                    SqlCommand cmd7 = new SqlCommand(query7, connection);
                    cmd7.Parameters.AddWithValue("@MachineName", machinenamestrng);
                    cmd7.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void InsertExercise(string musclestring,string machinenamestrng,string exercisenamestring)
        {
            try
            {
                
                SqlConnection connection = DatabaseManager.GetConnection();
                connection.Open();
                // Insert into  table
                string query8 = "INSERT INTO Exercise (Target_Muscle, Name, MachineName) OUTPUT INSERTED.ExerciseId VALUES (@TargetMuscle, @ExerciseName, @MachineName);";
                SqlCommand cmd8 = new SqlCommand(query8, connection);
                cmd8.Parameters.AddWithValue("@TargetMuscle", musclestring);
                cmd8.Parameters.AddWithValue("@ExerciseName", exercisenamestring);
                cmd8.Parameters.AddWithValue("@MachineName", machinenamestrng);
                int exerciseId = (int)cmd8.ExecuteScalar();


                // Insert into Workout_Exercise table
                string query9 = "INSERT INTO Workout_Exercise (WorkoutPlanId, ExerciseId) VALUES (@WorkoutPlanId, @ExerciseId);";
                SqlCommand cmd9 = new SqlCommand(query9, connection);
                cmd9.Parameters.AddWithValue("@WorkoutPlanId", this.insertedWorkoutPlanId);
                cmd9.Parameters.AddWithValue("@ExerciseId", exerciseId);
                cmd9.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                try {
                 
                        string exercisenamestring = exerciseName.Text.Trim();
                        string musclestring = TagerMuscle.Text.Trim();
                        string machinenamestrng = MachinName.Text.Trim();
                        InsertingWorkout();
                        // Insert into corresponding tables based on the role
                        if (Session.IsAuthenticated)
                        {
                        insertMachineData(machinenamestrng);
                        InsertExercise(musclestring, machinenamestrng, exercisenamestring);

                        }
                        exerciseName.Text = "";
                        TagerMuscle.Text = "";
                        MachinName.Text = "";
                        instruction.Text = "Enter new Exercise";
                        nofoexeccise++;

                        if (nofoexeccise == Plan.noofexercise)
                        {
                            instruction.Text = "Exercise completed";
                        }
                    

                }
                 catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

          
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Workout_Add workoutAdd = new Workout_Add();
            workoutAdd.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Workout_Add workoutAdd = new Workout_Add();
            workoutAdd.Show();
        }
    }
}
