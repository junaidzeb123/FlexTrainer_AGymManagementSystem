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
using System.Threading;
namespace WindowsFormsApp2
{
    public partial class Member_Home : Form
    {
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
        public Member_Home()
        {
            InitializeComponent();
        }

        void Currbtn(ref Button btn, int round)
        {
            int bs = btn.FlatAppearance.BorderSize;
            Color btnColor = btn.FlatAppearance.BorderColor;
            FlatStyle fs = btn.FlatStyle;

            btn.FlatStyle = FlatStyle.Standard;
            btn.FlatAppearance.BorderSize = 0;
            btn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, round, round));
            btn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128, 128);
            Thread.Sleep(100);
            btn.FlatStyle = fs;
            btn.FlatAppearance.BorderSize = bs;
            btn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 0, 0));
            btn.FlatAppearance.BorderColor = btnColor;


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
        }

      

        private void wokout_plan_btn_Click(object sender, EventArgs e)
        {
            Currbtn(ref wokout_plan_btn, 30);
            Thread.Sleep(50);
            Member_WorkoutPlans form = new Member_WorkoutPlans();
            Hide();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Currbtn(ref button3, 30);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Currbtn(ref button4, 30);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Currbtn(ref button5, 30);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Currbtn(ref button2, 30);
            Thread.Sleep(50);
            Member_FeedBack form = new Member_FeedBack();
            Hide();
            form.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Currbtn(ref button1, 30);
            Thread.Sleep(50);
            Member_DietPlans form = new Member_DietPlans();
            Hide();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Currbtn(ref button6, 30);
            Thread.Sleep(50);
            Member_SessionBook form = new Member_SessionBook();
            Hide();
            form.ShowDialog();
        }


        private void home_btn_Click(object sender, EventArgs e)
        {
            Currbtn(ref home_btn,40);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Currbtn(ref logout_btn, 40);
            Session.Logout();
            this.Hide();
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Currbtn(ref button7, 40);
            Thread.Sleep(50);
            Member_WorkoutPlans form = new Member_WorkoutPlans();
            Hide();
            form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Currbtn(ref button8, 40);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Currbtn(ref button9, 40);
        }

        private void account_btn_Click(object sender, EventArgs e)
        {
            Currbtn(ref account_btn, 40);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            panel8.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, 20, 20));

        }

        private void Search_text_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void wokout_plan_btn_Click_1(object sender, EventArgs e)
        {
            Currbtn(ref wokout_plan_btn, 40);
            Thread.Sleep(50);
            Member_WorkoutPlans form = new Member_WorkoutPlans();
            Hide();
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Currbtn(ref button1, 30);
            Thread.Sleep(50);
            Member_DietPlans form = new Member_DietPlans();
            Hide();
            form.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Currbtn(ref button2, 30);
            Thread.Sleep(50);
            Member_FeedBack form = new Member_FeedBack();
            Hide();
            form.ShowDialog();
        }
    }
}
