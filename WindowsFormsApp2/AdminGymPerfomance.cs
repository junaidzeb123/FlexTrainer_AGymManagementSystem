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
    public partial class AdminGymPerfomance : Form
    {
        public AdminGymPerfomance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Home admin_Home = new Admin_Home();
            admin_Home.Show();
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
            Admin_Home admin_Home = new Admin_Home();
            admin_Home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void LoadALLPlanIntoTable(){
            try
            {

                SqlConnection sqlConnection = DatabaseManager.GetConnection();
                sqlConnection.Open();

                string query = "Select * from gyms;";
                SqlCommand command = new SqlCommand(query, sqlConnection);


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Gridview.DataSource = dataTable;
            }
            catch(Exception ex)
            {
               
            }
            
        }

      
        private void AdminGymPerfomance_Load(object sender, EventArgs e)
        {
            try
            {

                Gridview.CellContentClick += Gridview_CellContentClick;
                LoadALLPlanIntoTable();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.ToString());
             }
        }

        private void Gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
