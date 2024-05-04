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
    public partial class OwnerProfile : Form
    {
        public OwnerProfile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GymOwnerHome home = new GymOwnerHome();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             OwnerProfileEdit edit = new OwnerProfileEdit();
            edit.Show();
            this.Hide();
        }

        private void OwnerProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
