namespace WindowsFormsApp2
{
    partial class Trainer_WorkoutAdd
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.experience = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.purpose = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NoofExercise = new System.Windows.Forms.TextBox();
            this.reps = new System.Windows.Forms.TextBox();
            this.sets = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(548, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 75);
            this.button1.TabIndex = 11;
            this.button1.Text = "add exercises";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.sets);
            this.panel1.Controls.Add(this.reps);
            this.panel1.Controls.Add(this.NoofExercise);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.experience);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.purpose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(44, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 613);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(68, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 53);
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(258, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 30);
            this.label7.TabIndex = 20;
            // 
            // experience
            // 
            this.experience.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.experience.Location = new System.Drawing.Point(522, 214);
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(358, 37);
            this.experience.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(303, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "No of Exercise :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(303, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Experience :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 45);
            this.label4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(303, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Purpose :";
            // 
            // purpose
            // 
            this.purpose.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.purpose.FormattingEnabled = true;
            this.purpose.Location = new System.Drawing.Point(522, 153);
            this.purpose.Name = "purpose";
            this.purpose.Size = new System.Drawing.Size(358, 38);
            this.purpose.TabIndex = 12;
            this.purpose.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(382, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 54);
            this.label2.TabIndex = 11;
            this.label2.Text = "Workout Creation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(307, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 119;
            this.label1.Text = "Sets :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(303, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 30);
            this.label8.TabIndex = 118;
            this.label8.Text = "Reps :";
            // 
            // NoofExercise
            // 
            this.NoofExercise.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.NoofExercise.Location = new System.Drawing.Point(526, 271);
            this.NoofExercise.Name = "NoofExercise";
            this.NoofExercise.Size = new System.Drawing.Size(358, 37);
            this.NoofExercise.TabIndex = 120;
            // 
            // reps
            // 
            this.reps.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.reps.Location = new System.Drawing.Point(522, 334);
            this.reps.Name = "reps";
            this.reps.Size = new System.Drawing.Size(358, 37);
            this.reps.TabIndex = 121;
            // 
            // sets
            // 
            this.sets.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.sets.Location = new System.Drawing.Point(522, 392);
            this.sets.Name = "sets";
            this.sets.Size = new System.Drawing.Size(358, 37);
            this.sets.TabIndex = 122;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(412, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 123;
            this.label9.Text = "(required)";
            // 
            // Trainer_WorkoutAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1228, 716);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Trainer_WorkoutAdd";
            this.Text = "WorkoutAdd";
            this.Load += new System.EventHandler(this.WorkoutAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox experience;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox purpose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox sets;
        private System.Windows.Forms.TextBox reps;
        private System.Windows.Forms.TextBox NoofExercise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

