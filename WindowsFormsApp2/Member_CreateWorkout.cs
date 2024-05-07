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
    public partial class Member_CreateWorkout : Form
    {
        public Member_CreateWorkout()
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
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void home_Click(object sender, EventArgs e)
        {
            Currbtn(ref home, 40);
            Thread.Sleep(50);
            Member_Home form = new Member_Home();
            Hide();
            form.ShowDialog();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            panel7.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void account_btn_Click(object sender, EventArgs e)
        {
            Currbtn(ref home, 40);
            Member_WorkoutPlans form = new Member_WorkoutPlans();
            Hide();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Currbtn(ref button1, 40);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 20, 20));
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {
            panel7.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
            panel4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 20, 20));

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
