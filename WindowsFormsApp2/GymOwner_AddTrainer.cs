﻿using System;
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
    public partial class GymOwner_AddTrainer : Form
    {
        public GymOwner_AddTrainer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gymowner_Search search  = new Gymowner_Search();
            search.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gymowner_Search search = new Gymowner_Search();
            search.Show();
            this.Hide();
        }

        private void GymOwner_AddTrainer_Load(object sender, EventArgs e)
        {

        }
    }
}
