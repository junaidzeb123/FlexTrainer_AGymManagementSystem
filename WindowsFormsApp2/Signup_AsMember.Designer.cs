namespace WindowsFormsApp2
{
    partial class Signup_AsMember
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
            this.Gym = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.basic = new System.Windows.Forms.RadioButton();
            this.premium = new System.Windows.Forms.RadioButton();
            this.standard = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(480, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 72);
            this.button1.TabIndex = 32;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Gym);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.basic);
            this.panel1.Controls.Add(this.premium);
            this.panel1.Controls.Add(this.standard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.panel1.Location = new System.Drawing.Point(68, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 620);
            this.panel1.TabIndex = 58;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(56, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 53);
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Gym
            // 
            this.Gym.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.Gym.FormattingEnabled = true;
            this.Gym.Location = new System.Drawing.Point(425, 95);
            this.Gym.Name = "Gym";
            this.Gym.Size = new System.Drawing.Size(369, 43);
            this.Gym.TabIndex = 65;
            this.Gym.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(169, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 35);
            this.label2.TabIndex = 64;
            this.label2.Text = "Select Pachage";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // basic
            // 
            this.basic.AutoSize = true;
            this.basic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basic.ForeColor = System.Drawing.Color.Black;
            this.basic.Location = new System.Drawing.Point(423, 178);
            this.basic.Name = "basic";
            this.basic.Size = new System.Drawing.Size(85, 29);
            this.basic.TabIndex = 63;
            this.basic.TabStop = true;
            this.basic.Text = "Basic";
            this.basic.UseVisualStyleBackColor = true;
            // 
            // premium
            // 
            this.premium.AutoSize = true;
            this.premium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premium.ForeColor = System.Drawing.Color.Black;
            this.premium.Location = new System.Drawing.Point(722, 176);
            this.premium.Name = "premium";
            this.premium.Size = new System.Drawing.Size(114, 29);
            this.premium.TabIndex = 62;
            this.premium.TabStop = true;
            this.premium.Text = "Premium";
            this.premium.UseVisualStyleBackColor = true;
            this.premium.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // standard
            // 
            this.standard.AutoSize = true;
            this.standard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standard.ForeColor = System.Drawing.Color.Black;
            this.standard.Location = new System.Drawing.Point(577, 176);
            this.standard.Name = "standard";
            this.standard.Size = new System.Drawing.Size(113, 29);
            this.standard.TabIndex = 61;
            this.standard.TabStop = true;
            this.standard.Text = "standard";
            this.standard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(171, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 35);
            this.label1.TabIndex = 58;
            this.label1.Text = "Select Gym :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(505, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 54);
            this.label3.TabIndex = 57;
            this.label3.Text = "Signup";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Signup_AsMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1228, 716);
            this.Controls.Add(this.panel1);
            this.Name = "Signup_AsMember";
            this.Text = "RegisterAsMember";
            this.Load += new System.EventHandler(this.RegisterAsMember_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Gym;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton basic;
        private System.Windows.Forms.RadioButton premium;
        private System.Windows.Forms.RadioButton standard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}