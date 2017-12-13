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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBookings
            // 
            this.lblBookings.AutoSize = true;
            this.lblBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBookings.Location = new System.Drawing.Point(506, 39);
            this.lblBookings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookings.Name = "lblBookings";
            this.lblBookings.Size = new System.Drawing.Size(140, 36);
            this.lblBookings.TabIndex = 15;
            this.lblBookings.Text = "Bookings";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(930, 250);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 42);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(930, 356);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 42);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(930, 150);
            this.btnAddBooking.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(75, 42);
            this.btnAddBooking.TabIndex = 1;
            this.btnAddBooking.Text = "Add new booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // libBookingID
            // 
            this.libBookingID.FormattingEnabled = true;
            this.libBookingID.ItemHeight = 25;
            this.libBookingID.Location = new System.Drawing.Point(612, 150);
            this.libBookingID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.libBookingID.Name = "libBookingID";
            this.libBookingID.Size = new System.Drawing.Size(152, 356);
            this.libBookingID.TabIndex = 8;
            // 
            // libCity
            // 
            this.libCity.FormattingEnabled = true;
            this.libCity.ItemHeight = 25;
            this.libCity.Location = new System.Drawing.Point(340, 150);
            this.libCity.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.libCity.Name = "libCity";
            this.libCity.Size = new System.Drawing.Size(152, 356);
            this.libCity.TabIndex = 7;
            this.libCity.Click += new System.EventHandler(this.libCity_Click);
            // 
            // libCustomerName
            // 
            this.libCustomerName.FormattingEnabled = true;
            this.libCustomerName.ItemHeight = 25;
            this.libCustomerName.Location = new System.Drawing.Point(70, 150);
            this.libCustomerName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.libCustomerName.Name = "libCustomerName";
            this.libCustomerName.Size = new System.Drawing.Size(152, 356);
            this.libCustomerName.TabIndex = 6;
            this.libCustomerName.Click += new System.EventHandler(this.libCustomerName_Click);
            this.libCustomerName.SelectedIndexChanged += new System.EventHandler(this.libCustomerName_SelectedIndexChanged);
            // 
            // btnShowBookingsOverview
            // 
            this.btnShowBookingsOverview.Location = new System.Drawing.Point(577, 401);
            this.btnShowBookingsOverview.Margin = new System.Windows.Forms.Padding(1);
            this.btnShowBookingsOverview.Name = "btnShowBookingsOverview";
            this.btnShowBookingsOverview.Size = new System.Drawing.Size(118, 51);
            this.btnShowBookingsOverview.TabIndex = 4;
            this.btnShowBookingsOverview.Text = "Show Bookings Overview";
            this.btnShowBookingsOverview.UseVisualStyleBackColor = true;
            this.btnShowBookingsOverview.Click += new System.EventHandler(this.btnShowBookingsOverview_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(47, 476);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 29);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(66, 117);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(166, 25);
            this.lblCustomerName.TabIndex = 17;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(336, 117);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(49, 25);
            this.lblCity.TabIndex = 18;
            this.lblCity.Text = "City";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(608, 117);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(116, 25);
            this.lblBookingID.TabIndex = 19;
            this.lblBookingID.Text = "Booking ID";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(70, 861);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(217, 40);
            this.btnBackToMenu.TabIndex = 20;
            this.btnBackToMenu.Text = "Back To Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 938);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnShowBookingsOverview);
            this.Controls.Add(this.lblBookings);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.libBookingID);
            this.Controls.Add(this.libCity);
            this.Controls.Add(this.libCustomerName);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}