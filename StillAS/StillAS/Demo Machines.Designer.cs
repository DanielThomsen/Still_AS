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
            this.btnFinish = new System.Windows.Forms.Button();
            this.cbSelectConfigurations = new System.Windows.Forms.CheckedListBox();
            this.lbAddedToBooking = new System.Windows.Forms.ListBox();
            this.coboDemoMachines = new System.Windows.Forms.ComboBox();
            this.lblDemoMachines = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbMachines = new System.Windows.Forms.GroupBox();
            this.gbConfigurations = new System.Windows.Forms.GroupBox();
            this.gbMachines.SuspendLayout();
            this.gbConfigurations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectMachines
            // 
            this.lblSelectMachines.AutoSize = true;
            this.lblSelectMachines.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblSelectMachines.Location = new System.Drawing.Point(214, 9);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(15, 442);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(101, 42);
            this.btnFinish.TabIndex = 15;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cbSelectConfigurations
            // 
            this.cbSelectConfigurations.FormattingEnabled = true;
            this.cbSelectConfigurations.Location = new System.Drawing.Point(6, 32);
            this.cbSelectConfigurations.Name = "cbSelectConfigurations";
            this.cbSelectConfigurations.Size = new System.Drawing.Size(200, 259);
            this.cbSelectConfigurations.TabIndex = 14;
            // 
            // lbAddedToBooking
            // 
            this.lbAddedToBooking.FormattingEnabled = true;
            this.lbAddedToBooking.ItemHeight = 16;
            this.lbAddedToBooking.Location = new System.Drawing.Point(6, 32);
            this.lbAddedToBooking.Name = "lbAddedToBooking";
            this.lbAddedToBooking.Size = new System.Drawing.Size(200, 260);
            this.lbAddedToBooking.TabIndex = 12;
            this.lbAddedToBooking.SelectedIndexChanged += new System.EventHandler(this.lbAddedToBooking_SelectedIndexChanged);
            // 
            // coboDemoMachines
            // 
            this.coboDemoMachines.FormattingEnabled = true;
            this.coboDemoMachines.Location = new System.Drawing.Point(18, 67);
            this.coboDemoMachines.Name = "coboDemoMachines";
            this.coboDemoMachines.Size = new System.Drawing.Size(121, 24);
            this.coboDemoMachines.TabIndex = 11;
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
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(212, 32);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(69, 45);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbMachines
            // 
            this.gbMachines.Controls.Add(this.btnRemove);
            this.gbMachines.Controls.Add(this.lbAddedToBooking);
            this.gbMachines.Location = new System.Drawing.Point(6, 119);
            this.gbMachines.Name = "gbMachines";
            this.gbMachines.Size = new System.Drawing.Size(288, 304);
            this.gbMachines.TabIndex = 19;
            this.gbMachines.TabStop = false;
            this.gbMachines.Text = "Machines:";
            // 
            // gbConfigurations
            // 
            this.gbConfigurations.Controls.Add(this.cbSelectConfigurations);
            this.gbConfigurations.Location = new System.Drawing.Point(319, 119);
            this.gbConfigurations.Name = "gbConfigurations";
            this.gbConfigurations.Size = new System.Drawing.Size(218, 304);
            this.gbConfigurations.TabIndex = 20;
            this.gbConfigurations.TabStop = false;
            this.gbConfigurations.Text = "Configurations";
            // 
            // Demo_Maskiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 502);
            this.Controls.Add(this.gbConfigurations);
            this.Controls.Add(this.gbMachines);
            this.Controls.Add(this.lblSelectMachines);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.coboDemoMachines);
            this.Controls.Add(this.lblDemoMachines);
            this.Name = "Demo_Maskiner";
            this.Text = "Demo_Machines";
            this.Load += new System.EventHandler(this.Demo_Maskiner_Load);
            this.gbMachines.ResumeLayout(false);
            this.gbConfigurations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectMachines;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.CheckedListBox cbSelectConfigurations;
        private System.Windows.Forms.ListBox lbAddedToBooking;
        private System.Windows.Forms.ComboBox coboDemoMachines;
        private System.Windows.Forms.Label lblDemoMachines;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbMachines;
        private System.Windows.Forms.GroupBox gbConfigurations;
    }
}