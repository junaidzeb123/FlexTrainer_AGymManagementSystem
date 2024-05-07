using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class NotificationForm : Form
    {
        private Timer timer;
        public NotificationForm(string message, int displayDuration)
        {
            InitializeComponent();
            labelMessage.Text = message;

            timer = new Timer();
            timer.Interval = displayDuration; // Set the duration in milliseconds
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Close(); // Close the form when the timer elapses
        }

        private void NotificationForm_Shown(object sender, EventArgs e)
        {
            timer.Start(); // Start the timer when the form is shown
        }
        private void NotificationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
