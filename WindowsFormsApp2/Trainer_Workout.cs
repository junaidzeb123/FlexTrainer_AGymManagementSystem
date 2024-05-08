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

    public partial class Trainer_Workout : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,int nTopRect,      
            int nRightRect,int nBottomRect,   
            int nWidthEllipse, int nHeightEllipse 
        );


        List<WorkoutPlan> workout;
        public Trainer_Workout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trainer_WorkoutAdd workoutAdd = new Trainer_WorkoutAdd();
            workoutAdd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrainenHome trainenHome = new TrainenHome();
            trainenHome.Show();
        }

    
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 40, 40));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            if (Session.Role == "Member")
            {
                Member_Home trainenHome = new Member_Home();
                trainenHome.Show();
            }
            else if (Session.Role == "Trainer") { 
                TrainenHome trainenHome = new TrainenHome();
                trainenHome.Show();
            
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadALLPlanIntoTable()
        {
            try
            {

                using (SqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT  Workout_Plan.WorkoutPlanId,  Workout_Plan.Experience_required, " +
                    " Workout_Plan.nofoexercise , Workout_Plan.sets  , Workout_Plan.reps , " +
                    "Workout_Plan_Purposes_.Purposes_  FROM " +
                    "  Workout_Plan inner join Workout_Plan_Purposes_  on " +
                    "Workout_Plan.WorkoutPlanId = Workout_Plan_Purposes_.WorkoutPlanId " +
                    "order by  Workout_Plan.WorkoutPlanId;";
               
                    SqlCommand command = new SqlCommand(query, connection);
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


        private void LoadMyPlansPlanIntoTable()
        {
            try
            {

                using (SqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT " + Session.Role +"_WorkoutPlan.UserName, Workout_Plan.WorkoutPlanId, Workout_Plan.Experience_required," +
                                    "Workout_Plan.nofoexercise,Workout_Plan.sets,Workout_Plan.reps FROM " +
                                    "Workout_Plan INNER JOIN " + Session.Role +
                                    "_WorkoutPlan ON " + Session.Role +"_WorkoutPlan.WorkoutPlanId = Workout_Plan.WorkoutPlanId " +
                                    "where UserName = @userName" +
                                    " order by  Workout_Plan.WorkoutPlanId;";
                  
                    
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userName", Session.Username);  

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


        private void Gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Gridview.Columns["btnColumn"].Index && e.RowIndex >= 0)
            {
                object value = Gridview.Rows[e.RowIndex].Cells[1].Value;
                if (value != null)
                {
                    string dataToSend = value.ToString();

                    this.Hide();
                    ShowExercise otherForm = new ShowExercise(dataToSend); // Pass the value to the constructor
                    otherForm.ShowDialog();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadMyPlansPlanIntoTable();
        }

        private void MyPlans_Click(object sender, EventArgs e)
        {
            LoadALLPlanIntoTable();
        }


        private void Trainer_Workout_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = "See Exercises";
            buttonColumn.Name = "btnColumn";
            buttonColumn.UseColumnTextForButtonValue = true;
            Gridview.Columns.Add(buttonColumn);
            Gridview.CellContentClick += Gridview_CellContentClick;
            LoadALLPlanIntoTable();
        }
    }
}
