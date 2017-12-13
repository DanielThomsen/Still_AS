﻿namespace StillAS
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDemoNumber = new System.Windows.Forms.Label();
            this.libDemoNumber = new System.Windows.Forms.ListBox();
            this.lblModelName = new System.Windows.Forms.Label();
            this.lblModelNumber = new System.Windows.Forms.Label();
            this.libModelName = new System.Windows.Forms.ListBox();
            this.btnRemoveMachine = new System.Windows.Forms.Button();
            this.libModelNumber = new System.Windows.Forms.ListBox();
            this.btnShowMachine = new System.Windows.Forms.Button();
            this.lblMachinesHeader = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddMachine);
            this.groupBox2.Location = new System.Drawing.Point(731, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(141, 417);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New machine";
            // 
            // btnAddMachine
            // 
            this.btnAddMachine.Location = new System.Drawing.Point(24, 47);
            this.btnAddMachine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddMachine.Name = "btnAddMachine";
            this.btnAddMachine.Size = new System.Drawing.Size(94, 59);
            this.btnAddMachine.TabIndex = 4;
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
            this.groupBox1.Controls.Add(this.lblModelName);
            this.groupBox1.Controls.Add(this.lblModelNumber);
            this.groupBox1.Controls.Add(this.libModelName);
            this.groupBox1.Controls.Add(this.btnRemoveMachine);
            this.groupBox1.Controls.Add(this.libModelNumber);
            this.groupBox1.Controls.Add(this.btnShowMachine);
            this.groupBox1.Location = new System.Drawing.Point(20, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(672, 417);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Existing machines";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(545, 172);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 47);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemove.Location = new System.Drawing.Point(71, 371);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(37, 25);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(23, 371);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 25);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDemoNumber
            // 
            this.lblDemoNumber.AutoSize = true;
            this.lblDemoNumber.Location = new System.Drawing.Point(368, 47);
            this.lblDemoNumber.Name = "lblDemoNumber";
            this.lblDemoNumber.Size = new System.Drawing.Size(101, 17);
            this.lblDemoNumber.TabIndex = 11;
            this.lblDemoNumber.Text = "Demo number:";
            // 
            // libDemoNumber
            // 
            this.libDemoNumber.FormattingEnabled = true;
            this.libDemoNumber.ItemHeight = 16;
            this.libDemoNumber.Location = new System.Drawing.Point(372, 71);
            this.libDemoNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.libDemoNumber.Name = "libDemoNumber";
            this.libDemoNumber.Size = new System.Drawing.Size(147, 292);
            this.libDemoNumber.TabIndex = 9;
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(19, 47);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(89, 17);
            this.lblModelName.TabIndex = 1;
            this.lblModelName.Text = "Model name:";
            // 
            // lblModelNumber
            // 
            this.lblModelNumber.AutoSize = true;
            this.lblModelNumber.Location = new System.Drawing.Point(193, 47);
            this.lblModelNumber.Name = "lblModelNumber";
            this.lblModelNumber.Size = new System.Drawing.Size(102, 17);
            this.lblModelNumber.TabIndex = 2;
            this.lblModelNumber.Text = "Model number:";
            // 
            // libModelName
            // 
            this.libModelName.FormattingEnabled = true;
            this.libModelName.ItemHeight = 16;
            this.libModelName.Location = new System.Drawing.Point(23, 71);
            this.libModelName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.libModelName.Name = "libModelName";
            this.libModelName.Size = new System.Drawing.Size(136, 292);
            this.libModelName.TabIndex = 7;
            this.libModelName.Click += new System.EventHandler(this.libModelName_Click);
            // 
            // btnRemoveMachine
            // 
            this.btnRemoveMachine.Location = new System.Drawing.Point(545, 124);
            this.btnRemoveMachine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveMachine.Name = "btnRemoveMachine";
            this.btnRemoveMachine.Size = new System.Drawing.Size(88, 40);
            this.btnRemoveMachine.TabIndex = 2;
            this.btnRemoveMachine.Text = "Remove";
            this.btnRemoveMachine.UseVisualStyleBackColor = true;
            this.btnRemoveMachine.Click += new System.EventHandler(this.btnRemoveMachine_Click);
            // 
            // libModelNumber
            // 
            this.libModelNumber.FormattingEnabled = true;
            this.libModelNumber.ItemHeight = 16;
            this.libModelNumber.Location = new System.Drawing.Point(197, 71);
            this.libModelNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.libModelNumber.Name = "libModelNumber";
            this.libModelNumber.Size = new System.Drawing.Size(142, 292);
            this.libModelNumber.TabIndex = 8;
            this.libModelNumber.Click += new System.EventHandler(this.libModelNumber_Click);
            this.libModelNumber.SelectedIndexChanged += new System.EventHandler(this.libModelNumber_SelectedIndexChanged);
            // 
            // btnShowMachine
            // 
            this.btnShowMachine.Location = new System.Drawing.Point(545, 71);
            this.btnShowMachine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowMachine.Name = "btnShowMachine";
            this.btnShowMachine.Size = new System.Drawing.Size(88, 45);
            this.btnShowMachine.TabIndex = 1;
            this.btnShowMachine.Text = "Show";
            this.btnShowMachine.UseVisualStyleBackColor = true;
            this.btnShowMachine.Click += new System.EventHandler(this.btnShowMachine_Click);
            // 
            // lblMachinesHeader
            // 
            this.lblMachinesHeader.AutoSize = true;
            this.lblMachinesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblMachinesHeader.Location = new System.Drawing.Point(417, 26);
            this.lblMachinesHeader.Name = "lblMachinesHeader";
            this.lblMachinesHeader.Size = new System.Drawing.Size(92, 24);
            this.lblMachinesHeader.TabIndex = 24;
            this.lblMachinesHeader.Text = "Machines";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(892, 26);
            this.menuStrip1.TabIndex = 27;
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
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(20, 507);
            this.btnBackToMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(117, 28);
            this.btnBackToMenu.TabIndex = 28;
            this.btnBackToMenu.Text = "Back To Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // Machines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 543);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMachinesHeader);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Machines";
            this.Text = "Machines";
            this.Load += new System.EventHandler(this.Machines_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddMachine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDemoNumber;
        private System.Windows.Forms.ListBox libDemoNumber;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.Label lblModelNumber;
        private System.Windows.Forms.ListBox libModelName;
        private System.Windows.Forms.Button btnRemoveMachine;
        private System.Windows.Forms.ListBox libModelNumber;
        private System.Windows.Forms.Button btnShowMachine;
        private System.Windows.Forms.Label lblMachinesHeader;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}

