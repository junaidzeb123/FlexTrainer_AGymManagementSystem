namespace WindowsFormsApp2
{
    partial class Trainer_Workout
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Gridview = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MyPlans = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(750, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 83);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.MyPlans);
            this.panel1.Controls.Add(this.Gridview);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(42, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 633);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(179, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(924, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "All Workouts Will be Available here";
            // 
            // Gridview
            // 
            this.Gridview.AllowDrop = true;
            this.Gridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.Gridview.Location = new System.Drawing.Point(26, 133);
            this.Gridview.Name = "Gridview";
            this.Gridview.RowHeadersWidth = 62;
            this.Gridview.RowTemplate.Height = 28;
            this.Gridview.Size = new System.Drawing.Size(1077, 312);
            this.Gridview.TabIndex = 117;
            this.Gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(60, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 53);
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MyPlans
            // 
            this.MyPlans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MyPlans.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.MyPlans.ForeColor = System.Drawing.Color.Coral;
            this.MyPlans.Location = new System.Drawing.Point(460, 501);
            this.MyPlans.Name = "MyPlans";
            this.MyPlans.Size = new System.Drawing.Size(168, 64);
            this.MyPlans.TabIndex = 118;
            this.MyPlans.Text = "All Plans";
            this.MyPlans.UseVisualStyleBackColor = false;
            this.MyPlans.Click += new System.EventHandler(this.MyPlans_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.button2.ForeColor = System.Drawing.Color.Coral;
            this.button2.Location = new System.Drawing.Point(126, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 64);
            this.button2.TabIndex = 119;
            this.button2.Text = "My Plans";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Trainer_Workout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1228, 716);
            this.Controls.Add(this.panel1);
            this.Name = "Trainer_Workout";
            this.Text = "Workout";
            this.Load += new System.EventHandler(this.Trainer_Workout_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView Gridview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button MyPlans;
    }
}