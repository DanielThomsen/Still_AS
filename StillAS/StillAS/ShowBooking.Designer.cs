namespace StillAS
{
    partial class ShowBooking
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
            this.btnEditBooking = new System.Windows.Forms.Button();
            this.btnBackToBooking = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.coboSalesRep = new System.Windows.Forms.ComboBox();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.lblLoadingPlatform = new System.Windows.Forms.Label();
            this.lblDeliveryNote = new System.Windows.Forms.Label();
            this.lblMessageToWorkshop = new System.Windows.Forms.Label();
            this.lblCarrier = new System.Windows.Forms.Label();
            this.lblRetrievalDate = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblSalesRep = new System.Windows.Forms.Label();
            this.txtDeliveryNote = new System.Windows.Forms.TextBox();
            this.txtMessageToWorkshop = new System.Windows.Forms.TextBox();
            this.txtCarrier = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtConfigs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMachines = new System.Windows.Forms.Label();
            this.libBookingMachines = new System.Windows.Forms.ListBox();
            this.lblShowBooking = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.coboCountry = new System.Windows.Forms.ComboBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblZIPCode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblATT = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtAdresss = new System.Windows.Forms.TextBox();
            this.txtATT = new System.Windows.Forms.TextBox();
            this.lblName2 = new System.Windows.Forms.Label();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.lblName1 = new System.Windows.Forms.Label();
            this.btnSaveBooking = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnDont = new System.Windows.Forms.Button();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRetrievalDate = new System.Windows.Forms.DateTimePicker();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.txtRetrievalDate = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditBooking
            // 
            this.btnEditBooking.Location = new System.Drawing.Point(1046, 792);
            this.btnEditBooking.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEditBooking.Name = "btnEditBooking";
            this.btnEditBooking.Size = new System.Drawing.Size(150, 97);
            this.btnEditBooking.TabIndex = 11;
            this.btnEditBooking.Text = "Edit booking";
            this.btnEditBooking.UseVisualStyleBackColor = true;
            this.btnEditBooking.Click += new System.EventHandler(this.btnEditBooking_Click_1);
            // 
            // btnBackToBooking
            // 
            this.btnBackToBooking.Location = new System.Drawing.Point(1206, 792);
            this.btnBackToBooking.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBackToBooking.Name = "btnBackToBooking";
            this.btnBackToBooking.Size = new System.Drawing.Size(100, 50);
            this.btnBackToBooking.Size = new System.Drawing.Size(200, 97);
            this.btnBackToBooking.TabIndex = 10;
            this.btnBackToBooking.Text = "Back To Bookings";
            this.btnBackToBooking.UseVisualStyleBackColor = true;
            this.btnBackToBooking.Click += new System.EventHandler(this.btnBackToBooking_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRetrievalDate);
            this.groupBox3.Controls.Add(this.txtDeliveryDate);
            this.groupBox3.Controls.Add(this.dtpRetrievalDate);
            this.groupBox3.Controls.Add(this.dtpDeliveryDate);
            this.groupBox3.Controls.Add(this.coboSalesRep);
            this.groupBox3.Controls.Add(this.rbtnNo);
            this.groupBox3.Controls.Add(this.rbtnYes);
            this.groupBox3.Controls.Add(this.lblLoadingPlatform);
            this.groupBox3.Controls.Add(this.lblDeliveryNote);
            this.groupBox3.Controls.Add(this.lblMessageToWorkshop);
            this.groupBox3.Controls.Add(this.lblCarrier);
            this.groupBox3.Controls.Add(this.lblRetrievalDate);
            this.groupBox3.Controls.Add(this.lblDeliveryDate);
            this.groupBox3.Controls.Add(this.lblSalesRep);
            this.groupBox3.Controls.Add(this.txtDeliveryNote);
            this.groupBox3.Controls.Add(this.txtMessageToWorkshop);
            this.groupBox3.Controls.Add(this.txtCarrier);
            this.groupBox3.Controls.Add(this.txtRetrievalDate);
            this.groupBox3.Controls.Add(this.txtDeliveryDate);
            this.groupBox3.Location = new System.Drawing.Point(24, 458);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(469, 330);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Booking Information";
            // 
            // coboSalesRep
            // 
            this.coboSalesRep.FormattingEnabled = true;
            this.coboSalesRep.Location = new System.Drawing.Point(20, 66);
            this.coboSalesRep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.coboSalesRep.Name = "coboSalesRep";
            this.coboSalesRep.Size = new System.Drawing.Size(197, 24);
            this.coboSalesRep.TabIndex = 9;
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(380, 456);
            this.rbtnNo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(47, 21);
            this.rbtnNo.TabIndex = 16;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(262, 456);
            this.rbtnYes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(53, 21);
            this.rbtnYes.TabIndex = 15;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // lblLoadingPlatform
            // 
            this.lblLoadingPlatform.AutoSize = true;
            this.lblLoadingPlatform.Location = new System.Drawing.Point(18, 456);
            this.lblLoadingPlatform.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLoadingPlatform.Name = "lblLoadingPlatform";
            this.lblLoadingPlatform.Size = new System.Drawing.Size(178, 25);
            this.lblLoadingPlatform.TabIndex = 12;
            this.lblLoadingPlatform.Text = "Loading platform:";
            // 
            // lblDeliveryNote
            // 
            this.lblDeliveryNote.AutoSize = true;
            this.lblDeliveryNote.Location = new System.Drawing.Point(368, 222);
            this.lblDeliveryNote.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDeliveryNote.Name = "lblDeliveryNote";
            this.lblDeliveryNote.Size = new System.Drawing.Size(144, 25);
            this.lblDeliveryNote.TabIndex = 11;
            this.lblDeliveryNote.Text = "Delivery note:";
            // 
            // lblMessageToWorkshop
            // 
            this.lblMessageToWorkshop.AutoSize = true;
            this.lblMessageToWorkshop.Location = new System.Drawing.Point(14, 222);
            this.lblMessageToWorkshop.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMessageToWorkshop.Name = "lblMessageToWorkshop";
            this.lblMessageToWorkshop.Size = new System.Drawing.Size(228, 25);
            this.lblMessageToWorkshop.TabIndex = 10;
            this.lblMessageToWorkshop.Text = "Message to workshop:";
            // 
            // lblCarrier
            // 
            this.lblCarrier.AutoSize = true;
            this.lblCarrier.Location = new System.Drawing.Point(368, 39);
            this.lblCarrier.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCarrier.Name = "lblCarrier";
            this.lblCarrier.Size = new System.Drawing.Size(83, 25);
            this.lblCarrier.TabIndex = 9;
            this.lblCarrier.Text = "Carrier:";
            // 
            // lblRetrievalDate
            // 
            this.lblRetrievalDate.AutoSize = true;
            this.lblRetrievalDate.Location = new System.Drawing.Point(364, 136);
            this.lblRetrievalDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRetrievalDate.Name = "lblRetrievalDate";
            this.lblRetrievalDate.Size = new System.Drawing.Size(151, 25);
            this.lblRetrievalDate.TabIndex = 8;
            this.lblRetrievalDate.Text = "Retrieval date:";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(16, 136);
            this.lblDeliveryDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(144, 25);
            this.lblDeliveryDate.TabIndex = 7;
            this.lblDeliveryDate.Text = "Delivery date:";
            // 
            // lblSalesRep
            // 
            this.lblSalesRep.AutoSize = true;
            this.lblSalesRep.Location = new System.Drawing.Point(12, 39);
            this.lblSalesRep.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSalesRep.Name = "lblSalesRep";
            this.lblSalesRep.Size = new System.Drawing.Size(117, 25);
            this.lblSalesRep.TabIndex = 6;
            this.lblSalesRep.Text = "Sales Rep:";
            // 
            // txtDeliveryNote
            // 
            this.txtDeliveryNote.Location = new System.Drawing.Point(368, 258);
            this.txtDeliveryNote.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDeliveryNote.Multiline = true;
            this.txtDeliveryNote.Name = "txtDeliveryNote";
            this.txtDeliveryNote.Size = new System.Drawing.Size(203, 106);
            this.txtDeliveryNote.TabIndex = 14;
            // 
            // txtMessageToWorkshop
            // 
            this.txtMessageToWorkshop.Location = new System.Drawing.Point(20, 258);
            this.txtMessageToWorkshop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMessageToWorkshop.Multiline = true;
            this.txtMessageToWorkshop.Name = "txtMessageToWorkshop";
            this.txtMessageToWorkshop.Size = new System.Drawing.Size(203, 106);
            this.txtMessageToWorkshop.TabIndex = 13;
            // 
            // txtCarrier
            // 
            this.txtCarrier.Location = new System.Drawing.Point(368, 69);
            this.txtCarrier.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCarrier.Name = "txtCarrier";
            this.txtCarrier.Size = new System.Drawing.Size(200, 22);
            this.txtCarrier.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtConfigs);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblMachines);
            this.groupBox2.Controls.Add(this.libBookingMachines);
            this.groupBox2.Location = new System.Drawing.Point(778, 83);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(456, 400);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Machines On Booking";
            // 
            // txtConfigs
            // 
            this.txtConfigs.Location = new System.Drawing.Point(366, 80);
            this.txtConfigs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtConfigs.Multiline = true;
            this.txtConfigs.Name = "txtConfigs";
            this.txtConfigs.Size = new System.Drawing.Size(191, 311);
            this.txtConfigs.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Configurations";
            // 
            // lblMachines
            // 
            this.lblMachines.AutoSize = true;
            this.lblMachines.Location = new System.Drawing.Point(30, 47);
            this.lblMachines.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMachines.Name = "lblMachines";
            this.lblMachines.Size = new System.Drawing.Size(105, 25);
            this.lblMachines.TabIndex = 1;
            this.lblMachines.Text = "Machines";
            // 
            // libBookingMachines
            // 
            this.libBookingMachines.FormattingEnabled = true;
            this.libBookingMachines.ItemHeight = 25;
            this.libBookingMachines.Location = new System.Drawing.Point(36, 84);
            this.libBookingMachines.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.libBookingMachines.Name = "libBookingMachines";
            this.libBookingMachines.Size = new System.Drawing.Size(276, 479);
            this.libBookingMachines.TabIndex = 0;
            this.libBookingMachines.Click += new System.EventHandler(this.libBookingMachines_Click);
            // 
            // lblShowBooking
            // 
            this.lblShowBooking.AutoSize = true;
            this.lblShowBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblShowBooking.Location = new System.Drawing.Point(658, 23);
            this.lblShowBooking.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShowBooking.Name = "lblShowBooking";
            this.lblShowBooking.Size = new System.Drawing.Size(206, 36);
            this.lblShowBooking.TabIndex = 7;
            this.lblShowBooking.Text = "Show booking";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCountry);
            this.groupBox1.Controls.Add(this.coboCountry);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.lblZIPCode);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblATT);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtZipCode);
            this.groupBox1.Controls.Add(this.txtAdresss);
            this.groupBox1.Controls.Add(this.txtATT);
            this.groupBox1.Controls.Add(this.lblName2);
            this.groupBox1.Controls.Add(this.txtName2);
            this.groupBox1.Controls.Add(this.txtName1);
            this.groupBox1.Controls.Add(this.lblName1);
            this.groupBox1.Location = new System.Drawing.Point(24, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(469, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(12, 266);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(87, 25);
            this.lblCountry.TabIndex = 15;
            this.lblCountry.Text = "Country";
            // 
            // coboCountry
            // 
            this.coboCountry.FormattingEnabled = true;
            this.coboCountry.Location = new System.Drawing.Point(12, 297);
            this.coboCountry.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.coboCountry.Name = "coboCountry";
            this.coboCountry.Size = new System.Drawing.Size(203, 24);
            this.coboCountry.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(366, 266);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(80, 25);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(362, 191);
            this.lblCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(55, 25);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City:";
            // 
            // lblZIPCode
            // 
            this.lblZIPCode.AutoSize = true;
            this.lblZIPCode.Location = new System.Drawing.Point(12, 191);
            this.lblZIPCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblZIPCode.Name = "lblZIPCode";
            this.lblZIPCode.Size = new System.Drawing.Size(107, 25);
            this.lblZIPCode.TabIndex = 11;
            this.lblZIPCode.Text = "ZIP Code:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(362, 116);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(97, 25);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address:";
            // 
            // lblATT
            // 
            this.lblATT.AutoSize = true;
            this.lblATT.Location = new System.Drawing.Point(12, 116);
            this.lblATT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblATT.Name = "lblATT";
            this.lblATT.Size = new System.Drawing.Size(44, 25);
            this.lblATT.TabIndex = 9;
            this.lblATT.Text = "Att:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(368, 297);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(302, 31);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(368, 222);
            this.txtCity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(203, 22);
            this.txtCity.TabIndex = 6;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(12, 222);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(203, 22);
            this.txtZipCode.TabIndex = 5;
            this.txtZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZipCode_KeyPress);
            // 
            // txtAdresss
            // 
            this.txtAdresss.Location = new System.Drawing.Point(368, 147);
            this.txtAdresss.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAdresss.Name = "txtAdresss";
            this.txtAdresss.Size = new System.Drawing.Size(203, 22);
            this.txtAdresss.TabIndex = 4;
            // 
            // txtATT
            // 
            this.txtATT.Location = new System.Drawing.Point(12, 147);
            this.txtATT.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtATT.Name = "txtATT";
            this.txtATT.Size = new System.Drawing.Size(203, 22);
            this.txtATT.TabIndex = 3;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(362, 39);
            this.lblName2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(74, 25);
            this.lblName2.TabIndex = 3;
            this.lblName2.Text = "Name:";
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(368, 69);
            this.txtName2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(302, 31);
            this.txtName2.TabIndex = 2;
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(12, 69);
            this.txtName1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(302, 31);
            this.txtName1.TabIndex = 1;
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(12, 39);
            this.lblName1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(74, 25);
            this.lblName1.TabIndex = 0;
            this.lblName1.Text = "Name:";
            // 
            // btnSaveBooking
            // 
            this.btnSaveBooking.Location = new System.Drawing.Point(1204, 791);
            this.btnSaveBooking.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveBooking.Name = "btnSaveBooking";
            this.btnSaveBooking.Size = new System.Drawing.Size(200, 97);
            this.btnSaveBooking.TabIndex = 12;
            this.btnSaveBooking.Text = "Save booking";
            this.btnSaveBooking.UseVisualStyleBackColor = true;
            this.btnSaveBooking.Click += new System.EventHandler(this.btnSaveBooking_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1046, 792);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 97);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(880, 759);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(178, 128);
            this.btnApprove.TabIndex = 14;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnDont
            // 
            this.btnDont.Location = new System.Drawing.Point(1144, 761);
            this.btnDont.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDont.Name = "btnDont";
            this.btnDont.Size = new System.Drawing.Size(178, 128);
            this.btnDont.TabIndex = 15;
            this.btnDont.Text = "Don\'t Approve";
            this.btnDont.UseVisualStyleBackColor = true;
            this.btnDont.Click += new System.EventHandler(this.btnDont_Click);
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(9, 86);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(153, 20);
            this.dtpDeliveryDate.TabIndex = 16;
            // 
            // dtpRetrievalDate
            // 
            this.dtpRetrievalDate.Location = new System.Drawing.Point(185, 86);
            this.dtpRetrievalDate.Name = "dtpRetrievalDate";
            this.dtpRetrievalDate.Size = new System.Drawing.Size(155, 20);
            this.dtpRetrievalDate.TabIndex = 16;
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(9, 86);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Size = new System.Drawing.Size(153, 20);
            this.txtDeliveryDate.TabIndex = 17;
            // 
            // txtRetrievalDate
            // 
            this.txtRetrievalDate.Location = new System.Drawing.Point(185, 86);
            this.txtRetrievalDate.Name = "txtRetrievalDate";
            this.txtRetrievalDate.Size = new System.Drawing.Size(155, 20);
            this.txtRetrievalDate.TabIndex = 18;
            // 
            // ShowBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 992);
            this.ControlBox = false;
            this.Controls.Add(this.btnDont);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditBooking);
            this.Controls.Add(this.btnBackToBooking);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblShowBooking);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveBooking);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ShowBooking";
            this.Text = "ShowBooking";
            this.Load += new System.EventHandler(this.ShowBooking_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditBooking;
        private System.Windows.Forms.Button btnBackToBooking;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.Label lblLoadingPlatform;
        private System.Windows.Forms.Label lblDeliveryNote;
        private System.Windows.Forms.Label lblMessageToWorkshop;
        private System.Windows.Forms.Label lblCarrier;
        private System.Windows.Forms.Label lblRetrievalDate;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblSalesRep;
        private System.Windows.Forms.TextBox txtDeliveryNote;
        private System.Windows.Forms.TextBox txtMessageToWorkshop;
        private System.Windows.Forms.TextBox txtCarrier;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMachines;
        private System.Windows.Forms.ListBox libBookingMachines;
        private System.Windows.Forms.Label lblShowBooking;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblZIPCode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblATT;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtAdresss;
        private System.Windows.Forms.TextBox txtATT;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Button btnSaveBooking;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtConfigs;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnDont;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox coboCountry;
        private System.Windows.Forms.ComboBox coboSalesRep;
        private System.Windows.Forms.DateTimePicker dtpRetrievalDate;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.TextBox txtRetrievalDate;
        private System.Windows.Forms.TextBox txtDeliveryDate;
    }
}