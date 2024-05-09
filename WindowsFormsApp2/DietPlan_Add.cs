using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class DietPlan_Add : Form
    {
        public DietPlan_Add()
        {
            InitializeComponent();
        }


        bool Validate()
        {
            return string.IsNullOrWhiteSpace(type.Text) ||
                   string.IsNullOrWhiteSpace(purpose.Text) ||
                   string.IsNullOrWhiteSpace(noofmeals.Text);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (Validate())
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                DietPlan_Class dietplan = new DietPlan_Class();


                 dietplan.purpose = purpose.Text.Trim();
                int.TryParse(noofmeals.Text, out dietplan.nofoMeals);
                dietplan.type =  type.Text.Trim();

                this.Hide();
                Diet_AddMealDetail mealDetail = new Diet_AddMealDetail(dietplan);
                mealDetail.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainenHome trainenHome = new TrainenHome();    
            trainenHome.Show(); 
        }

        private void DietPlanCreation_Load(object sender, EventArgs e)
        {

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
            laberl.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, laberl.Width, laberl.Height, 40, 40));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

            if (Session.Role == "Trainer")
            {
                DietPlans_Display diet  = new DietPlans_Display();
                diet.Show();
            }
            else
            {
                Member_Home member_Home = new Member_Home();
                member_Home.Show(); 
            }
        }
    }
}
