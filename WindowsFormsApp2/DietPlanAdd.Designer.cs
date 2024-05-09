namespace WindowsFormsApp2
{
    partial class DietPlanAdd
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
            this.laberl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.noofmeals = new System.Windows.Forms.TextBox();
            this.purpose = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.laberl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(491, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // laberl
            // 
            this.laberl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.laberl.Controls.Add(this.pictureBox1);
            this.laberl.Controls.Add(this.noofmeals);
            this.laberl.Controls.Add(this.button1);
            this.laberl.Controls.Add(this.purpose);
            this.laberl.Controls.Add(this.type);
            this.laberl.Controls.Add(this.label4);
            this.laberl.Controls.Add(this.label3);
            this.laberl.Controls.Add(this.label2);
            this.laberl.Controls.Add(this.label1);
            this.laberl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.laberl.Location = new System.Drawing.Point(80, 59);
            this.laberl.Name = "laberl";
            this.laberl.Size = new System.Drawing.Size(1070, 599);
            this.laberl.TabIndex = 11;
            this.laberl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(82, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 53);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // noofmeals
            // 
            this.noofmeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noofmeals.Location = new System.Drawing.Point(453, 295);
            this.noofmeals.Name = "noofmeals";
            this.noofmeals.Size = new System.Drawing.Size(322, 44);
            this.noofmeals.TabIndex = 14;
            // 
            // purpose
            // 
            this.purpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purpose.Location = new System.Drawing.Point(453, 234);
            this.purpose.Name = "purpose";
            this.purpose.Size = new System.Drawing.Size(322, 44);
            this.purpose.TabIndex = 13;
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(453, 173);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(322, 44);
            this.type.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.label4.Location = new System.Drawing.Point(236, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "No of Meals :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.label3.Location = new System.Drawing.Point(236, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Purpose :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.label2.Location = new System.Drawing.Point(240, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(365, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "Diet Plan Cration";
            // 
            // DietPlanAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1228, 716);
            this.Controls.Add(this.laberl);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "DietPlanAdd";
            this.Text = "DietPlanCreation";
            this.Load += new System.EventHandler(this.DietPlanCreation_Load);
            this.laberl.ResumeLayout(false);
            this.laberl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel laberl;
        private System.Windows.Forms.TextBox noofmeals;
        private System.Windows.Forms.TextBox purpose;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}