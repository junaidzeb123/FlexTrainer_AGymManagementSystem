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
    public partial class DietPlanAdd : Form
    {
        public DietPlanAdd()
        {
            InitializeComponent();
        }


        bool Validate()
        {
            return string.IsNullOrWhiteSpace(type.Text) ||
                   string.IsNullOrWhiteSpace(purpose.Text) ||
                   string.IsNullOrWhiteSpace(noofMeals.Text);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            //if (Validate())
            //{
            //    MessageBox.Show("Invalid Input");
            //}
            //else
            {
                DietPlan_Class dietplan = new DietPlan_Class();


                 dietplan.purpose = purpose.ToString().Trim();
               // !int.TryParse(noofMeals.Text, out_ dietplan.nofoMeals);
                 dietplan.type =  type.ToString().Trim();

                this.Hide();
                MealDetail mealDetail = new MealDetail(dietplan);
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
            noofMeals.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, noofMeals.Width, noofMeals.Height, 40, 40));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainenHome trainenHome = new TrainenHome();
            trainenHome.Show();
        }
    }
}
