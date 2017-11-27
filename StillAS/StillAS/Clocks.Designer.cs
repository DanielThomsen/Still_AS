namespace StillAS
{
    partial class Clocks
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
            this.lblCph = new System.Windows.Forms.Label();
            this.lblNow = new System.Windows.Forms.Label();
            this.lblNewYork = new System.Windows.Forms.Label();
            this.lblNY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCph
            // 
            this.lblCph.AutoSize = true;
            this.lblCph.Location = new System.Drawing.Point(235, 23);
            this.lblCph.Name = "lblCph";
            this.lblCph.Size = new System.Drawing.Size(89, 17);
            this.lblCph.TabIndex = 0;
            this.lblCph.Text = "Copenhagen";
            // 
            // lblNow
            // 
            this.lblNow.AutoSize = true;
            this.lblNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNow.Location = new System.Drawing.Point(183, 54);
            this.lblNow.Name = "lblNow";
            this.lblNow.Size = new System.Drawing.Size(190, 51);
            this.lblNow.TabIndex = 1;
            this.lblNow.Text = "00:00:00";
            // 
            // lblNewYork
            // 
            this.lblNewYork.AutoSize = true;
            this.lblNewYork.Location = new System.Drawing.Point(244, 130);
            this.lblNewYork.Name = "lblNewYork";
            this.lblNewYork.Size = new System.Drawing.Size(68, 17);
            this.lblNewYork.TabIndex = 2;
            this.lblNewYork.Text = "New York";
            // 
            // lblNY
            // 
            this.lblNY.AutoSize = true;
            this.lblNY.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNY.Location = new System.Drawing.Point(183, 157);
            this.lblNY.Name = "lblNY";
            this.lblNY.Size = new System.Drawing.Size(190, 51);
            this.lblNY.TabIndex = 3;
            this.lblNY.Text = "00:00:00";
            // 
            // Clocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 253);
            this.Controls.Add(this.lblNY);
            this.Controls.Add(this.lblNewYork);
            this.Controls.Add(this.lblNow);
            this.Controls.Add(this.lblCph);
            this.Name = "Clocks";
            this.Text = "Clocks";
            this.Load += new System.EventHandler(this.Clocks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCph;
        private System.Windows.Forms.Label lblNow;
        private System.Windows.Forms.Label lblNewYork;
        private System.Windows.Forms.Label lblNY;
    }
}