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
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddMachine);
            this.groupBox2.Location = new System.Drawing.Point(548, 68);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(147, 381);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New machine";
            // 
            // btnAddMachine
            // 
            this.btnAddMachine.Location = new System.Drawing.Point(36, 46);
            this.btnAddMachine.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddMachine.Name = "btnAddMachine";
            this.btnAddMachine.Size = new System.Drawing.Size(76, 36);
            this.btnAddMachine.TabIndex = 9;
            this.btnAddMachine.Text = "Add new machine";
            this.btnAddMachine.UseVisualStyleBackColor = true;
            this.btnAddMachine.Click += new System.EventHandler(this.btnAddMachine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
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
            this.groupBox1.Location = new System.Drawing.Point(15, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(504, 381);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Existing machines";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemove.Location = new System.Drawing.Point(49, 352);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(26, 23);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(17, 352);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDemoNumber
            // 
            this.lblDemoNumber.AutoSize = true;
            this.lblDemoNumber.Location = new System.Drawing.Point(276, 38);
            this.lblDemoNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDemoNumber.Name = "lblDemoNumber";
            this.lblDemoNumber.Size = new System.Drawing.Size(76, 13);
            this.lblDemoNumber.TabIndex = 11;
            this.lblDemoNumber.Text = "Demo number:";
            // 
            // libDemoNumber
            // 
            this.libDemoNumber.FormattingEnabled = true;
            this.libDemoNumber.Location = new System.Drawing.Point(279, 58);
            this.libDemoNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.libDemoNumber.Name = "libDemoNumber";
            this.libDemoNumber.Size = new System.Drawing.Size(115, 290);
            this.libDemoNumber.TabIndex = 10;
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Location = new System.Drawing.Point(406, 328);
            this.lblAvailability.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(66, 13);
            this.lblAvailability.TabIndex = 9;
            this.lblAvailability.Text = "\"Availability\"";
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(14, 38);
            this.lblModelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(68, 13);
            this.lblModelName.TabIndex = 1;
            this.lblModelName.Text = "Model name:";
            // 
            // lblModelNumber
            // 
            this.lblModelNumber.AutoSize = true;
            this.lblModelNumber.Location = new System.Drawing.Point(145, 38);
            this.lblModelNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelNumber.Name = "lblModelNumber";
            this.lblModelNumber.Size = new System.Drawing.Size(77, 13);
            this.lblModelNumber.TabIndex = 2;
            this.lblModelNumber.Text = "Model number:";
            // 
            // btnShowAvailability
            // 
            this.btnShowAvailability.Location = new System.Drawing.Point(398, 302);
            this.btnShowAvailability.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnShowAvailability.Name = "btnShowAvailability";
            this.btnShowAvailability.Size = new System.Drawing.Size(99, 23);
            this.btnShowAvailability.TabIndex = 8;
            this.btnShowAvailability.Text = "Show availability";
            this.btnShowAvailability.UseVisualStyleBackColor = true;
            // 
            // libModelName
            // 
            this.libModelName.FormattingEnabled = true;
            this.libModelName.Location = new System.Drawing.Point(17, 58);
            this.libModelName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.libModelName.Name = "libModelName";
            this.libModelName.Size = new System.Drawing.Size(115, 290);
            this.libModelName.TabIndex = 3;
            this.libModelName.Click += new System.EventHandler(this.libModelName_Click);
            // 
            // btnRemoveMachine
            // 
            this.btnRemoveMachine.Location = new System.Drawing.Point(409, 133);
            this.btnRemoveMachine.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRemoveMachine.Name = "btnRemoveMachine";
            this.btnRemoveMachine.Size = new System.Drawing.Size(63, 23);
            this.btnRemoveMachine.TabIndex = 7;
            this.btnRemoveMachine.Text = "Remove";
            this.btnRemoveMachine.UseVisualStyleBackColor = true;
            this.btnRemoveMachine.Click += new System.EventHandler(this.btnRemoveMachine_Click);
            // 
            // libModelNumber
            // 
            this.libModelNumber.FormattingEnabled = true;
            this.libModelNumber.Location = new System.Drawing.Point(148, 58);
            this.libModelNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.libModelNumber.Name = "libModelNumber";
            this.libModelNumber.Size = new System.Drawing.Size(115, 290);
            this.libModelNumber.TabIndex = 4;
            this.libModelNumber.Click += new System.EventHandler(this.libModelNumber_Click);
            // 
            // btnEditMachine
            // 
            this.btnEditMachine.Location = new System.Drawing.Point(409, 96);
            this.btnEditMachine.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEditMachine.Name = "btnEditMachine";
            this.btnEditMachine.Size = new System.Drawing.Size(63, 23);
            this.btnEditMachine.TabIndex = 6;
            this.btnEditMachine.Text = "Edit";
            this.btnEditMachine.UseVisualStyleBackColor = true;
            // 
            // btnShowMachine
            // 
            this.btnShowMachine.Location = new System.Drawing.Point(409, 58);
            this.btnShowMachine.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnShowMachine.Name = "btnShowMachine";
            this.btnShowMachine.Size = new System.Drawing.Size(63, 23);
            this.btnShowMachine.TabIndex = 5;
            this.btnShowMachine.Text = "Show";
            this.btnShowMachine.UseVisualStyleBackColor = true;
            this.btnShowMachine.Click += new System.EventHandler(this.btnShowMachine_Click);
            // 
            // lblMachinesHeader
            // 
            this.lblMachinesHeader.AutoSize = true;
            this.lblMachinesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblMachinesHeader.Location = new System.Drawing.Point(337, 16);
            this.lblMachinesHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMachinesHeader.Name = "lblMachinesHeader";
            this.lblMachinesHeader.Size = new System.Drawing.Size(72, 18);
            this.lblMachinesHeader.TabIndex = 24;
            this.lblMachinesHeader.Text = "Machines";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(409, 172);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(63, 23);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Machines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 471);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMachinesHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Machines";
            this.Text = "Machines";
            this.Load += new System.EventHandler(this.Machines_Load);
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
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
    }
}

