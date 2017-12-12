namespace StillAS
{
    partial class Bookings
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
            this.lblBookings = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.libBookingID = new System.Windows.Forms.ListBox();
            this.libCity = new System.Windows.Forms.ListBox();
            this.libCustomerName = new System.Windows.Forms.ListBox();
            this.btnShowBookingsOverview = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBookings
            // 
            this.lblBookings.AutoSize = true;
            this.lblBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBookings.Location = new System.Drawing.Point(337, 25);
            this.lblBookings.Name = "lblBookings";
            this.lblBookings.Size = new System.Drawing.Size(88, 24);
            this.lblBookings.TabIndex = 15;
            this.lblBookings.Text = "Bookings";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(620, 174);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 42);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(620, 250);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 42);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(620, 96);
            this.btnAddBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(75, 42);
            this.btnAddBooking.TabIndex = 11;
            this.btnAddBooking.Text = "Add new booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // libBookingID
            // 
            this.libBookingID.FormattingEnabled = true;
            this.libBookingID.ItemHeight = 16;
            this.libBookingID.Location = new System.Drawing.Point(408, 96);
            this.libBookingID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.libBookingID.Name = "libBookingID";
            this.libBookingID.Size = new System.Drawing.Size(152, 356);
            this.libBookingID.TabIndex = 10;
            // 
            // libCity
            // 
            this.libCity.FormattingEnabled = true;
            this.libCity.ItemHeight = 16;
            this.libCity.Location = new System.Drawing.Point(227, 96);
            this.libCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.libCity.Name = "libCity";
            this.libCity.Size = new System.Drawing.Size(152, 356);
            this.libCity.TabIndex = 9;
            this.libCity.Click += new System.EventHandler(this.libCity_Click);
            // 
            // libCustomerName
            // 
            this.libCustomerName.FormattingEnabled = true;
            this.libCustomerName.ItemHeight = 16;
            this.libCustomerName.Location = new System.Drawing.Point(47, 96);
            this.libCustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.libCustomerName.Name = "libCustomerName";
            this.libCustomerName.Size = new System.Drawing.Size(152, 356);
            this.libCustomerName.TabIndex = 8;
            this.libCustomerName.Click += new System.EventHandler(this.libCustomerName_Click);
            this.libCustomerName.SelectedIndexChanged += new System.EventHandler(this.libCustomerName_SelectedIndexChanged);
            // 
            // btnShowBookingsOverview
            // 
            this.btnShowBookingsOverview.Location = new System.Drawing.Point(583, 407);
            this.btnShowBookingsOverview.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowBookingsOverview.Name = "btnShowBookingsOverview";
            this.btnShowBookingsOverview.Size = new System.Drawing.Size(112, 45);
            this.btnShowBookingsOverview.TabIndex = 16;
            this.btnShowBookingsOverview.Text = "Show Bookings Overview";
            this.btnShowBookingsOverview.UseVisualStyleBackColor = true;
            this.btnShowBookingsOverview.Click += new System.EventHandler(this.btnShowBookingsOverview_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(44, 75);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(109, 17);
            this.lblCustomerName.TabIndex = 17;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(224, 75);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 18;
            this.lblCity.Text = "City";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(405, 75);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(76, 17);
            this.lblBookingID.TabIndex = 19;
            this.lblBookingID.Text = "Booking ID";
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 476);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnShowBookingsOverview);
            this.Controls.Add(this.lblBookings);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.libBookingID);
            this.Controls.Add(this.libCity);
            this.Controls.Add(this.libCustomerName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bookings";
            this.Text = "Bookings";
            this.Load += new System.EventHandler(this.Bookings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookings;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.ListBox libBookingID;
        private System.Windows.Forms.ListBox libCity;
        private System.Windows.Forms.ListBox libCustomerName;
        private System.Windows.Forms.Button btnShowBookingsOverview;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblBookingID;
    }
}