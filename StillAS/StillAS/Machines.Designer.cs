namespace StillAS
{
    partial class Machines
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddMachine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDemoNumber = new System.Windows.Forms.Label();
            this.libDemoNumber = new System.Windows.Forms.ListBox();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.lblModelName = new System.Windows.Forms.Label();
            this.lblModelNumber = new System.Windows.Forms.Label();
            this.btnShowAvailability = new System.Windows.Forms.Button();
            this.libModelName = new System.Windows.Forms.ListBox();
            this.btnRemoveMachine = new System.Windows.Forms.Button();
            this.libModelNumber = new System.Windows.Forms.ListBox();
            this.btnEditMachine = new System.Windows.Forms.Button();
            this.btnShowMachine = new System.Windows.Forms.Button();
            this.lblMachinesHeader = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddMachine);
            this.groupBox2.Location = new System.Drawing.Point(1096, 129);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(294, 733);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New machine";
            // 
            // btnAddMachine
            // 
            this.btnAddMachine.Location = new System.Drawing.Point(72, 88);
            this.btnAddMachine.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMachine.Name = "btnAddMachine";
            this.btnAddMachine.Size = new System.Drawing.Size(152, 71);
            this.btnAddMachine.TabIndex = 9;
            this.btnAddMachine.Text = "Add new machine";
            this.btnAddMachine.UseVisualStyleBackColor = true;
            this.btnAddMachine.Click += new System.EventHandler(this.btnAddMachine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDemoNumber);
            this.groupBox1.Controls.Add(this.libDemoNumber);
            this.groupBox1.Controls.Add(this.lblAvailability);
            this.groupBox1.Controls.Add(this.lblModelName);
            this.groupBox1.Controls.Add(this.lblModelNumber);
            this.groupBox1.Controls.Add(this.btnShowAvailability);
            this.groupBox1.Controls.Add(this.libModelName);
            this.groupBox1.Controls.Add(this.btnRemoveMachine);
            this.groupBox1.Controls.Add(this.libModelNumber);
            this.groupBox1.Controls.Add(this.btnEditMachine);
            this.groupBox1.Controls.Add(this.btnShowMachine);
            this.groupBox1.Location = new System.Drawing.Point(30, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1008, 733);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Existing machines";
            // 
            // lblDemoNumber
            // 
            this.lblDemoNumber.AutoSize = true;
            this.lblDemoNumber.Location = new System.Drawing.Point(552, 73);
            this.lblDemoNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDemoNumber.Name = "lblDemoNumber";
            this.lblDemoNumber.Size = new System.Drawing.Size(152, 25);
            this.lblDemoNumber.TabIndex = 11;
            this.lblDemoNumber.Text = "Demo number:";
            // 
            // libDemoNumber
            // 
            this.libDemoNumber.FormattingEnabled = true;
            this.libDemoNumber.ItemHeight = 25;
            this.libDemoNumber.Location = new System.Drawing.Point(558, 113);
            this.libDemoNumber.Margin = new System.Windows.Forms.Padding(4);
            this.libDemoNumber.Name = "libDemoNumber";
            this.libDemoNumber.Size = new System.Drawing.Size(226, 554);
            this.libDemoNumber.TabIndex = 10;
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Location = new System.Drawing.Point(812, 629);
            this.lblAvailability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(129, 25);
            this.lblAvailability.TabIndex = 9;
            this.lblAvailability.Text = "\"Availability\"";
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(28, 73);
            this.lblModelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(136, 25);
            this.lblModelName.TabIndex = 1;
            this.lblModelName.Text = "Model name:";
            // 
            // lblModelNumber
            // 
            this.lblModelNumber.AutoSize = true;
            this.lblModelNumber.Location = new System.Drawing.Point(290, 73);
            this.lblModelNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelNumber.Name = "lblModelNumber";
            this.lblModelNumber.Size = new System.Drawing.Size(155, 25);
            this.lblModelNumber.TabIndex = 2;
            this.lblModelNumber.Text = "Model number:";
            // 
            // btnShowAvailability
            // 
            this.btnShowAvailability.Location = new System.Drawing.Point(796, 579);
            this.btnShowAvailability.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAvailability.Name = "btnShowAvailability";
            this.btnShowAvailability.Size = new System.Drawing.Size(198, 46);
            this.btnShowAvailability.TabIndex = 8;
            this.btnShowAvailability.Text = "Show availability";
            this.btnShowAvailability.UseVisualStyleBackColor = true;
            // 
            // libModelName
            // 
            this.libModelName.FormattingEnabled = true;
            this.libModelName.ItemHeight = 25;
            this.libModelName.Location = new System.Drawing.Point(34, 113);
            this.libModelName.Margin = new System.Windows.Forms.Padding(4);
            this.libModelName.Name = "libModelName";
            this.libModelName.Size = new System.Drawing.Size(226, 554);
            this.libModelName.TabIndex = 3;
            // 
            // btnRemoveMachine
            // 
            this.btnRemoveMachine.Location = new System.Drawing.Point(818, 256);
            this.btnRemoveMachine.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveMachine.Name = "btnRemoveMachine";
            this.btnRemoveMachine.Size = new System.Drawing.Size(126, 46);
            this.btnRemoveMachine.TabIndex = 7;
            this.btnRemoveMachine.Text = "Remove";
            this.btnRemoveMachine.UseVisualStyleBackColor = true;
            this.btnRemoveMachine.Click += new System.EventHandler(this.btnRemoveMachine_Click);
            // 
            // libModelNumber
            // 
            this.libModelNumber.FormattingEnabled = true;
            this.libModelNumber.ItemHeight = 25;
            this.libModelNumber.Location = new System.Drawing.Point(296, 113);
            this.libModelNumber.Margin = new System.Windows.Forms.Padding(4);
            this.libModelNumber.Name = "libModelNumber";
            this.libModelNumber.Size = new System.Drawing.Size(226, 554);
            this.libModelNumber.TabIndex = 4;
            // 
            // btnEditMachine
            // 
            this.btnEditMachine.Location = new System.Drawing.Point(818, 185);
            this.btnEditMachine.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditMachine.Name = "btnEditMachine";
            this.btnEditMachine.Size = new System.Drawing.Size(126, 46);
            this.btnEditMachine.TabIndex = 6;
            this.btnEditMachine.Text = "Edit";
            this.btnEditMachine.UseVisualStyleBackColor = true;
            // 
            // btnShowMachine
            // 
            this.btnShowMachine.Location = new System.Drawing.Point(818, 113);
            this.btnShowMachine.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowMachine.Name = "btnShowMachine";
            this.btnShowMachine.Size = new System.Drawing.Size(126, 46);
            this.btnShowMachine.TabIndex = 5;
            this.btnShowMachine.Text = "Show";
            this.btnShowMachine.UseVisualStyleBackColor = true;
            this.btnShowMachine.Click += new System.EventHandler(this.btnShowMachine_Click);
            // 
            // lblMachinesHeader
            // 
            this.lblMachinesHeader.AutoSize = true;
            this.lblMachinesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblMachinesHeader.Location = new System.Drawing.Point(674, 29);
            this.lblMachinesHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMachinesHeader.Name = "lblMachinesHeader";
            this.lblMachinesHeader.Size = new System.Drawing.Size(143, 36);
            this.lblMachinesHeader.TabIndex = 24;
            this.lblMachinesHeader.Text = "Machines";
            // 
            // Machines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 888);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMachinesHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Machines";
            this.Text = "Machines";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddMachine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDemoNumber;
        private System.Windows.Forms.ListBox libDemoNumber;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.Label lblModelNumber;
        private System.Windows.Forms.Button btnShowAvailability;
        private System.Windows.Forms.ListBox libModelName;
        private System.Windows.Forms.Button btnRemoveMachine;
        private System.Windows.Forms.ListBox libModelNumber;
        private System.Windows.Forms.Button btnEditMachine;
        private System.Windows.Forms.Button btnShowMachine;
        private System.Windows.Forms.Label lblMachinesHeader;
    }
}

