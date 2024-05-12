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
    public partial class AdminPlanQuery : Form
    {
        public AdminPlanQuery()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Reports admin = new Admin_Reports();
            admin.Show();
        }
        private string create_query_filter()
        {
            string condition = "";
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
                condition = " Where ";
            if (!string.IsNullOrEmpty(textBox1.Text))
                condition += (" Meal.Calories <= " + textBox1.Text);

            if (!string.IsNullOrEmpty(textBox2.Text))
                condition += (" AND Meal.Carbs <= " + textBox2.Text);

            if (!string.IsNullOrEmpty(textBox3.Text))
                condition += (" AND Meal_Allergens.Allergens != '" + textBox3.Text + "'");



            return condition;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select Diet_Plan.DietPlanId, Diet_Plan.Type, Diet_Plan.Purpose, Diet_Plan.noofMeals from Diet_Plan inner join Diet_Plan_Meal on Diet_Plan.DietPlanId = Diet_Plan_Meal.DietPlanId inner join Meal on Diet_Plan_Meal.MealId = Meal.MealId inner join Meal_Allergens on Meal_Allergens.MealId = Meal.MealId" + create_query_filter(); //TO BE CHANGED LATER
            string count = "select Count(Distinct Diet_Plan.DietPlanId) from Diet_Plan inner join Diet_Plan_Meal on Diet_Plan.DietPlanId = Diet_Plan_Meal.DietPlanId inner join Meal on Diet_Plan_Meal.MealId = Meal.MealId inner join Meal_Allergens on Meal_Allergens.MealId = Meal.MealId" + create_query_filter();
            SqlConnection connection = DatabaseManager.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(count, connection);
            AdminQueryDisplay display = new AdminQueryDisplay(query, "diet", (int)command.ExecuteScalar());

            this.Hide();
            display.Show();
        }
    }
}
