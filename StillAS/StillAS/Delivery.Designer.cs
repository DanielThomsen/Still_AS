namespace StillAS
{
    partial class Delivery
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
            this.btnNext = new System.Windows.Forms.Button();
            this.rbRampNo = new System.Windows.Forms.RadioButton();
            this.rbRampYes = new System.Windows.Forms.RadioButton();
            this.tbDeliveryNote = new System.Windows.Forms.TextBox();
            this.tbMessageToWorkshop = new System.Windows.Forms.TextBox();
            this.tbTransporter = new System.Windows.Forms.TextBox();
            this.lblLoadingPlatform = new System.Windows.Forms.Label();
            this.lblDeliveryNote = new System.Windows.Forms.Label();
            this.lblMessageToWorkshop = new System.Windows.Forms.Label();
            this.lblTransporter = new System.Windows.Forms.Label();
            this.lblRetrievalDate = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRetrievalDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(206, 584);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(134, 59);
            this.btnNext.TabIndex = 27;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // rbRampNo
            // 
            this.rbRampNo.AutoSize = true;
            this.rbRampNo.Location = new System.Drawing.Point(393, 497);
            this.rbRampNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRampNo.Name = "rbRampNo";
            this.rbRampNo.Size = new System.Drawing.Size(70, 29);
            this.rbRampNo.TabIndex = 26;
            this.rbRampNo.TabStop = true;
            this.rbRampNo.Text = "No";
            this.rbRampNo.UseVisualStyleBackColor = true;
            // 
            // rbRampYes
            // 
            this.rbRampYes.AutoSize = true;
            this.rbRampYes.Location = new System.Drawing.Point(260, 497);
            this.rbRampYes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRampYes.Name = "rbRampYes";
            this.rbRampYes.Size = new System.Drawing.Size(81, 29);
            this.rbRampYes.TabIndex = 25;
            this.rbRampYes.TabStop = true;
            this.rbRampYes.Text = "Yes";
            this.rbRampYes.UseVisualStyleBackColor = true;
            // 
            // tbDeliveryNote
            // 
            this.tbDeliveryNote.Location = new System.Drawing.Point(260, 355);
            this.tbDeliveryNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDeliveryNote.Multiline = true;
            this.tbDeliveryNote.Name = "tbDeliveryNote";
            this.tbDeliveryNote.Size = new System.Drawing.Size(248, 102);
            this.tbDeliveryNote.TabIndex = 24;
            // 
            // tbMessageToWorkshop
            // 
            this.tbMessageToWorkshop.Location = new System.Drawing.Point(260, 223);
            this.tbMessageToWorkshop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMessageToWorkshop.Multiline = true;
            this.tbMessageToWorkshop.Name = "tbMessageToWorkshop";
            this.tbMessageToWorkshop.Size = new System.Drawing.Size(248, 102);
            this.tbMessageToWorkshop.TabIndex = 23;
            // 
            // tbTransporter
            // 
            this.tbTransporter.Location = new System.Drawing.Point(260, 156);
            this.tbTransporter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTransporter.Name = "tbTransporter";
            this.tbTransporter.Size = new System.Drawing.Size(148, 31);
            this.tbTransporter.TabIndex = 22;
            // 
            // lblLoadingPlatform
            // 
            this.lblLoadingPlatform.AutoSize = true;
            this.lblLoadingPlatform.Location = new System.Drawing.Point(22, 500);
            this.lblLoadingPlatform.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoadingPlatform.Name = "lblLoadingPlatform";
            this.lblLoadingPlatform.Size = new System.Drawing.Size(178, 25);
            this.lblLoadingPlatform.TabIndex = 19;
            this.lblLoadingPlatform.Text = "Loading platform:";
            // 
            // lblDeliveryNote
            // 
            this.lblDeliveryNote.AutoSize = true;
            this.lblDeliveryNote.Location = new System.Drawing.Point(22, 359);
            this.lblDeliveryNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeliveryNote.Name = "lblDeliveryNote";
            this.lblDeliveryNote.Size = new System.Drawing.Size(144, 25);
            this.lblDeliveryNote.TabIndex = 18;
            this.lblDeliveryNote.Text = "Delivery note:";
            // 
            // lblMessageToWorkshop
            // 
            this.lblMessageToWorkshop.AutoSize = true;
            this.lblMessageToWorkshop.Location = new System.Drawing.Point(22, 228);
            this.lblMessageToWorkshop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessageToWorkshop.Name = "lblMessageToWorkshop";
            this.lblMessageToWorkshop.Size = new System.Drawing.Size(228, 25);
            this.lblMessageToWorkshop.TabIndex = 17;
            this.lblMessageToWorkshop.Text = "Message to workshop:";
            // 
            // lblTransporter
            // 
            this.lblTransporter.AutoSize = true;
            this.lblTransporter.Location = new System.Drawing.Point(22, 161);
            this.lblTransporter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransporter.Name = "lblTransporter";
            this.lblTransporter.Size = new System.Drawing.Size(83, 25);
            this.lblTransporter.TabIndex = 16;
            this.lblTransporter.Text = "Carrier:";
            // 
            // lblRetrievalDate
            // 
            this.lblRetrievalDate.AutoSize = true;
            this.lblRetrievalDate.Location = new System.Drawing.Point(22, 95);
            this.lblRetrievalDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRetrievalDate.Name = "lblRetrievalDate";
            this.lblRetrievalDate.Size = new System.Drawing.Size(151, 25);
            this.lblRetrievalDate.TabIndex = 15;
            this.lblRetrievalDate.Text = "Retrieval date:";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(22, 28);
            this.lblDeliveryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(144, 25);
            this.lblDeliveryDate.TabIndex = 14;
            this.lblDeliveryDate.Text = "Delivery date:";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(260, 28);
            this.dtpDeliveryDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(248, 31);
            this.dtpDeliveryDate.TabIndex = 28;
            // 
            // dtpRetrievalDate
            // 
            this.dtpRetrievalDate.Location = new System.Drawing.Point(260, 88);
            this.dtpRetrievalDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpRetrievalDate.Name = "dtpRetrievalDate";
            this.dtpRetrievalDate.Size = new System.Drawing.Size(248, 31);
            this.dtpRetrievalDate.TabIndex = 29;
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 666);
            this.Controls.Add(this.dtpRetrievalDate);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rbRampNo);
            this.Controls.Add(this.rbRampYes);
            this.Controls.Add(this.tbDeliveryNote);
            this.Controls.Add(this.tbMessageToWorkshop);
            this.Controls.Add(this.tbTransporter);
            this.Controls.Add(this.lblLoadingPlatform);
            this.Controls.Add(this.lblDeliveryNote);
            this.Controls.Add(this.lblMessageToWorkshop);
            this.Controls.Add(this.lblTransporter);
            this.Controls.Add(this.lblRetrievalDate);
            this.Controls.Add(this.lblDeliveryDate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Delivery";
            this.Text = "Delivery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton rbRampNo;
        private System.Windows.Forms.RadioButton rbRampYes;
        private System.Windows.Forms.TextBox tbDeliveryNote;
        private System.Windows.Forms.TextBox tbMessageToWorkshop;
        private System.Windows.Forms.TextBox tbTransporter;
        private System.Windows.Forms.Label lblLoadingPlatform;
        private System.Windows.Forms.Label lblDeliveryNote;
        private System.Windows.Forms.Label lblMessageToWorkshop;
        private System.Windows.Forms.Label lblTransporter;
        private System.Windows.Forms.Label lblRetrievalDate;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtpRetrievalDate;
    }
}