namespace StillAS
{
    partial class Demo_Maskiner
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
            this.lblAddBooking = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lbAddedToBooking = new System.Windows.Forms.ListBox();
            this.coboDemoMachines = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbMachines = new System.Windows.Forms.GroupBox();
            this.gbConfigurations = new System.Windows.Forms.GroupBox();
            this.txtKonfig = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpRetrievalDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
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
            this.coboSalesRep = new System.Windows.Forms.ComboBox();
            this.gbMachines.SuspendLayout();
            this.gbConfigurations.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddBooking
            // 
            this.lblAddBooking.AutoSize = true;
            this.lblAddBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAddBooking.Location = new System.Drawing.Point(350, 7);
            this.lblAddBooking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddBooking.Name = "lblAddBooking";
            this.lblAddBooking.Size = new System.Drawing.Size(92, 18);
            this.lblAddBooking.TabIndex = 17;
            this.lblAddBooking.Text = "Add Booking";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(107, 32);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 19);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(685, 495);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(76, 34);
            this.btnFinish.TabIndex = 15;
            this.btnFinish.Text = "Done";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbAddedToBooking
            // 
            this.lbAddedToBooking.FormattingEnabled = true;
            this.lbAddedToBooking.Location = new System.Drawing.Point(4, 26);
            this.lbAddedToBooking.Margin = new System.Windows.Forms.Padding(2);
            this.lbAddedToBooking.Name = "lbAddedToBooking";
            this.lbAddedToBooking.Size = new System.Drawing.Size(151, 316);
            this.lbAddedToBooking.TabIndex = 12;
            // 
            // coboDemoMachines
            // 
            this.coboDemoMachines.FormattingEnabled = true;
            this.coboDemoMachines.Location = new System.Drawing.Point(8, 32);
            this.coboDemoMachines.Margin = new System.Windows.Forms.Padding(2);
            this.coboDemoMachines.Name = "coboDemoMachines";
            this.coboDemoMachines.Size = new System.Drawing.Size(98, 21);
            this.coboDemoMachines.TabIndex = 11;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(159, 26);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(52, 37);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbMachines
            // 
            this.gbMachines.Controls.Add(this.btnRemove);
            this.gbMachines.Controls.Add(this.lbAddedToBooking);
            this.gbMachines.Location = new System.Drawing.Point(4, 74);
            this.gbMachines.Margin = new System.Windows.Forms.Padding(2);
            this.gbMachines.Name = "gbMachines";
            this.gbMachines.Padding = new System.Windows.Forms.Padding(2);
            this.gbMachines.Size = new System.Drawing.Size(216, 347);
            this.gbMachines.TabIndex = 19;
            this.gbMachines.TabStop = false;
            this.gbMachines.Text = "Machines:";
            // 
            // gbConfigurations
            // 
            this.gbConfigurations.Controls.Add(this.txtKonfig);
            this.gbConfigurations.Location = new System.Drawing.Point(239, 74);
            this.gbConfigurations.Margin = new System.Windows.Forms.Padding(2);
            this.gbConfigurations.Name = "gbConfigurations";
            this.gbConfigurations.Padding = new System.Windows.Forms.Padding(2);
            this.gbConfigurations.Size = new System.Drawing.Size(164, 347);
            this.gbConfigurations.TabIndex = 20;
            this.gbConfigurations.TabStop = false;
            this.gbConfigurations.Text = "Configurations";
            // 
            // txtKonfig
            // 
            this.txtKonfig.Location = new System.Drawing.Point(5, 26);
            this.txtKonfig.Margin = new System.Windows.Forms.Padding(2);
            this.txtKonfig.Multiline = true;
            this.txtKonfig.Name = "txtKonfig";
            this.txtKonfig.Size = new System.Drawing.Size(150, 317);
            this.txtKonfig.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbMachines);
            this.groupBox1.Controls.Add(this.gbConfigurations);
            this.groupBox1.Controls.Add(this.coboDemoMachines);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(367, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(412, 426);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Demo Machines";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.coboSalesRep);
            this.groupBox3.Controls.Add(this.dtpRetrievalDate);
            this.groupBox3.Controls.Add(this.dtpDeliveryDate);
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
            this.groupBox3.Location = new System.Drawing.Point(14, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 268);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Booking Information";
            // 
            // dtpRetrievalDate
            // 
            this.dtpRetrievalDate.Location = new System.Drawing.Point(184, 83);
            this.dtpRetrievalDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRetrievalDate.Name = "dtpRetrievalDate";
            this.dtpRetrievalDate.Size = new System.Drawing.Size(151, 20);
            this.dtpRetrievalDate.TabIndex = 16;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(9, 83);
            this.dtpDeliveryDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(150, 20);
            this.dtpDeliveryDate.TabIndex = 15;
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(190, 237);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(39, 17);
            this.rbtnNo.TabIndex = 14;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(131, 237);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(43, 17);
            this.rbtnYes.TabIndex = 13;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // lblLoadingPlatform
            // 
            this.lblLoadingPlatform.AutoSize = true;
            this.lblLoadingPlatform.Location = new System.Drawing.Point(9, 237);
            this.lblLoadingPlatform.Name = "lblLoadingPlatform";
            this.lblLoadingPlatform.Size = new System.Drawing.Size(88, 13);
            this.lblLoadingPlatform.TabIndex = 12;
            this.lblLoadingPlatform.Text = "Loading platform:";
            // 
            // lblDeliveryNote
            // 
            this.lblDeliveryNote.AutoSize = true;
            this.lblDeliveryNote.Location = new System.Drawing.Point(184, 115);
            this.lblDeliveryNote.Name = "lblDeliveryNote";
            this.lblDeliveryNote.Size = new System.Drawing.Size(72, 13);
            this.lblDeliveryNote.TabIndex = 11;
            this.lblDeliveryNote.Text = "Delivery note:";
            // 
            // lblMessageToWorkshop
            // 
            this.lblMessageToWorkshop.AutoSize = true;
            this.lblMessageToWorkshop.Location = new System.Drawing.Point(7, 115);
            this.lblMessageToWorkshop.Name = "lblMessageToWorkshop";
            this.lblMessageToWorkshop.Size = new System.Drawing.Size(114, 13);
            this.lblMessageToWorkshop.TabIndex = 10;
            this.lblMessageToWorkshop.Text = "Message to workshop:";
            // 
            // lblCarrier
            // 
            this.lblCarrier.AutoSize = true;
            this.lblCarrier.Location = new System.Drawing.Point(181, 20);
            this.lblCarrier.Name = "lblCarrier";
            this.lblCarrier.Size = new System.Drawing.Size(40, 13);
            this.lblCarrier.TabIndex = 9;
            this.lblCarrier.Text = "Carrier:";
            // 
            // lblRetrievalDate
            // 
            this.lblRetrievalDate.AutoSize = true;
            this.lblRetrievalDate.Location = new System.Drawing.Point(182, 66);
            this.lblRetrievalDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRetrievalDate.Name = "lblRetrievalDate";
            this.lblRetrievalDate.Size = new System.Drawing.Size(76, 13);
            this.lblRetrievalDate.TabIndex = 8;
            this.lblRetrievalDate.Text = "Retrievel date:";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(6, 67);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(72, 13);
            this.lblDeliveryDate.TabIndex = 7;
            this.lblDeliveryDate.Text = "Delivery date:";
            // 
            // lblSalesRep
            // 
            this.lblSalesRep.AutoSize = true;
            this.lblSalesRep.Location = new System.Drawing.Point(6, 20);
            this.lblSalesRep.Name = "lblSalesRep";
            this.lblSalesRep.Size = new System.Drawing.Size(59, 13);
            this.lblSalesRep.TabIndex = 6;
            this.lblSalesRep.Text = "Sales Rep:";
            // 
            // txtDeliveryNote
            // 
            this.txtDeliveryNote.Location = new System.Drawing.Point(184, 134);
            this.txtDeliveryNote.Multiline = true;
            this.txtDeliveryNote.Name = "txtDeliveryNote";
            this.txtDeliveryNote.Size = new System.Drawing.Size(153, 87);
            this.txtDeliveryNote.TabIndex = 5;
            // 
            // txtMessageToWorkshop
            // 
            this.txtMessageToWorkshop.Location = new System.Drawing.Point(6, 134);
            this.txtMessageToWorkshop.Multiline = true;
            this.txtMessageToWorkshop.Name = "txtMessageToWorkshop";
            this.txtMessageToWorkshop.Size = new System.Drawing.Size(153, 87);
            this.txtMessageToWorkshop.TabIndex = 4;
            // 
            // txtCarrier
            // 
            this.txtCarrier.Location = new System.Drawing.Point(181, 36);
            this.txtCarrier.Name = "txtCarrier";
            this.txtCarrier.Size = new System.Drawing.Size(153, 20);
            this.txtCarrier.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCountry);
            this.groupBox2.Controls.Add(this.coboCountry);
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Controls.Add(this.lblCity);
            this.groupBox2.Controls.Add(this.lblZIPCode);
            this.groupBox2.Controls.Add(this.lblAddress);
            this.groupBox2.Controls.Add(this.lblATT);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Controls.Add(this.txtZipCode);
            this.groupBox2.Controls.Add(this.txtAdresss);
            this.groupBox2.Controls.Add(this.txtATT);
            this.groupBox2.Controls.Add(this.lblName2);
            this.groupBox2.Controls.Add(this.txtName2);
            this.groupBox2.Controls.Add(this.txtName1);
            this.groupBox2.Controls.Add(this.lblName1);
            this.groupBox2.Location = new System.Drawing.Point(14, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 192);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Information";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(7, 139);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 17;
            this.lblCountry.Text = "Country";
            // 
            // coboCountry
            // 
            this.coboCountry.FormattingEnabled = true;
            this.coboCountry.Location = new System.Drawing.Point(7, 155);
            this.coboCountry.Name = "coboCountry";
            this.coboCountry.Size = new System.Drawing.Size(153, 21);
            this.coboCountry.TabIndex = 16;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(184, 139);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(181, 99);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City:";
            // 
            // lblZIPCode
            // 
            this.lblZIPCode.AutoSize = true;
            this.lblZIPCode.Location = new System.Drawing.Point(6, 99);
            this.lblZIPCode.Name = "lblZIPCode";
            this.lblZIPCode.Size = new System.Drawing.Size(55, 13);
            this.lblZIPCode.TabIndex = 11;
            this.lblZIPCode.Text = "ZIP Code:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(181, 60);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address:";
            // 
            // lblATT
            // 
            this.lblATT.AutoSize = true;
            this.lblATT.Location = new System.Drawing.Point(6, 60);
            this.lblATT.Name = "lblATT";
            this.lblATT.Size = new System.Drawing.Size(23, 13);
            this.lblATT.TabIndex = 9;
            this.lblATT.Text = "Att:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(184, 155);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(153, 20);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(184, 115);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(153, 20);
            this.txtCity.TabIndex = 7;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(6, 116);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(153, 20);
            this.txtZipCode.TabIndex = 6;
            this.txtZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZipCode_KeyPress);
            // 
            // txtAdresss
            // 
            this.txtAdresss.Location = new System.Drawing.Point(184, 76);
            this.txtAdresss.Name = "txtAdresss";
            this.txtAdresss.Size = new System.Drawing.Size(153, 20);
            this.txtAdresss.TabIndex = 5;
            // 
            // txtATT
            // 
            this.txtATT.Location = new System.Drawing.Point(6, 76);
            this.txtATT.Name = "txtATT";
            this.txtATT.Size = new System.Drawing.Size(153, 20);
            this.txtATT.TabIndex = 4;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(181, 20);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(38, 13);
            this.lblName2.TabIndex = 3;
            this.lblName2.Text = "Name:";
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(184, 36);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(153, 20);
            this.txtName2.TabIndex = 2;
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(6, 36);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(153, 20);
            this.txtName1.TabIndex = 1;
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(6, 20);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(38, 13);
            this.lblName1.TabIndex = 0;
            this.lblName1.Text = "Name:";
            // 
            // coboSalesRep
            // 
            this.coboSalesRep.FormattingEnabled = true;
            this.coboSalesRep.Location = new System.Drawing.Point(9, 36);
            this.coboSalesRep.Name = "coboSalesRep";
            this.coboSalesRep.Size = new System.Drawing.Size(150, 21);
            this.coboSalesRep.TabIndex = 17;
            // 
            // Demo_Maskiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 539);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAddBooking);
            this.Controls.Add(this.btnFinish);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Demo_Maskiner";
            this.Text = "Demo_Machines";
            this.Load += new System.EventHandler(this.Demo_Maskiner_Load);
            this.gbMachines.ResumeLayout(false);
            this.gbConfigurations.ResumeLayout(false);
            this.gbConfigurations.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddBooking;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ListBox lbAddedToBooking;
        private System.Windows.Forms.ComboBox coboDemoMachines;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbMachines;
        private System.Windows.Forms.GroupBox gbConfigurations;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.DateTimePicker dtpRetrievalDate;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.TextBox txtKonfig;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox coboCountry;
        private System.Windows.Forms.ComboBox coboSalesRep;
    }
}