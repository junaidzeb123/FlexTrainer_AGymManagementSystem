using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp2
{
    public partial class Memeber_GiveFeedBack : Form
    {
        public Memeber_GiveFeedBack()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,int nTopRect,int nRightRect,    
            int nBottomRect,int nWidthEllipse, int nHeightEllipse );


        private bool Validate()
        {
            return string.IsNullOrEmpty( feedback.Text ) ||(
                   !radioButton1.Checked && 
                   !radioButton2.Checked && 
                   !radioButton3.Checked && 
                   !radioButton4.Checked && 
                   !radioButton5.Checked  ) ||
                   comboBox1.SelectedItem == null;  
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
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            panel7.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 20, 20));

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));

        }

        private void account_btn_Click(object sender, EventArgs e)
        {
            Currbtn(ref account_btn, 40);
            Member_FeedBack form = new Member_FeedBack();
            Hide();
            form.ShowDialog();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Currbtn(ref home, 40);
            Member_Home form = new Member_Home();
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

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
            panel4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 20, 20));
        }

        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {
            panel7.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Validate())
            {
                MessageBox.Show("Please Complete Your Feeback");
            }
            else
            {
                int rating = 0;
                if (radioButton1.Checked)
                    rating = 1;  
                if (radioButton2.Checked)
                    rating = 2;  
                if (radioButton3.Checked)
                    rating = 3; 
                if (radioButton4.Checked)
                    rating = 4;  
                if (radioButton5.Checked)
                    rating = 5;

                SqlConnection sqlConnection = DatabaseManager.GetConnection();
                sqlConnection.Open();

                string query = "Insert into Feedback (Description,Rating,MemberUserName,TrainerUserName) " +
                                "Values (@description , @rating,  @memberName, @TrainerName)";

                SqlCommand sqlCommand  = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue(@"description", feedback.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@rating", rating);
                sqlCommand.Parameters.AddWithValue("@memberName", Session.Username);
                sqlCommand.Parameters.AddWithValue("@TrainerName", comboBox1.SelectedItem.ToString().Trim() );

                sqlCommand.ExecuteReader();

                comboBox1.SelectedItem = null;
                feedback.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Memeber_GiveFeedBack_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT Gyms.Name from Gyms " +
                                "INNER JOIN " +
                                "MemberGym ON GYMS.Name = MemberGym.Name" +
                                " where  MemberGym.UserName = @userName;";

                SqlConnection sqlConnection = DatabaseManager.GetConnection();
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@userName", Session.Username);

                string gymName = (string)sqlCommand.ExecuteScalar();



                string query2 = "Select TRAINER.UserName FROM TRAINER" +
                    " INNER JOIN TrainerGym " +
                    " on TrainerGym.UserName = Trainer.UserName " +
                    "WHERE TrainerGym.Name = @gymsName;";

                SqlCommand sqlCommand2 = new SqlCommand(query2, sqlConnection);
                sqlCommand2.Parameters.AddWithValue("@gymsName", gymName);

                SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    var value1 = sqlDataReader["UserName"];
                    comboBox1.Items.Add(value1);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
