namespace WindowsFormsApp2
{
    partial class MealDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealDetail));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mealNameInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.calroriesinput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lactose = new System.Windows.Forms.CheckBox();
            this.gluton = new System.Windows.Forms.CheckBox();
            this.peanuts = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fatinput = new System.Windows.Forms.TextBox();
            this.fiberinput = new System.Windows.Forms.TextBox();
            this.carbsinput = new System.Windows.Forms.TextBox();
            this.proteininput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(858, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 76);
            this.button1.TabIndex = 13;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.button2.ForeColor = System.Drawing.Color.Coral;
            this.button2.Location = new System.Drawing.Point(607, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 74);
            this.button2.TabIndex = 23;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(68, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.panel4.Controls.Add(this.mealNameInput);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(566, 82);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(532, 100);
            this.panel4.TabIndex = 49;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // mealNameInput
            // 
            this.mealNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mealNameInput.Location = new System.Drawing.Point(216, 41);
            this.mealNameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mealNameInput.Name = "mealNameInput";
            this.mealNameInput.Size = new System.Drawing.Size(227, 35);
            this.mealNameInput.TabIndex = 23;
            this.mealNameInput.TextChanged += new System.EventHandler(this.mealName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(18, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 48);
            this.label8.TabIndex = 22;
            this.label8.Text = "Meal Name";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.calroriesinput);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.lactose);
            this.panel7.Controls.Add(this.gluton);
            this.panel7.Controls.Add(this.peanuts);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.fatinput);
            this.panel7.Controls.Add(this.fiberinput);
            this.panel7.Controls.Add(this.carbsinput);
            this.panel7.Controls.Add(this.proteininput);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.panel7.Location = new System.Drawing.Point(374, 190);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(820, 401);
            this.panel7.TabIndex = 48;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // calroriesinput
            // 
            this.calroriesinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.calroriesinput.Location = new System.Drawing.Point(430, 260);
            this.calroriesinput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calroriesinput.Name = "calroriesinput";
            this.calroriesinput.Size = new System.Drawing.Size(227, 30);
            this.calroriesinput.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(228, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 32);
            this.label13.TabIndex = 30;
            this.label13.Text = "calories";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(223, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 32);
            this.label12.TabIndex = 29;
            this.label12.Text = "ALLERGENS";
            // 
            // lactose
            // 
            this.lactose.AutoSize = true;
            this.lactose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lactose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lactose.Location = new System.Drawing.Point(667, 310);
            this.lactose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lactose.Name = "lactose";
            this.lactose.Size = new System.Drawing.Size(114, 29);
            this.lactose.TabIndex = 28;
            this.lactose.Text = "Lactose";
            this.lactose.UseVisualStyleBackColor = true;
            // 
            // gluton
            // 
            this.gluton.AutoSize = true;
            this.gluton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gluton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gluton.Location = new System.Drawing.Point(560, 310);
            this.gluton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gluton.Name = "gluton";
            this.gluton.Size = new System.Drawing.Size(101, 29);
            this.gluton.TabIndex = 27;
            this.gluton.Text = "Gluten";
            this.gluton.UseVisualStyleBackColor = true;
            // 
            // peanuts
            // 
            this.peanuts.AutoSize = true;
            this.peanuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.peanuts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.peanuts.Location = new System.Drawing.Point(430, 310);
            this.peanuts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.peanuts.Name = "peanuts";
            this.peanuts.Size = new System.Drawing.Size(117, 29);
            this.peanuts.TabIndex = 26;
            this.peanuts.Text = "Peanuts";
            this.peanuts.UseVisualStyleBackColor = true;
            this.peanuts.CheckedChanged += new System.EventHandler(this.peanuts_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(312, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "(g)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(295, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "(g)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(295, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "(g)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(273, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "(g)";
            // 
            // fatinput
            // 
            this.fatinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fatinput.Location = new System.Drawing.Point(430, 202);
            this.fatinput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fatinput.Name = "fatinput";
            this.fatinput.Size = new System.Drawing.Size(227, 30);
            this.fatinput.TabIndex = 11;
            // 
            // fiberinput
            // 
            this.fiberinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fiberinput.Location = new System.Drawing.Point(430, 148);
            this.fiberinput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fiberinput.Name = "fiberinput";
            this.fiberinput.Size = new System.Drawing.Size(227, 30);
            this.fiberinput.TabIndex = 10;
            // 
            // carbsinput
            // 
            this.carbsinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.carbsinput.Location = new System.Drawing.Point(430, 92);
            this.carbsinput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.carbsinput.Name = "carbsinput";
            this.carbsinput.Size = new System.Drawing.Size(227, 30);
            this.carbsinput.TabIndex = 9;
            // 
            // proteininput
            // 
            this.proteininput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.proteininput.Location = new System.Drawing.Point(430, 43);
            this.proteininput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.proteininput.Name = "proteininput";
            this.proteininput.Size = new System.Drawing.Size(227, 30);
            this.proteininput.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(228, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(228, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Carbs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(228, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Protein";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(228, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fiber";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 369);
            this.panel1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(593, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 60);
            this.label1.TabIndex = 44;
            this.label1.Text = "Create Diet Plan";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(12, 500);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(329, 180);
            this.panel5.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(458, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 32;
            // 
            // MealDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1228, 716);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "MealDetail";
            this.Text = "MealDetail";
            this.Load += new System.EventHandler(this.MealDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox mealNameInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox lactose;
        private System.Windows.Forms.CheckBox gluton;
        private System.Windows.Forms.CheckBox peanuts;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fatinput;
        private System.Windows.Forms.TextBox fiberinput;
        private System.Windows.Forms.TextBox carbsinput;
        private System.Windows.Forms.TextBox proteininput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox calroriesinput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
    }
}