namespace StillAS
{
    partial class Frontpage
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMachines = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnUr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitle.Location = new System.Drawing.Point(468, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "STILL A/S";
            // 
            // btnMachines
            // 
            this.btnMachines.Location = new System.Drawing.Point(478, 196);
            this.btnMachines.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMachines.Name = "btnMachines";
            this.btnMachines.Size = new System.Drawing.Size(200, 96);
            this.btnMachines.TabIndex = 1;
            this.btnMachines.Text = "Machines";
            this.btnMachines.UseVisualStyleBackColor = true;
            this.btnMachines.Click += new System.EventHandler(this.btnMachines_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.Location = new System.Drawing.Point(478, 306);
            this.btnBookings.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(200, 96);
            this.btnBookings.TabIndex = 2;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = true;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(478, 415);
            this.btnManageUsers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(200, 96);
            this.btnManageUsers.TabIndex = 3;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnUr
            // 
            this.btnUr.Location = new System.Drawing.Point(1036, 19);
            this.btnUr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUr.Name = "btnUr";
            this.btnUr.Size = new System.Drawing.Size(92, 85);
            this.btnUr.TabIndex = 4;
            this.btnUr.Text = "Ur";
            this.btnUr.UseVisualStyleBackColor = true;
            this.btnUr.Click += new System.EventHandler(this.btnUr_Click);
            // 
            // Frontpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 713);
            this.Controls.Add(this.btnUr);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnMachines);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frontpage";
            this.Text = "Frontpage";
            this.Load += new System.EventHandler(this.Frontpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMachines;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnUr;
    }
}