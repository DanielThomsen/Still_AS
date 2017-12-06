namespace StillAS
{
    partial class BookingsOverview
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
            this.components = new System.ComponentModel.Container();
            this.btnShowAllBookings = new System.Windows.Forms.Button();
            this.gvBookings = new System.Windows.Forms.DataGridView();
            this.stillasDataSet = new StillAS.stillasDataSet();
            this.stillasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbModelName = new System.Windows.Forms.ComboBox();
            this.cbModelNr = new System.Windows.Forms.ComboBox();
            this.btnShowBookingsByModel = new System.Windows.Forms.Button();
            this.btnShowBookingsByDate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new StillAS.stillasDataSetTableAdapters.BookingTableAdapter();
            this.btnShowCalendar = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stillasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stillasDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowAllBookings
            // 
            this.btnShowAllBookings.Location = new System.Drawing.Point(12, 23);
            this.btnShowAllBookings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowAllBookings.Name = "btnShowAllBookings";
            this.btnShowAllBookings.Size = new System.Drawing.Size(87, 25);
            this.btnShowAllBookings.TabIndex = 0;
            this.btnShowAllBookings.Text = "Show bookings";
            this.btnShowAllBookings.UseVisualStyleBackColor = true;
            this.btnShowAllBookings.Click += new System.EventHandler(this.btnShowAllBookings_Click);
            // 
            // gvBookings
            // 
            this.gvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBookings.Location = new System.Drawing.Point(32, 124);
            this.gvBookings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gvBookings.Name = "gvBookings";
            this.gvBookings.RowTemplate.Height = 33;
            this.gvBookings.Size = new System.Drawing.Size(710, 335);
            this.gvBookings.TabIndex = 1;
            this.gvBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBookings_CellContentClick);
            // 
            // stillasDataSet
            // 
            this.stillasDataSet.DataSetName = "stillasDataSet";
            this.stillasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stillasDataSetBindingSource
            // 
            this.stillasDataSetBindingSource.DataSource = this.stillasDataSet;
            this.stillasDataSetBindingSource.Position = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(10, 23);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(133, 20);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // cbModelName
            // 
            this.cbModelName.FormattingEnabled = true;
            this.cbModelName.Location = new System.Drawing.Point(10, 22);
            this.cbModelName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbModelName.Name = "cbModelName";
            this.cbModelName.Size = new System.Drawing.Size(62, 21);
            this.cbModelName.TabIndex = 3;
            // 
            // cbModelNr
            // 
            this.cbModelNr.FormattingEnabled = true;
            this.cbModelNr.Location = new System.Drawing.Point(82, 22);
            this.cbModelNr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbModelNr.Name = "cbModelNr";
            this.cbModelNr.Size = new System.Drawing.Size(62, 21);
            this.cbModelNr.TabIndex = 4;
            // 
            // btnShowBookingsByModel
            // 
            this.btnShowBookingsByModel.Location = new System.Drawing.Point(156, 22);
            this.btnShowBookingsByModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowBookingsByModel.Name = "btnShowBookingsByModel";
            this.btnShowBookingsByModel.Size = new System.Drawing.Size(87, 25);
            this.btnShowBookingsByModel.TabIndex = 5;
            this.btnShowBookingsByModel.Text = "Show bookings";
            this.btnShowBookingsByModel.UseVisualStyleBackColor = true;
            // 
            // btnShowBookingsByDate
            // 
            this.btnShowBookingsByDate.Location = new System.Drawing.Point(150, 23);
            this.btnShowBookingsByDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowBookingsByDate.Name = "btnShowBookingsByDate";
            this.btnShowBookingsByDate.Size = new System.Drawing.Size(86, 25);
            this.btnShowBookingsByDate.TabIndex = 6;
            this.btnShowBookingsByDate.Text = "Show bookings";
            this.btnShowBookingsByDate.UseVisualStyleBackColor = true;
            this.btnShowBookingsByDate.Click += new System.EventHandler(this.btnShowBookingsByDate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowAllBookings);
            this.groupBox1.Location = new System.Drawing.Point(32, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(109, 58);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show all bookings:";
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.groupBox2.Controls.Add(this.dtpDate);
            this.groupBox2.Controls.Add(this.btnShowBookingsByDate);
            this.groupBox2.Location = new System.Drawing.Point(192, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(246, 58);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show by date:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbModelName);
            this.groupBox3.Controls.Add(this.cbModelNr);
            this.groupBox3.Controls.Add(this.btnShowBookingsByModel);
            this.groupBox3.Location = new System.Drawing.Point(488, 35);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(254, 58);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show by model:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(32, 487);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 25);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.stillasDataSetBindingSource;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // btnShowCalendar
            // 
            this.btnShowCalendar.Location = new System.Drawing.Point(549, 40);
            this.btnShowCalendar.Name = "btnShowCalendar";
            this.btnShowCalendar.Size = new System.Drawing.Size(96, 41);
            this.btnShowCalendar.TabIndex = 12;
            this.btnShowCalendar.Text = "Show";
            this.btnShowCalendar.UseVisualStyleBackColor = true;
            this.btnShowCalendar.Click += new System.EventHandler(this.btnShowCalendar_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(300, 43);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(228, 31);
            this.dtpEndDate.TabIndex = 11;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(19, 43);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(262, 31);
            this.dtpStartDate.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpStartDate);
            this.groupBox4.Controls.Add(this.btnShowCalendar);
            this.groupBox4.Controls.Add(this.dtpEndDate);
            this.groupBox4.Location = new System.Drawing.Point(384, 207);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(684, 100);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calender for machines";
            // 
            // BookingsOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(771, 531);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvBookings);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookingsOverview";
            this.Text = "BookingsOverview";
            this.Load += new System.EventHandler(this.BookingsOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stillasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stillasDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowAllBookings;
        private System.Windows.Forms.DataGridView gvBookings;
        private System.Windows.Forms.BindingSource stillasDataSetBindingSource;
        private stillasDataSet stillasDataSet;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbModelName;
        private System.Windows.Forms.ComboBox cbModelNr;
        private System.Windows.Forms.Button btnShowBookingsByModel;
        private System.Windows.Forms.Button btnShowBookingsByDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private stillasDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.Button btnShowCalendar;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}