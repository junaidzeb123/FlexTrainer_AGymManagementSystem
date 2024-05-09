using System;
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
    public partial class DietPlans_Display : Form
    {
        public DietPlans_Display()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DietPlan_Add dietPlanAdd = new DietPlan_Add();
            dietPlanAdd.Show();
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


        //private bool Validate()
        //{
        //    // Check if any of the fields are empty or contain non-integer values
        //    return string.IsNullOrWhiteSpace(type.Text) ||
        //           string.IsNullOrWhiteSpace(Purpose.Text) ||
        //           string.IsNullOrWhiteSpace(.Text) ||
               
        //}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 40, 40));
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


        private void LoadMyPlansPlanIntoTable()
        {
            try
            {

                using (SqlConnection connection = DatabaseManager.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT " +Session.Role +  "DietPlan.UserName, Diet_Plan.DietPlanId, Diet_Plan.Type, Diet_Plan.Purpose," +
                                    " Diet_Plan.noofMeals " +
                                   "FROM Diet_Plan " +
                                   "INNER JOIN " + Session.Role + "DietPlan ON Diet_Plan.DietPlanId =" +Session.Role +"DietPlan.DietPlanId " +
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


        private void Gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Gridview.Columns["btnColumn"].Index && e.RowIndex >= 0)
            {
                object value = Gridview.Rows[e.RowIndex].Cells[1].Value;
                if (value != null)
                {
                    string dataToSend = value.ToString();

                    this.Hide();
                    Diet_Display_Show_Meals otherForm = new Diet_Display_Show_Meals(dataToSend); // Pass the value to the constructor
                    otherForm.Show();
                    return;
                }
            }
        }


        private void DietPlans_Load(object sender, EventArgs e)
        {
           
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "Action";
                buttonColumn.Text = "See Meals";
                buttonColumn.Name = "btnColumn";
                buttonColumn.UseColumnTextForButtonValue = true;
                Gridview.Columns.Add(buttonColumn);
                LoadALLPlanIntoTable();

        }

        private void Allplans_Click(object sender, EventArgs e)
        {
        LoadALLPlanIntoTable();

        }

        private void MyPlans_Click(object sender, EventArgs e)
        {
            LoadMyPlansPlanIntoTable();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                this.Hide();
            if(Session.Role == "Trainer")
            {
                TrainenHome trainenHome = new TrainenHome();
                trainenHome.Show();
            }else if(Session.Role == "Member")
            {
                Member_Home member_Home = new Member_Home();
                member_Home.Show();


            }
        }
    }
}
