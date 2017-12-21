namespace StillAS
{
    partial class CarrierForm
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
            this.gpSelectDate = new System.Windows.Forms.GroupBox();
            this.lblDateExplanation = new System.Windows.Forms.Label();
            this.btnShowBookings = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.libBookingID = new System.Windows.Forms.ListBox();
            this.libDemoNumber = new System.Windows.Forms.ListBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblDemoNumber = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpSelectDate.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpSelectDate
            // 
            this.gpSelectDate.Controls.Add(this.lblDateExplanation);
            this.gpSelectDate.Controls.Add(this.btnShowBookings);
            this.gpSelectDate.Controls.Add(this.dtpStartDate);
            this.gpSelectDate.Location = new System.Drawing.Point(23, 25);
            this.gpSelectDate.Margin = new System.Windows.Forms.Padding(2);
            this.gpSelectDate.Name = "gpSelectDate";
            this.gpSelectDate.Padding = new System.Windows.Forms.Padding(2);
            this.gpSelectDate.Size = new System.Drawing.Size(482, 100);
            this.gpSelectDate.TabIndex = 0;
            this.gpSelectDate.TabStop = false;
            this.gpSelectDate.Text = "Select dates:";
            // 
            // lblDateExplanation
            // 
            this.lblDateExplanation.AutoSize = true;
            this.lblDateExplanation.Location = new System.Drawing.Point(14, 32);
            this.lblDateExplanation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateExplanation.Name = "lblDateExplanation";
            this.lblDateExplanation.Size = new System.Drawing.Size(317, 17);
            this.lblDateExplanation.TabIndex = 6;
            this.lblDateExplanation.Text = "Select the monday of the week you want to show:";
            // 
            // btnShowBookings
            // 
            this.btnShowBookings.Location = new System.Drawing.Point(217, 58);
            this.btnShowBookings.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowBookings.Name = "btnShowBookings";
            this.btnShowBookings.Size = new System.Drawing.Size(118, 27);
            this.btnShowBookings.TabIndex = 1;
            this.btnShowBookings.Text = "Show bookings";
            this.btnShowBookings.UseVisualStyleBackColor = true;
            this.btnShowBookings.Click += new System.EventHandler(this.btnShowBookings_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(17, 58);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(177, 22);
            this.dtpStartDate.TabIndex = 0;
            // 
            // libBookingID
            // 
            this.libBookingID.FormattingEnabled = true;
            this.libBookingID.ItemHeight = 16;
            this.libBookingID.Location = new System.Drawing.Point(40, 170);
            this.libBookingID.Margin = new System.Windows.Forms.Padding(2);
            this.libBookingID.Name = "libBookingID";
            this.libBookingID.Size = new System.Drawing.Size(157, 276);
            this.libBookingID.TabIndex = 1;
            this.libBookingID.SelectedIndexChanged += new System.EventHandler(this.libBookingID_SelectedIndexChanged);
            // 
            // libDemoNumber
            // 
            this.libDemoNumber.FormattingEnabled = true;
            this.libDemoNumber.ItemHeight = 16;
            this.libDemoNumber.Location = new System.Drawing.Point(240, 170);
            this.libDemoNumber.Margin = new System.Windows.Forms.Padding(2);
            this.libDemoNumber.Name = "libDemoNumber";
            this.libDemoNumber.Size = new System.Drawing.Size(157, 276);
            this.libDemoNumber.TabIndex = 2;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(37, 145);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(80, 17);
            this.lblBookingID.TabIndex = 3;
            this.lblBookingID.Text = "Booking ID:";
            // 
            // lblDemoNumber
            // 
            this.lblDemoNumber.AutoSize = true;
            this.lblDemoNumber.Location = new System.Drawing.Point(237, 145);
            this.lblDemoNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDemoNumber.Name = "lblDemoNumber";
            this.lblDemoNumber.Size = new System.Drawing.Size(101, 17);
            this.lblDemoNumber.TabIndex = 4;
            this.lblDemoNumber.Text = "Demo number:";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(440, 170);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(65, 27);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(798, 26);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.viewHelpToolStripMenuItem.Text = "View help";
            // 
            // CarrierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 553);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblDemoNumber);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.libDemoNumber);
            this.Controls.Add(this.libBookingID);
            this.Controls.Add(this.gpSelectDate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CarrierForm";
            this.Text = "CarrierForm";
            this.Load += new System.EventHandler(this.CarrierForm_Load);
            this.gpSelectDate.ResumeLayout(false);
            this.gpSelectDate.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpSelectDate;
        private System.Windows.Forms.Button btnShowBookings;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ListBox libBookingID;
        private System.Windows.Forms.ListBox libDemoNumber;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblDemoNumber;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblDateExplanation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
    }
}