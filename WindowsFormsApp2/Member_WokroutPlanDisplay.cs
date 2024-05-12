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
    public partial class Member_WokroutPlanDisplay : Form
    {
        public Member_WokroutPlanDisplay()
        {
            InitializeComponent();
        }


        private void LoadMyPlansPlanIntoTable()
        {
            try
            {

                using (SqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT " + Session.Role + "_WorkoutPlan.UserName, Workout_Plan.WorkoutPlanId, Workout_Plan.Experience_required," +
                                    "Workout_Plan.nofoexercise,Workout_Plan.sets,Workout_Plan.reps FROM " +
                                    "Workout_Plan INNER JOIN " + Session.Role +
                                    "_WorkoutPlan ON " + Session.Role + "_WorkoutPlan.WorkoutPlanId = Workout_Plan.WorkoutPlanId " +
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

        private void Gridview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Gridview.Columns["btnColumn"].Index && e.RowIndex >= 0)
            {
                object value = Gridview.Rows[e.RowIndex].Cells[2].Value;
                if (value != null)
                {
                    string dataToSend = value.ToString();

                    this.Hide();
                    Workout_Display_ShowExercise otherForm = new Workout_Display_ShowExercise(dataToSend); // Pass the value to the constructor
                    otherForm.Show();
                    return;
                }
            }

            if (e.ColumnIndex == Gridview.Columns["btnColumn2"].Index && e.RowIndex >= 0)
            {
                object value = Gridview.Rows[e.RowIndex].Cells[2].Value;
                if (value != null)
                {
                    string dataToSend = value.ToString();

                    int workoutPlanId;
                    int.TryParse(dataToSend, out workoutPlanId);


                    SqlConnection sqlConnection = DatabaseManager.GetConnection();
                    sqlConnection.Open();

                    string query2 = "Select count(*) from Member_WorkoutPlan where   UserName = @username and WorkoutPlanId = @wokrplan ";
                    SqlCommand sqlCommand1 = new SqlCommand(query2, sqlConnection);
                    sqlCommand1.Parameters.AddWithValue("@wokrplan", workoutPlanId);
                    sqlCommand1.Parameters.AddWithValue("@username", Session.Username);

                    int count = (int)sqlCommand1.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("This is already included in your plans");
                        return;
                    }

                    string query = "Insert into Member_WorkoutPlan ( UserName ,WorkoutPlanId ) VALUES(@usernme, @dietplan ) ";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);


                    sqlCommand.Parameters.AddWithValue("@usernme", Session.Username);
                    sqlCommand.Parameters.AddWithValue("@dietplan", workoutPlanId);

                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Plan is added in your plans.");

                    return;
                }
            }
        }
        private void Member_WokroutPlan_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = "See Exercise";
            buttonColumn.Name = "btnColumn";
            buttonColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.HeaderText = "Action2";
            buttonColumn2.Text = "Add to MY";
            buttonColumn2.Name = "btnColumn2";
            buttonColumn2.UseColumnTextForButtonValue = true;
            Gridview.Columns.Add(buttonColumn);
            Gridview.Columns.Add(buttonColumn2);

            LoadALLPlanIntoTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Workout_Add workoutAdd = new Workout_Add();
            workoutAdd.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Member_WorkoutPlans member_WorkoutPlans = new Member_WorkoutPlans();
            member_WorkoutPlans.Show();
        }

        private void Allplans_Click(object sender, EventArgs e)
        {
            LoadALLPlanIntoTable();
        }

        private void MyPlans_Click(object sender, EventArgs e)
        {
            LoadMyPlansPlanIntoTable();
        }

     
    }
}
