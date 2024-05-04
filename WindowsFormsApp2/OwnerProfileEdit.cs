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
    public partial class OwnerProfileEdit : Form
    {
        public OwnerProfileEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OwnerProfile prof = new OwnerProfile();
            prof.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OwnerProfile prof = new OwnerProfile();
            prof.Show();
            this.Hide();
        }
    }
}
