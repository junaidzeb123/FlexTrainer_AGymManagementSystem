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
    public partial class Trainer_WorkoutAdd : Form
    {
        public Trainer_WorkoutAdd()
        {
            InitializeComponent();
            // Add the initial workout purposes to the ComboBox
            purpose.Items.Add("Weight Loss");
            purpose.Items.Add("Bulking");
            purpose.Items.Add("Cutting");
            purpose.Items.Add("Muscle Definition/Toning");
            purpose.Items.Add("Strength Training");
            purpose.Items.Add("Functional Fitness");
            purpose.Items.Add("Injury Prevention");
            purpose.Items.Add("Sport-Specific Training");
            purpose.Items.Add("Mind-Body Connection");
            purpose.Items.Add("General Fitness");

        }

        private bool Validate()
        {
            // Check if any of the fields are empty or contain non-integer values
            return string.IsNullOrWhiteSpace(experience.Text) ||
                   string.IsNullOrWhiteSpace(NoofExercise.Text) ||
                   !int.TryParse(NoofExercise.Text, out _) || // Check if NoofExercise is not a valid integer
                   string.IsNullOrWhiteSpace(reps.Text) ||
                   !int.TryParse(reps.Text, out _) || // Check if reps is not a valid integer
                   string.IsNullOrWhiteSpace(sets.Text) ||
                   !int.TryParse(sets.Text, out _) || // Check if sets is not a valid integer
                   purpose.SelectedItem == null; // Check if purpose is not selected
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (Validate())
            {
                MessageBox.Show("Invalid Input");
            }
            else
            {
                WorkoutPlan workoutplan = new WorkoutPlan();
                workoutplan.purpose = purpose.SelectedItem.ToString();
                workoutplan.experience = experience.Text.Trim();
                int.TryParse(NoofExercise.Text, out workoutplan.noofexercise);
                int.TryParse(reps.Text, out workoutplan.reps);
                int.TryParse(sets.Text, out workoutplan.set);



                this.Hide();
                Trainer_AddingExercise dietPlanCreation = new Trainer_AddingExercise(workoutplan);
                dietPlanCreation.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WorkoutAdd_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trainer_Workout workout = new Trainer_Workout();
            workout.Show();
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
            Trainer_Workout workout = new Trainer_Workout();
            workout.Show();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
