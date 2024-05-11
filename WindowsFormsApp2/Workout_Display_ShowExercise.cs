using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Workout_Display_ShowExercise : Form
    {


        int intValue;
        public Workout_Display_ShowExercise(string value)
        {
            InitializeComponent();

            if (int.TryParse(value, out intValue))
            {
            }
            else
            {
                MessageBox.Show("Someting Went Wronge.");
                this.intValue = 0; // Default value
            }
        }


          private void LoadDataIntoTable()
        {
            try
            {

                using (SqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT  Workout_Exercise.WorkoutPlanId, Exercise.ExerciseId, " +
                                   "Exercise.Target_Muscle,Exercise.Name,Exercise.MachineName  FROM " +
                                   "Exercise INNER JOIN Workout_Exercise ON Exercise.ExerciseId = Workout_Exercise.ExerciseId " +
                                   "WHERE Workout_Exercise.WorkoutPlanId = @workoutId;";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@workoutId", intValue);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    Gridview.DataSource = dataTable; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void ShowExercise_Load(object sender, EventArgs e)
        {
            LoadDataIntoTable();            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Workout_Display workout = new Workout_Display();    
            workout.Show();
        }

        private void Gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
