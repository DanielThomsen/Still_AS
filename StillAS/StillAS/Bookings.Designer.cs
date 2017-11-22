﻿namespace StillAS
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.libBookingID = new System.Windows.Forms.ListBox();
            this.libCity = new System.Windows.Forms.ListBox();
            this.libCustomerName = new System.Windows.Forms.ListBox();
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
            this.btnShow.Location = new System.Drawing.Point(620, 161);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 42);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(620, 295);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 42);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(620, 227);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 42);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(620, 96);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(75, 42);
            this.btnAddBooking.TabIndex = 11;
            this.btnAddBooking.Text = "Add new booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            // 
            // libBookingID
            // 
            this.libBookingID.FormattingEnabled = true;
            this.libBookingID.ItemHeight = 16;
            this.libBookingID.Location = new System.Drawing.Point(408, 96);
            this.libBookingID.Name = "libBookingID";
            this.libBookingID.Size = new System.Drawing.Size(152, 356);
            this.libBookingID.TabIndex = 10;
            // 
            // libCity
            // 
            this.libCity.FormattingEnabled = true;
            this.libCity.ItemHeight = 16;
            this.libCity.Location = new System.Drawing.Point(227, 96);
            this.libCity.Name = "libCity";
            this.libCity.Size = new System.Drawing.Size(152, 356);
            this.libCity.TabIndex = 9;
            // 
            // libCustomerName
            // 
            this.libCustomerName.FormattingEnabled = true;
            this.libCustomerName.ItemHeight = 16;
            this.libCustomerName.Location = new System.Drawing.Point(47, 96);
            this.libCustomerName.Name = "libCustomerName";
            this.libCustomerName.Size = new System.Drawing.Size(152, 356);
            this.libCustomerName.TabIndex = 8;
            // 
            // Bookings
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
            this.Name = "Bookings";
            this.Text = "Bookings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookings;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.ListBox libBookingID;
        private System.Windows.Forms.ListBox libCity;
        private System.Windows.Forms.ListBox libCustomerName;
    }
}