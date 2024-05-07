namespace WindowsFormsApp2
{
    partial class SignupAsGymOwner
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
            this.timing = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.licenceno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gymname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.button1.Location = new System.Drawing.Point(443, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 71);
            this.button1.TabIndex = 83;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.timing);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.location);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.licenceno);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.gymname);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(49, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 653);
            this.panel1.TabIndex = 99;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(70, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 53);
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timing
            // 
            this.timing.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.timing.Location = new System.Drawing.Point(390, 343);
            this.timing.Name = "timing";
            this.timing.Size = new System.Drawing.Size(369, 42);
            this.timing.TabIndex = 108;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(145, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 35);
            this.label8.TabIndex = 107;
            this.label8.Text = "Timings:";
            // 
            // location
            // 
            this.location.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.location.Location = new System.Drawing.Point(390, 261);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(369, 42);
            this.location.TabIndex = 104;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(145, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 35);
            this.label5.TabIndex = 103;
            this.label5.Text = "Location:";
            // 
            // licenceno
            // 
            this.licenceno.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.licenceno.Location = new System.Drawing.Point(390, 184);
            this.licenceno.Name = "licenceno";
            this.licenceno.Size = new System.Drawing.Size(369, 42);
            this.licenceno.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(145, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 35);
            this.label4.TabIndex = 101;
            this.label4.Text = "Licencse No :";
            // 
            // gymname
            // 
            this.gymname.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.gymname.Location = new System.Drawing.Point(390, 110);
            this.gymname.Name = "gymname";
            this.gymname.Size = new System.Drawing.Size(369, 42);
            this.gymname.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(145, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 35);
            this.label6.TabIndex = 99;
            this.label6.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(361, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 54);
            this.label3.TabIndex = 98;
            this.label3.Text = "Enter Gym Detail";
            // 
            // SignupAsGymOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1228, 716);
            this.Controls.Add(this.panel1);
            this.Name = "SignupAsGymOwner";
            this.Text = "SignupAsGymOwner";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox timing;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox licenceno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gymname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}