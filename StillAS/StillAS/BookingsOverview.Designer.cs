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
            this.btnShowBookingsByDate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new StillAS.stillasDataSetTableAdapters.BookingTableAdapter();
            this.btnShowCalendar = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblDemoNummer = new System.Windows.Forms.Label();
            this.lblModelNavn = new System.Windows.Forms.Label();
            this.lblAfhentning = new System.Windows.Forms.Label();
            this.lblLevering = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnShowAllMachines = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stillasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stillasDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowAllBookings
            // 
            this.btnShowAllBookings.Location = new System.Drawing.Point(16, 28);
            this.btnShowAllBookings.Name = "btnShowAllBookings";
            this.btnShowAllBookings.Size = new System.Drawing.Size(116, 31);
            this.btnShowAllBookings.TabIndex = 1;
            this.btnShowAllBookings.Text = "Show bookings";
            this.btnShowAllBookings.UseVisualStyleBackColor = true;
            this.btnShowAllBookings.Click += new System.EventHandler(this.btnShowAllBookings_Click);
            // 
            // gvBookings
            // 
            this.gvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBookings.Location = new System.Drawing.Point(43, 233);
            this.gvBookings.Name = "gvBookings";
            this.gvBookings.RowTemplate.Height = 33;
            this.gvBookings.Size = new System.Drawing.Size(947, 332);
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
            this.dtpDate.Location = new System.Drawing.Point(13, 28);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(176, 22);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btnShowBookingsByDate
            // 
            this.btnShowBookingsByDate.Location = new System.Drawing.Point(200, 28);
            this.btnShowBookingsByDate.Name = "btnShowBookingsByDate";
            this.btnShowBookingsByDate.Size = new System.Drawing.Size(115, 31);
            this.btnShowBookingsByDate.TabIndex = 2;
            this.btnShowBookingsByDate.Text = "Show bookings";
            this.btnShowBookingsByDate.UseVisualStyleBackColor = true;
            this.btnShowBookingsByDate.Click += new System.EventHandler(this.btnShowBookingsByDate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowAllBookings);
            this.groupBox1.Location = new System.Drawing.Point(43, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show all bookings:";
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.groupBox2.Controls.Add(this.dtpDate);
            this.groupBox2.Controls.Add(this.btnShowBookingsByDate);
            this.groupBox2.Location = new System.Drawing.Point(256, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 72);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show by date:";
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
            this.btnShowCalendar.Location = new System.Drawing.Point(0, 0);
            this.btnShowCalendar.Name = "btnShowCalendar";
            this.btnShowCalendar.Size = new System.Drawing.Size(75, 23);
            this.btnShowCalendar.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 2;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 0;
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblDemoNummer);
            this.groupBox5.Controls.Add(this.lblModelNavn);
            this.groupBox5.Controls.Add(this.lblAfhentning);
            this.groupBox5.Controls.Add(this.lblLevering);
            this.groupBox5.Controls.Add(this.cbType);
            this.groupBox5.Controls.Add(this.cbModel);
            this.groupBox5.Controls.Add(this.dtpStart);
            this.groupBox5.Controls.Add(this.btnShowAllMachines);
            this.groupBox5.Controls.Add(this.dtpEnd);
            this.groupBox5.Location = new System.Drawing.Point(256, 136);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(636, 92);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Calender for machines";
            // 
            // lblDemoNummer
            // 
            this.lblDemoNummer.AutoSize = true;
            this.lblDemoNummer.Location = new System.Drawing.Point(453, 28);
            this.lblDemoNummer.Name = "lblDemoNummer";
            this.lblDemoNummer.Size = new System.Drawing.Size(97, 17);
            this.lblDemoNummer.TabIndex = 31;
            this.lblDemoNummer.Text = "Demo number";
            // 
            // lblModelNavn
            // 
            this.lblModelNavn.AutoSize = true;
            this.lblModelNavn.Location = new System.Drawing.Point(359, 28);
            this.lblModelNavn.Name = "lblModelNavn";
            this.lblModelNavn.Size = new System.Drawing.Size(85, 17);
            this.lblModelNavn.TabIndex = 30;
            this.lblModelNavn.Text = "Model name";
            // 
            // lblAfhentning
            // 
            this.lblAfhentning.AutoSize = true;
            this.lblAfhentning.Location = new System.Drawing.Point(194, 28);
            this.lblAfhentning.Name = "lblAfhentning";
            this.lblAfhentning.Size = new System.Drawing.Size(96, 17);
            this.lblAfhentning.TabIndex = 29;
            this.lblAfhentning.Text = "Retrieval date";
            // 
            // lblLevering
            // 
            this.lblLevering.AutoSize = true;
            this.lblLevering.Location = new System.Drawing.Point(10, 28);
            this.lblLevering.Name = "lblLevering";
            this.lblLevering.Size = new System.Drawing.Size(91, 17);
            this.lblLevering.TabIndex = 6;
            this.lblLevering.Text = "Delivery date";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(456, 50);
            this.cbType.Margin = new System.Windows.Forms.Padding(2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(79, 24);
            this.cbType.TabIndex = 4;
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(362, 50);
            this.cbModel.Margin = new System.Windows.Forms.Padding(2);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(82, 24);
            this.cbModel.TabIndex = 3;
            this.cbModel.SelectedIndexChanged += new System.EventHandler(this.cbModel_SelectedIndexChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(10, 50);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(176, 22);
            this.dtpStart.TabIndex = 1;
            // 
            // btnShowAllMachines
            // 
            this.btnShowAllMachines.Location = new System.Drawing.Point(554, 50);
            this.btnShowAllMachines.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowAllMachines.Name = "btnShowAllMachines";
            this.btnShowAllMachines.Size = new System.Drawing.Size(75, 31);
            this.btnShowAllMachines.TabIndex = 5;
            this.btnShowAllMachines.Text = "Show";
            this.btnShowAllMachines.Click += new System.EventHandler(this.btnShowAllMachines_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(197, 50);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(153, 22);
            this.dtpEnd.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1028, 26);
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
            // BookingsOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1028, 653);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvBookings);
            this.Name = "BookingsOverview";
            this.Text = "BookingsOverview";
            this.Load += new System.EventHandler(this.BookingsOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stillasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stillasDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAllBookings;
        private System.Windows.Forms.DataGridView gvBookings;
        private System.Windows.Forms.BindingSource stillasDataSetBindingSource;
        private stillasDataSet stillasDataSet;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnShowBookingsByDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private stillasDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.Button btnShowCalendar;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnShowAllMachines;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.Label lblAfhentning;
        private System.Windows.Forms.Label lblLevering;
        private System.Windows.Forms.Label lblDemoNummer;
        private System.Windows.Forms.Label lblModelNavn;
    }
}