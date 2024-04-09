namespace InfoManagementSystem
{
    partial class FindShowsPage
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
            this.goBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.dateCalendar = new System.Windows.Forms.MonthCalendar();
            this.depart = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.peopleNumber = new System.Windows.Forms.TextBox();
            this.welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goBack
            // 
            this.goBack.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBack.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.goBack.Location = new System.Drawing.Point(40, 399);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(181, 33);
            this.goBack.TabIndex = 4;
            this.goBack.Text = "Previous Page";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(130, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // city
            // 
            this.city.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.city.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(130, 86);
            this.city.Multiline = true;
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(146, 33);
            this.city.TabIndex = 2;
            // 
            // dateCalendar
            // 
            this.dateCalendar.Location = new System.Drawing.Point(283, 189);
            this.dateCalendar.Name = "dateCalendar";
            this.dateCalendar.TabIndex = 5;
            // 
            // depart
            // 
            this.depart.AutoSize = true;
            this.depart.BackColor = System.Drawing.Color.Olive;
            this.depart.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depart.ForeColor = System.Drawing.Color.Snow;
            this.depart.Location = new System.Drawing.Point(283, 160);
            this.depart.Name = "depart";
            this.depart.Size = new System.Drawing.Size(56, 25);
            this.depart.TabIndex = 6;
            this.depart.Text = "Date";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.searchButton.Location = new System.Drawing.Point(604, 387);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(162, 54);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Olive;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(438, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Number of People";
            // 
            // peopleNumber
            // 
            this.peopleNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.peopleNumber.Location = new System.Drawing.Point(632, 90);
            this.peopleNumber.Multiline = true;
            this.peopleNumber.Name = "peopleNumber";
            this.peopleNumber.Size = new System.Drawing.Size(47, 21);
            this.peopleNumber.TabIndex = 16;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Olive;
            this.welcome.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.Snow;
            this.welcome.Location = new System.Drawing.Point(104, 13);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(177, 25);
            this.welcome.TabIndex = 17;
            this.welcome.Text = "Welcome, [name]";
            // 
            // FindShowsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.peopleNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.depart);
            this.Controls.Add(this.dateCalendar);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Sienna;
            this.Name = "FindShowsPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.MonthCalendar dateCalendar;
        private System.Windows.Forms.Label depart;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox peopleNumber;
        private System.Windows.Forms.Label welcome;
    }
}