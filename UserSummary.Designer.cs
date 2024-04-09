namespace InfoManagementSystem
{
    partial class UserSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSummary));
            this.hello = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.summary = new System.Windows.Forms.DataGridView();
            this.findflights = new System.Windows.Forms.Button();
            this.map = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.summary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hello
            // 
            this.hello.AutoSize = true;
            this.hello.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hello.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hello.Location = new System.Drawing.Point(168, 21);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(560, 32);
            this.hello.TabIndex = 4;
            this.hello.Text = "{name}, please find your tickets below:";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logout.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.logout.Location = new System.Drawing.Point(34, 361);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(134, 74);
            this.logout.TabIndex = 17;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.register_Click);
            // 
            // summary
            // 
            this.summary.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.summary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summary.Location = new System.Drawing.Point(34, 120);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(510, 217);
            this.summary.TabIndex = 18;
            // 
            // findflights
            // 
            this.findflights.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.findflights.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findflights.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.findflights.Location = new System.Drawing.Point(174, 361);
            this.findflights.Name = "findflights";
            this.findflights.Size = new System.Drawing.Size(160, 74);
            this.findflights.TabIndex = 19;
            this.findflights.Text = "Book more tickets";
            this.findflights.UseVisualStyleBackColor = false;
            this.findflights.Click += new System.EventHandler(this.findflights_Click);
            // 
            // map
            // 
            this.map.AutoSize = true;
            this.map.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.map.Location = new System.Drawing.Point(821, 53);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(136, 17);
            this.map.TabIndex = 21;
            this.map.Text = "Seats Reference:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Click on a row to make changes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(572, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 377);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // UserSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.findflights);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.hello);
            this.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserSummary";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.summary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hello;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.DataGridView summary;
        private System.Windows.Forms.Button findflights;
        private System.Windows.Forms.Label map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}