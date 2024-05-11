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
    public partial class Diet_Display_Show_Meals : Form
    {

        int intValue;
        public Diet_Display_Show_Meals(string value)
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
                    string query = "SELECT  Diet_Plan_Meal.DietPlanId, Meal.MealId, " +
                   "Meal.MealName , Meal.Amount_of_Protein ,Meal.Carbs,Meal.Fiber,Meal.Fat,Meal.Calories  FROM " +
                   "Meal INNER JOIN Diet_Plan_Meal ON Meal.MealId = Diet_Plan_Meal.MealId " +
                   "WHERE Diet_Plan_Meal.DietPlanId = @dietplanid;";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@dietplanid", intValue);
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DietPlans_Display dietPlans = new DietPlans_Display();
            dietPlans.Show();
        }

        private void ShowMeals_Load(object sender, EventArgs e)
        {
            LoadDataIntoTable();
        }
    }
}
