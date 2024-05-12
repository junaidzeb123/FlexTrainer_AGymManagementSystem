﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Member_DietPlanShow : Form
    {
        public Member_DietPlanShow()
        {
            InitializeComponent();
        }

        private void LoadMyPlansPlanIntoTable()
        {
            try
            {

                using (SqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT " + Session.Role + "DietPlan.UserName, Diet_Plan.DietPlanId, Diet_Plan.Type, Diet_Plan.Purpose," +
                                    " Diet_Plan.noofMeals " +
                                   "FROM Diet_Plan " +
                                   "INNER JOIN " + Session.Role + "DietPlan ON Diet_Plan.DietPlanId =" + Session.Role + "DietPlan.DietPlanId " +
                                   "WHERE " + Session.Role + "DietPlan.UserName = @userName " +
                                   "ORDER BY Diet_Plan.DietPlanId;";


                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userName", Session.Username);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    Gridview.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void LoadALLPlanIntoTable()
        {
            try
            {

                using (SqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM Diet_Plan;";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    Gridview.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void Member_DietPlanShow_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = "See Meals";
            buttonColumn.Name = "btnColumn";
            buttonColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.HeaderText = "Action2";
            buttonColumn2.Text = "Add to MY";
            buttonColumn2.Name = "btnColumn2";
            buttonColumn2.UseColumnTextForButtonValue = true;
            Gridview.Columns.Add(buttonColumn);
            Gridview.Columns.Add(buttonColumn2);

            LoadALLPlanIntoTable();
        }

        private void Gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Gridview.Columns["btnColumn"].Index && e.RowIndex >= 0)
            {
                object value = Gridview.Rows[e.RowIndex].Cells[2].Value;
                if (value != null)
                {
                    string dataToSend = value.ToString();

                    this.Hide();
                    Diet_Display_Show_Meals otherForm = new Diet_Display_Show_Meals(dataToSend); // Pass the value to the constructor
                    otherForm.Show();
                    return;
                }
            }

            if (e.ColumnIndex == Gridview.Columns["btnColumn2"].Index && e.RowIndex >= 0)
            {
                object value = Gridview.Rows[e.RowIndex].Cells[2].Value;
                if (value != null)
                {
                    string dataToSend = value.ToString();

                    int dietplanId;
                    int.TryParse(dataToSend, out dietplanId);


                    SqlConnection sqlConnection = DatabaseManager.GetConnection();
                    sqlConnection.Open();

                    string query2 = "Select count(*) from MemberDietPlan where DietPlanId = @dietplan and  UserName = @username";
                    SqlCommand sqlCommand1 = new SqlCommand(query2, sqlConnection);
                    sqlCommand1.Parameters.AddWithValue("@dietplan", dietplanId);
                    sqlCommand1.Parameters.AddWithValue("@username", Session.Username);

                    int count = (int)sqlCommand1.ExecuteScalar();
                    if(count > 0)
                    {
                        MessageBox.Show("This is already included in your plans");
                        return;
                    }

                    string query = "Insert into MemberDietPlan ( DietPlanId ,UserName) VALUES(@dietplan , @usernme) ";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);


                    sqlCommand.Parameters.AddWithValue("@dietplan", dietplanId);
                    sqlCommand.Parameters.AddWithValue("@usernme", Session.Username);

                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Plan is added in your plans.");

                    return;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Member_DietPlans member_DietPlans = new Member_DietPlans();
            member_DietPlans.Show();
        }
    }
}
