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
    public partial class SignupPage : Form
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (!radioButton1.Checked  && !radioButton2.Checked  && !radioButton3.Checked )
                MessageBox.Show("Please Complete you information");
            else if(radioButton1.Checked)
            {

                this.Hide();
                RegisterAsMember registerAsMember = new RegisterAsMember();
                registerAsMember.Show();
            }
            else if(radioButton2.Checked)
            {
                this.Hide();
                SginupAsTrainer registerTrainer = new SginupAsTrainer();
                registerTrainer.Show();
            }
            else 
            {
                this.Hide();
                SignupAsGymOwner signupAsGymOwner = new SignupAsGymOwner();
                signupAsGymOwner.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();  
            loginPage.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrainenHome home = new TrainenHome();
            home.Show();
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
            TrainenHome home = new TrainenHome();
            home.Show();
        }
    }
}
