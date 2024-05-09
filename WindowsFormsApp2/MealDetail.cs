using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MealDetail : Form
    {
        DietPlan_Class DietPlan;
        decimal DietPlanId;
        bool dietPlanDone;
        int proteinint, carbsint, fatint, fiberint, caloriesint; 
        string mealName;
        int noofMealsdone;
        public MealDetail(DietPlan_Class dietlan)
        {
            InitializeComponent();
            this.DietPlan = dietlan;
            dietPlanDone = false;
            noofMealsdone = 0;
        }

        bool Validate()
        {
            return string.IsNullOrWhiteSpace(mealNameInput.Text) ||
                   string.IsNullOrWhiteSpace(proteininput.Text) ||
                   string.IsNullOrWhiteSpace(carbsinput.Text) ||
                   string.IsNullOrWhiteSpace(calroriesinput.Text) ||
                   string.IsNullOrWhiteSpace(fatinput.Text) ||
                   string.IsNullOrWhiteSpace(fiberinput.Text) ||
                   !int.TryParse(proteininput.Text,out _) ||
                   !int.TryParse(carbsinput.Text,out _) ||
                   !int.TryParse(calroriesinput.Text,out _) ||
                   !int.TryParse(fatinput.Text,out _) ||
                   !int.TryParse(fiberinput.Text,out _) ;
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


        private void InsertMeal()
        {
            try
            {
                using (SqlConnection sqlConnection = DatabaseManager.GetConnection())
                {
                    sqlConnection.Open();

                    string query = "INSERT INTO Meal (MealName ,Amount_of_Protein,Carbs,Fiber,Fat,Calories)" +
                                  " VALUES(@MealName, @Protein, @Carbs,@Fiber,@Fat,@Caloreis);  SELECT SCOPE_IDENTITY();";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@MealName", mealName);
                    sqlCommand.Parameters.AddWithValue("@Protein", proteinint);
                    sqlCommand.Parameters.AddWithValue("@Carbs", carbsint);
                    sqlCommand.Parameters.AddWithValue("@Fiber", fiberint);
                    sqlCommand.Parameters.AddWithValue("@Fat", fatint);
                    sqlCommand.Parameters.AddWithValue("@Caloreis", caloriesint);

                      
                    decimal mealId = (decimal)sqlCommand.ExecuteScalar();

                    string query2 = "INSERT INTO Diet_Plan_Meal VALUES(@MealId,@DietPlanId)";
                    SqlCommand sqlCommand2 = new SqlCommand(query2, sqlConnection);
                    sqlCommand2.Parameters.AddWithValue("@MealId", mealId);
                    sqlCommand2.Parameters.AddWithValue("@DietPlanId", this.DietPlanId);
                    sqlCommand2.ExecuteNonQuery();

                    if(peanuts.Checked)
                    {
                        string query3 = "INSERT INTO Meal_Allergens VALUES(@Allergens,@MealId)";
                        SqlCommand sqlCommand3 = new SqlCommand(query3, sqlConnection);
                        sqlCommand3.Parameters.AddWithValue("@Allergens", "peanuts");
                        sqlCommand3.Parameters.AddWithValue("@MealId", mealId);
                        sqlCommand3.ExecuteNonQuery();
                    }

                    if (gluton.Checked)
                    {
                        string query3 = "INSERT INTO Meal_Allergens VALUES(@Allergens,@MealId)";
                        SqlCommand sqlCommand3 = new SqlCommand(query3, sqlConnection);
                        sqlCommand3.Parameters.AddWithValue("@Allergens", "gluton");
                        sqlCommand3.Parameters.AddWithValue("@MealId", mealId);
                        sqlCommand3.ExecuteNonQuery();
                    }
                    if (lactose.Checked)
                      {
                      string query3 = "INSERT INTO Meal_Allergens VALUES(@Allergens,@MealId)";
                        SqlCommand sqlCommand3 = new SqlCommand(query3, sqlConnection);
                        sqlCommand3.Parameters.AddWithValue("@Allergens", "lactose");
                        sqlCommand3.Parameters.AddWithValue("@MealId", mealId);
                        sqlCommand3.ExecuteNonQuery();

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void InsertMealPlan()
        {
            if (dietPlanDone == false)
            {
                try
                {
                    using (SqlConnection sqlConnection = DatabaseManager.GetConnection()) {
                        sqlConnection.Open();

                        string query = "INSERT INTO Diet_Plan (Type , Purpose, noofMeals) VALUES(@type, @purpose, @noofMeals);  SELECT SCOPE_IDENTITY();";

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@type", DietPlan.type);
                        sqlCommand.Parameters.AddWithValue("@purpose", DietPlan.purpose);
                        sqlCommand.Parameters.AddWithValue("@noofMeals", DietPlan.nofoMeals);

                        this.DietPlanId = (decimal)sqlCommand.ExecuteScalar();
                        dietPlanDone = true;


                        if(Session.IsAuthenticated)
                        {
                            if(Session.Role == "Member")
                            {
                                string query2 = "INSERT INTO MemberDietPlan (DietPlanId , UserName) VALUES(@DietPlanId, @UserName)";
                                SqlCommand sqlCommand2 = new SqlCommand(query2, sqlConnection);
                                sqlCommand2.Parameters.AddWithValue("@DietPlanId", DietPlanId);
                                sqlCommand2.Parameters.AddWithValue("@UserName", Session.Username);
                                sqlCommand2.ExecuteNonQuery();
                            }
                            else if(Session.Role == "Trainer")
                            {
                                string query2 = "INSERT INTO TrainerDietPlan (DietPlanId , UserName) VALUES(@DietPlanId, @UserName)";
                                SqlCommand sqlCommand2 = new SqlCommand(query2, sqlConnection);
                                sqlCommand2.Parameters.AddWithValue("@DietPlanId", DietPlanId);
                                sqlCommand2.Parameters.AddWithValue("@UserName", Session.Username);
                                sqlCommand2.ExecuteNonQuery();
                            }
                        }

                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                dietPlanDone = true;    
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(Validate())
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                mealName = mealNameInput.Text.Trim();
                int.TryParse(proteininput.Text, out proteinint); // corrected variable name
                int.TryParse(carbsinput.Text, out carbsint); // corrected variable name
                int.TryParse(fatinput.Text, out fatint); // corrected variable name
                int.TryParse(fiberinput.Text, out fiberint); // corrected variable name
                int.TryParse(calroriesinput.Text, out caloriesint); // corrected variable name

                InsertMealPlan();
                InsertMeal();
                noofMealsdone++;
                if (noofMealsdone != DietPlan.nofoMeals)
                {
                    label2.Text = "Enter next Meal";
                    mealNameInput.Text = "";
                    proteininput.Text = "";
                    carbsinput.Text = "";
                    fatinput.Text = "";
                    fiberinput.Text = "";
                    calroriesinput.Text = "";
                }
                else
                {
                    label2.Text = "Meal detail completed";
                    await Task.Delay(1000);
                    this.Hide();
                    DietPlanAdd dietPlanAdd = new DietPlanAdd();
                    dietPlanAdd.Show();
                }
            }
        }

        private void MealDetail_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DietPlanAdd dietPlanCreation = new DietPlanAdd();
            dietPlanCreation.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DietPlanAdd dietPlanCreation = new DietPlanAdd();
            dietPlanCreation.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void peanuts_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            panel7.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 40, 40));

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 40, 40));

        }

        private void mealName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
