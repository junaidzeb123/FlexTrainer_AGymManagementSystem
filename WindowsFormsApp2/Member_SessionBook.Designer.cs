namespace WindowsFormsApp2
{
    partial class Member_SessionBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member_SessionBook));
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.starttime = new System.Windows.Forms.ComboBox();
            this.endtime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trainer = new System.Windows.Forms.ComboBox();
            this.notification = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(488, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Book Training Session";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.notification);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.home);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(14, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1250, 772);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.panel4.Controls.Add(this.trainer);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(497, 170);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(579, 157);
            this.panel4.TabIndex = 27;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(44, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 35);
            this.label8.TabIndex = 22;
            this.label8.Text = "Trainer";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.endtime);
            this.panel7.Controls.Add(this.starttime);
            this.panel7.Controls.Add(this.date);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Location = new System.Drawing.Point(428, 335);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(684, 323);
            this.panel7.TabIndex = 25;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint_1);
            // 
            // button1
            // 
            this.button1.AccessibleName = "home";
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(306, 238);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(226, 67);
            this.button1.TabIndex = 26;
            this.button1.Text = "Book Now";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(64, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "Date";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.date.Location = new System.Drawing.Point(239, 42);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(409, 39);
            this.date.TabIndex = 28;
            // 
            // starttime
            // 
            this.starttime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starttime.FormattingEnabled = true;
            this.starttime.Location = new System.Drawing.Point(239, 102);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(409, 40);
            this.starttime.TabIndex = 29;
            this.starttime.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // endtime
            // 
            this.endtime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endtime.FormattingEnabled = true;
            this.endtime.Location = new System.Drawing.Point(239, 162);
            this.endtime.Name = "endtime";
            this.endtime.Size = new System.Drawing.Size(409, 40);
            this.endtime.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(64, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 30);
            this.label3.TabIndex = 31;
            this.label3.Text = "End Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(64, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 30);
            this.label4.TabIndex = 32;
            this.label4.Text = "Start time";
            // 
            // trainer
            // 
            this.trainer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainer.FormattingEnabled = true;
            this.trainer.Location = new System.Drawing.Point(214, 53);
            this.trainer.Name = "trainer";
            this.trainer.Size = new System.Drawing.Size(317, 40);
            this.trainer.TabIndex = 31;
            // 
            // notification
            // 
            this.notification.AutoSize = true;
            this.notification.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification.ForeColor = System.Drawing.Color.Red;
            this.notification.Location = new System.Drawing.Point(573, 117);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(0, 28);
            this.notification.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(16, 193);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 483);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // home
            // 
            this.home.AccessibleName = "home";
            this.home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.home.BackColor = System.Drawing.Color.DarkViolet;
            this.home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home.BackgroundImage")));
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.home.Location = new System.Drawing.Point(1102, -80);
            this.home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.home.Name = "home";
            this.home.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.home.Size = new System.Drawing.Size(90, 81);
            this.home.TabIndex = 18;
            this.home.Text = "\r\n";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(76, 19);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 118);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(310, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Member_SessionBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 716);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Member_SessionBook";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Member_SessionBook_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox starttime;
        private System.Windows.Forms.ComboBox endtime;
        private System.Windows.Forms.ComboBox trainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label notification;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}