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
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitle.Location = new System.Drawing.Point(312, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "STILL A/S";
            // 
            // btnMachines
            // 
            this.btnMachines.Location = new System.Drawing.Point(319, 126);
            this.btnMachines.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMachines.Name = "btnMachines";
            this.btnMachines.Size = new System.Drawing.Size(133, 62);
            this.btnMachines.TabIndex = 1;
            this.btnMachines.Text = "Machines";
            this.btnMachines.UseVisualStyleBackColor = true;
            this.btnMachines.Click += new System.EventHandler(this.btnMachines_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.Location = new System.Drawing.Point(319, 196);
            this.btnBookings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(133, 62);
            this.btnBookings.TabIndex = 2;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = true;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Enabled = false;
            this.btnManageUsers.Location = new System.Drawing.Point(319, 266);
            this.btnManageUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(133, 62);
            this.btnManageUsers.TabIndex = 3;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            // 
            // Frontpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 457);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnMachines);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frontpage";
            this.Text = "Frontpage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMachines;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnManageUsers;
    }
}