namespace WindowsFormsApp2
{
    partial class SignupPage
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Password2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gmail = new System.Windows.Forms.TextBox();
            this.cnic = new System.Windows.Forms.TextBox();
            this.fatherName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.cnic2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fatherName2 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(445, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 81);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(455, 595);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(208, 20);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have account. Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.Password2);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.gmail);
            this.panel1.Controls.Add(this.cnic);
            this.panel1.Controls.Add(this.fatherName);
            this.panel1.Controls.Add(this.lastName);
            this.panel1.Controls.Add(this.cnic2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.fatherName2);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.firstName);
            this.panel1.Location = new System.Drawing.Point(57, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 633);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Password2
            // 
            this.Password2.AutoSize = true;
            this.Password2.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.Password2.ForeColor = System.Drawing.Color.Black;
            this.Password2.Location = new System.Drawing.Point(595, 301);
            this.Password2.Name = "Password2";
            this.Password2.Size = new System.Drawing.Size(179, 35);
            this.Password2.TabIndex = 116;
            this.Password2.Text = "Password:";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.Password.Location = new System.Drawing.Point(787, 298);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(277, 42);
            this.Password.TabIndex = 115;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(56, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 35);
            this.label4.TabIndex = 114;
            this.label4.Text = "UserName:";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.username.Location = new System.Drawing.Point(275, 358);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(277, 42);
            this.username.TabIndex = 113;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(102, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 53);
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(595, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 30);
            this.label2.TabIndex = 47;
            this.label2.Text = "Register as";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(609, 404);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(138, 29);
            this.radioButton3.TabIndex = 46;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "As Member";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(917, 404);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(170, 29);
            this.radioButton2.TabIndex = 45;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "As Gym Owner";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(763, 402);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(128, 29);
            this.radioButton1.TabIndex = 44;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "As Trainer";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(276, 301);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 43);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gmail
            // 
            this.gmail.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.gmail.Location = new System.Drawing.Point(272, 176);
            this.gmail.Name = "gmail";
            this.gmail.Size = new System.Drawing.Size(277, 42);
            this.gmail.TabIndex = 42;
            // 
            // cnic
            // 
            this.cnic.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.cnic.Location = new System.Drawing.Point(786, 241);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(277, 42);
            this.cnic.TabIndex = 41;
            // 
            // fatherName
            // 
            this.fatherName.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.fatherName.Location = new System.Drawing.Point(274, 241);
            this.fatherName.Name = "fatherName";
            this.fatherName.Size = new System.Drawing.Size(277, 42);
            this.fatherName.TabIndex = 40;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.lastName.Location = new System.Drawing.Point(787, 112);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(277, 42);
            this.lastName.TabIndex = 39;
            // 
            // cnic2
            // 
            this.cnic2.AutoSize = true;
            this.cnic2.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.cnic2.ForeColor = System.Drawing.Color.Black;
            this.cnic2.Location = new System.Drawing.Point(601, 248);
            this.cnic2.Name = "cnic2";
            this.cnic2.Size = new System.Drawing.Size(95, 35);
            this.cnic2.TabIndex = 38;
            this.cnic2.Text = "Cnic :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(595, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 35);
            this.label8.TabIndex = 37;
            this.label8.Text = "Last Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(595, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 35);
            this.label7.TabIndex = 36;
            this.label7.Text = "Address :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(56, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 35);
            this.label6.TabIndex = 35;
            this.label6.Text = "Gmail :";
            // 
            // fatherName2
            // 
            this.fatherName2.AutoSize = true;
            this.fatherName2.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.fatherName2.ForeColor = System.Drawing.Color.Black;
            this.fatherName2.Location = new System.Drawing.Point(56, 241);
            this.fatherName2.Name = "fatherName2";
            this.fatherName2.Size = new System.Drawing.Size(218, 35);
            this.fatherName2.TabIndex = 34;
            this.fatherName2.Text = "Father Name :";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.gender.ForeColor = System.Drawing.Color.Black;
            this.gender.Location = new System.Drawing.Point(60, 301);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(141, 35);
            this.gender.TabIndex = 33;
            this.gender.Text = "Gender :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 35);
            this.label1.TabIndex = 32;
            this.label1.Text = "First Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(511, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 54);
            this.label3.TabIndex = 31;
            this.label3.Text = "Signup";
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.address.Location = new System.Drawing.Point(787, 179);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(277, 42);
            this.address.TabIndex = 30;
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.firstName.Location = new System.Drawing.Point(275, 109);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(277, 42);
            this.firstName.TabIndex = 29;
            this.firstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SignupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1228, 716);
            this.Controls.Add(this.panel1);
            this.Name = "SignupPage";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox gmail;
        private System.Windows.Forms.TextBox cnic;
        private System.Windows.Forms.TextBox fatherName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label cnic2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label fatherName2;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label Password2;
        private System.Windows.Forms.TextBox Password;
    }
}