namespace WindowsFormsApp2
{
    partial class TrainenHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainenHome));
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Search_text_Box = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Feedback = new System.Windows.Forms.Button();
            this.account_btn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(-413, -123);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(120, 90);
            this.vScrollBar1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.Feedback);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.home_btn);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 764);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.button7.ForeColor = System.Drawing.Color.Coral;
            this.button7.Location = new System.Drawing.Point(44, 196);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button7.Size = new System.Drawing.Size(246, 73);
            this.button7.TabIndex = 3;
            this.button7.Text = "Workout";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.button8.ForeColor = System.Drawing.Color.Coral;
            this.button8.Location = new System.Drawing.Point(44, 371);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button8.Size = new System.Drawing.Size(246, 73);
            this.button8.TabIndex = 5;
            this.button8.Text = "Appointments";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.logout_btn.ForeColor = System.Drawing.Color.Coral;
            this.logout_btn.Location = new System.Drawing.Point(44, 631);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logout_btn.Size = new System.Drawing.Size(246, 73);
            this.logout_btn.TabIndex = 2;
            this.logout_btn.Text = "LOGOUT";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.home_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.home_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_btn.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.home_btn.ForeColor = System.Drawing.Color.Coral;
            this.home_btn.Location = new System.Drawing.Point(44, 284);
            this.home_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.home_btn.Name = "home_btn";
            this.home_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.home_btn.Size = new System.Drawing.Size(246, 73);
            this.home_btn.TabIndex = 0;
            this.home_btn.Text = "Diet Plans";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.button9.ForeColor = System.Drawing.Color.Coral;
            this.button9.Location = new System.Drawing.Point(44, 458);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button9.Size = new System.Drawing.Size(246, 73);
            this.button9.TabIndex = 7;
            this.button9.Text = "Reports";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Search_text_Box
            // 
            this.Search_text_Box.BackColor = System.Drawing.Color.White;
            this.Search_text_Box.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Search_text_Box.Location = new System.Drawing.Point(507, 161);
            this.Search_text_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search_text_Box.Name = "Search_text_Box";
            this.Search_text_Box.Size = new System.Drawing.Size(558, 45);
            this.Search_text_Box.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.panel3.Controls.Add(this.account_btn);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.Search_text_Box);
            this.panel3.Location = new System.Drawing.Point(2, -3);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1237, 728);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(643, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "FLEX TRAINER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1287, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 32);
            this.label10.TabIndex = 16;
            this.label10.Text = "Account";
            // 
            // Feedback
            // 
            this.Feedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Feedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Feedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Feedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Feedback.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.Feedback.ForeColor = System.Drawing.Color.Coral;
            this.Feedback.Location = new System.Drawing.Point(44, 542);
            this.Feedback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Feedback.Name = "Feedback";
            this.Feedback.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Feedback.Size = new System.Drawing.Size(246, 73);
            this.Feedback.TabIndex = 8;
            this.Feedback.Text = "Feedbacks";
            this.Feedback.UseVisualStyleBackColor = false;
            this.Feedback.Click += new System.EventHandler(this.Feedback_Click);
            // 
            // account_btn
            // 
            this.account_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.account_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.account_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("account_btn.BackgroundImage")));
            this.account_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.account_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.account_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.account_btn.Location = new System.Drawing.Point(1095, 36);
            this.account_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.account_btn.Name = "account_btn";
            this.account_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.account_btn.Size = new System.Drawing.Size(90, 81);
            this.account_btn.TabIndex = 18;
            this.account_btn.Text = "\r\n";
            this.account_btn.UseVisualStyleBackColor = false;
            this.account_btn.Click += new System.EventHandler(this.account_btn_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.panel8.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.photo_1534438327276_14e5300c3a48;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(355, 226);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(879, 498);
            this.panel8.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(54, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 156);
            this.panel2.TabIndex = 1;
            // 
            // TrainenHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 716);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "TrainenHome";
            this.Text = "TrainenHome";
            this.Load += new System.EventHandler(this.TrainenHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Search_text_Box;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button account_btn;
        private System.Windows.Forms.Button Feedback;
    }
}