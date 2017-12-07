namespace StillAS
{
    partial class AddModelName
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
            this.lblExample = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtModelname = new System.Windows.Forms.TextBox();
            this.lblModelnameTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Location = new System.Drawing.Point(62, 27);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(83, 13);
            this.lblExample.TabIndex = 7;
            this.lblExample.Text = "Example: RX-20";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(65, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtModelname
            // 
            this.txtModelname.Location = new System.Drawing.Point(30, 64);
            this.txtModelname.Name = "txtModelname";
            this.txtModelname.Size = new System.Drawing.Size(150, 20);
            this.txtModelname.TabIndex = 5;
            // 
            // lblModelnameTitle
            // 
            this.lblModelnameTitle.AutoSize = true;
            this.lblModelnameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblModelnameTitle.Location = new System.Drawing.Point(46, 9);
            this.lblModelnameTitle.Name = "lblModelnameTitle";
            this.lblModelnameTitle.Size = new System.Drawing.Size(115, 18);
            this.lblModelnameTitle.TabIndex = 4;
            this.lblModelnameTitle.Text = "Add Modelname";
            // 
            // AddModelName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 145);
            this.Controls.Add(this.lblExample);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtModelname);
            this.Controls.Add(this.lblModelnameTitle);
            this.Name = "AddModelName";
            this.Text = "AddModelName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtModelname;
        private System.Windows.Forms.Label lblModelnameTitle;
    }
}