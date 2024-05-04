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
    public partial class GymOwnerHome : Form
    {
        public GymOwnerHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GymOwnerMemberSearch search = new GymOwnerMemberSearch();
            search.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GymownerSearch trainer = new GymownerSearch();
            trainer.Show();
            this.Hide();
        }
    }
}
