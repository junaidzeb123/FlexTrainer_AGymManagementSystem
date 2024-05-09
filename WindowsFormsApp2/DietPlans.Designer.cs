namespace WindowsFormsApp2
{
    partial class DietPlans
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
            this.Allplans = new System.Windows.Forms.Button();
            this.MyPlans = new System.Windows.Forms.Button();
            this.Gridview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.button1.Location = new System.Drawing.Point(794, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 83);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Allplans);
            this.panel1.Controls.Add(this.MyPlans);
            this.panel1.Controls.Add(this.Gridview);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(88, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 595);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Allplans
            // 
            this.Allplans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Allplans.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.Allplans.ForeColor = System.Drawing.Color.Coral;
            this.Allplans.Location = new System.Drawing.Point(422, 494);
            this.Allplans.Name = "Allplans";
            this.Allplans.Size = new System.Drawing.Size(244, 83);
            this.Allplans.TabIndex = 15;
            this.Allplans.Text = "All Plans";
            this.Allplans.UseVisualStyleBackColor = false;
            this.Allplans.Click += new System.EventHandler(this.Allplans_Click);
            // 
            // MyPlans
            // 
            this.MyPlans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MyPlans.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.MyPlans.ForeColor = System.Drawing.Color.Coral;
            this.MyPlans.Location = new System.Drawing.Point(81, 494);
            this.MyPlans.Name = "MyPlans";
            this.MyPlans.Size = new System.Drawing.Size(244, 83);
            this.MyPlans.TabIndex = 14;
            this.MyPlans.Text = "My Plans";
            this.MyPlans.UseVisualStyleBackColor = false;
            this.MyPlans.Click += new System.EventHandler(this.MyPlans_Click);
            // 
            // Gridview
            // 
            this.Gridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridview.Location = new System.Drawing.Point(30, 104);
            this.Gridview.Name = "Gridview";
            this.Gridview.RowHeadersWidth = 62;
            this.Gridview.RowTemplate.Height = 28;
            this.Gridview.Size = new System.Drawing.Size(1008, 384);
            this.Gridview.TabIndex = 13;
            this.Gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridview_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(233, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "All Available dietp plans";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(64, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 53);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DietPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1228, 716);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "DietPlans";
            this.Text = "DietPlans";
            this.Load += new System.EventHandler(this.DietPlans_Load);
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
        private System.Windows.Forms.DataGridView Gridview;
        private System.Windows.Forms.Button Allplans;
        private System.Windows.Forms.Button MyPlans;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}