﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public SignupPage()
        {
            InitializeComponent();
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
        }


        private bool validateInput()
        {

            //if any one is null or white space it return true;
            return string.IsNullOrWhiteSpace(firstName.Text) ||
                   string.IsNullOrWhiteSpace(lastName.Text) ||
                   string.IsNullOrWhiteSpace(fatherName.Text) ||
                   string.IsNullOrWhiteSpace(address.Text) ||
                   string.IsNullOrWhiteSpace(cnic.Text) ||
                   string.IsNullOrWhiteSpace(gmail.Text) ||
                   string.IsNullOrWhiteSpace(username.Text) ||
                   string.IsNullOrWhiteSpace(Password2.Text) ||
                   comboBox1.SelectedItem == null;
                    
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void memberSingup()
        {

            if (validateInput())
            {

            }
            else
            {

                Trainer_class trainer = new Trainer_class();
                trainer.SetFirstName(firstName.Text.Trim());
                trainer.SetLastName(lastName.Text.Trim());
                trainer.SetGender(gender.Text.Trim());
                trainer.SetCNIC(cnic.Text.Trim());
                trainer.SetGmail(gmail.Text.Trim());
                trainer.SetFatherName(fatherName.Text.Trim());
                trainer.SetGender(comboBox1.SelectedItem.ToString());
                trainer.SetUserName(username.Text.Trim());
                trainer.SetAddress(address.Text.Trim());
                trainer.SetPassword(Password.Text.Trim());


                SqlConnection sqlConnection = DatabaseManager.GetConnection();
                sqlConnection.Open();

                string checkQuery = "SELECT COUNT(*) FROM Trainer WHERE UserName = @username";
                SqlCommand checkCommand = new SqlCommand(checkQuery, sqlConnection);

                SqlParameter usernameParam = new SqlParameter("@username", trainer.GetUserName());
                checkCommand.Parameters.Add(usernameParam);

                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("a user with same user name exists");
                    return;
                }

                sqlConnection.Close();

                this.Hide();
                RegisterAsMember registerAsMember = new RegisterAsMember();
                registerAsMember.Show();
            }

        }

        private void TrainerSignup()
        {

            if (validateInput())
            {
                MessageBox.Show("something is wornge");
            }
            else
            {
                Trainer_class trainer = new Trainer_class();
                trainer.SetFirstName(firstName.Text.Trim());
                trainer.SetLastName(lastName.Text.Trim());
                trainer.SetGender(gender.Text.Trim());
                trainer.SetCNIC(cnic.Text.Trim());
                trainer.SetGmail(gmail.Text.Trim());
                trainer.SetFatherName(fatherName.Text.Trim());
                trainer.SetGender(comboBox1.SelectedItem.ToString());
                trainer.SetUserName(username.Text.Trim());
                trainer.SetAddress(address.Text.Trim());
                trainer.SetPassword(Password.Text.Trim());


                SqlConnection sqlConnection = DatabaseManager.GetConnection();
                sqlConnection.Open();

                string checkQuery = "SELECT COUNT(*) FROM Trainer WHERE UserName = @username";
                SqlCommand checkCommand = new SqlCommand(checkQuery, sqlConnection);

                SqlParameter usernameParam = new SqlParameter("@username", trainer.GetUserName());
                checkCommand.Parameters.Add(usernameParam);

                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("a user with same user name exists");
                    return;
                }

                sqlConnection.Close();
                this.Hide();
                SginupAsTrainer registerTrainer = new SginupAsTrainer(trainer);
                registerTrainer.Show();
            }

        }
        private void GymOwnerSingup()
        {

            this.Hide();
            SignupAsGymOwner signupAsGymOwner = new SignupAsGymOwner();
            signupAsGymOwner.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
                MessageBox.Show("Please Complete you information");
            else if (radioButton1.Checked)
            {
                TrainerSignup();

            }
            else if (radioButton2.Checked)
            {

                memberSingup();
            }
            else
            {
                GymOwnerSingup();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
