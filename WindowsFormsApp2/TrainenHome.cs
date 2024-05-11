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
    public partial class TrainenHome : Form
    {
        public TrainenHome()
        {
            InitializeComponent();
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
    
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DietPlan_Add dietPlanCreation = new DietPlan_Add();
            dietPlanCreation.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Workout_Display form = new Workout_Display();   
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trainer_AppointmentManagment trainerAppointmentManagment = new Trainer_AppointmentManagment();    
            trainerAppointmentManagment.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Treiner_Feedback treinerFeedback = new Treiner_Feedback();    
            treinerFeedback.Show();
            this.Hide();
        }

        private void TrainenHome_Load(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DietPlans_Display dietPlanCreation  = new DietPlans_Display();
            dietPlanCreation.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Workout_Display WorkoutAdd = new Workout_Display();   
            WorkoutAdd.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Trainer_AppointmentManagment app = new Trainer_AppointmentManagment();
            app.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           // button2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 20, 20));
            this.Hide();
            SignupPage loginPage = new SignupPage();  
            loginPage.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        //    button1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Session.Logout();
            this.Hide();
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void account_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trainer_Profile trainer_Profile     = new Trainer_Profile();
            trainer_Profile.Show();
        }

        private void Feedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trainer_Feebacks trainer_Feebacks = new Trainer_Feebacks();
            trainer_Feebacks.Show();
        }
    }
}
