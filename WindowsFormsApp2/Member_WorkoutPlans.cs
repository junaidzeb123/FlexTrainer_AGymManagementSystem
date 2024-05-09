using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Member_WorkoutPlans : Form
    {
        public Member_WorkoutPlans()
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


        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Currbtn(ref button6, 70);
            Thread.Sleep(50);
            Workout_Add form = new Workout_Add();
            Hide();
            form.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Currbtn(ref button1, 40);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Currbtn(ref button2, 30);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Currbtn(ref button3, 30);

        }

        private void buton4_Click(object sender, EventArgs e)
        {
            Currbtn(ref buton4, 30);

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Currbtn(ref button5, 30);

        }

        private void home_Click_1(object sender, EventArgs e)
        {
            Currbtn(ref home, 40);
            Thread.Sleep(50);
            Member_Home form = new Member_Home();
            Hide();
            form.ShowDialog();
        }

        private void account_btn_Click(object sender, EventArgs e)
        {
          

        }

        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {
            panel7.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));

        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Workout_Display trainer_Workout = new Workout_Display();
            trainer_Workout.Show();
        }
    }
}
