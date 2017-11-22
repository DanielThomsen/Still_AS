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
            this.lblSelectMachines = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cbSelectConfigurations = new System.Windows.Forms.CheckedListBox();
            this.lblSelectConfigurations = new System.Windows.Forms.Label();
            this.lbAddedToBooking = new System.Windows.Forms.ListBox();
            this.coboDemoMachines = new System.Windows.Forms.ComboBox();
            this.lblAddedToBooking = new System.Windows.Forms.Label();
            this.lblDemoMachines = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectMachines
            // 
            this.lblSelectMachines.AutoSize = true;
            this.lblSelectMachines.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblSelectMachines.Location = new System.Drawing.Point(176, 18);
            this.lblSelectMachines.Name = "lblSelectMachines";
            this.lblSelectMachines.Size = new System.Drawing.Size(149, 24);
            this.lblSelectMachines.TabIndex = 17;
            this.lblSelectMachines.Text = "Select Machines";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(143, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(15, 442);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(101, 42);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // cbSelectConfigurations
            // 
            this.cbSelectConfigurations.FormattingEnabled = true;
            this.cbSelectConfigurations.Location = new System.Drawing.Point(287, 151);
            this.cbSelectConfigurations.Name = "cbSelectConfigurations";
            this.cbSelectConfigurations.Size = new System.Drawing.Size(200, 259);
            this.cbSelectConfigurations.TabIndex = 14;
            // 
            // lblSelectConfigurations
            // 
            this.lblSelectConfigurations.AutoSize = true;
            this.lblSelectConfigurations.Location = new System.Drawing.Point(284, 119);
            this.lblSelectConfigurations.Name = "lblSelectConfigurations";
            this.lblSelectConfigurations.Size = new System.Drawing.Size(144, 17);
            this.lblSelectConfigurations.TabIndex = 13;
            this.lblSelectConfigurations.Text = "Select configurations:";
            // 
            // lbAddedToBooking
            // 
            this.lbAddedToBooking.FormattingEnabled = true;
            this.lbAddedToBooking.ItemHeight = 16;
            this.lbAddedToBooking.Location = new System.Drawing.Point(15, 151);
            this.lbAddedToBooking.Name = "lbAddedToBooking";
            this.lbAddedToBooking.Size = new System.Drawing.Size(200, 260);
            this.lbAddedToBooking.TabIndex = 12;
            // 
            // coboDemoMachines
            // 
            this.coboDemoMachines.FormattingEnabled = true;
            this.coboDemoMachines.Location = new System.Drawing.Point(15, 68);
            this.coboDemoMachines.Name = "coboDemoMachines";
            this.coboDemoMachines.Size = new System.Drawing.Size(121, 24);
            this.coboDemoMachines.TabIndex = 11;
            // 
            // lblAddedToBooking
            // 
            this.lblAddedToBooking.AutoSize = true;
            this.lblAddedToBooking.Location = new System.Drawing.Point(12, 119);
            this.lblAddedToBooking.Name = "lblAddedToBooking";
            this.lblAddedToBooking.Size = new System.Drawing.Size(123, 17);
            this.lblAddedToBooking.TabIndex = 10;
            this.lblAddedToBooking.Text = "Added to booking:";
            // 
            // lblDemoMachines
            // 
            this.lblDemoMachines.AutoSize = true;
            this.lblDemoMachines.Location = new System.Drawing.Point(15, 38);
            this.lblDemoMachines.Name = "lblDemoMachines";
            this.lblDemoMachines.Size = new System.Drawing.Size(113, 17);
            this.lblDemoMachines.TabIndex = 9;
            this.lblDemoMachines.Text = "Demo Machines:";
            // 
            // Demo_Maskiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 502);
            this.Controls.Add(this.lblSelectMachines);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cbSelectConfigurations);
            this.Controls.Add(this.lblSelectConfigurations);
            this.Controls.Add(this.lbAddedToBooking);
            this.Controls.Add(this.coboDemoMachines);
            this.Controls.Add(this.lblAddedToBooking);
            this.Controls.Add(this.lblDemoMachines);
            this.Name = "Demo_Maskiner";
            this.Text = "Demo_Machines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectMachines;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckedListBox cbSelectConfigurations;
        private System.Windows.Forms.Label lblSelectConfigurations;
        private System.Windows.Forms.ListBox lbAddedToBooking;
        private System.Windows.Forms.ComboBox coboDemoMachines;
        private System.Windows.Forms.Label lblAddedToBooking;
        private System.Windows.Forms.Label lblDemoMachines;
    }
}