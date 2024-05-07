using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class GymOwner_Profile : Form
    {
        public GymOwner_Profile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GymOwner_Home home = new GymOwner_Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             GymOwner_ProfileEdit edit = new GymOwner_ProfileEdit();
            edit.Show();
            this.Hide();
        }

        private void OwnerProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
