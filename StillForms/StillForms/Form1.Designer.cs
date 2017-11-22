namespace StillForms
{
    partial class Booking
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
            this.libCustomerName = new System.Windows.Forms.ListBox();
            this.libCity = new System.Windows.Forms.ListBox();
            this.libBookingID = new System.Windows.Forms.ListBox();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblBookings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // libCustomerName
            // 
            this.libCustomerName.FormattingEnabled = true;
            this.libCustomerName.ItemHeight = 16;
            this.libCustomerName.Location = new System.Drawing.Point(45, 101);
            this.libCustomerName.Name = "libCustomerName";
            this.libCustomerName.Size = new System.Drawing.Size(152, 356);
            this.libCustomerName.TabIndex = 0;
            // 
            // libCity
            // 
            this.libCity.FormattingEnabled = true;
            this.libCity.ItemHeight = 16;
            this.libCity.Location = new System.Drawing.Point(225, 101);
            this.libCity.Name = "libCity";
            this.libCity.Size = new System.Drawing.Size(152, 356);
            this.libCity.TabIndex = 1;
            // 
            // libBookingID
            // 
            this.libBookingID.FormattingEnabled = true;
            this.libBookingID.ItemHeight = 16;
            this.libBookingID.Location = new System.Drawing.Point(406, 101);
            this.libBookingID.Name = "libBookingID";
            this.libBookingID.Size = new System.Drawing.Size(152, 356);
            this.libBookingID.TabIndex = 2;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(618, 101);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(75, 42);
            this.btnAddBooking.TabIndex = 3;
            this.btnAddBooking.Text = "Add new booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(618, 232);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 42);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(618, 300);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 42);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(618, 166);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 42);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // lblBookings
            // 
            this.lblBookings.AutoSize = true;
            this.lblBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBookings.Location = new System.Drawing.Point(335, 30);
            this.lblBookings.Name = "lblBookings";
            this.lblBookings.Size = new System.Drawing.Size(88, 24);
            this.lblBookings.TabIndex = 7;
            this.lblBookings.Text = "Bookings";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 476);
            this.Controls.Add(this.lblBookings);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.libBookingID);
            this.Controls.Add(this.libCity);
            this.Controls.Add(this.libCustomerName);
            this.Name = "Booking";
            this.Text = "Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox libCustomerName;
        private System.Windows.Forms.ListBox libCity;
        private System.Windows.Forms.ListBox libBookingID;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblBookings;
    }
}

