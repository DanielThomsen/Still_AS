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
            this.gpSelectDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpSelectDate
            // 
            this.gpSelectDate.Controls.Add(this.lblDateExplanation);
            this.gpSelectDate.Controls.Add(this.btnShowBookings);
            this.gpSelectDate.Controls.Add(this.dtpStartDate);
            this.gpSelectDate.Location = new System.Drawing.Point(34, 39);
            this.gpSelectDate.Name = "gpSelectDate";
            this.gpSelectDate.Size = new System.Drawing.Size(723, 156);
            this.gpSelectDate.TabIndex = 0;
            this.gpSelectDate.TabStop = false;
            this.gpSelectDate.Text = "Select dates:";
            // 
            // lblDateExplanation
            // 
            this.lblDateExplanation.AutoSize = true;
            this.lblDateExplanation.Location = new System.Drawing.Point(21, 50);
            this.lblDateExplanation.Name = "lblDateExplanation";
            this.lblDateExplanation.Size = new System.Drawing.Size(484, 25);
            this.lblDateExplanation.TabIndex = 6;
            this.lblDateExplanation.Text = "Select the monday of the week you want to show:";
            // 
            // btnShowBookings
            // 
            this.btnShowBookings.Location = new System.Drawing.Point(326, 90);
            this.btnShowBookings.Name = "btnShowBookings";
            this.btnShowBookings.Size = new System.Drawing.Size(177, 42);
            this.btnShowBookings.TabIndex = 1;
            this.btnShowBookings.Text = "Show bookings";
            this.btnShowBookings.UseVisualStyleBackColor = true;
            this.btnShowBookings.Click += new System.EventHandler(this.btnShowBookings_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(26, 90);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(264, 31);
            this.dtpStartDate.TabIndex = 0;
            // 
            // libBookingID
            // 
            this.libBookingID.FormattingEnabled = true;
            this.libBookingID.ItemHeight = 25;
            this.libBookingID.Location = new System.Drawing.Point(60, 266);
            this.libBookingID.Name = "libBookingID";
            this.libBookingID.Size = new System.Drawing.Size(234, 429);
            this.libBookingID.TabIndex = 1;
            this.libBookingID.SelectedIndexChanged += new System.EventHandler(this.libBookingID_SelectedIndexChanged);
            // 
            // libDemoNumber
            // 
            this.libDemoNumber.FormattingEnabled = true;
            this.libDemoNumber.ItemHeight = 25;
            this.libDemoNumber.Location = new System.Drawing.Point(360, 266);
            this.libDemoNumber.Name = "libDemoNumber";
            this.libDemoNumber.Size = new System.Drawing.Size(234, 429);
            this.libDemoNumber.TabIndex = 2;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(55, 226);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(122, 25);
            this.lblBookingID.TabIndex = 3;
            this.lblBookingID.Text = "Booking ID:";
            // 
            // lblDemoNumber
            // 
            this.lblDemoNumber.AutoSize = true;
            this.lblDemoNumber.Location = new System.Drawing.Point(355, 226);
            this.lblDemoNumber.Name = "lblDemoNumber";
            this.lblDemoNumber.Size = new System.Drawing.Size(152, 25);
            this.lblDemoNumber.TabIndex = 4;
            this.lblDemoNumber.Text = "Demo number:";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(660, 266);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(97, 42);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // CarrierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 864);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblDemoNumber);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.libDemoNumber);
            this.Controls.Add(this.libBookingID);
            this.Controls.Add(this.gpSelectDate);
            this.Name = "CarrierForm";
            this.Text = "CarrierForm";
            this.gpSelectDate.ResumeLayout(false);
            this.gpSelectDate.PerformLayout();
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
    }
}