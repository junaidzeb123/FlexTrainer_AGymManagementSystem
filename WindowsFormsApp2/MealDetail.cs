using System;
using System.Collections.Generic;
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
        public MealDetail(DietPlan_Class dietlan)
        {
            InitializeComponent();
            this.DietPlan = dietlan;
        }

        bool Validate()
        {
            return string.IsNullOrWhiteSpace(mealNameInput.Text) ||
                   string.IsNullOrWhiteSpace(proteininput.Text) ||
                   string.IsNullOrWhiteSpace(carbsinput.Text) ||
                   string.IsNullOrWhiteSpace(calroriesinput.Text) ||
                   string.IsNullOrWhiteSpace(fatinput.Text) ||
                   string.IsNullOrWhiteSpace(fiberinput.Text) ||
                   !int.TryParse(proteininput.Text, out _) ||
                   !int.TryParse(carbsinput.Text, out _) ||
                   !int.TryParse(calroriesinput.Text, out _) ||
                   !int.TryParse(fatinput.Text, out _) ||
                   !int.TryParse(fiberinput.Text, out _);
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void InsertMealPlan()
        {
            SqlConnection sqlConnection = DatabaseManager.GetConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Validate())
            {

            }
            else
            {
                string mealName = mealNameInput.Text.Trim();
                int protein , carbs, fat,fiber,calories;
                int.TryParse(proteininput.Text, out protein);
                int.TryParse(carbsinput.Text, out carbs);
                int.TryParse(fatinput.Text, out fat);
                int.TryParse(fiberinput.Text, out fiber);
                int.TryParse(calroriesinput.Text, out calories);


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
